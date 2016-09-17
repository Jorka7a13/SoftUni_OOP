package _01_geometry.plane_shapes;

import vertices.Vertex2D;

public class Circle extends PlaneShape {
	
	private double radius;
	
	public Circle(Vertex2D center, double radius) {
		super(new Vertex2D[] { center });
		this.setRadius(radius);
	}

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		if (radius < 0) {
			throw new IllegalArgumentException("Radius can't be negative!");
		}
		
		this.radius = radius;
	}
	
	@Override
	public double getArea() {
		return Math.PI * this.getRadius() * this.getRadius();
	}

	@Override
	public double getPerimeter() {
		return Math.PI * this.getRadius() * 2;
	}

	@Override
	public String toString() {
		return "Circle: \n" + this.getVertices()[0].toString() +
				"\nperimeter: " + this.getPerimeter() + "\narea:" + this.getArea();
	}
}