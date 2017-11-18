using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Wine
    {
      
        private int temperature = 0;
        public int Temperature { get { return temperature; } }
        public void GetHeat()
        {
            if (temperature<100)
            {
                temperature++;
            }
        }
    }
}
