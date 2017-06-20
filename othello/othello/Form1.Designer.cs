namespace othello
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
            this.flowLayoutPanelOption = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumUD = new System.Windows.Forms.NumericUpDown();
            this.LblNbCase = new System.Windows.Forms.Label();
            this.flowLayoutPanelDamier = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelOption.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelOption
            // 
            this.flowLayoutPanelOption.Controls.Add(this.panel1);
            this.flowLayoutPanelOption.Location = new System.Drawing.Point(706, 0);
            this.flowLayoutPanelOption.Name = "flowLayoutPanelOption";
            this.flowLayoutPanelOption.Size = new System.Drawing.Size(225, 283);
            this.flowLayoutPanelOption.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NumUD);
            this.panel1.Controls.Add(this.LblNbCase);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 278);
            this.panel1.TabIndex = 1;
            // 
            // NumUD
            // 
            this.NumUD.Location = new System.Drawing.Point(137, 0);
            this.NumUD.Name = "NumUD";
            this.NumUD.Size = new System.Drawing.Size(44, 20);
            this.NumUD.TabIndex = 1;
            this.NumUD.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumUD.ValueChanged += new System.EventHandler(this.NumUD_ValueChanged);
            // 
            // LblNbCase
            // 
            this.LblNbCase.Location = new System.Drawing.Point(3, 2);
            this.LblNbCase.Name = "LblNbCase";
            this.LblNbCase.Size = new System.Drawing.Size(115, 19);
            this.LblNbCase.TabIndex = 0;
            this.LblNbCase.Text = "Nombre de case(s) ?";
            // 
            // flowLayoutPanelDamier
            // 
            this.flowLayoutPanelDamier.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelDamier.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelDamier.Name = "flowLayoutPanelDamier";
            this.flowLayoutPanelDamier.Size = new System.Drawing.Size(700, 700);
            this.flowLayoutPanelDamier.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 656);
            this.Controls.Add(this.flowLayoutPanelDamier);
            this.Controls.Add(this.flowLayoutPanelOption);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanelOption.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown NumUD;
        private System.Windows.Forms.Label LblNbCase;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDamier;
    }
}

