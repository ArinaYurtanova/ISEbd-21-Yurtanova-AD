package lab_2_TP;

import java.awt.Color;
import java.awt.Graphics;
import java.io.BufferedInputStream;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.ArrayList;

public class Port implements Serializable{
	
	 	 
	 	int countPlaces = 10;
	 	ArrayList<ClassArray<ITransport>> portStages;
	 	int placeSizeWidth = 210;
	 	int placeSizeHeight = 80;
	 	int currentLevel; 
	 	public Port(int countStages)
	 	{
	 			 	portStages = new ArrayList<ClassArray<ITransport>>(countStages);
	 		  		for (int i = 0; i < countStages; i++)
	 		  		{
	 		  			portStages.add(new ClassArray<ITransport>(countPlaces, null));
	 		  		}
	 	}
	 	public int getCurrentLevel(){
	 		 			return currentLevel;	
	 		  	}
	 		  
	 		  	public void levelUp()
	 		  	{
	 		  		if (currentLevel + 1 < portStages.size())
	 		  			{
	 		  			currentLevel++;
	 		  			}
	 		  	}
	 		  
	 		  	public void levelDown()
	 		  	{
	 		  		if (currentLevel > 0)
	 		  			{
	 		  			currentLevel--;			
	 		  			}
	 		   	}
	 		  	public int PutLinerInPort(ITransport ship) throws PortOverflowException
	 	 	{
	 	 		return portStages.get(currentLevel).plus(portStages.get(currentLevel), ship);
	 	 	}
	 	 
	 		  	public ITransport GetLinerInPort(int ind) throws PortIndexOutOfRangeException
	 	 	{
	 	 		return portStages.get(currentLevel).minus(portStages.get(currentLevel), ind);
	 	 	}
	 	 
	 	 	public void Draw(Graphics g,int width,int height)
	 	 	{
	 	 		DrawMarking(g);
	 	 		for(int i = 0; i < countPlaces; i++)
	 	 		{
	 	 			ITransport ship = portStages.get(currentLevel).getLiner(i);
	 	 			if (ship != null)
	 	 			{
	 	 				ship.setPosition(0 + i / 5 * placeSizeWidth + 8, i % 5 * placeSizeHeight + 7);
	 	 				ship.drawShip(g);
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
	 	 	public boolean save(String fileName) throws IOException {
	 	 		 
	 	 		 			FileOutputStream save = null;
	 	 		 			try {
	 	 		 				save = new FileOutputStream(fileName);
	 	 		 			} catch (FileNotFoundException e) {
	 	 		 				// TODO Auto-generated catch block
	 	 		 				e.printStackTrace();
	 	 		 			}
	 	 		 			ObjectOutputStream obSave = new ObjectOutputStream(save);
	 	 		 			System.out.println(portStages.get(0).getLiner(0).getInfo());
	 	 		 			obSave.writeObject(portStages);
	 	 		 
	 	 		 			return true;
	 	 		 		}
	 	 		 
	 	 		 		public boolean load(String filename) {
	 	 		 			try {
	 	 		 				ObjectInputStream obLoad = new ObjectInputStream(new BufferedInputStream(new FileInputStream(filename)));
	 	 		 				try {
	 	 		 					portStages = (ArrayList<ClassArray<ITransport>>)obLoad.readObject();
	 	 		 					System.out.println(portStages.get(0).getLiner(0).getInfo());
	 	 		 				} catch (ClassNotFoundException e) {
	 	 		 					// TODO Auto-generated catch block
	 	 		 					e.printStackTrace();
	 	 		 				}
	 	 		 			} catch (IOException e) {
	 	 		 				// TODO Auto-generated catch block
	 	 		 				e.printStackTrace();
	 	 					}
	 	 		 			
	 	 		 			return true;
	 	 		 		}
	 	 
	 	 
}