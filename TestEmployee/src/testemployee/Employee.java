package testemployee;

/**Purpose:
 * The Employee class should be declared as a public class and should meet all the requirements listed below.
 * Its purpose is to store a person's full name (using the Name class defined in the Chapter 1 assignment sheet),
 * address (using the Address class defined in the Chapter 1 assignment sheet), and social security number (using a String object).
 * The Employee class should include a public constructor that initializes the instance variables,
 * which should thereafter remain constant. Therefore, the only other method that should be declared public is the print
 * method which can be called by other objects to print the values of an Employee object to the screen.
 */
public class Employee {
    // parameters
    private Name name;
    private Address address;
    private String social;
    
    // constructor
    public Employee(Name theName, Address theAddress, String theSocial){
        name = theName;
        address = theAddress;
        social = theSocial;
    }
    
    // getters
    private Name getName(){
        return name;
    }
    private Address getAddress(){
        return address;
    }
    private String getSocial(){
        return social;
    }
    
    public void print(){
        System.out.println("Employee:");
        name.print();
        address.print();
        System.out.println(social);
    }
}
