package basicexample1;

import java.sql.*;
import javax.swing.*;

public class BasicExample1 {
    public static void main(String[] args) {
        Connection conn = null;    // JDBC connection to the database
        Statement stmt = null;     // Statement object for general SQL commands
        String userName, pw;       // Login credentials

        try {
            // === Prompt for credentials ===
            userName = JOptionPane.showInputDialog("Enter Oracle username: ");
            pw = JOptionPane.showInputDialog("Enter Oracle password: ");

            // === Connection string for Oracle Autonomous Database (using Wallet) ===
            String url = "jdbc:oracle:thin:@citc2340fall2025_high?TNS_ADMIN=C:/Users/sharg/Downloads/Wallet_CITC2340Fall2025";

            // === Establish connection ===
            conn = DriverManager.getConnection(url, userName, pw);
            conn.setAutoCommit(false);   // disable auto-commit for transaction control
            stmt = conn.createStatement();

            JOptionPane.showMessageDialog(null, "Connected to Oracle Cloud DB!");

            // ---------------------------------------------------------------------
            // INSERT demo – prompt user for values and add a row into CUSTOMERS
            // ---------------------------------------------------------------------
            int customerId = Integer.parseInt(JOptionPane.showInputDialog("Enter integer customer ID"));
            String firstName = JOptionPane.showInputDialog("Enter first name");
            String lastName = JOptionPane.showInputDialog("Enter last name");
            String phone = JOptionPane.showInputDialog("Enter phone (xxx-xxx-xxxx)");
            String dob = JOptionPane.showInputDialog("Enter DOB (yyyy-mm-dd)");

            String insertSQL = "INSERT INTO customers (customer_id, first_name, last_name, dob, phone) " +
                    "VALUES (?, ?, ?, TO_DATE(?, 'YYYY-MM-DD'), ?)";
            PreparedStatement psInsert = conn.prepareStatement(insertSQL);
            psInsert.setInt(1, customerId);
            psInsert.setString(2, firstName);
            psInsert.setString(3, lastName);
            psInsert.setString(4, dob);
            psInsert.setString(5, phone);
            psInsert.executeUpdate();
            System.out.println("Inserted a new customer into CUSTOMERS.");

            // ---------------------------------------------------------------------
            // UPDATE demo – change first_name of customer #1 to "Jean"
            // ---------------------------------------------------------------------
            String updateSQL = "UPDATE customers SET first_name = ? WHERE customer_id = ?";
            PreparedStatement psUpdate = conn.prepareStatement(updateSQL);
            psUpdate.setString(1, "Jean");
            psUpdate.setInt(2, 1);
            psUpdate.executeUpdate();
            System.out.println("Updated customer #1's first name to Jean.");
            
            // ---------------------------------------------------------------------
            // UPDATE demo – change first_name to "Billy" and last_name to "Jean" of customer #1
            // ---------------------------------------------------------------------
            String myUpdateSQL = "UPDATE customers SET first_name = ?, last_name = ? WHERE customer_id = ?";
            PreparedStatement myUpdate = conn.prepareStatement(myUpdateSQL);
            myUpdate.setString(1,"Billy");
            myUpdate.setString(2,"Jean");
            myUpdate.setInt(3, 1);
            myUpdate.executeUpdate();
            System.out.println("Billy Jean is now a loving customer.");

            // ---------------------------------------------------------------------
            // DELETE demo – remove customer #5 from the CUSTOMERS table
            // ---------------------------------------------------------------------
            String deleteSQL = "DELETE FROM customers WHERE customer_id = ?";
            PreparedStatement psDelete = conn.prepareStatement(deleteSQL);
            psDelete.setInt(1, 5);
            psDelete.executeUpdate();
            System.out.println("Deleted customer #5 from CUSTOMERS.");

            // ---------------------------------------------------------------------
            // SELECT demo – retrieve and display all rows from CUSTOMERS
            // ---------------------------------------------------------------------
            ResultSet rs = stmt.executeQuery(
                "SELECT customer_id, first_name, last_name, dob, phone FROM customers"
            );
            while (rs.next()) {
                System.out.println("Customer ID: " + rs.getInt("customer_id")
                        + ", Name: " + rs.getString("first_name") + " " + rs.getString("last_name")
                        + ", DOB: " + rs.getDate("dob")
                        + ", Phone: " + rs.getString("phone"));
            }
            rs.close();

            // ---------------------------------------------------------------------
            // SELECT demo on PRODUCTS – retrieve product_id, type, and price
            // ---------------------------------------------------------------------
            ResultSet rsProducts = stmt.executeQuery(
                    "SELECT product_id, product_type_id, price FROM products WHERE product_id = 3");
            if (rsProducts.next()) {
                int productId = rsProducts.getInt("product_id");
                int productTypeId = rsProducts.getInt("product_type_id");
                double price = rsProducts.getDouble("price");

                System.out.println("Product ID: " + productId);
                System.out.println("Product Type ID: " + productTypeId);
                if (rsProducts.wasNull()) {
                    System.out.println("Last value read was NULL");
                }
                System.out.println("Price: " + price);
            }
            rsProducts.close();
            
            // ---------------------------------------------------------------------
            // Create a new product
            // ---------------------------------------------------------------------
            String createProduct = "Insert INTO products (product_id, product_type_id, name, description, price) " +
                    "VALUES (?, ?, ?, ?, ?)";
            PreparedStatement newProduct = conn.prepareStatement(createProduct);
            newProduct.setInt(1,13);
            newProduct.setInt(2, 4);
            newProduct.setString(3, "Spencer Sad Songs");
            newProduct.setString(4, "So many sad songs about nothing");
            newProduct.setDouble(5, 14.99);
            newProduct.executeUpdate();
            System.out.println("I added a cd of my sad songs to the products table.");
            
            ResultSet myProducts = stmt.executeQuery("SELECT * FROM products WHERE product_id = 13");
            
            if (myProducts.next()) {
                int productId = myProducts.getInt("product_id");
                int productTypeId = myProducts.getInt("product_type_id");
                String productName = myProducts.getString("name");
                String productDescription = myProducts.getString("description");
                double price = myProducts.getDouble("price");

                System.out.println("Product ID: " + productId);
                System.out.println("Product Type ID: " + productTypeId);
                System.out.println("Product Name: " + productName);
                System.out.println("Product description: " + productDescription);
                if (myProducts.wasNull()) {
                    System.out.println("Last value read was NULL");
                }
                System.out.println("Price: " + price);
            }
            myProducts.close();
            

            // ---------------------------------------------------------------------
            // DDL demo – CREATE and DROP an ADDRESSES table
            // ---------------------------------------------------------------------
            stmt.execute("CREATE TABLE addresses (" +
                    "  address_id INTEGER CONSTRAINT addresses_pk PRIMARY KEY," +
                    "  customer_id INTEGER CONSTRAINT addresses_fk_customers REFERENCES customers(customer_id)," +
                    "  street VARCHAR2(20) NOT NULL," +
                    "  city VARCHAR2(20) NOT NULL," +
                    "  state CHAR(2) NOT NULL)");
            System.out.println("Created ADDRESSES table.");

            stmt.execute("DROP TABLE addresses");
            System.out.println("Dropped ADDRESSES table.");

            // ---------------------------------------------------------------------
            // Commit the transaction – all changes are saved to the database
            // ---------------------------------------------------------------------
            conn.commit();

        } catch (SQLException e) {
            // Print error info
            System.out.println("SQL Error: " + e.getMessage());
            e.printStackTrace();
            try {
                // Roll back if something goes wrong
                if (conn != null) conn.rollback();
                System.out.println("Rolled back changes due to error.");
            } catch (SQLException ignore) {}
        } finally {
            // Always close JDBC objects
            try { if (stmt != null) stmt.close(); } catch (SQLException ignore) {}
            try { if (conn != null) conn.close(); } catch (SQLException ignore) {}
        }
    }
}