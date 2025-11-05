/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package testdefinedexception;

/**
 *
 * @author sharg
 */
public class Account {
    private int balance = 1000;

    public Account() {
    }

    public int balance() {
        return balance;
    }

    public void withdraw(int amount) throws NotSufficientFundException {
        if (amount > balance) {
            throw new NotSufficientFundException(String.format(
                "Current balance %d is less than requested amount %d", balance, amount));
        }
        balance = balance - amount;
    }

    public void deposit(int amount) {
        if (amount <= 0) {
            throw new IllegalArgumentException(String.format("Invalid deposit amount %s", amount));
        }
        balance = balance + amount;
    }
}
