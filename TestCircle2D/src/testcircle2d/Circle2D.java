/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package testcircle2d;

/**
 *
 * @author sharg
 */
public class Circle2D {
    private double x;
    private double y;
    private double radius;
    private double result;
    
    public Circle2D(){
        this(0,0,1);
    }
    public Circle2D(double x, double y, double radius){
        this.x = x;
        this.y = y;
        this.radius = radius;
    }
    public double getArea(){
        return Math.PI * radius * radius;
    }
    public double getPerimeter(){
        return 2 * Math.PI * radius;
    }
    public boolean contains(double y, double x){
        result = coordinate(x, y);
        return result <= this.radius;
    }
    public boolean contains(Circle2D circle){
        result = coordinate(circle.x, circle.y);
        boolean isInside = result + circle.radius <= this.radius;
        return isInside;
    }
    public boolean overlaps(Circle2D circle){
        result = coordinate(circle.x, circle.y);
        boolean closeEnough = result < this.radius + circle.radius;
        return closeEnough;
    }
    private double coordinate(double x, double y){
        double coordinates = Math.sqrt(Math.pow((x-this.x), 2) + Math.pow((y-this.y), 2));
        return coordinates;
    }
    
}
