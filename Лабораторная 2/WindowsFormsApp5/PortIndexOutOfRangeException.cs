using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class PortIndexOutOfRangeException: Exception
    {
        public PortIndexOutOfRangeException():
            base("В порту нет кораблей на этом месте")
        { }
    }
}
