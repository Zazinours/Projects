using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonPremierDelegate2
{
    public partial class Form1 : Form
    {
        delegate bool premierDelegate(int taux);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            int taux = int.Parse(TbxAugmentation.Text) / 100;
            int salaireOrigine = int.Parse(TbxSalaire.Text);

           
            
        }

  
        static public bool CalculeNouveauSalaire(int taux)
        {
            bool changement = false;

            if (taux!=0)
            {
                 MessageBox.Show("Le salaire a changer !");
            }
            else
            {
                MessageBox.Show("Le salaire n'a pas changer !");

            }


            return changement;


        }

        private void BtnCalculeNvSalaire_Click(object sender, EventArgs e)
        {
            premierDelegate a = new premierDelegate(CalculeNouveauSalaire);

            double taux = double.Parse(TbxAugmentation.Text) / 100;
           int salaireOrigine = int.Parse(TbxSalaire.Text);

            TbxNvSalaire.Text = ((salaireOrigine * taux)+salaireOrigine).ToString();
            bool res = a(25);

        }
    }
}
