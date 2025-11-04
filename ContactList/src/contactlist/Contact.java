package contactlist;

public class Contact {
    
    // create all the data types that are associated with a contact
    String FirstName;
    String LastName;
    String Email;
    String PhoneNum;
    
    // create a method that will assign a string value to FirstName
    public void setFirstName(String fName){
        FirstName = fName;
    }
    // create a method that will retreive the string in FirstName and return that data
    public String getFirstName(){
        return this.FirstName;
    }
    
    // create a method that will assign a string value to LastName
    public void setLastName(String lName){
        LastName = lName;
    }
    // create a method that will retreive the string in LastName and return that data
    public String getLastName(){
        return this.LastName;
    }
    
    // create a method that will assign a string value to Email
    public void setEmail(String email){
        Email = email;
    }
    // create a method that will retreive the string in Email and return that data
    public String getEmail(){
        return this.Email;
    }
    
    // create a method that will assign a string value to PhoneNum
    public void setPhoneNum(String phone){
        PhoneNum = phone;
    }
    // create a method that will retreive the string in PhoneNum and return that data
    public String getPhone(){
        return this.PhoneNum;
    }
    
    // create a method that formats and prints out the contact info
    // calls the data using get methods created above
    public void displayContact(){
        System.out.printf("\n------------------------------------------\n");
        System.out.printf("----" + "Current Contact" + "-----------------------" + "\n");
        System.out.printf("------------------------------------------\n");
        System.out.print("Name: \t\t" + getFirstName() + " " + getLastName() + "\n" +
               "Email Address: \t" + getEmail() + "\n" +
               "Phone Number: \t" + getPhone());
        System.out.printf("\n------------------------------------------\n");
    }
}