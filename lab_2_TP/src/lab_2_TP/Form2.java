package lab_2_TP;

import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

import java.awt.SystemColor;
import javax.swing.border.BevelBorder;

public class Form2 {

	private JFrame frame;

	Color color;
	Color dopColor;
	int maxSpeed;
	int maxCountPass;
	int weight;
	boolean pool;
	boolean palyb;
	boolean aquapark;
	boolean restaurant;
	Port port;
	JPanel panel;
	JList list;
	private JTextField Number;
	Form3 select;
	private String[] elements = new String[6];
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Form2 window = new Form2();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Form2() {

		maxSpeed = 40;
		maxCountPass = 1500;
		weight = 10000;
		port = new Port(5);
		initialize();
		for (int i = 0; i < 5; i++) {
			 			 			elements[i] = "Уровень" + (i+1);
			 			 		}
		list.setSelectedIndex(port.getCurrentLevel());
	}
	public void getShip() {
		 		select = new Form3(frame);
		 		if (select.res()) {
		 			ITransport ship = select.getPlane();
		 			int place = port.PutLinerInPort(ship);
		 			panel.repaint();
		 			JOptionPane.showMessageDialog(panel, "Your place: "+ place);
		 		}
		 	}
		 
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 550, 442);
		 		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		 		frame.getContentPane().setLayout(null);
		 
		 	    panel = new Panel(port);
		 	    panel.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		 		panel.setBounds(0, 0, 355, 449);
		 		frame.getContentPane().add(panel);
		 		
		 
		 		Number = new JTextField();
		 		Number.setBounds(421, 228, 34, 23);
		 		frame.getContentPane().add(Number);
		 		Number.setColumns(10);
		 
		 		JLabel lblNewLabel = new JLabel("\u041C\u0435\u0441\u0442\u043E");
		 		lblNewLabel.setBounds(365, 232, 46, 14);
		 		frame.getContentPane().add(lblNewLabel);
		 		
		 		JPanel panelTake = new JPanel();
		 		panelTake.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		 		panelTake.setBounds(368, 291, 127, 108);
		 		frame.getContentPane().add(panelTake);
		 
		 		JButton btnTake = new JButton("\u0417\u0430\u0431\u0440\u0430\u0442\u044C");
		 		btnTake.addActionListener(new ActionListener() {
		 			public void actionPerformed(ActionEvent arg0) {
		 
						if (checkPlace(Number.getText())) {
		 					ITransport ship = port.GetLinerInPort(Integer.parseInt(Number.getText()));
		 					Graphics gr = panelTake.getGraphics();
		 					gr.clearRect(0, 0, panelTake.getWidth(), panelTake.getHeight());
		 					ship.setPosition(10,35);
		 					ship.drawShip(gr);
		 					panel.repaint();
		 				}
		 
		 			}
		 		});
		 		btnTake.setBounds(377, 257, 89, 23);
		 		frame.getContentPane().add(btnTake);
		 		
		 		list = new JList(elements);
		 		list.setBounds(396, 23, 99, 95);
		 		frame.getContentPane().add(list);
		
		 		JButton btnLevelDown = new JButton("<<");
		 		btnLevelDown.addActionListener(new ActionListener() {
		 			public void actionPerformed(ActionEvent arg0) {
		 				port.levelDown();
		 				list.setSelectedIndex(port.getCurrentLevel());
		 				panel.repaint();
		 			}
		 		});
		 		btnLevelDown.setBounds(365, 129, 73, 23);
		 		frame.getContentPane().add(btnLevelDown);
		 
		 		JButton btnLevelUp = new JButton(">>");
		 		btnLevelUp.addActionListener(new ActionListener() {
		 			public void actionPerformed(ActionEvent e) {
		 				port.levelUp();
		 				list.setSelectedIndex(port.getCurrentLevel());
		 				panel.repaint();
		 			}
		 		});
		 		btnLevelUp.setBounds(461, 129, 63, 23);
		 		frame.getContentPane().add(btnLevelUp);
		 
		 		JButton btnGet = new JButton("\u0417\u0430\u043A\u0430\u0437\u0430\u0442\u044C");
		 		btnGet.setForeground(Color.BLACK);
		 		btnGet.addActionListener(new ActionListener() {
		 			@SuppressWarnings("deprecation")
		 			public void actionPerformed(ActionEvent e) {
		 				getShip();
		 			}
		 		});
		 		btnGet.setBounds(396, 160, 89, 23);
		 		frame.getContentPane().add(btnGet);
		 
}
	private boolean checkPlace(String str) {
		try {
			Integer.parseInt(str);
		} catch (Exception e) {
			
			return false;
		}

		if (Integer.parseInt(str) > 20)
			return false;
		return true;
	}
}


