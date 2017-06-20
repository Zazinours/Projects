using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace additionneur
{
    public partial class FormAdditionneur : Form
    {
        int resultat;

        public FormAdditionneur()
        {
            InitializeComponent();

            
        }

        private void FormAdditionneur_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

            int addition;

            RtxtBAffichage.Text = RtxtBAffichage.Text + "0+";

            resultat = resultat + 0;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            RtxtBAffichage.Text = RtxtBAffichage.Text + "1+";

            resultat = resultat + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            RtxtBAffichage.Text = RtxtBAffichage.Text + "2+";
            resultat = resultat + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            RtxtBAffichage.Text = RtxtBAffichage.Text + "3+";
            resultat = resultat + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            RtxtBAffichage.Text = RtxtBAffichage.Text + "4+";
            resultat = resultat + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            RtxtBAffichage.Text = RtxtBAffichage.Text + "5+";
            resultat = resultat + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            RtxtBAffichage.Text = RtxtBAffichage.Text + "6+";
            resultat = resultat + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            RtxtBAffichage.Text = RtxtBAffichage.Text + "7+";
            resultat = resultat + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            RtxtBAffichage.Text = RtxtBAffichage.Text + "8+";
            resultat = resultat + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            RtxtBAffichage.Text = RtxtBAffichage.Text + "9+";
            resultat = resultat + 9;
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            RtxtBAffichage.Text = "";
            resultat = 0;
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {


            RtxtBAffichage.Text = RtxtBAffichage.Text + "=" + resultat+"+";

        }
    }
}
