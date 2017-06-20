using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogue_Modal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnDigMob_Click(object sender, EventArgs e)
        {
            FrmDialogueModal dialogueModal = new FrmDialogueModal();
            DialogResult resultat = dialogueModal.ShowDialog();

            switch (resultat)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:

                    textBox1.Text= "OK";
                    
                    break;
                case DialogResult.Cancel:
                    textBox1.Text = "Abandon";
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }
    }
}
