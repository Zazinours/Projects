namespace DialogueConnexion
{
    partial class FrmDialogueModal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GbxParametres = new System.Windows.Forms.GroupBox();
            this.TbxPass = new System.Windows.Forms.TextBox();
            this.TbxID = new System.Windows.Forms.TextBox();
            this.LblPasse = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.BtnConnecte = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbxParametres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxParametres
            // 
            this.GbxParametres.Controls.Add(this.TbxPass);
            this.GbxParametres.Controls.Add(this.TbxID);
            this.GbxParametres.Controls.Add(this.LblPasse);
            this.GbxParametres.Controls.Add(this.lblID);
            this.GbxParametres.Location = new System.Drawing.Point(12, 12);
            this.GbxParametres.Name = "GbxParametres";
            this.GbxParametres.Size = new System.Drawing.Size(426, 85);
            this.GbxParametres.TabIndex = 0;
            this.GbxParametres.TabStop = false;
            this.GbxParametres.Text = "Paramètres d\'authentification";
            // 
            // TbxPass
            // 
            this.TbxPass.Location = new System.Drawing.Point(89, 53);
            this.TbxPass.Name = "TbxPass";
            this.TbxPass.PasswordChar = '*';
            this.TbxPass.Size = new System.Drawing.Size(307, 20);
            this.TbxPass.TabIndex = 3;
            this.TbxPass.Validating += new System.ComponentModel.CancelEventHandler(this.TbxPass_Validating);
            // 
            // TbxID
            // 
            this.TbxID.Location = new System.Drawing.Point(89, 25);
            this.TbxID.Name = "TbxID";
            this.TbxID.Size = new System.Drawing.Size(307, 20);
            this.TbxID.TabIndex = 2;
            this.TbxID.Validating += new System.ComponentModel.CancelEventHandler(this.TbxID_Validating);
            // 
            // LblPasse
            // 
            this.LblPasse.AutoSize = true;
            this.LblPasse.Location = new System.Drawing.Point(12, 56);
            this.LblPasse.Name = "LblPasse";
            this.LblPasse.Size = new System.Drawing.Size(71, 13);
            this.LblPasse.TabIndex = 1;
            this.LblPasse.Text = "Mot de passe";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(18, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID utilisateur";
            // 
            // BtnConnecte
            // 
            this.BtnConnecte.Location = new System.Drawing.Point(12, 103);
            this.BtnConnecte.Name = "BtnConnecte";
            this.BtnConnecte.Size = new System.Drawing.Size(105, 23);
            this.BtnConnecte.TabIndex = 1;
            this.BtnConnecte.Tag = "Connexion";
            this.BtnConnecte.Text = "Se connecter";
            this.BtnConnecte.UseVisualStyleBackColor = true;
            this.BtnConnecte.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(333, 104);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(105, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Tag = "Quitter";
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.Btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmDialogueModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 139);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.BtnConnecte);
            this.Controls.Add(this.GbxParametres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDialogueModal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identifiez-vous";
            this.Load += new System.EventHandler(this.FrmDialogueModal_Load);
            this.GbxParametres.ResumeLayout(false);
            this.GbxParametres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxParametres;
        private System.Windows.Forms.TextBox TbxPass;
        private System.Windows.Forms.TextBox TbxID;
        private System.Windows.Forms.Label LblPasse;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button BtnConnecte;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

