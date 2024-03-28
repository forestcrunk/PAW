using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs6
{
    class Salariat
    {
        public int Marca { get; set; }
        public string Nume { get; set; }
    }

    class Firma
    {
        public event EventHandler event_modificare;
        List<Salariat> list;
        public Firma()
        {
            list = new List<Salariat>();
        }

        public void Adauga(Salariat s)
        {
            list.Add(s);
            if(event_modificare != null)
            {
                event_modificare(this, null);
            }
        }

        public List<Salariat> Salariati => list;
    }
}
