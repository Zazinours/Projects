namespace ManipulationControles
{
    partial class FrmManipulation
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblInviteTexte = new System.Windows.Forms.Label();
            this.GbxChoix = new System.Windows.Forms.GroupBox();
            this.ChkbxCasse = new System.Windows.Forms.CheckBox();
            this.ChkbxCouleurCara = new System.Windows.Forms.CheckBox();
            this.ChkbxCouleurFond = new System.Windows.Forms.CheckBox();
            this.LblResultat = new System.Windows.Forms.Label();
            this.GbxFond = new System.Windows.Forms.GroupBox();
            this.RbtnFondBleu = new System.Windows.Forms.RadioButton();
            this.RbtnFondVert = new System.Windows.Forms.RadioButton();
            this.RbtnFondRouge = new System.Windows.Forms.RadioButton();
            this.GbxCara = new System.Windows.Forms.GroupBox();
            this.RbtnCaraBleu = new System.Windows.Forms.RadioButton();
            this.RbtnCaraVert = new System.Windows.Forms.RadioButton();
            this.RbtnCaraRouge = new System.Windows.Forms.RadioButton();
            this.GbxCasse = new System.Windows.Forms.GroupBox();
            this.RbtnMaj = new System.Windows.Forms.RadioButton();
            this.RbtnMin = new System.Windows.Forms.RadioButton();
            this.GbxChoix.SuspendLayout();
            this.GbxFond.SuspendLayout();
            this.GbxCara.SuspendLayout();
            this.GbxCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblInviteTexte
            // 
            this.LblInviteTexte.AutoSize = true;
            this.LblInviteTexte.Location = new System.Drawing.Point(19, 13);
            this.LblInviteTexte.Name = "LblInviteTexte";
            this.LblInviteTexte.Size = new System.Drawing.Size(90, 13);
            this.LblInviteTexte.TabIndex = 1;
            this.LblInviteTexte.Text = "Tapez votre texte";
            // 
            // GbxChoix
            // 
            this.GbxChoix.Controls.Add(this.ChkbxCasse);
            this.GbxChoix.Controls.Add(this.ChkbxCouleurCara);
            this.GbxChoix.Controls.Add(this.ChkbxCouleurFond);
            this.GbxChoix.Location = new System.Drawing.Point(247, 13);
            this.GbxChoix.Name = "GbxChoix";
            this.GbxChoix.Size = new System.Drawing.Size(154, 100);
            this.GbxChoix.TabIndex = 2;
            this.GbxChoix.TabStop = false;
            this.GbxChoix.Text = "Choix";
            // 
            // ChkbxCasse
            // 
            this.ChkbxCasse.AutoSize = true;
            this.ChkbxCasse.Checked = true;
            this.ChkbxCasse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkbxCasse.Location = new System.Drawing.Point(7, 68);
            this.ChkbxCasse.Name = "ChkbxCasse";
            this.ChkbxCasse.Size = new System.Drawing.Size(55, 17);
            this.ChkbxCasse.TabIndex = 2;
            this.ChkbxCasse.Tag = "ChoixCasse";
            this.ChkbxCasse.Text = "Casse";
            this.ChkbxCasse.UseVisualStyleBackColor = true;
            this.ChkbxCasse.Click += new System.EventHandler(this.choix_CheckedChanged);
            // 
            // ChkbxCouleurCara
            // 
            this.ChkbxCouleurCara.AutoSize = true;
            this.ChkbxCouleurCara.Checked = true;
            this.ChkbxCouleurCara.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkbxCouleurCara.Location = new System.Drawing.Point(7, 44);
            this.ChkbxCouleurCara.Name = "ChkbxCouleurCara";
            this.ChkbxCouleurCara.Size = new System.Drawing.Size(135, 17);
            this.ChkbxCouleurCara.TabIndex = 1;
            this.ChkbxCouleurCara.Tag = "ChoixCoulCar";
            this.ChkbxCouleurCara.Text = "Couleur des caractères";
            this.ChkbxCouleurCara.UseVisualStyleBackColor = true;
            this.ChkbxCouleurCara.Click += new System.EventHandler(this.choix_CheckedChanged);
            // 
            // ChkbxCouleurFond
            // 
            this.ChkbxCouleurFond.AutoSize = true;
            this.ChkbxCouleurFond.Checked = true;
            this.ChkbxCouleurFond.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkbxCouleurFond.Location = new System.Drawing.Point(7, 20);
            this.ChkbxCouleurFond.Name = "ChkbxCouleurFond";
            this.ChkbxCouleurFond.Size = new System.Drawing.Size(101, 17);
            this.ChkbxCouleurFond.TabIndex = 0;
            this.ChkbxCouleurFond.Tag = "ChoixCoulFond";
            this.ChkbxCouleurFond.Text = "Couleur de fond";
            this.ChkbxCouleurFond.UseVisualStyleBackColor = true;
            this.ChkbxCouleurFond.Click += new System.EventHandler(this.choix_CheckedChanged);
            // 
            // LblResultat
            // 
            this.LblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultat.Location = new System.Drawing.Point(20, 65);
            this.LblResultat.Name = "LblResultat";
            this.LblResultat.Size = new System.Drawing.Size(202, 48);
            this.LblResultat.TabIndex = 3;
            this.LblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxFond
            // 
            this.GbxFond.Controls.Add(this.RbtnFondBleu);
            this.GbxFond.Controls.Add(this.RbtnFondVert);
            this.GbxFond.Controls.Add(this.RbtnFondRouge);
            this.GbxFond.Location = new System.Drawing.Point(22, 126);
            this.GbxFond.Name = "GbxFond";
            this.GbxFond.Size = new System.Drawing.Size(109, 100);
            this.GbxFond.TabIndex = 4;
            this.GbxFond.TabStop = false;
            this.GbxFond.Text = "Fond";
            // 
            // RbtnFondBleu
            // 
            this.RbtnFondBleu.AutoSize = true;
            this.RbtnFondBleu.Location = new System.Drawing.Point(6, 65);
            this.RbtnFondBleu.Name = "RbtnFondBleu";
            this.RbtnFondBleu.Size = new System.Drawing.Size(46, 17);
            this.RbtnFondBleu.TabIndex = 2;
            this.RbtnFondBleu.TabStop = true;
            this.RbtnFondBleu.Tag = "FdBleu";
            this.RbtnFondBleu.Text = "Bleu";
            this.RbtnFondBleu.UseVisualStyleBackColor = true;
            this.RbtnFondBleu.Click += new System.EventHandler(this.Fond_CheckedChanged);
            // 
            // RbtnFondVert
            // 
            this.RbtnFondVert.AutoSize = true;
            this.RbtnFondVert.Location = new System.Drawing.Point(7, 42);
            this.RbtnFondVert.Name = "RbtnFondVert";
            this.RbtnFondVert.Size = new System.Drawing.Size(44, 17);
            this.RbtnFondVert.TabIndex = 1;
            this.RbtnFondVert.TabStop = true;
            this.RbtnFondVert.Tag = "FdVert";
            this.RbtnFondVert.Text = "Vert";
            this.RbtnFondVert.UseVisualStyleBackColor = true;
            this.RbtnFondVert.Click += new System.EventHandler(this.Fond_CheckedChanged);
            // 
            // RbtnFondRouge
            // 
            this.RbtnFondRouge.AutoSize = true;
            this.RbtnFondRouge.Location = new System.Drawing.Point(7, 20);
            this.RbtnFondRouge.Name = "RbtnFondRouge";
            this.RbtnFondRouge.Size = new System.Drawing.Size(57, 17);
            this.RbtnFondRouge.TabIndex = 0;
            this.RbtnFondRouge.TabStop = true;
            this.RbtnFondRouge.Tag = "FdRouge";
            this.RbtnFondRouge.Text = "Rouge";
            this.RbtnFondRouge.UseVisualStyleBackColor = true;
            this.RbtnFondRouge.Click += new System.EventHandler(this.Fond_CheckedChanged);
            // 
            // GbxCara
            // 
            this.GbxCara.Controls.Add(this.RbtnCaraBleu);
            this.GbxCara.Controls.Add(this.RbtnCaraVert);
            this.GbxCara.Controls.Add(this.RbtnCaraRouge);
            this.GbxCara.Location = new System.Drawing.Point(148, 126);
            this.GbxCara.Name = "GbxCara";
            this.GbxCara.Size = new System.Drawing.Size(109, 100);
            this.GbxCara.TabIndex = 5;
            this.GbxCara.TabStop = false;
            this.GbxCara.Text = "Caractères";
            // 
            // RbtnCaraBleu
            // 
            this.RbtnCaraBleu.AutoSize = true;
            this.RbtnCaraBleu.Location = new System.Drawing.Point(11, 64);
            this.RbtnCaraBleu.Name = "RbtnCaraBleu";
            this.RbtnCaraBleu.Size = new System.Drawing.Size(46, 17);
            this.RbtnCaraBleu.TabIndex = 5;
            this.RbtnCaraBleu.TabStop = true;
            this.RbtnCaraBleu.Tag = "CaraBleu";
            this.RbtnCaraBleu.Text = "Bleu";
            this.RbtnCaraBleu.UseVisualStyleBackColor = true;
            this.RbtnCaraBleu.Click += new System.EventHandler(this.Cara_CheckedChanged);
            // 
            // RbtnCaraVert
            // 
            this.RbtnCaraVert.AutoSize = true;
            this.RbtnCaraVert.Location = new System.Drawing.Point(12, 41);
            this.RbtnCaraVert.Name = "RbtnCaraVert";
            this.RbtnCaraVert.Size = new System.Drawing.Size(44, 17);
            this.RbtnCaraVert.TabIndex = 4;
            this.RbtnCaraVert.TabStop = true;
            this.RbtnCaraVert.Tag = "CaraVert";
            this.RbtnCaraVert.Text = "Vert";
            this.RbtnCaraVert.UseVisualStyleBackColor = true;
            this.RbtnCaraVert.Click += new System.EventHandler(this.Cara_CheckedChanged);
            // 
            // RbtnCaraRouge
            // 
            this.RbtnCaraRouge.AutoSize = true;
            this.RbtnCaraRouge.Location = new System.Drawing.Point(12, 19);
            this.RbtnCaraRouge.Name = "RbtnCaraRouge";
            this.RbtnCaraRouge.Size = new System.Drawing.Size(57, 17);
            this.RbtnCaraRouge.TabIndex = 3;
            this.RbtnCaraRouge.TabStop = true;
            this.RbtnCaraRouge.Tag = "CaraRouge";
            this.RbtnCaraRouge.Text = "Rouge";
            this.RbtnCaraRouge.UseVisualStyleBackColor = true;
            this.RbtnCaraRouge.Click += new System.EventHandler(this.Cara_CheckedChanged);
            // 
            // GbxCasse
            // 
            this.GbxCasse.Controls.Add(this.RbtnMaj);
            this.GbxCasse.Controls.Add(this.RbtnMin);
            this.GbxCasse.Location = new System.Drawing.Point(280, 126);
            this.GbxCasse.Name = "GbxCasse";
            this.GbxCasse.Size = new System.Drawing.Size(109, 67);
            this.GbxCasse.TabIndex = 6;
            this.GbxCasse.TabStop = false;
            this.GbxCasse.Text = "Casse";
            // 
            // RbtnMaj
            // 
            this.RbtnMaj.AutoSize = true;
            this.RbtnMaj.Location = new System.Drawing.Point(12, 41);
            this.RbtnMaj.Name = "RbtnMaj";
            this.RbtnMaj.Size = new System.Drawing.Size(73, 17);
            this.RbtnMaj.TabIndex = 4;
            this.RbtnMaj.TabStop = true;
            this.RbtnMaj.Tag = "CasseMaj";
            this.RbtnMaj.Text = "Majuscule";
            this.RbtnMaj.UseVisualStyleBackColor = true;
            this.RbtnMaj.Click += new System.EventHandler(this.Casse_CheckedChanged);
            // 
            // RbtnMin
            // 
            this.RbtnMin.AutoSize = true;
            this.RbtnMin.Location = new System.Drawing.Point(12, 19);
            this.RbtnMin.Name = "RbtnMin";
            this.RbtnMin.Size = new System.Drawing.Size(73, 17);
            this.RbtnMin.TabIndex = 3;
            this.RbtnMin.TabStop = true;
            this.RbtnMin.Tag = "CasseMin";
            this.RbtnMin.Text = "Minuscule";
            this.RbtnMin.UseVisualStyleBackColor = true;
            this.RbtnMin.Click += new System.EventHandler(this.Casse_CheckedChanged);
            // 
            // FrmManipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 235);
            this.Controls.Add(this.GbxCasse);
            this.Controls.Add(this.GbxCara);
            this.Controls.Add(this.GbxFond);
            this.Controls.Add(this.LblResultat);
            this.Controls.Add(this.GbxChoix);
            this.Controls.Add(this.LblInviteTexte);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmManipulation";
            this.Text = "CheckBox et radioButton";
            this.GbxChoix.ResumeLayout(false);
            this.GbxChoix.PerformLayout();
            this.GbxFond.ResumeLayout(false);
            this.GbxFond.PerformLayout();
            this.GbxCara.ResumeLayout(false);
            this.GbxCara.PerformLayout();
            this.GbxCasse.ResumeLayout(false);
            this.GbxCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblInviteTexte;
        private System.Windows.Forms.GroupBox GbxChoix;
        private System.Windows.Forms.CheckBox ChkbxCasse;
        private System.Windows.Forms.CheckBox ChkbxCouleurCara;
        private System.Windows.Forms.CheckBox ChkbxCouleurFond;
        private System.Windows.Forms.Label LblResultat;
        private System.Windows.Forms.GroupBox GbxFond;
        private System.Windows.Forms.RadioButton RbtnFondBleu;
        private System.Windows.Forms.RadioButton RbtnFondVert;
        private System.Windows.Forms.RadioButton RbtnFondRouge;
        private System.Windows.Forms.GroupBox GbxCara;
        private System.Windows.Forms.RadioButton RbtnCaraBleu;
        private System.Windows.Forms.RadioButton RbtnCaraVert;
        private System.Windows.Forms.RadioButton RbtnCaraRouge;
        private System.Windows.Forms.GroupBox GbxCasse;
        private System.Windows.Forms.RadioButton RbtnMaj;
        private System.Windows.Forms.RadioButton RbtnMin;
    }
}

