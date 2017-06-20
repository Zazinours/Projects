using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instanciation_dynamique_de_controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Damier()

        {


            //this.Paint += (o, e) => {
            //    Graphics g = e.Graphics;
            //    using (Pen selPen = new Pen(Color.Blue))
            //    {
            //        g.DrawRectangle(selPen, 10, 10, 50, 50);
            //        //g.FillRectangle(Brush, new Rectangle(10, 60, 50, 50));
            //    }
            //};



            this.Refresh();

        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int nbCase;
            int tailleCase;


            nbCase = 10;
            tailleCase = 60;

            Graphics g = this.CreateGraphics();
            Brush b = new SolidBrush(Color.Yellow);

            for (int x = 0; x < nbCase; x++)
            {

                for (int y = 0; y < nbCase; y++)
                {

                    if (x % 2 == 0)
                    {
                        if (y % 2 == 0)
                        {
                            b = new SolidBrush(Color.Black);
                        }
                        else
                        {
                            b = new SolidBrush(Color.White);
                        }

                        g.FillRectangle(b, x * tailleCase, y * tailleCase, tailleCase, tailleCase);
                    }
                    if (x % 2 != 0)
                    {
                        if (y % 2 == 0)
                        {
                            b = new SolidBrush(Color.White);
                        }
                        else
                        {
                            b = new SolidBrush(Color.Black);
                        }

                        g.FillRectangle(b, x * tailleCase, y * tailleCase, tailleCase, tailleCase);
                    }

                }
                


            }



        }


        //b.Dispose();
        //    g.Dispose();

        }
}

