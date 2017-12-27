namespace Proiect
{
    partial class FormFisaMed
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
            this.labelGrupa = new System.Windows.Forms.Label();
            this.labelInaltime = new System.Windows.Forms.Label();
            this.labelGreutate = new System.Windows.Forms.Label();
            this.labelStareSanatate = new System.Windows.Forms.Label();
            this.labelObservatii = new System.Windows.Forms.Label();
            this.comboGrupa = new System.Windows.Forms.ComboBox();
            this.textInaltime = new System.Windows.Forms.TextBox();
            this.textGreutate = new System.Windows.Forms.TextBox();
            this.comboStare = new System.Windows.Forms.ComboBox();
            this.textObservatii = new System.Windows.Forms.TextBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGrupa
            // 
            this.labelGrupa.AutoSize = true;
            this.labelGrupa.Location = new System.Drawing.Point(2, 30);
            this.labelGrupa.Name = "labelGrupa";
            this.labelGrupa.Size = new System.Drawing.Size(70, 13);
            this.labelGrupa.TabIndex = 5;
            this.labelGrupa.Text = "Grupa Sange";
            this.labelGrupa.Click += new System.EventHandler(this.labelGrupa_Click);
            // 
            // labelInaltime
            // 
            this.labelInaltime.AutoSize = true;
            this.labelInaltime.Location = new System.Drawing.Point(2, 57);
            this.labelInaltime.Name = "labelInaltime";
            this.labelInaltime.Size = new System.Drawing.Size(43, 13);
            this.labelInaltime.TabIndex = 6;
            this.labelInaltime.Text = "Inaltime";
            this.labelInaltime.Click += new System.EventHandler(this.labelInaltime_Click);
            // 
            // labelGreutate
            // 
            this.labelGreutate.AutoSize = true;
            this.labelGreutate.Location = new System.Drawing.Point(2, 90);
            this.labelGreutate.Name = "labelGreutate";
            this.labelGreutate.Size = new System.Drawing.Size(48, 13);
            this.labelGreutate.TabIndex = 7;
            this.labelGreutate.Text = "Greutate";
            this.labelGreutate.Click += new System.EventHandler(this.labelGreutate_Click);
            // 
            // labelStareSanatate
            // 
            this.labelStareSanatate.AutoSize = true;
            this.labelStareSanatate.Location = new System.Drawing.Point(2, 120);
            this.labelStareSanatate.Name = "labelStareSanatate";
            this.labelStareSanatate.Size = new System.Drawing.Size(78, 13);
            this.labelStareSanatate.TabIndex = 8;
            this.labelStareSanatate.Text = "Stare Sanatate";
            this.labelStareSanatate.Click += new System.EventHandler(this.labelStareSanatate_Click);
            // 
            // labelObservatii
            // 
            this.labelObservatii.AutoSize = true;
            this.labelObservatii.Location = new System.Drawing.Point(2, 163);
            this.labelObservatii.Name = "labelObservatii";
            this.labelObservatii.Size = new System.Drawing.Size(54, 13);
            this.labelObservatii.TabIndex = 9;
            this.labelObservatii.Text = "Observatii";
            this.labelObservatii.Click += new System.EventHandler(this.labelObservatii_Click);
            // 
            // comboGrupa
            // 
            this.comboGrupa.AllowDrop = true;
            this.comboGrupa.FormattingEnabled = true;
            this.comboGrupa.Location = new System.Drawing.Point(118, 27);
            this.comboGrupa.Name = "comboGrupa";
            this.comboGrupa.Size = new System.Drawing.Size(121, 21);
            this.comboGrupa.TabIndex = 10;
            this.comboGrupa.SelectedIndexChanged += new System.EventHandler(this.comboGrupa_SelectedIndexChanged);
            // 
            // textInaltime
            // 
            this.textInaltime.Location = new System.Drawing.Point(118, 57);
            this.textInaltime.Name = "textInaltime";
            this.textInaltime.Size = new System.Drawing.Size(121, 20);
            this.textInaltime.TabIndex = 11;
            this.textInaltime.TextChanged += new System.EventHandler(this.textInaltime_TextChanged);
            // 
            // textGreutate
            // 
            this.textGreutate.Location = new System.Drawing.Point(118, 90);
            this.textGreutate.Name = "textGreutate";
            this.textGreutate.Size = new System.Drawing.Size(121, 20);
            this.textGreutate.TabIndex = 12;
            this.textGreutate.TextChanged += new System.EventHandler(this.textGreutate_TextChanged);
            // 
            // comboStare
            // 
            this.comboStare.AllowDrop = true;
            this.comboStare.FormattingEnabled = true;
            this.comboStare.Location = new System.Drawing.Point(118, 120);
            this.comboStare.Name = "comboStare";
            this.comboStare.Size = new System.Drawing.Size(121, 21);
            this.comboStare.TabIndex = 13;
            this.comboStare.SelectedIndexChanged += new System.EventHandler(this.comboStare_SelectedIndexChanged);
            // 
            // textObservatii
            // 
            this.textObservatii.Location = new System.Drawing.Point(118, 156);
            this.textObservatii.Name = "textObservatii";
            this.textObservatii.Size = new System.Drawing.Size(121, 20);
            this.textObservatii.TabIndex = 14;
            this.textObservatii.TextChanged += new System.EventHandler(this.textObservatii_TextChanged);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(88, 216);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(75, 23);
            this.buttonAdauga.TabIndex = 15;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // FormFisaMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.textObservatii);
            this.Controls.Add(this.comboStare);
            this.Controls.Add(this.textGreutate);
            this.Controls.Add(this.textInaltime);
            this.Controls.Add(this.comboGrupa);
            this.Controls.Add(this.labelObservatii);
            this.Controls.Add(this.labelStareSanatate);
            this.Controls.Add(this.labelGreutate);
            this.Controls.Add(this.labelInaltime);
            this.Controls.Add(this.labelGrupa);
            this.Name = "FormFisaMed";
            this.Text = "FormFisaMed";
            this.Load += new System.EventHandler(this.FormFisaMed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGrupa;
        private System.Windows.Forms.Label labelInaltime;
        private System.Windows.Forms.Label labelGreutate;
        private System.Windows.Forms.Label labelStareSanatate;
        private System.Windows.Forms.Label labelObservatii;
        private System.Windows.Forms.ComboBox comboGrupa;
        private System.Windows.Forms.TextBox textInaltime;
        private System.Windows.Forms.TextBox textGreutate;
        private System.Windows.Forms.ComboBox comboStare;
        private System.Windows.Forms.TextBox textObservatii;
        private System.Windows.Forms.Button buttonAdauga;
    }
}