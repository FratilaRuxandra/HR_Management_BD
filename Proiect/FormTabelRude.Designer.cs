namespace Proiect
{
    partial class FormTabelRude
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelGradRudenie = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelCNP = new System.Windows.Forms.Label();
            this.textGrad = new System.Windows.Forms.TextBox();
            this.textNume = new System.Windows.Forms.TextBox();
            this.textPrenume = new System.Windows.Forms.TextBox();
            this.textCNP = new System.Windows.Forms.TextBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGradRudenie
            // 
            this.labelGradRudenie.AutoSize = true;
            this.labelGradRudenie.Location = new System.Drawing.Point(12, 34);
            this.labelGradRudenie.Name = "labelGradRudenie";
            this.labelGradRudenie.Size = new System.Drawing.Size(76, 13);
            this.labelGradRudenie.TabIndex = 0;
            this.labelGradRudenie.Text = "Grad Rudenie:";
            this.labelGradRudenie.Click += new System.EventHandler(this.labelGradRudenie_Click);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(12, 59);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(38, 13);
            this.labelNume.TabIndex = 1;
            this.labelNume.Text = "Nume:";
            this.labelNume.Click += new System.EventHandler(this.labelNume_Click);
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(12, 85);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(52, 13);
            this.labelPrenume.TabIndex = 2;
            this.labelPrenume.Text = "Prenume:";
            this.labelPrenume.Click += new System.EventHandler(this.labelPrenume_Click);
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Location = new System.Drawing.Point(12, 113);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(32, 13);
            this.labelCNP.TabIndex = 3;
            this.labelCNP.Text = "CNP:";
            this.labelCNP.Click += new System.EventHandler(this.labelCNP_Click);
            // 
            // textGrad
            // 
            this.textGrad.Location = new System.Drawing.Point(113, 31);
            this.textGrad.Name = "textGrad";
            this.textGrad.Size = new System.Drawing.Size(100, 20);
            this.textGrad.TabIndex = 4;
            this.textGrad.TextChanged += new System.EventHandler(this.textGrad_TextChanged);
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(113, 61);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(100, 20);
            this.textNume.TabIndex = 5;
            this.textNume.TextChanged += new System.EventHandler(this.textNume_TextChanged);
            // 
            // textPrenume
            // 
            this.textPrenume.Location = new System.Drawing.Point(113, 87);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(100, 20);
            this.textPrenume.TabIndex = 6;
            this.textPrenume.TextChanged += new System.EventHandler(this.textPrenume_TextChanged);
            // 
            // textCNP
            // 
            this.textCNP.Location = new System.Drawing.Point(113, 113);
            this.textCNP.Name = "textCNP";
            this.textCNP.Size = new System.Drawing.Size(100, 20);
            this.textCNP.TabIndex = 7;
            this.textCNP.TextChanged += new System.EventHandler(this.textCNP_TextChanged);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(208, 152);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(85, 32);
            this.buttonAdauga.TabIndex = 8;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // FormTabelRude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 198);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.textCNP);
            this.Controls.Add(this.textPrenume);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.textGrad);
            this.Controls.Add(this.labelCNP);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelGradRudenie);
            this.Name = "FormTabelRude";
            this.Text = "FormTabelRude";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGradRudenie;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.TextBox textGrad;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.TextBox textPrenume;
        private System.Windows.Forms.TextBox textCNP;
        private System.Windows.Forms.Button buttonAdauga;
    }
}