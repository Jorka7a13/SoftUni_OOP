package _01_geometry.plane_shapes;

import vertices.Vertex2D;

public class Rectangle extends PlaneShape {

	private double width;
	private double height;
	
	public Rectangle(Vertex2D[] vertices, double width, double height) {
		super(vertices);
		this.setWidth(width);
		this.setHeight(height);
	}
	
	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		if (width < 0) {
			throw new IllegalArgumentException("Width can't be negative!");
		}		
		
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		if (height < 0) {
			throw new IllegalArgumentException("Height can't be negative!");
		}
		
		this.height = height;
	}

	@Override
	public double getArea() {
		return this.getWidth() * this.getHeight();
	}

	@Override
	public double getPerimeter() {
		return 2 * this.getWidth() + 2 * this.getHeight();
	}

	@Override
	public String toString() {
		return "Rectangle: \n" + this.getVertices()[0].toString() +
				"\nperimeter: " + this.getPerimeter() + "\narea:" + this.getArea();
	}
}