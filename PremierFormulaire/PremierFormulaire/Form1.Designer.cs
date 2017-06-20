namespace PremierFormulaire
{
    partial class Form1
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
            this.labelOriginal = new System.Windows.Forms.Label();
            this.labelCopie = new System.Windows.Forms.Label();
            this.TbxTxtInitial = new System.Windows.Forms.TextBox();
            this.lblRecopie = new System.Windows.Forms.Label();
            this.BtnRecopier = new System.Windows.Forms.Button();
            this.BtnEffacer = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOriginal
            // 
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Location = new System.Drawing.Point(17, 20);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(48, 13);
            this.labelOriginal.TabIndex = 0;
            this.labelOriginal.Text = "Original :";
            // 
            // labelCopie
            // 
            this.labelCopie.AutoSize = true;
            this.labelCopie.Location = new System.Drawing.Point(25, 66);
            this.labelCopie.Name = "labelCopie";
            this.labelCopie.Size = new System.Drawing.Size(40, 13);
            this.labelCopie.TabIndex = 1;
            this.labelCopie.Text = "Copie :";
            // 
            // TbxTxtInitial
            // 
            this.TbxTxtInitial.Location = new System.Drawing.Point(82, 20);
            this.TbxTxtInitial.Name = "TbxTxtInitial";
            this.TbxTxtInitial.Size = new System.Drawing.Size(495, 20);
            this.TbxTxtInitial.TabIndex = 2;
            this.TbxTxtInitial.Text = "Entrer un texte initial";
            // 
            // lblRecopie
            // 
            this.lblRecopie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecopie.Location = new System.Drawing.Point(80, 61);
            this.lblRecopie.Name = "lblRecopie";
            this.lblRecopie.Size = new System.Drawing.Size(496, 17);
            this.lblRecopie.TabIndex = 3;
            // 
            // BtnRecopier
            // 
            this.BtnRecopier.Location = new System.Drawing.Point(632, 9);
            this.BtnRecopier.Name = "BtnRecopier";
            this.BtnRecopier.Size = new System.Drawing.Size(75, 23);
            this.BtnRecopier.TabIndex = 4;
            this.BtnRecopier.Text = "Recopier";
            this.BtnRecopier.UseVisualStyleBackColor = true;
            this.BtnRecopier.Click += new System.EventHandler(this.BtnRecopier_Click);
            // 
            // BtnEffacer
            // 
            this.BtnEffacer.Location = new System.Drawing.Point(632, 37);
            this.BtnEffacer.Name = "BtnEffacer";
            this.BtnEffacer.Size = new System.Drawing.Size(75, 23);
            this.BtnEffacer.TabIndex = 5;
            this.BtnEffacer.Text = "Effacer";
            this.BtnEffacer.UseVisualStyleBackColor = true;
            this.BtnEffacer.Click += new System.EventHandler(this.BtnEffacer_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(632, 66);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitter.TabIndex = 6;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 101);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnEffacer);
            this.Controls.Add(this.BtnRecopier);
            this.Controls.Add(this.lblRecopie);
            this.Controls.Add(this.TbxTxtInitial);
            this.Controls.Add(this.labelCopie);
            this.Controls.Add(this.labelOriginal);
            this.Name = "Form1";
            this.Text = "Recopier un champ dans un autre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.Label labelCopie;
        private System.Windows.Forms.TextBox TbxTxtInitial;
        private System.Windows.Forms.Label lblRecopie;
        private System.Windows.Forms.Button BtnRecopier;
        private System.Windows.Forms.Button BtnEffacer;
        private System.Windows.Forms.Button BtnQuitter;
    }
}

