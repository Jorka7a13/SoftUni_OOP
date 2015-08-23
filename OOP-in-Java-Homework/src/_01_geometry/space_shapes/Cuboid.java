package _01_geometry.space_shapes;

import vertices.Vertex3D;

public class Cuboid extends SpaceShape {

	private double width;
	private double height;
	private double depth;
	
	public Cuboid(Vertex3D startingPoint, double width, double height, double depth) {
		super(new Vertex3D[] { startingPoint });
		this.setWidth(width);
		this.setHeight(height);
		this.setDepth(depth);
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

	public double getDepth() {
		return depth;
	}

	public void setDepth(double depth) {
		if (depth < 0) {
			throw new IllegalArgumentException("Depth can't be negative!");
		}
		
		this.depth = depth;
	}

	@Override
	public double getVolume() {
		return this.getWidth() * this.getHeight() * this.getDepth();
	}

	@Override
	public double getArea() {
		return 2 * this.getWidth() * this.getDepth() +
				2 * this.getDepth() * this.getHeight() +
				2 * this.getHeight() * this.getWidth();
	}

	@Override
	public String toString() {
		return "Cuboid: \n" + this.getVertices()[0].toString() +
				"\nvolume: " + this.getVolume() + "\narea:" + this.getArea();
	}
}