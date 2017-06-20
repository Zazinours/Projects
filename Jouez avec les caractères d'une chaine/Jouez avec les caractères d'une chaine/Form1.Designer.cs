namespace Jouez_avec_les_caractères_d_une_chaine
{
    partial class FrmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxSaisie = new System.Windows.Forms.TextBox();
            this.NumUDPosition = new System.Windows.Forms.NumericUpDown();
            this.LblResultat = new System.Windows.Forms.Label();
            this.BtnCatCara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisissez une chaine :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Résultat :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "position du caractère :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TbxSaisie
            // 
            this.TbxSaisie.Location = new System.Drawing.Point(138, 7);
            this.TbxSaisie.Name = "TbxSaisie";
            this.TbxSaisie.Size = new System.Drawing.Size(302, 20);
            this.TbxSaisie.TabIndex = 3;
            this.TbxSaisie.TextChanged += new System.EventHandler(this.BtnCatCara_TextChange);
            // 
            // NumUDPosition
            // 
            this.NumUDPosition.Location = new System.Drawing.Point(138, 34);
            this.NumUDPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUDPosition.Name = "NumUDPosition";
            this.NumUDPosition.Size = new System.Drawing.Size(120, 20);
            this.NumUDPosition.TabIndex = 4;
            this.NumUDPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblResultat
            // 
            this.LblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResultat.Location = new System.Drawing.Point(138, 66);
            this.LblResultat.Name = "LblResultat";
            this.LblResultat.Size = new System.Drawing.Size(302, 20);
            this.LblResultat.TabIndex = 5;
            // 
            // BtnCatCara
            // 
            this.BtnCatCara.Location = new System.Drawing.Point(12, 100);
            this.BtnCatCara.Name = "BtnCatCara";
            this.BtnCatCara.Size = new System.Drawing.Size(428, 21);
            this.BtnCatCara.TabIndex = 6;
            this.BtnCatCara.Text = "Catégorie de caractère";
            this.BtnCatCara.UseVisualStyleBackColor = true;
            this.BtnCatCara.Click += new System.EventHandler(this.BtnCatCara_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 130);
            this.Controls.Add(this.BtnCatCara);
            this.Controls.Add(this.LblResultat);
            this.Controls.Add(this.NumUDPosition);
            this.Controls.Add(this.TbxSaisie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.Text = "Catégorie du caractère";
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxSaisie;
        private System.Windows.Forms.NumericUpDown NumUDPosition;
        private System.Windows.Forms.Label LblResultat;
        private System.Windows.Forms.Button BtnCatCara;
    }
}

