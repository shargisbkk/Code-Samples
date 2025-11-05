/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package tempuratureconverter;

/**
 Spencer Hargis
CITC-1310-W01
Lab 2 Student Registration
2-3-2025
 */

import java.util.Scanner;
import java.text.NumberFormat;
        
public class TempuratureConverter {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //Creates an instance of the Scanner class
        Scanner input = new Scanner(System.in);
        
        //Creates an instance to format floats to only 2 decimals
        NumberFormat twodecimal = NumberFormat.getNumberInstance();
        twodecimal.setMaximumFractionDigits(2);
        
        String choice = "y";
        while (choice.equalsIgnoreCase("y")) {
        
            System.out.println("Enter degrees in Fahrenheit:");
                                    
            //takes user's input as a float
            float userFahrenheit = input.nextFloat();
            
            //formula converts the stored input to Celcius
            float celsius = (userFahrenheit - 32) * 5 / 9;
            
            //Formats the celsius float and converts it to a string
            String celsiusFormatted = twodecimal.format(celsius);
            
            System.out.println("Degrees in Celsius: " + celsiusFormatted);
            
            System.out.print("Continue? (y/n): ");
            //as long as user's input is y or Y, the loop will continue
            choice = input.next();
        }
                
    }
    
}
