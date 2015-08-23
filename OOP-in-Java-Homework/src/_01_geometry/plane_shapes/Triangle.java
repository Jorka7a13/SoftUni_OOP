package _01_geometry.plane_shapes;

import vertices.Vertex2D;

public class Triangle extends PlaneShape {

	private Vertex2D pointC;
	
	public Triangle(Vertex2D pointA, Vertex2D pointB, Vertex2D pointC) {
		super(new Vertex2D[] { pointA, pointB });
		this.setPointC(pointC);
	}
	
	public Vertex2D getPointC() {
		return this.pointC;
	}

	public void setPointC(Vertex2D pointC) {
		this.pointC = pointC;
	}
	
	@Override
	public double getArea() {
		double sideA = Vertex2D.calculateDistanceBetweenTwo2DVertices(this.getVertices()[0], this.getVertices()[1]);
		double sideB = Vertex2D.calculateDistanceBetweenTwo2DVertices(this.getVertices()[1], this.pointC);
		double sideC = Vertex2D.calculateDistanceBetweenTwo2DVertices(this.pointC, this.getVertices()[0]);
		
		double p = (sideA + sideB + sideC) / 2;
		
		return Math.sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
	}

	@Override
	public double getPerimeter() {
		double sideA = Vertex2D.calculateDistanceBetweenTwo2DVertices(this.getVertices()[0], this.getVertices()[1]);
		double sideB = Vertex2D.calculateDistanceBetweenTwo2DVertices(this.getVertices()[1], this.pointC);
		double sideC = Vertex2D.calculateDistanceBetweenTwo2DVertices(this.pointC, this.getVertices()[0]);
		
		return sideA + sideB + sideC;
	}
	
	@Override
	public String toString() {
		return "Triangle: \n" + this.getVertices()[0].toString() + ", " +
				this.getVertices()[1].toString() + ", " + this.getPointC() +
				"\nperimeter: " + this.getPerimeter() + "\narea:" + this.getArea();
	}

	
}