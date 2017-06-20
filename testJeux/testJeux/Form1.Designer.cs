namespace testJeux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PbxRaquette = new System.Windows.Forms.PictureBox();
            this.PbxBalle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRaquette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBalle)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxRaquette
            // 
            this.PbxRaquette.Image = ((System.Drawing.Image)(resources.GetObject("PbxRaquette.Image")));
            this.PbxRaquette.Location = new System.Drawing.Point(263, 464);
            this.PbxRaquette.Name = "PbxRaquette";
            this.PbxRaquette.Size = new System.Drawing.Size(125, 31);
            this.PbxRaquette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxRaquette.TabIndex = 0;
            this.PbxRaquette.TabStop = false;
            // 
            // PbxBalle
            // 
            this.PbxBalle.Image = global::testJeux.Properties.Resources.Balle;
            this.PbxBalle.Location = new System.Drawing.Point(312, 428);
            this.PbxBalle.Name = "PbxBalle";
            this.PbxBalle.Size = new System.Drawing.Size(30, 30);
            this.PbxBalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxBalle.TabIndex = 1;
            this.PbxBalle.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 507);
            this.Controls.Add(this.PbxBalle);
            this.Controls.Add(this.PbxRaquette);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbxRaquette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxRaquette;
        private System.Windows.Forms.PictureBox PbxBalle;
    }
}

