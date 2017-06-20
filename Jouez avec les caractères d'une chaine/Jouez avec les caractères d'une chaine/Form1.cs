using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jouez_avec_les_caractères_d_une_chaine
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCatCara_TextChange(object sender, EventArgs e)
        {

            string chaine = TbxSaisie.Text;
            int nbCaraChaine= chaine.Length;

            NumUDPosition.Maximum = nbCaraChaine-1;



        }

        private void BtnCatCara_Click(object sender, EventArgs e)
        {
            string chaine = TbxSaisie.Text;
            decimal IndexCara = NumUDPosition.Value;
            int Index = Decimal.ToInt32(IndexCara);

            //string Cara = chaine.Substring(Index, 1);

            
            char Cara = char.Parse(chaine.Substring(Index, 1));

            
            if (Char.IsLetter(Cara) && char.IsUpper(Cara))
            {

                LblResultat.Text = "Ceci est une lettre majuscule";

            }
            if (Char.IsLetter(Cara) && char.IsLower(Cara))
            {

                LblResultat.Text = "Ceci est une lettre Minuscule";

            }
            if (Char.IsNumber(Cara))
            {

                LblResultat.Text = "Ceci est un chiffre";

            }
            if (Char.IsPunctuation(Cara))
            {

                LblResultat.Text = "Ceci est une ponctuation";

            }

        }
    }
}
