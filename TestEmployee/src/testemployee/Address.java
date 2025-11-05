package testemployee;

/**Purpose:
 * The Address class should be declared as a public class and should meet all the requirements listed below.
 * Its purpose is to store a person's address (street, city, state, and zip code) as four individual String objects.
 * The class should include a public constructor that initializes the instance variables, which should thereafter remain constant.
 * Therefore, the only other method that should be declared public is the print method
 * which can be called by other objects to print the values of an Address object to the screen.
 */
public class Address {
    // parameters
    private String street;
    private String city;
    private String state;
    private String zip;
    
    // constructor
    public Address(String theStreet, String theCity, String theState, String theZip){
        street = theStreet;
        city = theCity;
        state = theState;
        zip = theZip;
    }
    
    // getters
    private String getStreet(){
        return street;
    }
    private String getCity(){
        return city;
    }
    private String getState(){
        return state;
    }
    private String getZip(){
        return zip;
    }
    
    public void print(){
        System.out.print(street+", ");
        System.out.print(city+", ");
        System.out.print(state+", ");
        System.out.println(zip);
    }
}
