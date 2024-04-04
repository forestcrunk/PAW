using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Curs7_legare
{
    [Serializable] //adaugam asta pt a face clasa Salariat serializabila
    class Salariat
    {
        public int Marca { get; set; }
        public string Nume { get; set; }
    }

    class Firma_Ev_args : EventArgs
    {
        int idx;
        public Firma_Ev_args(int fidx)
        {
            idx = fidx;
        }

        public int Index => idx;
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
                event_modificare(this, new Firma_Ev_args(list.Count-1));
            }
        }

        public Salariat this[int k]
        {
            get => list[k];
            set
            {
                if (list[k] != value)
                {
                    list[k] = value;
                    if (event_modificare != null)
                    {
                        event_modificare(this, new Firma_Ev_args(k));
                    }
                }
            }
        }
        public List<Salariat> Salariati => list;

        public void Serializare(string nf)
        {
            FileStream fs = new FileStream(nf, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, list);
            fs.Close();
        }

        public void Deserializare(string nf)
        {
            FileStream fs = new FileStream(nf, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            list = bf.Deserialize(fs) as List<Salariat>;
            fs.Close();
            if (event_modificare != null)
            {
                event_modificare(this, new Firma_Ev_args(list.Count-1));
            }

        }
    }
}
