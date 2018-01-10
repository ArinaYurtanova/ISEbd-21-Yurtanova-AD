package lab_2_TP;
import java.awt.Color;
import java.awt.Graphics;
import java.io.Serializable;

public abstract class Vessel implements ITransport, Serializable {
	private static final long serialVersionUID = -771902464810205743L;
	protected int startPosX;
	protected int startPosY;
	public int MaxCountPassengers;
	public int MaxSpeed;
	transient public Color ColorBody;
	public int Weight;

	public abstract void moveShip(Graphics g);

	public abstract void drawShip(Graphics g);

	public int getMaxSpeed() {
		return MaxSpeed;
	}

	protected void setMaxSpeed(int MaxSpeed) {
		this.MaxSpeed = MaxSpeed;
	}

	public int getMaxCountPassengers() {
		return MaxCountPassengers;

	}

	protected void setMaxCountPassengers(int MaxCountPassengers) {
		this.MaxCountPassengers = MaxCountPassengers;
	}

	public int getWeight() {
		return Weight;
	}

	protected void setWeight(int Weight) {
		this.Weight = Weight;
	}

	public void setPosition(int x, int y) {
		startPosX = x;
		startPosY = y;
	}
	public void setMainColor(Color color)
	 	{
	 		ColorBody = color;
	 	}
	public abstract String getInfo();
}



