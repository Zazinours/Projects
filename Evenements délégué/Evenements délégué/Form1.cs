using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evenements_délégué
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public void salaireInvoquerMethodes_TextChanged(object sender, EventArgs e)
        {

            //appelMethodes();
            
        }
        public void MethodeA()
        {

            MessageBox.Show("Le salaire à changé !");

        }
        public void MethodeB()
        {

            MessageBox.Show("Ben si !");

        }
    }
}
