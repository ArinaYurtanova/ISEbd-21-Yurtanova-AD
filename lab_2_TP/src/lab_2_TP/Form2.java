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
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import java.awt.SystemColor;

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

	private JTextField Number;

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
		port = new Port();
		initialize();
	}

	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 550, 479);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		final JPanel panel = new Panel(port);
		panel.setBounds(0, 0, 355, 417);
		frame.getContentPane().add(panel);

		JButton SetShip = new JButton(
				"\u041A\u043E\u0440\u0430\u0431\u043B\u044C");
		SetShip.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color colorDialog = JColorChooser.showDialog(null,
						"JColorChooser Sample", null);
				if (colorDialog != null) {
					ITransport ship = new PassengerShip(100, 4, 1000,
							colorDialog);
					int place = port.PutLinerInPort(ship);
					panel.repaint();
					
					JOptionPane.showMessageDialog(null, "Ваше место " + place);

				}

			}
		});
		SetShip.setBounds(396, 35, 89, 23);
		frame.getContentPane().add(SetShip);

		JButton SetLiner = new JButton("\u041B\u0430\u0439\u043D\u0435\u0440");
		SetLiner.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color colorDialog1 = JColorChooser.showDialog(null,
						"JColorChooser Sample", null);
				if (colorDialog1 != null) {
					Color colorDialog = JColorChooser.showDialog(null,
							"JColorChooser Sample", null);
					if (colorDialog != null) {
						ITransport ship = new Liner(40, 1500, 10000,
								colorDialog1, true, true, true, true,
								colorDialog);
						int place = port.PutLinerInPort(ship);
						panel.repaint();
						JOptionPane.showMessageDialog(null, "Ваше место "
								+ place);
					}
				}

			}
		});
		SetLiner.setBounds(396, 82, 89, 23);
		frame.getContentPane().add(SetLiner);

		Number = new JTextField();
		Number.setBounds(417, 186, 86, 28);
		frame.getContentPane().add(Number);

		JLabel label = new JLabel("\u041C\u0435\u0441\u0442\u043E");
		label.setBounds(376, 193, 46, 14);
		frame.getContentPane().add(label);

		final JPanel panel_2 = new JPanel();
		
		panel_2.setBounds(376, 258, 127, 108);
		frame.getContentPane().add(panel_2);

		JButton Get = new JButton("\u0417\u0430\u0431\u0440\u0430\u0442\u044C");
		Get.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkPlace(Number.getText())) {
					ITransport ship = port.GetLinerInPort(Integer
							.parseInt(Number.getText()));
					Graphics gr = panel_2.getGraphics();
					gr.clearRect(0, 0, panel_2.getWidth(), panel_2.getHeight());
					ship.setPosition(10, 10);
					ship.drawShip(gr);
					panel.repaint();
				}
				

			}
		});
		Get.setBounds(396, 225, 89, 23);
		frame.getContentPane().add(Get);
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


