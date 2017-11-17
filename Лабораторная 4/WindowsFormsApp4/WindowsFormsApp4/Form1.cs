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
            buttonSelectColor.BackColor = color;
            buttonSelectDopColor.BackColor = dopColor;






        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMaxSpeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                buttonSelectColor.BackColor = color;
            }
        }

        private void buttonSelectDopColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                buttonSelectDopColor.BackColor = dopColor;
            }
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

        private void buttonSetShip_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
