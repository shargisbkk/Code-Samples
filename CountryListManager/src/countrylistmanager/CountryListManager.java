package countrylistmanager;

/*
 Spencer Hargis
CITC-1310-W01
Lab 8 Country List Manager
4-20-2025
 */

// import arraylist to use a mutable list
import java.util.ArrayList;
import java.util.Scanner;
import java.util.InputMismatchException;
public class CountryListManager {

    public static void main(String[] args) {
        printTitle();
        // all class instances
        Scanner input = new Scanner(System.in);
        CountryIO countryio = new CountryIO();
        Console console = new Console();
        
        // instantiate arraylist called CountryArrayList
        var CountryList = new ArrayList<String>();
        // use the getCountries method in the CountryIO class
        CountryList = countryio.getCountries();
        
        while (true) {
            int Choice = printMenu(input);
            
            if (Choice == 1) {
                printCountries(CountryList);
            }
            
            if (Choice == 2) {
                String newcountry;
                newcountry = console.getString("\nEnter Country: ");
                
                // add new country value to the end of CountryList
                CountryList.add(newcountry);
                
                // passing null sorts the list in an alphabetical order
                CountryList.sort(null);
                
                // pass the countries list to the saveCountries method in CountryIO class
                boolean save = countryio.saveCountries(CountryList);
                if (save == true){
                    System.out.println("This country has been saved.");
                }else{
                    System.out.println("This country was not saved.");
                }
            }
            
            if (Choice == 3) {
                break;
            }
        }
        input.close();
        System.out.println("\nGoodbye.");
        
    }
    // method to print a menu, validate, and return the user's input
    private static int printMenu(Scanner input) {
        int menuNumber = 0;
        do {
            try {
                System.out.print("\nCOMMAND MENU\n" +
                                 "1 - List countries\n" +
                                 "2 - Add a country\n" +
                                 "3 - Exit\n" +
                                 "Enter menu number: ");
                menuNumber = input.nextInt();
            } catch (InputMismatchException ime) {
                System.out.println("Please enter a valid menu number.");
                // Clear invalid input from scanner
                input.nextLine();
            }
            // check if  input is within the valid range
            if (menuNumber < 1 || menuNumber > 3) {
                System.out.println("Invalid choice. Please select a valid menu option (1-3).");
            }
        // Loop until valid input is entered
        } while (menuNumber < 1 || menuNumber > 3);
        return menuNumber;
    }
    
    private static void printCountries (ArrayList<String> list) {
        // check size method for an empty list
        if (list.size() == 0) {
                System.out.println("\nNo countries in the list");
            }
        else {
            System.out.println();
            // call each value in the list to print seperately
            for (String country : list) {
                System.out.println(country);
                }
            }
    }
    
    private static void printTitle () {
        System.out.println("Country List Manager");
    }
}
