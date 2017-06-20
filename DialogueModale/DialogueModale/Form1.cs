using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueModale
{
    public partial class FrmDialogueModal : Form
    {
        public FrmDialogueModal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDialogueModal dialogueModal = new FrmDialogueModal();
            DialogResult resultat = dialogueModal.ShowDialog();
        }
        
    }
}
