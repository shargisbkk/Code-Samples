/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */

package student_registration;

/*
Spencer Hargis
CITC-1310-W01
Lab 2 Student Registration
1/31/2025
*/

//imports the scanner utility
import java.util.Scanner;
public class Student_Registration {

    public static void main(String[] args) {
        
        //creates the scanner object 
        Scanner input = new Scanner(System.in);
        
        //asks user for first name and stores input
        System.out.println("What is your first name?");
        var firstName = input.nextLine();
        
        //asks user for last name and stores input
        System.out.println("What is your last name?");
        var lastName = input.nextLine();
        
        //asks user for birth year and stores input
        System.out.println("What is your birth year?");
        short birthYear = input.nextShort();
        
        //combine the inputs from the user for a simple output message
        var message = "Welcome "+ firstName + " " + lastName + "!"
                + "\nYour registration is complete."
                + "\nYour temporary password is: " + firstName + "*" + birthYear;
        
        System.out.print(message);
    }
    
}
