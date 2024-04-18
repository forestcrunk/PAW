using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Curs9
{
    class Fer_viz : Control
    {
        List<int> lo;
        public Fer_viz()
        {
            lo = null;
            this.ResizeRedraw = true;
        }

        public List<int> Observatii
        {
            get => lo;
            set
            {
                lo = value;
                Invalidate(); //forteaza re-draw la fereastra
            }
        }

        float[] get_unghiuri()
        {
            float[] vu = new float[lo.Count];

            for(int i=0; i <lo.Count; i++)
            {
                vu[i] = (lo[i] * 360F) / lo.Sum();
            }

            return vu;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Rectangle rf = this.ClientRectangle;
            Rectangle rd = new Rectangle {
                X = rf.X + 10,
                Y = rf.Y + 10,
                Width = rf.Width - 20,
                Height = rf.Height - 20
            };

            g.DrawRectangle(Pens.Green, rd);
            Random rgen = new Random();
            if(lo != null)
            {
                float unghi_start = 0;
                float[] vector = get_unghiuri();
                byte[] vcol = new byte[3];
                for (int i = 0; i < vector.Length; i++)
                {
                    rgen.NextBytes(vcol);
                    Brush brush = new SolidBrush(Color.FromArgb(
                        vcol[0], vcol[1], vcol[2]));

                    g.FillPie(brush, rd, unghi_start, vector[i]);
                    unghi_start += vector[i];
                }
            }
        }

    }
}
