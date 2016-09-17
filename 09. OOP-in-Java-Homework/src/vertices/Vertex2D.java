package vertices;

public class Vertex2D extends Vertex {
	public Vertex2D(double x, double y) {
		super(x, y);
	}
	
	public static double calculateDistanceBetweenTwo2DVertices(Vertex2D firstVertex, Vertex2D secondVertex) {
		double result = Math.pow(firstVertex.getX() - secondVertex.getX(), 2) +
					Math.pow(firstVertex.getY() - secondVertex.getY(), 2);
		
		return Math.sqrt(Math.abs(result));
	}
	
	@Override
	public String toString() {
		return "(" + this.getX() + ", " + this.getY() + ")";
	}
}