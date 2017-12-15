package lab_2_TP;

import java.awt.Graphics;

public interface ITransport {
	void moveShip(Graphics g);

	void drawShip(Graphics g);

	void setPosition(int x, int y);

	void loadPassenger(int count);

	int getPassenger();
}