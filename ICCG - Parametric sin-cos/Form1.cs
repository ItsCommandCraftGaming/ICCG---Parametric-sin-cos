using System;
using System.Drawing;
using System.Windows.Forms;

namespace ICCG___Parametric_sin_cos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double xi, yi, t;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double r;
            r = Convert.ToDouble(numericUpDown1.Value);

            System.Drawing.Graphics desen;
            System.Random n;
            System.Drawing.Pen creion_albastru;
            System.Drawing.SolidBrush pensula_rosie;
            System.Drawing.SolidBrush radiera;

            desen = this.CreateGraphics();
            n = new System.Random();
            pensula_rosie = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            radiera = new System.Drawing.SolidBrush(this.BackColor);
            desen.Clear(BackColor);
            x0 = x; y0 = y;

            t = 0; int k = 0;
            while (t <= 2)
            {
                if (k % 50 >= 25)
                {
                    creion_albastru = new System.Drawing.Pen(Color.Green);
                    xi = 300 - 200 * Math.Sin(r * Math.PI * t);
                    yi = 200 - 200 * Math.Cos(15 * Math.PI * t);
                    x = Convert.ToInt32(xi);
                    y = Convert.ToInt64(yi);

                    desen.DrawLine(creion_albastru, x0, y0, x, y);
                    t += 0.0001;
                    k += 1;
                    x0 = x; y0 = y;

                }
                else
                {
                    creion_albastru = new System.Drawing.Pen(Color.Red);
                    xi = 300 - 200 * Math.Sin(r * Math.PI * t);
                    yi = 200 - 200 * Math.Cos(15 * Math.PI * t);
                    x = Convert.ToInt32(xi);
                    y = Convert.ToInt64(yi);

                    desen.DrawLine(creion_albastru, x0, y0, x, y);
                    t += 0.0001;
                    k += 1;
                    x0 = x; y0 = y;

                }
            }
        }

        long x, y, x0, y0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
