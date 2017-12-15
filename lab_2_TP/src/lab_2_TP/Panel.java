package lab_2_TP;

import java.awt.Graphics;

import javax.swing.JPanel;

public class Panel extends JPanel {

	Port port;

	public Panel(Port por) {
		this.port = por;
	}

	public void paint(Graphics g) {
		g.clearRect(0, 0, this.getWidth(), this.getHeight());
		port.Draw(g, this.getWidth(), this.getHeight());
	}
}