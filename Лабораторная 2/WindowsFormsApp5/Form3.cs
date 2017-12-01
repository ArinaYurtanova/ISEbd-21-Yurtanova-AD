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
    public partial class Form3 : Form
    {
        ITransport ship = null;

        public ITransport getShip { get { return ship; } }
        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.setPosition(5, 5);
                ship.drawShip(gr);
                pictureBox1.Image = bmp;
            }
        }
        private event myDel eventAddShip;
        public void AddEvent(myDel ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new myDel(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }



        public Form3()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelViolet.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };

        }

        private void labelShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelShip_Click(object sender, EventArgs e)
        {

        }

        private void panelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Корабль":
                    ship = new PassengerShip(40, 1500, 10000, Color.White);
                    break;
                case "Лайнер":
                    ship = new Liner(40, 1500, 10000, Color.White, true, true, true, true, Color.Black);
                    break;
            }
            DrawShip();
        }

        private void panelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }

        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                if (ship is Liner)
                {
                    (ship as Liner).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShip();
                }
            }

        }


        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (eventAddShip != null)
            {
                eventAddShip(ship);
            }
            Close();

        }

        private void panelWhite_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panelRed_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panelYellow_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panelGreen_MouseDown(object sender, MouseEventArgs e)
        {

        }


        private void labelLiner_MouseDown(object sender, MouseEventArgs e)
        {
            labelLiner.DoDragDrop(labelLiner.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_Click(object sender, EventArgs e)
        {

        }

        private void labelLiner_Click(object sender, EventArgs e)
        {

        }
    }
}
