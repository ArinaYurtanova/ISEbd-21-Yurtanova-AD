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
    public partial class Form1 : Form
    {
        Color color;
        Color dopColor;
        int maxSpeed;
        int maxCountPass;
        int weight;
        private ITransport inter;
        public Form1()
        {
            InitializeComponent();
            color = Color.Brown;
            dopColor = Color.Blue;
            maxSpeed = 40;
            maxCountPass = 1500;
            weight = 10000;
            buttonSetColor.BackColor = color;
            buttonSetDopColor.BackColor = dopColor;
        }
        private bool checkFields()
        {
            if (!int.TryParse(textBoxMaxSpeed.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBoxMaxCountPassenget.Text, out maxCountPass))
            {
                return false;
            }
            if (!int.TryParse(textBoxWeight.Text, out weight))
            {
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new PassengerShip(maxSpeed, maxCountPass, weight, color);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawShip(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetDopColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                buttonSetDopColor.BackColor = dopColor;
            }

        }

        private void buttonSetLiner_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Liner(maxSpeed, maxCountPass, weight, color, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, dopColor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawShip(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                buttonSetColor.BackColor = color;
            }
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.moveShip(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
