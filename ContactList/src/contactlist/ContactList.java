package contactlist;

/**
 Spencer Hargis
CITC-1310-W01
Lab 6 Contact List
3-30-2025
*/

import java.util.Scanner;
public class ContactList {

    
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        // create an instance of the contact class
        Contact newContact = new Contact();
        String Choice;
        
        WelcomeMessage();
        
        do {
            System.out.print("\nEnter first name: ");
            // calls a contact method to set the first name with the next user's input.
            newContact.setFirstName(input.next());
            
            System.out.print("Enter last name: ");
            // calls a contact method to set the last name with the next user's input.
            newContact.setLastName(input.next());
            
            System.out.print("Enter email: ");
            // calls a contact method to set the email with the next user's input.
            newContact.setEmail(input.next());
            
            System.out.print("Enter phone number: ");
            // calls a contact method to set the phone number with the next user's input.
            newContact.setPhoneNum(input.next());
            
            // calls the display contact method
            newContact.displayContact();
            
            System.out.print("\nContinue? (y/n): ");
            Choice = input.next();
            
        } while (Choice.equalsIgnoreCase("y"));
        
        input.close();
        
    }
    
    // creates a method to prind the welcome message.
    private static void WelcomeMessage(){
        System.out.print("Welcome to the Contact List\n");
    }
    
}
