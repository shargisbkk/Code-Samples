/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package testconnection;

import java.sql.*;

public class TestConnection {

    public static void main(String[] args) {

        try {
        // Set the TNS_ADMIN property to the directory containing the wallet files.
            System.setProperty("oracle.net.tns_admin", "C:/Users/sharg/Downloads/Wallet_CITC2340Fall2025");
        
        // The URL does not need the TNS_ADMIN parameter if the system property is set.
            String url = "jdbc:oracle:thin:@CITC2340FALL2025_HIGH";
            
            Connection conn = DriverManager.getConnection(url, "slhargis", "b3P!n!sA1!33");
            
            System.out.println("Connected successfully!");
            
            conn.close();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}
