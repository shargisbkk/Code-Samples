/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package exp6;
import java.util.Scanner;
import java.util.Stack;
/**
 *
 * @author sharg
 */

public class EXP6
{
    /**
     * @param args the command line arguments
     */
    public static boolean isItBalanced(String inputExpr)
    {
        Stack<Character> stack = new Stack<>();

        for (int i = 0; i < inputExpr.length(); i++)
        {
            char ch = inputExpr.charAt(i);

            if (ch == '{' || ch == '(' || ch == '[')
            {
                stack.push(ch);
            }
            else if (ch == '}' || ch == ')' || ch == ']')
            {
                if (stack.isEmpty())
                {
                    System.out.println("Mismatch found : " + ch + " at " + i);
                    return false;
                }

                char stackTop = stack.pop();

                if ((ch == '}' && stackTop != '{') ||
                    (ch == ')' && stackTop != '(') ||
                    (ch == ']' && stackTop != '['))
                {
                    System.out.println("Mismatch found : " + ch + " at " + i);
                    return false;
                }
            }
        }

        if (!stack.isEmpty())
        {
            System.out.println("Mismatch found : " + stack.peek() + " missing closing symbol");
            return false;
        }

        return true;
    }

    // Main method
    public static void main(String[] args)
    {
        Scanner input = new Scanner(System.in);
        
        System.out.print("How many expressions are you testing? ");
        int expLimit = input.nextInt();
        input.nextLine();

        for (int i = 1; i <= expLimit; i++)
        {
            System.out.print("Enter your expression: ");
            String expr = input.nextLine();

            boolean result = isItBalanced(expr);

            System.out.println(expr + " == " + (result ? 1 : 0));
        }

        input.close();
    }
}

