using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class PassengerShip : Vessel
    {
        public override int MaxSpeed
        {

            get
            {
                return base.MaxSpeed;
            }
            protected set
            {
                if (value > 0 && value < 60)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 40;
                }
            }
        }
        public override int MaxCountPassengers
        {
            get
            {
                return base.MaxCountPassengers;
            }
            protected set
            {
                if (value > 0 && value < 3000)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 1500;
                }
            }
        }
        public override double Weight
        {
            get
            {
                return base.Weight;
            }
            protected set
            {
                if (value > 0 && value < 112000)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 100000;
                }
            }
        }
        public PassengerShip(int maxSpeed, int maxCountPassengers, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountPassengers = maxCountPassengers;
            this.ColorBody = color;
            this.Weight = weight;
            this.countPassengers = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);

        }
        public override void moveShip(Graphics g)
        {
            startPosX += (MaxSpeed * 50 / (float)Weight / (countPassengers == 0 ? 1 : countPassengers));
            drawShip(g);
        }

        public override void drawShip(Graphics g)
        {
            drawUsualShip(g);
        }
        protected virtual void drawUsualShip(Graphics g)
        {
            Pen pen = new Pen(ColorBody);
            
            g.DrawLine(pen, startPosX+20, startPosY+60, startPosX+80 , startPosY +60 );
            g.DrawLine(pen, startPosX , startPosY + 40, startPosX + 100, startPosY + 40);
            g.DrawLine(pen, startPosX + 20, startPosY + 60, startPosX , startPosY + 40);
            g.DrawLine(pen, startPosX+100, startPosY + 40, startPosX + 80, startPosY + 60);
            g.DrawLine(pen, startPosX + 50, startPosY -5, startPosX + 100, startPosY + 40);
            g.DrawLine(pen, startPosX + 50, startPosY +40, startPosX + 50, startPosY - 5);
        }
    }
}
