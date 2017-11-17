using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        Port port;
        public Form2()
        {
               InitializeComponent();
               port = new Port();
               Draw();
        }
            
            private void Draw()
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                port.Draw(gr, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bmp;
            }

         

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetLiner_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var ship = new Liner(100, 4, 1000, dialog.Color, true, true, true,true, dialogDop.Color);
                    int place = port.PutShipInPort(ship);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }
        }

        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var ship = new PassengerShip(100, 4, 1000, dialog.Color);
                int place = port.PutShipInPort(ship);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }
        }

        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var ship = port.GetShipInPort(Convert.ToInt32(maskedTextBox1.Text));

                Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.setPosition(5, 5);
                ship.drawShip(gr);
                pictureBoxTakeShip.Image = bmp;
                Draw();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
