﻿namespace additionneur
{
    partial class FormAdditionneur
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
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.RtxtBAffichage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 114);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(34, 29);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(52, 114);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(34, 29);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(92, 114);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(34, 29);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(132, 114);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(34, 29);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(172, 114);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(34, 29);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(172, 149);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(34, 29);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(132, 149);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(34, 29);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(92, 149);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(34, 29);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(52, 149);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(34, 29);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(12, 149);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(34, 29);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(12, 203);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(75, 23);
            this.btnVider.TabIndex = 10;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(131, 203);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(75, 23);
            this.btnCalculer.TabIndex = 11;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // RtxtBAffichage
            // 
            this.RtxtBAffichage.Location = new System.Drawing.Point(12, 12);
            this.RtxtBAffichage.Name = "RtxtBAffichage";
            this.RtxtBAffichage.ReadOnly = true;
            this.RtxtBAffichage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RtxtBAffichage.Size = new System.Drawing.Size(194, 96);
            this.RtxtBAffichage.TabIndex = 12;
            this.RtxtBAffichage.Text = "";
            // 
            // FormAdditionneur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 237);
            this.Controls.Add(this.RtxtBAffichage);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Name = "FormAdditionneur";
            this.Text = "Additionneur";
            this.Load += new System.EventHandler(this.FormAdditionneur_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.RichTextBox RtxtBAffichage;
    }
}

