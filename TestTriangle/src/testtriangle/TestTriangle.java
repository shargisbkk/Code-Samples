/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package testtriangle;

/**
 *
 * @author sharg
 */
public class TestTriangle {
    
    public static void main(String[] args) {
        // Create a Triangle object with specified sides, color, and filled
        Triangle triangle = new Triangle(1, 1.5, 1, "yellow", true);

        // Display area
        System.out.println("Area: " + triangle.getArea());

        // Display perimeter
        System.out.println("Perimeter: " + triangle.getPerimeter());

        // Display color
        System.out.println("Color: " + triangle.getColor());

        // Display whether it is filled
        System.out.println("Filled: " + triangle.isFilled());
    }
}

