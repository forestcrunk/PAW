using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar9
{
    class Histo : Control
    {
        List<float> ls; //ls= lista de salarii
        Histo()
        {
            ls = null;
        }

        public List<float> Salarii //proprietate
        {
            get => ls;
            set
            {
                ls = value;
                Invalidate(); //invalidate e metoda
                
            }
        }

    }
}
