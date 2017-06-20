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
        List<Button> listBtn = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NumUD.Value = 15;
            AfficheDamier();

        }

        private void AfficheDamier()
        {
            
            int TailleCase = 80;
            int NbCase= decimal.ToInt32(NumUD.Value);
                       
            int limite = 640;

            if ((NbCase * TailleCase) > limite)
            {

                TailleCase = limite / NbCase;

            }

            bool couleur = true;

            for (int y = 0; y < NbCase; y++)

            {

                if (y%2==0)
                {
                    couleur = true;
                }
                else
                {
                    couleur = false;
                }
                for (int x = 0; x < NbCase; x++)
                {

                  Button  Btn = new Button();

                    Btn.Height = TailleCase;
                    Btn.Width = TailleCase;
                    Btn.Left = x * TailleCase;
                    Btn.Top = y*TailleCase;
                    Btn.FlatStyle = FlatStyle.Flat;
                    

                    if (couleur)
                    {
                        Btn.BackColor = Color.Black;
                        couleur = false;
                    }
                    else
                    {
                        couleur = true;
                    }
                    listBtn.Add(Btn);
                    this.Controls.Add(Btn);

                    this.Refresh();

                }
            }




        }

        public int CalculeXY(int NbCase,int TailleCase)
        {
            int nb = NbCase;
            int Taille = TailleCase;
            int limite = 640;

            if ((nb*Taille)>limite)
            {

                Taille = limite / nb;

            }

            TailleCase = Taille;

            return TailleCase;
        }

        private void NumUD_ValueChanged(object sender, EventArgs e)
        {
            DetruitButton();
            ActiveForm.Refresh();

            AfficheDamier();

        }

        private void DetruitButton()
        {
            listBtn.Clear();
                                   
        }
    }
}
