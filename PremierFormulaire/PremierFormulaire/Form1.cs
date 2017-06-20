using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierFormulaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);

        }

        private void BtnEffacer_Click(object sender, EventArgs e)
        {

            TbxTxtInitial.Text = "Entrer un texte initial";
            TbxTxtInitial.Focus();

            lblRecopie.Text = "";
        }

        private void BtnRecopier_Click(object sender, EventArgs e)
        {
            lblRecopie.Text = TbxTxtInitial.Text;
        }
    }
}
