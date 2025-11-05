/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package testall;

/**
 *
 * @author sharg
 */
public class Square implements FigureGeometry{
    
    private Point point;
    
    public Square(Point p){
        point = p;
    }
    
    public int getSideLength(){
        return point.getWidth();
    }
    public float getArea(){
        return getSideLength()*getSideLength();
    }
    public float getPerimeter(){
        return getSideLength()*4;
    }
    public void setPoint(Point p){
        point = p;
    }
}
