/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package large.power;
import java.math.BigInteger;

/**
 *
 * @author sharg
 */
public class LargePower {

    public static void main(String[] args) {
        BigInteger baseNumber = new BigInteger("50");
        long power = 70;
        
        System.out.println("50 raised to the power of 70 is\n" + raiseToPower(baseNumber, power));
    }
    public static BigInteger raiseToPower(BigInteger n, long m){
        BigInteger result = BigInteger.ONE;
        
        for (long i = 1; i <= m; i++){
            result = result.multiply(n);
        }
        
        return result;
    }
}
