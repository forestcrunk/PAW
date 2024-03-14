using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4_WindowsForms
{
    internal class CElement
    {

        public event Action<int> ev_change_val;


        int a;

        public CElement()
        {
            a = 0;
        }

        public CElement(int _a)
        {
            a = _a;
        }

        public int Element
        {
            get => a;
            set
            {
                if (a != value)
                {
                    a = value;
                    if (ev_change_val != null)
                    {
                        ev_change_val(value);
                    }
                }
            }
        }

        public int ElementSq => a * a;
    }
}
