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

        private void ChkbxCouleurFond_CheckedChanged(object sender, EventArgs e)
        {

            if (ChkbxCouleurFond.Checked)
            {
                GbxFond.Enabled = true;
            }
            else
            {
                GbxFond.Enabled=false;
            }
        }

        private void ChkbxCouleurCara_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkbxCouleurCara.Checked)
            {
                GbxCara.Enabled = true;
            }
            else
            {
                GbxCara.Enabled = false;
            }
        }

        private void ChkbxCasse_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkbxCasse.Checked)
            {
                GbxCasse.Enabled = true;
            }
            else
            {
                GbxCasse.Enabled = false;
            }
        }

        private void RbtnFondRouge_CheckedChanged(object sender, EventArgs e)
        {
            LblResultat.BackColor = System.Drawing.Color.Red;
        }

        private void RbtnFondVert_CheckedChanged(object sender, EventArgs e)
        {
            LblResultat.BackColor = System.Drawing.Color.Green;

        }

        private void RbtnFondBleu_CheckedChanged(object sender, EventArgs e)
        {
            LblResultat.BackColor = System.Drawing.Color.Blue;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LblResultat.Text = textBox1.Text;
        }

        private void RbtnCaraRouge_CheckedChanged(object sender, EventArgs e)
        {
            LblResultat.ForeColor = System.Drawing.Color.Red;

        }

        private void RbtnCaraVert_CheckedChanged(object sender, EventArgs e)
        {
            LblResultat.ForeColor = System.Drawing.Color.Green;

        }

        private void RbtnCaraBleu_CheckedChanged(object sender, EventArgs e)
        {
            LblResultat.ForeColor = System.Drawing.Color.Blue;

        }

        private void RbtnMaj_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void RbtnMin_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
        }
    }
}
