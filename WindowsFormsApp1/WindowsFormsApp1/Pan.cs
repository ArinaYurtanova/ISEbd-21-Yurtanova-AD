using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Pan
    {
        private Wine[] wine;
        private OrangeJuice[] orangeJuice;
        private Sugar sugar;
        private Spice spice;
        public bool  ReadyToGo { get { return Check(); } }  
        public void Init (int countWine )
        {
            wine = new Wine[1];
            orangeJuice = new OrangeJuice[1];
        }
        public void AddWine(Wine w)
        {
            for (int i = 0; i < wine.Length;i++)
                if (wine [i]==null)
                {
                    wine[i] = w;
                    return;
                }
        }
        public void AddSugar(Sugar s)
        {
            sugar = s;
        }
        public void AddOrangeJuice(OrangeJuice oj)
        {
            for (int i = 0; i < orangeJuice.Length; i++)
                if (orangeJuice[i] == null)
                {
                    orangeJuice[i] = oj;
                    return;
                }
        }
        public void AddSpice(Spice sp)
        {
            spice = sp;
        }
        private bool Check()
        {
            if (wine.Length == 0)
            {
                return false;
            }
            if (orangeJuice.Length == 0)
            {
                return false;
            }
            
            for (int i = 0; i < wine.Length; i++)
            {
                if (wine[i] == null)
                {

                    return false;
                }
            }
            for (int i = 0; i < orangeJuice.Length; i++)
            {
                if (orangeJuice[i] == null)
                {
                    return false;
                }
            }
            if (wine.Length == 0)
            {
                return false;
            }

            return true;

        }
        public void GetHeat()
        {
             if (!Check())
            {
                return;
            }
             if (wine.Length>0)
            {
                for (int i = 0; i < wine.Length; i++)
                {
                    wine[i].GetHeat();
                }
                bool flag = false;
                switch (wine [0].Temperature)
                {
                    case 20: flag = true;break;
                    case 40: flag = true; break;
                    case 60: flag = true; break;
                    case 80: flag = true; break;
                    case 100: flag = true; break;
                }
                //if (flag)
            }
        }
    }
}
