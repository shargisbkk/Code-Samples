/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package diceroller;

/**
 Spencer Hargis
CITC-1310-W01
Lab 5 Dice Roller
3-24-2025
 */

import java.util.*;
import java.lang.Math;

public class DiceRoller {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("Dice Roller");
        
        String choice = "y";

        do {
            int Sides = getNumberOfSides(input);

            // Create 2 dice variable to assign the rolled integers
            int Die1 = rollDie(Sides);
            int Die2 = rollDie(Sides);
            
            System.out.println("Die 1: " + Die1);
            System.out.println("Die 1: " + Die2);
            System.out.println("Total: " + (Die1 + Die2));

            // Only print if die1 and die2 are double 1's or double 6's
            printSpecialMessage(Die1, Die2);

            System.out.print("\nRoll again? (y/n): ");
            choice = input.next();

        } while (choice.equalsIgnoreCase("y"));

        // Prints closing message and close scanner
        System.out.println("\nAutobots ROLLOUT!");
        input.close();
    }

    // Pass through the Scanner class to be able to use the input method in getNumberOfSides
    private static int getNumberOfSides( Scanner input) {
        int dieSides = 0;
        // Create a loop that runs at least once, or until a valid input is entered
        do {
            try{
                System.out.print("\nEnter the number of sides for the dice (2-20): ");
                dieSides = input.nextInt();
            }
            // Catch inputs that are not integers and resets the input
            catch (InputMismatchException ime) {
                System.out.println("\nPlease enter an integer.");
                input.nextLine();
            }
        // Checks if the user enters a number less than two or greater than 20
        } while (dieSides < 2 | dieSides > 20);
        return dieSides;
    }
    
    // Use the math.random() method to return a random number
    private static int rollDie(int sides) {
        // Use the user's sides input as the upper limit of the Math.random()
        int roll = (int)(Math.random() * sides) + 1;
        return roll;
    }
    
    // Pass die1 and die2 through the method, check, and print special messages for double 1's and double 6's
    private static void printSpecialMessage(int dice1, int dice2) {
        
        if (dice1 == 1 && dice2 == 1) {
            System.out.println("Snake eyes!");
        } else if (dice1 == 6 && dice2 == 6) {
            System.out.println("Box cars!");
        }
    }
}