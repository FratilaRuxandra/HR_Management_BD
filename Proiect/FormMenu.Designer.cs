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
            this.buttonModificariAngajati = new System.Windows.Forms.Button();
            this.buttonVeziInfo = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.buttonRezerva = new System.Windows.Forms.Button();
            this.buttonSalariu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAngajatNou
            // 
            this.buttonAngajatNou.Location = new System.Drawing.Point(38, 23);
            this.buttonAngajatNou.Name = "buttonAngajatNou";
            this.buttonAngajatNou.Size = new System.Drawing.Size(127, 36);
            this.buttonAngajatNou.TabIndex = 0;
            this.buttonAngajatNou.Text = "Angajat Nou";
            this.buttonAngajatNou.UseVisualStyleBackColor = true;
            this.buttonAngajatNou.Click += new System.EventHandler(this.buttonAngajatNou_Click);
            // 
            // buttonModificariAngajati
            // 
            this.buttonModificariAngajati.Location = new System.Drawing.Point(38, 83);
            this.buttonModificariAngajati.Name = "buttonModificariAngajati";
            this.buttonModificariAngajati.Size = new System.Drawing.Size(127, 38);
            this.buttonModificariAngajati.TabIndex = 1;
            this.buttonModificariAngajati.Text = "Modificari Angajati";
            this.buttonModificariAngajati.UseVisualStyleBackColor = true;
            this.buttonModificariAngajati.Click += new System.EventHandler(this.buttonModificariAngajati_Click);
            // 
            // buttonVeziInfo
            // 
            this.buttonVeziInfo.Location = new System.Drawing.Point(38, 149);
            this.buttonVeziInfo.Name = "buttonVeziInfo";
            this.buttonVeziInfo.Size = new System.Drawing.Size(127, 42);
            this.buttonVeziInfo.TabIndex = 2;
            this.buttonVeziInfo.Text = "Vezi Informatii Angajati";
            this.buttonVeziInfo.UseVisualStyleBackColor = true;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Location = new System.Drawing.Point(38, 218);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(127, 40);
            this.buttonTransfer.TabIndex = 3;
            this.buttonTransfer.Text = "Transfera Angajat";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // buttonRezerva
            // 
            this.buttonRezerva.Location = new System.Drawing.Point(38, 284);
            this.buttonRezerva.Name = "buttonRezerva";
            this.buttonRezerva.Size = new System.Drawing.Size(127, 40);
            this.buttonRezerva.TabIndex = 4;
            this.buttonRezerva.Text = "Trecere in Rezerva";
            this.buttonRezerva.UseVisualStyleBackColor = true;
            // 
            // buttonSalariu
            // 
            this.buttonSalariu.Location = new System.Drawing.Point(38, 356);
            this.buttonSalariu.Name = "buttonSalariu";
            this.buttonSalariu.Size = new System.Drawing.Size(127, 37);
            this.buttonSalariu.TabIndex = 5;
            this.buttonSalariu.Text = "Modificare Salarii";
            this.buttonSalariu.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 405);
            this.Controls.Add(this.buttonSalariu);
            this.Controls.Add(this.buttonRezerva);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.buttonVeziInfo);
            this.Controls.Add(this.buttonModificariAngajati);
            this.Controls.Add(this.buttonAngajatNou);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Angajati";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAngajatNou;
        private System.Windows.Forms.Button buttonModificariAngajati;
        private System.Windows.Forms.Button buttonVeziInfo;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Button buttonRezerva;
        private System.Windows.Forms.Button buttonSalariu;
    }
}