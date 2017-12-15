package lab_2_TP;
import java.awt.Color;
import java.awt.Graphics;

public class Liner extends PassengerShip {
	private boolean pool;
	private boolean palyb;
	private boolean aquapark;
	private boolean restaurant;
	private Color dopColor;

	public Liner(int maxSpeed, int maxCountPassengers, int weight, Color color,
			boolean pool, boolean palyb, boolean aquapark, boolean restaurant,
			Color dopColor) {
		super(maxCountPassengers, maxSpeed, weight, color);
		this.pool = pool;
		this.palyb = palyb;
		this.aquapark = aquapark;
		this.restaurant = restaurant;
		this.dopColor = dopColor;
	}

	protected void drawUsualShip(Graphics g) {
		super.drawUsualShip(g);

		if (pool) {
			g.setColor(dopColor);
			g.fillOval(startPosX + 20, startPosY + 45, 10, 10);
			g.fillOval(startPosX + 40, startPosY + 45, 10, 10);
			g.fillOval(startPosX + 60, startPosY + 45, 10, 10);
		}

		if (aquapark) {
			g.setColor(dopColor);
			g.drawLine(startPosX + 30, startPosY + 40, startPosX + 30,
					startPosY + 10);
			g.drawLine(startPosX + 30, startPosY + 10, startPosX + 50,
					startPosY + 40);
			g.drawLine(startPosX + 30, startPosY + 10, startPosX + 20,
					startPosY + 40);

		}

		if (palyb) {

			g.setColor(dopColor);
			g.fillRect(startPosX + 20, startPosY + 60, 60, 5);
		}
		if (restaurant) {

			g.setColor(dopColor);
			g.fillRect(startPosX, startPosY + 20, 20, 20);
		}
	}
}