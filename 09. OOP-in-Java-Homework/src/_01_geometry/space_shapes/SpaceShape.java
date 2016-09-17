package _01_geometry.space_shapes;

import vertices.Vertex3D;
import _01_geometry.Shape;
import _01_geometry.interfaces.AreaMeasurable;
import _01_geometry.interfaces.VolumeMeasurable;

public abstract class SpaceShape extends Shape implements VolumeMeasurable, AreaMeasurable {

	protected SpaceShape(Vertex3D[] vertices) {
		super(vertices);
	}
}