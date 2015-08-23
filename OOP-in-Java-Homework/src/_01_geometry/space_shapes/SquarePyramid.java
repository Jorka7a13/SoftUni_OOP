package _01_geometry.space_shapes;

import vertices.Vertex3D;

public class SquarePyramid extends SpaceShape {

	private double baseWidth;
	private double height;
	
	public SquarePyramid(Vertex3D baseCenter, double baseWidth, double height) {
		super(new Vertex3D[] { baseCenter });
		this.setBaseWidth(baseWidth);
		this.setHeight(height);
	}
	
	public double getBaseWidth() {
		return baseWidth;
	}

	public void setBaseWidth(double baseWidth) {
		if (baseWidth < 0) {
			throw new IllegalArgumentException("Base width can't be negative!");
		}
		
		this.baseWidth = baseWidth;
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
	public double getVolume() {
		return 1/3 * (this.getBaseWidth() * this.getBaseWidth()) * this.getHeight();
	}

	@Override
	public double getArea() {
		double slantHeight = Math.sqrt(this.getHeight() * this.getHeight() + 
				((this.getBaseWidth() / 2) * (this.getBaseWidth() / 2)));
		
		return this.getBaseWidth() * slantHeight * 2 + this.getBaseWidth() * this.getBaseWidth();
	}
	
	@Override
	public String toString() {
		return "Square Pyramid: \n" + this.getVertices()[0].toString() +
				"\nvolume: " + this.getVolume() + "\narea:" + this.getArea();
	}
}