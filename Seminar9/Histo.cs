using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar9
{
    class Histo : Control
    {
        List<float> ls; //ls= lista de salarii
        Rectangle rd;
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

        Rectangle[] get_rectangles()
        {
            Rectangle[] rectangles = new Rectangle[ls.Count];
            int db, lb, st;
            
            db = rd.Width / (3 * ls.Count + 1);
            st = rd.X + db;
            lb = 2 * db;


            
            return rectangles;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Rectangle rf = this.ClientRectangle;
            rd = new Rectangle
            {
                X = rf.X + 10,
                Y = rf.Y + 10,
                Width = rf.Width - 20,
                Height = rf.Height - 20
            };

            g.DrawRectangle(Pens.Red, rd);
        }

    }
}
