using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace othello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            AfficheDamier();

        }

        private void AfficheDamier()
        {

            int TailleCase = 80;
            int NbCase = decimal.ToInt32(NumUD.Value);
            int limite = 640;
            bool couleur;
            int Verif = decimal.ToInt32(limite / NbCase);
            limite = Verif * NbCase;

            if (Verif > limite)
            {

                TailleCase = limite / NbCase;

            }




            for (int y = 0; y < limite; y++)

            {
                if (y < NbCase)
                {
                    if (y % 2 == 0)
                    {
                        couleur = true;
                    }
                    else
                    {
                        couleur = false;
                    }


                    for (int x = 0; x < NbCase; x++)
                    {


                        Button Btn = new Button();

                        Btn.Height = TailleCase;
                        Btn.Width = TailleCase;
                        Btn.Left = x * TailleCase;
                        Btn.Top = y * TailleCase;
                        Btn.FlatStyle = FlatStyle.Flat;
                        Btn.Margin = new Padding(0, 0, 0, 0);

                        if (couleur)
                        {
                            Btn.BackColor = Color.Black;
                            couleur = false;
                        }
                        else
                        {
                            couleur = true;
                        }

                        flowLayoutPanelDamier.Controls.Add(Btn);

                    //    flowLayoutPanelDamier.Refresh();

                    }
                }

            }




        }



        private void NumUD_ValueChanged(object sender, EventArgs e)
        {

            if (NumUD.Value > 1)
            {
                flowLayoutPanelDamier.Controls.Clear();
          //      flowLayoutPanelDamier.Refresh();

                AfficheDamier();
            }
            else
            {

                NumUD.Value = 2;

            }


        }
    }
}
