using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulationControles
{
    public partial class FrmManipulation : Form
    {
        public FrmManipulation()
        {
            InitializeComponent();
        }

        private void choix_CheckedChanged(object sender, EventArgs e)

        {
            bool choix;
            string NomChoix;

            choix = ((CheckBox)sender).Checked;
            NomChoix = ((CheckBox)sender).Tag.ToString();

            switch (NomChoix)

            {
                case "ChoixCoulFond":

                    if (choix)
                    {
                        GbxFond.Enabled = true;
                    }
                    else
                    {
                        GbxFond.Enabled = false;
                    }

                    break;

                case "ChoixCoulCar":

                    if (choix)
                    {
                        GbxCara.Enabled = true;
                    }
                    else
                    {
                        GbxCara.Enabled = false;
                    }

                    break;

                case "ChoixCasse":

                    if (choix)
                    {
                        GbxCasse.Enabled = true;
                    }
                    else
                    {
                        GbxCasse.Enabled = false;
                    }

                    break;


                default:
                    break;
            }


        }

        private void Fond_CheckedChanged(object sender, EventArgs e)
        {


            bool choix;
            string NomChoix;

            choix = ((RadioButton)sender).Checked;
            NomChoix = ((RadioButton)sender).Tag.ToString();

            switch (NomChoix)
            {

                case "FdRouge":

                    LblResultat.BackColor = System.Drawing.Color.Red;

                    break;
                case "FdVert":

                    LblResultat.BackColor = System.Drawing.Color.Green;

                    break;
                case "FdBleu":

                    LblResultat.BackColor = System.Drawing.Color.Blue;

                    break;
  
  

            }

            
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LblResultat.Text = textBox1.Text;
        }

        private void Cara_CheckedChanged(object sender, EventArgs e)
        {
            bool choix;
            string NomChoix;

            choix = ((RadioButton)sender).Checked;
            NomChoix = ((RadioButton)sender).Tag.ToString();

            switch (NomChoix)
            {
                case "CaraRouge":

                    LblResultat.ForeColor = System.Drawing.Color.Red;

                    break;
                case "CaraVert":

                    LblResultat.ForeColor = System.Drawing.Color.Green;

                    break;
                case "CaraBleu":

                    LblResultat.ForeColor = System.Drawing.Color.Blue;

                    break;
            }

        }

        private void Casse_CheckedChanged(object sender, EventArgs e)
        {
            bool choix;
            string NomChoix;

            choix = ((RadioButton)sender).Checked;
            NomChoix = ((RadioButton)sender).Tag.ToString();

            switch (NomChoix)
            {
                case "CasseMaj":

                    textBox1.Text = textBox1.Text.ToUpper();

                    break;
                case "CasseMin":

                    textBox1.Text = textBox1.Text.ToLower();

                    break;
            }

        }
    }
}
