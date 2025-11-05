/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package testdefinedexception;

/**
 *
 * @author sharg
 */
public class NotSufficientFundException extends Exception {
    private String message;

    public NotSufficientFundException(String message) {
        super(message);
    }

    public String getMessage() {
        return message;
    }
}
