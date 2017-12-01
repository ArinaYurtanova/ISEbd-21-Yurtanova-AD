using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Liner : PassengerShip
    {
        private Color dopColor;
        private bool pool;
        private bool palyb;
        private bool aquapark;
        private bool restaurant;
        public Liner(int maxSpeed, int maxCountPassengers, double weight, Color color, bool pool, bool palyb, bool aquapark, bool restaurant, Color dopColor) : base(maxCountPassengers, maxSpeed, weight, color)
        {
            this.dopColor = dopColor;
            this.pool = pool;
            this.palyb = palyb;
            this.aquapark = aquapark;
            this.restaurant = restaurant;
        }
        public Liner(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 9)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountPassengers = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
                pool = Convert.ToBoolean(strs[4]);
                palyb = Convert.ToBoolean(strs[5]);
                aquapark = Convert.ToBoolean(strs[6]);
                restaurant = Convert.ToBoolean(strs[7]);
                dopColor = Color.FromName(strs[8]);

            }
        }
        protected override void drawUsualShip(Graphics g)
        {

            if (pool)
            {
                Brush brBlue = new SolidBrush(dopColor);
                g.FillEllipse(brBlue, startPosX + 20, startPosY + 45, 10, 10);
                g.FillEllipse(brBlue, startPosX + 40, startPosY + 45, 10, 10);
                g.FillEllipse(brBlue, startPosX + 60, startPosY + 45, 10, 10);
            }
            base.drawUsualShip(g);

            if (aquapark)
            {
                Pen pen = new Pen(dopColor);
                g.DrawLine(pen, startPosX + 30, startPosY + 40, startPosX + 30, startPosY + 10);
                g.DrawLine(pen, startPosX + 30, startPosY + 10, startPosX + 50, startPosY + 40);
                g.DrawLine(pen, startPosX + 30, startPosY + 10, startPosX + 20, startPosY + 40);

            }

            if (palyb)
            {

                Brush br = new SolidBrush(dopColor);
                g.FillRectangle(br, startPosX + 20, startPosY + 60, 60, 5);
            }
            if (restaurant)
            {

                Brush br = new SolidBrush(dopColor);
                g.FillRectangle(br, startPosX, startPosY + 20, 20, 20);
            }

        }
        public void SetDopColor(Color color)
        {
            dopColor = color;
        }
        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" + Weight + ";" + ColorBody.Name + ";" + pool + ";" + aquapark + ";" + palyb + ";" + restaurant + ";" + dopColor.Name;

        }
    }
}
