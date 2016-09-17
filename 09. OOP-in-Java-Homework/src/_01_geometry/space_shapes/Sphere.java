package _01_geometry.space_shapes;

import vertices.Vertex3D;

public class Sphere extends SpaceShape {

	private double radius;
	
	public Sphere(Vertex3D center, double radius) {
		super(new Vertex3D[] { center });
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
	public double getVolume() {
		return 4/3 * Math.PI * Math.pow(this.getRadius(), 3);
	}

	@Override
	public double getArea() {
		return 4 * Math.PI * this.getRadius() * this.getRadius();
	}

	@Override
	public String toString() {
		return "Sphere: \n" + this.getVertices()[0].toString() +
				"\nvolume: " + this.getVolume() + "\narea:" + this.getArea();
	}
}