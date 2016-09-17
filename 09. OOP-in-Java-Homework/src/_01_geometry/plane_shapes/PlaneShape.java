package _01_geometry.plane_shapes;

import vertices.Vertex2D;
import _01_geometry.Shape;
import _01_geometry.interfaces.AreaMeasurable;
import _01_geometry.interfaces.PerimeterMeasurable;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable, AreaMeasurable {
	
	protected Vertex2D[] vertices;
	
	protected PlaneShape(Vertex2D[] vertices) {
		super(vertices);
	}

	protected Vertex2D[] getVertices() {
		return vertices;
	}

	protected void setVertices(Vertex2D[] vertices) {
		this.vertices = vertices;
	}
}