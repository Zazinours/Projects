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

        private void BtnJouer_Click(object sender, EventArgs e)
        {

            string chaine = TbxSaisie.Text;
            string str = TbxCh1.Text;
            string remp = TbxRemp2.Text;
            string NbOccu = "0";

            if (chaine != "")
            {

                if (RbtnNbOcc1.Checked == true)
                {

                    compte(str, chaine);


                }

                if (RbtnRempOcc1Par2.Checked == true)
                {

                    RemplaceOcc1Par2(str, remp, chaine);

                }

            }
            else
            {

                MessageBox.Show("La chaîne de référence est vide !");

            }

        }

        private void Rbtn_ChangeValue(object sender, EventArgs e)
        {

            //MessageBox.Show(RbtnRempOcc1Par2.Name);

            if (RbtnNbOcc1.Checked == true)
            {
                TbxRemp2.Enabled = false;

            }
            else
            {
                TbxRemp2.Enabled = true;

            }


        }
        public void compte(String str, String chaine)
        {
            int NbCar = chaine.Length;
            int NbStr = str.Length;
            int NbOccu = 0;
            string Compar;

            chaine = chaine + "*";

            for (int i = 0; i < NbCar; i++)
            {
                Compar = chaine.Substring(i, NbStr);

                if (Compar == str)
                {
                    NbOccu++;
                }
            }

            LblResultat.Text = NbOccu.ToString();

        }
        public void RemplaceOcc1Par2(string str, string remp, string chaine)
        {

            int NbCar = chaine.Length;
            int NbRemp = remp.Length;
            int nboccurence=0;
            string Compar;
            int pos = 0;

            chaine = chaine + "*";

            while (str != string.Empty && chaine.IndexOf(str, pos) != -1)
            {
                nboccurence++;


                Compar = chaine.Substring(pos, NbRemp);
                if (Compar == str)
                {
                    chaine = chaine.Replace(Compar, remp);
                }

            }


            NbCar = chaine.Length;
            chaine = chaine.Remove(NbCar - 1);

            LblResultat.Text = chaine;

        }
    }
}
