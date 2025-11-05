/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package testdefinedexception;
/**
 *
 * @author sharg
 */

import java.util.Scanner;
import java.io.IOException;

public class TestDefinedException {
    public static void main(String[] args) {
        Account acct = new Account();
        Scanner scanner = new Scanner(System.in);
        boolean running = true;

        System.out.println("Welcome! Your current balance is: $" + acct.balance());

        while (running) {
            System.out.println("\nChoose an option:");
            System.out.println("1 - Withdraw");
            System.out.println("2 - Deposit");
            System.out.println("3 - Check Balance");
            System.out.println("4 - Exit");
            System.out.print("Enter your choice: ");
            int choice = scanner.nextInt();

            try {
                switch (choice) {
                    case 1:
                        System.out.print("Enter amount to withdraw: ");
                        int withdrawAmount = scanner.nextInt();
                        acct.withdraw(withdrawAmount);
                        break;

                    case 2:
                        System.out.print("Enter amount to deposit: ");
                        int depositAmount = scanner.nextInt();
                        acct.deposit(depositAmount);
                        break;

                    case 3:
                        break;

                    case 4:
                        running = false;
                        break;

                    default:
                        System.out.println("Invalid choice. Please try again.");
                        break;
                }
            } catch (NotSufficientFundException ex) {
                ex.printStackTrace();
                waitForKeyPress(scanner);
            } catch (IllegalArgumentException ex) {
                ex.printStackTrace();
                waitForKeyPress(scanner);
            } finally {
                System.out.println("Your balance is $" + acct.balance());
            }
        }

        scanner.close();
    }

    private static void waitForKeyPress(Scanner scanner) {
        System.out.println("Press any key to continue...");
        try {
            System.in.read(); // waits for user to press Enter or any key
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}