package lab_2_TP;

import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.Random;

public class PassengerShip extends Vessel implements Serializable {
	protected int countPassengers;
	public int MaxCountPassengers;

	protected void setMaxSpeed(int value) {
		if (value > 0 && value < 60) {
			super.setMaxSpeed(value);
		} else {
			super.setMaxSpeed(40);
		}
	}

	protected void setMaxCountPassengers(int value) {
		if (value > 0 && value < 3000) {
			super.setMaxCountPassengers(value);
		} else {
			super.setMaxCountPassengers(1500);
		}
	}

	protected void setWeight(int value) {
		if (value > 0 && value < 112000) {
			super.setWeight(value);
		} else {
			super.setWeight(100000);
		}
	}

	public PassengerShip(int maxSpeed, int maxCountPassengers, int weight,
			Color color) {
		this.MaxSpeed = maxSpeed;
		this.MaxCountPassengers = maxCountPassengers;
		this.ColorBody = color;
		this.Weight = weight;
		this.countPassengers = 0;
		Random rand = new Random();
		startPosX = rand.nextInt(200);
		startPosY = rand.nextInt(200);
	}

	public void moveShip(Graphics g) {

		startPosX += (MaxSpeed * 50 / (float) Weight / (countPassengers == 0 ? 1
				: countPassengers));
		drawShip(g);
	}

	public void drawShip(Graphics g) {
		drawUsualShip(g);
	}

	protected void drawUsualShip(Graphics g) {
		g.setColor(ColorBody);
		g.drawLine(startPosX + 20, startPosY + 60, startPosX + 80,
				startPosY + 60);
		g.drawLine(startPosX, startPosY + 40, startPosX + 100, startPosY + 40);
		g.drawLine(startPosX + 20, startPosY + 60, startPosX, startPosY + 40);
		g.drawLine(startPosX + 100, startPosY + 40, startPosX + 80,
				startPosY + 60);
		g.drawLine(startPosX + 50, startPosY - 5, startPosX + 100,
				startPosY + 40);
		g.drawLine(startPosX + 50, startPosY + 40, startPosX + 50,
				startPosY - 5);
	}

	@Override
	public void loadPassenger(int count) {
	}

	@Override
	public int getPassenger() {
		return 0;
	}
	public PassengerShip(String info)
	     {
	         String[] strs = info.split(info, ';');
	         if(strs.length==5)
	         {
	             MaxSpeed = Integer.parseInt(strs[0]);
	             MaxCountPassengers = Integer.parseInt(strs[1]);
	             ColorBody = Color.decode(strs[2]);
	             Weight = Integer.parseInt(strs[3]);
	             countPassengers = Integer.parseInt(strs[4]);
	             
	         }
	     }
	 
	     public String getInfo()
	     {           
	         return MaxSpeed + ";" + MaxCountPassengers + ";" + ColorBody + ";" + Weight + ";" + countPassengers;
	     }
	     
	     private void writeObject(ObjectOutputStream s) throws IOException {
	         s.defaultWriteObject();
	         s.writeInt(ColorBody.getRed());
	         s.writeInt(ColorBody.getGreen());
	         s.writeInt(ColorBody.getBlue());
	     }
	  
	     private void readObject(ObjectInputStream s) throws IOException, ClassNotFoundException {
	         s.defaultReadObject();
	         int red = s.readInt();
	         int green = s.readInt();
	         int blue = s.readInt();
	         ColorBody = new Color(red, green, blue);
	     }
}
