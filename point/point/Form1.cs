using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace point
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Random random = new Random();

            Pen pen = new Pen(Color.DarkKhaki, 2);
            g.DrawRectangle(Pens.Red, 0, 0, 299, 249);

            int v = 2;
            double x = random.Next(10, 290);  
            double y = random.Next(10, 240);  
            double a = random.Next(0, 391);   

            double vx = v * Math.Cos(a);     
            double vy = v * Math.Sin(a);

             


            while (true)
            {

                g.DrawEllipse(new Pen(Color.Black, 2), Convert.ToInt32(Math.Round(x)), Convert.ToInt32(Math.Round(y)), 10, 10);// затираем эллипс

                x += vx; 
                y += vy;

                if (x < 10)
                {
                    vx = -vx;        
                }

                if (x > 285) vx = -vx;
                if (y < 10) vy = -vy;
                if (y > 235) vy = -vy;

                g.DrawEllipse(pen, Convert.ToInt32(Math.Round(x)), Convert.ToInt32(Math.Round(y)), 10, 10);
                Thread.Sleep(10);
                Application.DoEvents();


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
