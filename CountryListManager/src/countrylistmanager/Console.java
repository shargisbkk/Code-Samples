package countrylistmanager;

import java.util.Scanner;

public class Console {
    
    // Method to get validated string input (only letters and spaces allowed)
    public String getString(String prompt) {
        Scanner scanner= new Scanner(System.in);
        String country;
        while (true) {
            System.out.print(prompt);
            country = scanner.nextLine();
            // check if the variable is empty
            if (country.isEmpty()) {
                System.out.println("Country name cannot be empty. Please enter a country.");
            }
            // check if the variable only uses alphabet and space values
            else if (!country.matches("[a-zA-Z ]+")) {
                System.out.println("Country name cannot have numbers or special characters. Please try again.");
            } else {
                break;
            }
        }
        return country;
    }
}
