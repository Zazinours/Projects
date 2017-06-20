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

              private void Button_Click(object sender, EventArgs e)
        {
            string txt = ((Button)sender).Text;
            RtxtBAffichage.Text += txt + '+';
            resultat += int.Parse(txt);

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
