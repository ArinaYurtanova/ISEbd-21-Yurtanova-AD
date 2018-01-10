package lab_2_TP;

import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class Liner extends PassengerShip implements Serializable {
	private boolean pool;
	private boolean palyb;
	private boolean aquapark;
	private boolean restaurant;
	transient private Color dopColor;

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

	public void setDopColor(Color f) {
		dopColor = f;
	}
	private void writeObject(ObjectOutputStream s) throws IOException {
		        s.defaultWriteObject();
		         s.writeInt(ColorBody.getRed());
		         s.writeInt(ColorBody.getGreen());
		         s.writeInt(ColorBody.getBlue());
		         s.writeInt(dopColor.getRed());
		         s.writeInt(dopColor.getGreen());
		         s.writeInt(dopColor.getBlue());
		     }
		 
		     private void readObject(ObjectInputStream s) throws IOException, ClassNotFoundException {
		         s.defaultReadObject();
		         int red = s.readInt();
		         int green = s.readInt();
		         int blue = s.readInt();
		         ColorBody = new Color(red, green, blue);
		         int red1 = s.readInt();
		         int green1 = s.readInt();
		         int blue1 = s.readInt();
		         dopColor = new Color(red1, green1, blue1);
		     }
		 
		     public Liner(String info){
		     	     	super(info);
		     	         String[] strs = info.split(";");
		     	         if (strs.length == 7)
		     	         {
		     	        	 MaxSpeed = Integer.parseInt(strs[0]);
			   	             MaxCountPassengers = Integer.parseInt(strs[1]);
			   	             ColorBody = Color.decode(strs[2]);
			   	             Weight = Integer.parseInt(strs[3]);
		   	             countPassengers = Integer.parseInt(strs[4]);  	            
		     	             restaurant = Boolean.parseBoolean(strs[5]);
		     	             aquapark = Boolean.parseBoolean(strs[6]);
		     	             palyb = Boolean.parseBoolean(strs[7]);
		     	             pool = Boolean.parseBoolean(strs[8]);
		     	             dopColor= Color.decode(strs[9]);
		     	             
		     	         }
		     	     }
		     
		     
		 	public String getInfo() {
		 		// TODO Auto-generated method stub
		 		return MaxSpeed + ";" + MaxCountPassengers + ";" + Weight + ";" + countPassengers + ";" + restaurant + ";" + aquapark + ";" + palyb + ";" +pool+";"+ dopColor;
		 
		 	}
}
