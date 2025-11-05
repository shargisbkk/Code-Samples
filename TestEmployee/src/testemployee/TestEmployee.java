package testemployee;

/**Purpose:
 * The TestEmployee class should be declared as a public class and should meet all the requirements listed below.
 * The TestEmployee class should implement a main method which creates an instance of the Employee class
 * (defined in the Chapter 1 Assignment sheet). The main method should create an Employee object
 * called johnDoe and print its values to the screen.
 */
public class TestEmployee {

    
    public static void main(String[] args) {
        // instantiate the name
        Name newName = new Name("John","H.","Doe");
        // instantiate the address
        Address newAddress = new Address("123 Sunset Boulevard","BeverlyHills","CA","99999");
        // pass the name and address through and instantiate employee
        Employee johnDoe = new Employee(newName, newAddress, "123-45-6789");
        
        johnDoe.print();
    }
    
}
