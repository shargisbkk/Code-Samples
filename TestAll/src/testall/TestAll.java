/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package testall;

/**
 *
 * @author sharg
 */
public class TestAll {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Circle c1 = new Circle(5f);
        Point p1 = new Point(5, 5);
        Point p2 = new Point(5,7);
        Square s1 = new Square(p1);
        Rectangle r1 = new Rectangle(p2);
        
        System.out.println("Details of c1:");
        System.out.println("Radius: " + c1.getRadius());
        System.out.println("Area: " + c1.getArea());
        System.out.println("Perimeter: " + c1.getPerimeter());
        System.out.println();

        System.out.println("Details of s1:");
        System.out.println("Side length: " + s1.getSideLength());
        System.out.println("Area: " + s1.getArea());
        System.out.println("Perimeter: " + s1.getPerimeter());
        System.out.println();

        System.out.println("Details of r1:");
        System.out.println("Width: " + r1.getWidth());
        System.out.println("Height: " + r1.getHeight());
        System.out.println("Area: " + r1.getArea());
        System.out.println("Perimeter: " + r1.getPerimeter());
    }
    
}
