package lab_2_TP;

import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Frame;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class Form1 {

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

	private ITransport inter;
	private Frame Color;
	private Frame DopColor;
	private JTextField textMaxCountPass;
	private JTextField textMaxWeight;
	private JTextField textMaxSpeed;

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Form1 window = new Form1();
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
	public Form1() {

		maxSpeed = 40;
		maxCountPass = 1500;
		weight = 10000;

		initialize();
	}

	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 555, 441);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		final JPanel panel = new JPanel();
		panel.setBounds(10, 11, 519, 244);
		frame.getContentPane().add(panel);

		textMaxCountPass = new JTextField();
		textMaxCountPass.setBounds(218, 297, 48, 20);
		frame.getContentPane().add(textMaxCountPass);
		textMaxCountPass.setColumns(10);

		textMaxWeight = new JTextField();
		textMaxWeight.setBounds(218, 328, 48, 20);
		frame.getContentPane().add(textMaxWeight);
		textMaxWeight.setColumns(10);

		textMaxSpeed = new JTextField();
		textMaxSpeed.setBounds(218, 266, 48, 20);
		frame.getContentPane().add(textMaxSpeed);
		textMaxSpeed.setColumns(10);

		JLabel lblPass = new JLabel(
				"\u041A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E \u043F\u0430\u0441\u0441\u0430\u0436\u0438\u0440\u043E\u0432");
		lblPass.setBounds(10, 300, 177, 14);
		frame.getContentPane().add(lblPass);

		JLabel lblweight = new JLabel("\u0412\u0435\u0441 ");
		lblweight.setBounds(10, 331, 64, 14);
		frame.getContentPane().add(lblweight);

		JLabel lblSpeed = new JLabel(
				"\u0421\u043A\u043E\u0440\u043E\u0441\u0442\u044C");
		lblSpeed.setBounds(10, 269, 64, 14);
		frame.getContentPane().add(lblSpeed);

		final JCheckBox chckbxPool = new JCheckBox(
				"\u0411\u0430\u0441\u0441\u0435\u0439\u043D");
		chckbxPool.setBounds(272, 302, 97, 23);
		frame.getContentPane().add(chckbxPool);

		final JCheckBox chckbxPalyb = new JCheckBox(
				"\u041F\u0430\u043B\u0443\u0431\u0430");
		chckbxPalyb.setBounds(272, 328, 86, 20);
		frame.getContentPane().add(chckbxPalyb);

		JCheckBox chckbxRestaurant = new JCheckBox(
				"\u0420\u0435\u0441\u0442\u043E\u0440\u0430\u043D");
		chckbxRestaurant.setBounds(272, 260, 97, 23);
		frame.getContentPane().add(chckbxRestaurant);

		JCheckBox chckbxAquapark = new JCheckBox(
				"\u0410\u043A\u0432\u0430\u043F\u0430\u0440\u043A");
		chckbxAquapark.setBounds(272, 280, 97, 23);
		frame.getContentPane().add(chckbxAquapark);

		JButton buttonSetShip = new JButton(
				"\u041A\u043E\u0440\u0430\u0431\u043B\u044C");
		buttonSetShip.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (checkFields()) {
					inter = new PassengerShip(maxSpeed, maxCountPass, weight,
							color);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.drawShip(gr);

				}

			}
		});
		buttonSetShip.setBounds(404, 265, 108, 23);
		frame.getContentPane().add(buttonSetShip);

		JButton buttonSetLiner = new JButton(
				"\u041B\u0430\u0439\u043D\u0435\u0440");
		buttonSetLiner.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkFields()) {
					pool = chckbxPool.isSelected();
					palyb = chckbxPalyb.isSelected();
					aquapark = chckbxAquapark.isSelected();
					restaurant = chckbxRestaurant.isSelected();
					inter = new Liner(maxSpeed, maxCountPass, weight, color,
							pool, palyb, aquapark, restaurant, dopColor);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.drawShip(gr);
				}

			}
		});
		buttonSetLiner.setBounds(404, 296, 108, 23);
		frame.getContentPane().add(buttonSetLiner);

		final JButton buttonSetColor = new JButton(
				"\u041E\u0441\u043D\u043E\u0432\u043D\u043E\u0439  \u0446\u0432\u0435\u0442");
		buttonSetColor.setForeground(color);
		buttonSetColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				Color initialBackground = buttonSetColor.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				if (foreground != null) {
					buttonSetColor.setForeground(foreground);
				}
				color = foreground;
			}
		});
		buttonSetColor.setBounds(10, 368, 131, 23);
		frame.getContentPane().add(buttonSetColor);

		final JButton buttonSetDopColor = new JButton(
				"\u0414\u043E\u043F\u043E\u043B\u043D\u0438\u0442\u0435\u043B\u044C\u043D\u044B\u0439 \u0446\u0432\u0435\u0442");
		buttonSetDopColor.setForeground(dopColor);
		buttonSetDopColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				Color initialBackground = buttonSetDopColor.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				if (foreground != null) {
					buttonSetDopColor.setForeground(foreground);
				}
				dopColor = foreground;
			}
		});
		buttonSetDopColor.setBounds(153, 368, 172, 23);
		frame.getContentPane().add(buttonSetDopColor);

		JButton buttonMove = new JButton(
				"\u0414\u0432\u0438\u0436\u0435\u043D\u0438\u0435 ");
		buttonMove.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (inter != null) {
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.moveShip(gr);
				}
			}
		});
		buttonMove.setBounds(407, 338, 105, 23);
		frame.getContentPane().add(buttonMove);

	}

	private boolean checkParse(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
		}

		return true;
	}

	private boolean checkFields() {
		if (checkParse(textMaxCountPass.getText()))
			maxCountPass = Integer.parseInt(textMaxCountPass.getText());
		if (checkParse(textMaxSpeed.getText()))
			maxSpeed = Integer.parseInt(textMaxSpeed.getText());

		if (checkParse(textMaxWeight.getText()))
			weight = Integer.parseInt(textMaxWeight.getText());

		return true;
	}
}