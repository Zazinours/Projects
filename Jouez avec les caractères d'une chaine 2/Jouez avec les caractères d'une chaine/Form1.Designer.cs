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
            this.LblResultat = new System.Windows.Forms.Label();
            this.BtnJouer = new System.Windows.Forms.Button();
            this.TbxRemp2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxCh1 = new System.Windows.Forms.TextBox();
            this.GbxChoix = new System.Windows.Forms.GroupBox();
            this.RbtnDernOcc1Par2 = new System.Windows.Forms.RadioButton();
            this.Rbtn1EreOcc1Par2 = new System.Windows.Forms.RadioButton();
            this.RbtnRempOcc1Par2 = new System.Windows.Forms.RadioButton();
            this.RbtnNbOcc1 = new System.Windows.Forms.RadioButton();
            this.GbxChoix.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisissez une chaine :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Résultat :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Portion de chaine 1:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TbxSaisie
            // 
            this.TbxSaisie.Location = new System.Drawing.Point(187, 6);
            this.TbxSaisie.Name = "TbxSaisie";
            this.TbxSaisie.Size = new System.Drawing.Size(302, 20);
            this.TbxSaisie.TabIndex = 3;
            this.TbxSaisie.Text = "aabbaabbaa";
            // 
            // LblResultat
            // 
            this.LblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResultat.Location = new System.Drawing.Point(187, 90);
            this.LblResultat.Name = "LblResultat";
            this.LblResultat.Size = new System.Drawing.Size(302, 20);
            this.LblResultat.TabIndex = 5;
            // 
            // BtnJouer
            // 
            this.BtnJouer.Location = new System.Drawing.Point(12, 420);
            this.BtnJouer.Name = "BtnJouer";
            this.BtnJouer.Size = new System.Drawing.Size(477, 21);
            this.BtnJouer.TabIndex = 6;
            this.BtnJouer.Text = "Jouer";
            this.BtnJouer.UseVisualStyleBackColor = true;
            this.BtnJouer.Click += new System.EventHandler(this.BtnJouer_Click);
            // 
            // TbxRemp2
            // 
            this.TbxRemp2.Location = new System.Drawing.Point(187, 62);
            this.TbxRemp2.Name = "TbxRemp2";
            this.TbxRemp2.Size = new System.Drawing.Size(302, 20);
            this.TbxRemp2.TabIndex = 8;
            this.TbxRemp2.Text = "kk";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Portion de remplacement 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TbxCh1
            // 
            this.TbxCh1.Location = new System.Drawing.Point(187, 34);
            this.TbxCh1.Name = "TbxCh1";
            this.TbxCh1.Size = new System.Drawing.Size(302, 20);
            this.TbxCh1.TabIndex = 9;
            this.TbxCh1.Text = "aa";
            // 
            // GbxChoix
            // 
            this.GbxChoix.Controls.Add(this.RbtnDernOcc1Par2);
            this.GbxChoix.Controls.Add(this.Rbtn1EreOcc1Par2);
            this.GbxChoix.Controls.Add(this.RbtnRempOcc1Par2);
            this.GbxChoix.Controls.Add(this.RbtnNbOcc1);
            this.GbxChoix.Location = new System.Drawing.Point(14, 132);
            this.GbxChoix.Name = "GbxChoix";
            this.GbxChoix.Size = new System.Drawing.Size(475, 282);
            this.GbxChoix.TabIndex = 10;
            this.GbxChoix.TabStop = false;
            this.GbxChoix.Text = "Faites votre choix";
            // 
            // RbtnDernOcc1Par2
            // 
            this.RbtnDernOcc1Par2.AutoSize = true;
            this.RbtnDernOcc1Par2.Location = new System.Drawing.Point(7, 92);
            this.RbtnDernOcc1Par2.Name = "RbtnDernOcc1Par2";
            this.RbtnDernOcc1Par2.Size = new System.Drawing.Size(222, 17);
            this.RbtnDernOcc1Par2.TabIndex = 3;
            this.RbtnDernOcc1Par2.Text = "Remplacer dernière occurence de 1 par 2";
            this.RbtnDernOcc1Par2.UseVisualStyleBackColor = true;
            this.RbtnDernOcc1Par2.CheckedChanged += new System.EventHandler(this.Rbtn_ChangeValue);
            // 
            // Rbtn1EreOcc1Par2
            // 
            this.Rbtn1EreOcc1Par2.AutoSize = true;
            this.Rbtn1EreOcc1Par2.Location = new System.Drawing.Point(7, 68);
            this.Rbtn1EreOcc1Par2.Name = "Rbtn1EreOcc1Par2";
            this.Rbtn1EreOcc1Par2.Size = new System.Drawing.Size(190, 17);
            this.Rbtn1EreOcc1Par2.TabIndex = 2;
            this.Rbtn1EreOcc1Par2.Text = "Remplacer 1ère occurence 1 par 2";
            this.Rbtn1EreOcc1Par2.UseVisualStyleBackColor = true;
            this.Rbtn1EreOcc1Par2.CheckedChanged += new System.EventHandler(this.Rbtn_ChangeValue);
            // 
            // RbtnRempOcc1Par2
            // 
            this.RbtnRempOcc1Par2.AutoSize = true;
            this.RbtnRempOcc1Par2.Checked = true;
            this.RbtnRempOcc1Par2.Location = new System.Drawing.Point(7, 44);
            this.RbtnRempOcc1Par2.Name = "RbtnRempOcc1Par2";
            this.RbtnRempOcc1Par2.Size = new System.Drawing.Size(234, 17);
            this.RbtnRempOcc1Par2.TabIndex = 1;
            this.RbtnRempOcc1Par2.TabStop = true;
            this.RbtnRempOcc1Par2.Text = "Remplacer toutes les occurences de 1 par 2";
            this.RbtnRempOcc1Par2.UseVisualStyleBackColor = true;
            this.RbtnRempOcc1Par2.CheckedChanged += new System.EventHandler(this.Rbtn_ChangeValue);
            // 
            // RbtnNbOcc1
            // 
            this.RbtnNbOcc1.AutoSize = true;
            this.RbtnNbOcc1.Location = new System.Drawing.Point(7, 20);
            this.RbtnNbOcc1.Name = "RbtnNbOcc1";
            this.RbtnNbOcc1.Size = new System.Drawing.Size(130, 17);
            this.RbtnNbOcc1.TabIndex = 0;
            this.RbtnNbOcc1.Text = "Nombre occurences 1";
            this.RbtnNbOcc1.UseVisualStyleBackColor = true;
            this.RbtnNbOcc1.CheckedChanged += new System.EventHandler(this.Rbtn_ChangeValue);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 453);
            this.Controls.Add(this.GbxChoix);
            this.Controls.Add(this.TbxCh1);
            this.Controls.Add(this.TbxRemp2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnJouer);
            this.Controls.Add(this.LblResultat);
            this.Controls.Add(this.TbxSaisie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.Text = "Jouez avec une chaîne de caractères";
            this.GbxChoix.ResumeLayout(false);
            this.GbxChoix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxSaisie;
        private System.Windows.Forms.Label LblResultat;
        private System.Windows.Forms.Button BtnJouer;
        private System.Windows.Forms.TextBox TbxRemp2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxCh1;
        private System.Windows.Forms.GroupBox GbxChoix;
        private System.Windows.Forms.RadioButton RbtnDernOcc1Par2;
        private System.Windows.Forms.RadioButton Rbtn1EreOcc1Par2;
        private System.Windows.Forms.RadioButton RbtnRempOcc1Par2;
        private System.Windows.Forms.RadioButton RbtnNbOcc1;
    }
}

