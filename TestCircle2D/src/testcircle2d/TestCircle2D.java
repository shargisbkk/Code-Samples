/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package testcircle2d;

/**
 *
 * @author sharg
 */
public class TestCircle2D {
    
    public static void main(String[] args) {
        Circle2D c1 = new Circle2D(2, 2, 5.5);
        
        System.out.println("Area: " + c1.getArea());
        System.out.println("Perimeter: " + c1.getPerimeter());
        
        System.out.println("(A) Is point(3,3) inside circle 1? " + c1.contains(3, 3));
        
        Circle2D c2 = new Circle2D(4, 5, 10.5);
        System.out.println("(B) Is new cirlce c2 inside c1? " + c1.contains(c2));
        
        Circle2D c3 = new Circle2D(3, 5, 2.3);
        System.out.println("(C) Do new circle c3 and c1 overlap? " + c1.overlaps(c3));
    }
}
