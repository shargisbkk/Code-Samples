package tableofpowers;

/**
 Spencer Hargis
CITC-1310-W01
Lab 2 Student Registration
2-3-2025
 */

import java.util.Scanner;

public class TableofPowers {

    
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        
        String choice = "y";
        
        System.out.println("Welcome to the Squares and Cubes table");
        while (choice.equalsIgnoreCase("y")) {
            System.out.print("\nEnter a number: ");
            int userNumber = input.nextInt();
            
            System.out.println("\nNumber\tSquare\tCube");
            System.out.println("======\t=======\t=====");
            for (int i = 1; i <= userNumber; i++) {
                System.out.println(i + "\t" + (i * i) + "\t" + (i * i * i));
            }
            
            System.out.print("\nConintue? (y/n): ");
            choice = input.next();

        }
        System.out.println("Bye!");
        input.close();
     }
 } 