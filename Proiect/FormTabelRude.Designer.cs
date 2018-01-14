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
            this.labelGradRudenie.BackColor = System.Drawing.Color.Transparent;
            this.labelGradRudenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradRudenie.ForeColor = System.Drawing.Color.White;
            this.labelGradRudenie.Location = new System.Drawing.Point(104, 91);
            this.labelGradRudenie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGradRudenie.Name = "labelGradRudenie";
            this.labelGradRudenie.Size = new System.Drawing.Size(99, 18);
            this.labelGradRudenie.TabIndex = 0;
            this.labelGradRudenie.Text = "Grad Rudenie";
            this.labelGradRudenie.Click += new System.EventHandler(this.labelGradRudenie_Click);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.BackColor = System.Drawing.Color.Transparent;
            this.labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.ForeColor = System.Drawing.Color.White;
            this.labelNume.Location = new System.Drawing.Point(158, 153);
            this.labelNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(48, 18);
            this.labelNume.TabIndex = 1;
            this.labelNume.Text = "Nume";
            this.labelNume.Click += new System.EventHandler(this.labelNume_Click);
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.BackColor = System.Drawing.Color.Transparent;
            this.labelPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenume.ForeColor = System.Drawing.Color.White;
            this.labelPrenume.Location = new System.Drawing.Point(138, 216);
            this.labelPrenume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(68, 18);
            this.labelPrenume.TabIndex = 2;
            this.labelPrenume.Text = "Prenume";
            this.labelPrenume.Click += new System.EventHandler(this.labelPrenume_Click);
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.BackColor = System.Drawing.Color.Transparent;
            this.labelCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNP.ForeColor = System.Drawing.Color.White;
            this.labelCNP.Location = new System.Drawing.Point(166, 280);
            this.labelCNP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(40, 18);
            this.labelCNP.TabIndex = 3;
            this.labelCNP.Text = "CNP";
            this.labelCNP.Click += new System.EventHandler(this.labelCNP_Click);
            // 
            // textGrad
            // 
            this.textGrad.Location = new System.Drawing.Point(229, 90);
            this.textGrad.Margin = new System.Windows.Forms.Padding(4);
            this.textGrad.Name = "textGrad";
            this.textGrad.Size = new System.Drawing.Size(132, 22);
            this.textGrad.TabIndex = 4;
            this.textGrad.TextChanged += new System.EventHandler(this.textGrad_TextChanged);
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(229, 153);
            this.textNume.Margin = new System.Windows.Forms.Padding(4);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(132, 22);
            this.textNume.TabIndex = 5;
            this.textNume.TextChanged += new System.EventHandler(this.textNume_TextChanged);
            // 
            // textPrenume
            // 
            this.textPrenume.Location = new System.Drawing.Point(229, 216);
            this.textPrenume.Margin = new System.Windows.Forms.Padding(4);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(132, 22);
            this.textPrenume.TabIndex = 6;
            this.textPrenume.TextChanged += new System.EventHandler(this.textPrenume_TextChanged);
            // 
            // textCNP
            // 
            this.textCNP.Location = new System.Drawing.Point(229, 279);
            this.textCNP.Margin = new System.Windows.Forms.Padding(4);
            this.textCNP.Name = "textCNP";
            this.textCNP.Size = new System.Drawing.Size(132, 22);
            this.textCNP.TabIndex = 7;
            this.textCNP.TextChanged += new System.EventHandler(this.textCNP_TextChanged);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(343, 402);
            this.buttonAdauga.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(113, 39);
            this.buttonAdauga.TabIndex = 8;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // FormTabelRude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect.Properties.Resources._316016;
            this.ClientSize = new System.Drawing.Size(494, 486);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.textCNP);
            this.Controls.Add(this.textPrenume);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.textGrad);
            this.Controls.Add(this.labelCNP);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelGradRudenie);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTabelRude";
            this.Text = "Tabel Rude";
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