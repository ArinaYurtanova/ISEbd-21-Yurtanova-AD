package lab_2_TP;

import java.awt.Color;
import java.awt.Graphics;

public class Port {
	ClassArray<ITransport> port;
	 	 
	 	int countPlaces = 10;
	 	int placeSizeWidth = 210;
	 	int placeSizeHeight = 80;
	 	 
	 	public Port()
	 	{
	 		port = new ClassArray<ITransport>(countPlaces, null);
	 	}
	 	 
	 	 	public int PutLinerInPort(ITransport ship)
	 	 	{
	 	 		return port.plus(port, ship);
	 	 	}
	 	 
	 	 	public ITransport GetLinerInPort(int ticket)
	 	 	{
	 	 		return port.minus(port, ticket);
	 	 	}
	 	 
	 	 	public void Draw(Graphics g,int width,int height)
	 	 	{
	 	 		DrawMarking(g);
	 	 		for(int i = 0; i < countPlaces; i++)
	 	 		{
	 	 			ITransport liner = port.getObject(i);
	 	 			if (liner != null)
	 	 			{
	 	 				liner.setPosition(0 + i / 5 * placeSizeWidth + 8, i % 5 * placeSizeHeight + 7);
	 	 				liner.drawShip(g);
	 	 			}
	 	 		}
	 	 		
	 	 	}	 
	 	 	public void DrawMarking(Graphics g)
	 	 	{
	 	 		g.setColor(Color.BLACK);
	 	 		g.drawRect( 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
	 	 		for(int i = 0; i < countPlaces / 5; i++)
	 	 		{
	 	 			for(int j = 0; j < 6; j++)
	 	 			{
	 	 				g.drawLine( i * placeSizeWidth,j* placeSizeHeight,i*placeSizeWidth+110,j*placeSizeHeight);
	 	 			}
	 	 			g.drawLine( i * placeSizeWidth, 0, i * placeSizeWidth,400);
	 	 		}
	 	 		
		 	}
	 	 
	 	 
}