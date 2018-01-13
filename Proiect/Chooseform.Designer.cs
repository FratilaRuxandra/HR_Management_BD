namespace Proiect
{
    partial class Chooseform
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
            this.btnCreste = new System.Windows.Forms.Button();
            this.btnScade = new System.Windows.Forms.Button();
            this.comboGrad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFunctie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCreste
            // 
            this.btnCreste.Location = new System.Drawing.Point(58, 180);
            this.btnCreste.Name = "btnCreste";
            this.btnCreste.Size = new System.Drawing.Size(174, 42);
            this.btnCreste.TabIndex = 0;
            this.btnCreste.Text = "Creste";
            this.btnCreste.UseVisualStyleBackColor = true;
            this.btnCreste.Click += new System.EventHandler(this.btnCreste_Click);
            // 
            // btnScade
            // 
            this.btnScade.Location = new System.Drawing.Point(427, 184);
            this.btnScade.Name = "btnScade";
            this.btnScade.Size = new System.Drawing.Size(174, 38);
            this.btnScade.TabIndex = 1;
            this.btnScade.Text = "Scade";
            this.btnScade.UseVisualStyleBackColor = true;
            this.btnScade.Click += new System.EventHandler(this.btnScade_Click);
            // 
            // comboGrad
            // 
            this.comboGrad.FormattingEnabled = true;
            this.comboGrad.Items.AddRange(new object[] {
            "Caporal",
            "Sergent",
            "Sg.Major",
            "Plutonier",
            "Sublocotenent",
            "Locotenent",
            "Capitan",
            "Maior",
            "Lt.Colonel",
            "Colonel",
            "General"});
            this.comboGrad.Location = new System.Drawing.Point(58, 64);
            this.comboGrad.Name = "comboGrad";
            this.comboGrad.Size = new System.Drawing.Size(174, 24);
            this.comboGrad.TabIndex = 2;
            this.comboGrad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selectati Grad";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(766, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selectati Functie";
            // 
            // comboFunctie
            // 
            this.comboFunctie.FormattingEnabled = true;
            this.comboFunctie.Items.AddRange(new object[] {
            "Administrator Retea",
            "Tehnician",
            "Sef Departament",
            "Programator",
            "Secretar",
            "Admin Baze Data",
            "Admin Server",
            "Director",
            "Director Adj",
            "Manager Proiect"});
            this.comboFunctie.Location = new System.Drawing.Point(427, 64);
            this.comboFunctie.Name = "comboFunctie";
            this.comboFunctie.Size = new System.Drawing.Size(174, 24);
            this.comboFunctie.TabIndex = 6;
            // 
            // Chooseform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 253);
            this.Controls.Add(this.comboFunctie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboGrad);
            this.Controls.Add(this.btnScade);
            this.Controls.Add(this.btnCreste);
            this.Name = "Chooseform";
            this.Text = "Creste/Scade?";
            this.Load += new System.EventHandler(this.Chooseform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreste;
        private System.Windows.Forms.Button btnScade;
        private System.Windows.Forms.ComboBox comboGrad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFunctie;
    }
}