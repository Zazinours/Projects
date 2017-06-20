using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalarieDll;

namespace Delegate_v3
{
    public partial class Form1 : Form
    {
        
        Salarie _sa1 = new Salarie() { SalaireBrut = 1500 };
        public Form1()
        {
            InitializeComponent();
            _sa1.ChangementSalaire += _sa1_ChangementSalaire;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             
            _sa1.SalaireBrut += 10;
            label3.Text = _sa1.SalaireBrut.ToString();
        }
        private void _sa1_ChangementSalaire(object sender, ChangementSalaireEventArgs e)
        {
            //MessageBox.Show(e.AncienSalaire.ToString() + " - " + e.NouveauSalaire.ToString());
            MessageBox.Show("Le salaire a changer !");
        }

    }
}
