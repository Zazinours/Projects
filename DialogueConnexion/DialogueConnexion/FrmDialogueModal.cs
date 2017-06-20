using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueConnexion
{
    public partial class FrmDialogueModal : Form
    {
        private void FrmDialogueModal_Load(object sender, EventArgs e)
        {

        }
        public FrmDialogueModal()
        {
            InitializeComponent();
            this.btnQuitter.CausesValidation = false;
            this.AcceptButton = BtnConnecte;
            this.CancelButton = btnQuitter;
        }

        private void Btn_Click(object sender, EventArgs e)
        {

            string NomBtn = ((Button)sender).Tag.ToString();

            switch (NomBtn)
            {

                case "Quitter":

                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                    break;

                case "Connexion":

                    if (TbxID.Text == "Fuentes" && TbxPass.Text == "123456")

                    {
                        MessageBox.Show("Infomations de connexion correcte ! Bienvenue !");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                        MessageBox.Show("Infomations de connexion incorrecte ! Recommencez votre saisie !");
                        TbxID.Clear();
                        TbxPass.Clear();
                        TbxID.Focus();

                    }

                    break;

                default:
                    break;
            }
        }

        private void TbxID_Validating(object sender, CancelEventArgs e)
        {

                        
            int MaxCaraID =TbxID.Text.Length;

            if (MaxCaraID<5)
            {
                errorProvider1.SetError(TbxID,"l'Id doit contenir plus de 5 caractères et ne pas être vide !");

            }
            
            if (TbxID.Text!="" && !char.IsLetter(TbxID.Text.First<char>())) 
            {
                errorProvider1.SetError(TbxID, "l'Id doit débuter par un caractère !");
            }

        }

        private void TbxPass_Validating(object sender, CancelEventArgs e)
        {



        }
    }


}

