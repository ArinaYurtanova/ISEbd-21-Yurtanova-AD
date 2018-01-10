package lab_2_TP;

import java.awt.Color;
import java.awt.Graphics;
import java.io.Serializable;
public interface ITransport extends Serializable {
	void moveShip(Graphics g);

	void drawShip(Graphics g);

	void setPosition(int x, int y);

	void loadPassenger(int count);

	int getPassenger();
	
	void setMainColor(Color color);

	String getInfo();
	
	

	
}