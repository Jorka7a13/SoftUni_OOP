package _01_geometry;

import vertices.Vertex;

public abstract class Shape {
	protected Vertex[] vertices;
	
	protected Shape(Vertex[] vertices) {
		this.setVertices(vertices);
	}

	protected Vertex[] getVertices() {
		return vertices;
	}

	protected void setVertices(Vertex[] vertices) {
		if (vertices.length == 0) {
			throw new IllegalArgumentException("Vertices array can't be empty!");
		}
		
		this.vertices = vertices;
	}
}