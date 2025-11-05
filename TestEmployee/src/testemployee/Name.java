package testemployee;

/**Purpose:
 * The Name class should be declared as a public class and should meet all the requirements listed below.
 * Its purpose is to store a person's full name (first, middle, and last) as three individual String objects.
 * The class should include a public constructor that initializes the instance variables, which should thereafter remain constant.
 * Therefore, the only other method that should be declared public is the print method
 * which can be called by other objects to print the values of a Name object to the screen.
 */
public class Name {
    // parameters
    private String first;
    private String middle;
    private String last;
    
    // constructor
    public Name(String theFirst, String theMiddle, String theLast){
        first = theFirst;
        middle = theMiddle;
        last = theLast;
    }
    
    // getters
    private String getFirst(){
        return first;
    }
    private String getMiddle(){
        return middle;
    }
    private String getLast(){
        return last;
    }
    
    public void print(){
        System.out.print(first+" ");
        System.out.print(middle+" ");
        System.out.println(last);
    }
    
}
