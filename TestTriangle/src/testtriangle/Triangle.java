/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package testtriangle;

/**
 *
 * @author sharg
 */
public class Triangle extends GeometricObject {
    
    private double side1;
    private double side2;
    private double side3;

    public Triangle() {
        super(); // Call to GeometricObject's no-arg constructor
        this.side1 = 0;
        this.side2 = 0;
        this.side3 = 0;
    }

    public Triangle(double side1, double side2, double side3, String color, boolean filled) {
        super(color, filled); // Use super to set color and filled
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public double getSide1() {
        return side1;
    }

    public double getSide2() {
        return side2;
    }

    public double getSide3() {
        return side3;
    }

    public String getColor() {
        return super.getColor();
    }

    public boolean isFilled() {
        return super.isFilled();
    }

    // Method to compute the area using Heron's formula
    public double getArea() {
        double s = getPerimeter() / 2; // semi-perimeter
        return Math.sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    // Method to compute the perimeter
    public double getPerimeter() {
        return side1 + side2 + side3;
    }

    // toString method
    @Override
    public String toString() {
        return "Triangle: side1 = " + side1 +
               " side2 = " + side2 +
               " side3 = " + side3;
    }
}

