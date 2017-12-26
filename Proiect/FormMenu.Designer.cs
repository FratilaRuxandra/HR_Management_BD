namespace Proiect
{
    partial class FormMenu
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
            this.buttonAngajatNou = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAngajatNou
            // 
            this.buttonAngajatNou.Location = new System.Drawing.Point(51, 28);
            this.buttonAngajatNou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAngajatNou.Name = "buttonAngajatNou";
            this.buttonAngajatNou.Size = new System.Drawing.Size(169, 44);
            this.buttonAngajatNou.TabIndex = 0;
            this.buttonAngajatNou.Text = "Angajat Nou";
            this.buttonAngajatNou.UseVisualStyleBackColor = true;
            this.buttonAngajatNou.Click += new System.EventHandler(this.buttonAngajatNou_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAngajatNou);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMenu";
            this.Text = "Management Angajati";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAngajatNou;
        private System.Windows.Forms.Button button1;
    }
}