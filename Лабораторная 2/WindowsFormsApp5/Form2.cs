using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        Port port;
        public Form2()
        {
            InitializeComponent();
            port = new Port(5);
            for (int i = 1; i < 6; i++)
            {
                listBoxLevels.Items.Add("Уровень " + i);
            }
            listBoxLevels.SelectedIndex = port.getCurrentLevel;

            Draw();
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                port.Draw(gr, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bmp;
            }
        }



        

        private void buttonSetShip_Click(object sender, EventArgs e)
        {

        }



        private void buttonSetLiner_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var ship = new Liner(100, 4, 1000, dialog.Color, true, true, true, true, dialogDop.Color);
                    int place = port.PutShipInPort(ship);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonSetShip_Click_1(object sender, EventArgs e)
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

        private void buttonTakeShip_Click_1(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    ITransport ship = port.GetShipInPort(Convert.ToInt32(maskedTextBox1.Text));
                    if (ship != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        ship.setPosition(5, 5);
                        ship.drawShip(gr);
                        pictureBoxTakeShip.Image = bmp;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Извинте, на этом месте нет машины");
                    }
                }
            }
        }

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            port.LevelUp();
            listBoxLevels.SelectedIndex = port.getCurrentLevel;
            Draw();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            port.LevelDown();
            listBoxLevels.SelectedIndex = port.getCurrentLevel;
            Draw();
        }
    }
}
