using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Port
    {
        ClassArray<ITransport> port;
        List<ClassArray<ITransport>> portStages;
        int countPlaces = 20;
        int placeSizeWidth = 210;
        int placeSizeHeight = 80;
        int currentLevel;
        public int getCurrentLevel { get { return currentLevel; } }
        public Port(int countStages)
        {
            portStages = new List<ClassArray<ITransport>>(countPlaces);
            for (int i = 0; i < countStages; i++)
            {
                port = new ClassArray<ITransport>(countPlaces, null);
                portStages.Add(port);
            }
        }
        public void LevelUp()
        {
            if (currentLevel + 1 < portStages.Count)
            {
                currentLevel++;
            }
        }
        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }
        public int PutShipInPort(ITransport ship)
        {
            return portStages[currentLevel] + ship;
        }
        public ITransport GetShipInPort(int ticket)
        {
            return portStages[currentLevel] - ticket;
        }
        public void Draw(Graphics g, int weidth, int height)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var ship = portStages[currentLevel][i];
                if (ship != null)
                {
                    ship.setPosition(5 + i / 5 * placeSizeWidth + 5, i % 5 * placeSizeHeight + 15);
                    ship.drawShip(g);
                }

            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Black), (countPlaces / 5) * placeSizeWidth * 70, 420);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
                    if (i < 5)
                    {
                        g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30), new SolidBrush(Color.Black), i * placeSizeWidth + 30, j * placeSizeHeight + 20);
                    }
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }

        }
    }

}
