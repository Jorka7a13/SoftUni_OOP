package vertices;

public abstract class Vertex {
	protected double x;
	protected double y;
	
	protected Vertex(double x, double y) {
		this.setX(x);
		this.setY(y);
	}
	
	protected double getX() {
		return x;
	}
	
	protected void setX(double x) {
		this.x = x;
	}
	
	protected double getY() {
		return y;
	}
	
	protected void setY(double y) {
		this.y = y;
	}
}