/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package testall;

/**
 *
 * @author sharg
 */
public class Circle implements FigureGeometry{
    
    private float radius;
    
    public Circle(float theRadius){
        radius = theRadius;
    }
    
    public float getRadius(){
        return radius;
    }
    public float getArea(){
        return getRadius()*getRadius()*PI;
    }
    public float getPerimeter(){
        return getRadius() * 2 * PI;
    }
    
    public void setRadius(float theRadius){
        radius = theRadius;
    }
}
