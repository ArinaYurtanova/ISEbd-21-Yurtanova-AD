using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public interface ITransport
    {
        void moveShip(Graphics g);
        void drawShip(Graphics g);
        void setPosition(int x, int y);
        void loadPassenger(int count);
        int getPassenger();
        void SetMainColor(Color color);
        string getInfo();
    }
}
