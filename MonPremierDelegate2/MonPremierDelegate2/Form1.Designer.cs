namespace MonPremierDelegate2
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCalculeNvSalaire = new System.Windows.Forms.Button();
            this.TbxSalaire = new System.Windows.Forms.TextBox();
            this.TbxAugmentation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxNvSalaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salaire";
            // 
            // BtnCalculeNvSalaire
            // 
            this.BtnCalculeNvSalaire.Location = new System.Drawing.Point(14, 106);
            this.BtnCalculeNvSalaire.Name = "BtnCalculeNvSalaire";
            this.BtnCalculeNvSalaire.Size = new System.Drawing.Size(244, 27);
            this.BtnCalculeNvSalaire.TabIndex = 1;
            this.BtnCalculeNvSalaire.Text = "Calcule du nouveau Salaire";
            this.BtnCalculeNvSalaire.UseVisualStyleBackColor = true;
            this.BtnCalculeNvSalaire.Click += new System.EventHandler(this.BtnCalculeNvSalaire_Click);
            // 
            // TbxSalaire
            // 
            this.TbxSalaire.Location = new System.Drawing.Point(108, 15);
            this.TbxSalaire.Name = "TbxSalaire";
            this.TbxSalaire.Size = new System.Drawing.Size(150, 20);
            this.TbxSalaire.TabIndex = 2;
            this.TbxSalaire.Text = "1500";
            // 
            // TbxAugmentation
            // 
            this.TbxAugmentation.Location = new System.Drawing.Point(108, 41);
            this.TbxAugmentation.Name = "TbxAugmentation";
            this.TbxAugmentation.Size = new System.Drawing.Size(150, 20);
            this.TbxAugmentation.TabIndex = 4;
            this.TbxAugmentation.Text = "15";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Augmentation";
            // 
            // TbxNvSalaire
            // 
            this.TbxNvSalaire.Location = new System.Drawing.Point(108, 67);
            this.TbxNvSalaire.Name = "TbxNvSalaire";
            this.TbxNvSalaire.Size = new System.Drawing.Size(150, 20);
            this.TbxNvSalaire.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nouveau Salaire";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.TbxNvSalaire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxAugmentation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxSalaire);
            this.Controls.Add(this.BtnCalculeNvSalaire);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCalculeNvSalaire;
        private System.Windows.Forms.TextBox TbxSalaire;
        private System.Windows.Forms.TextBox TbxAugmentation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxNvSalaire;
        private System.Windows.Forms.Label label3;
    }
}

