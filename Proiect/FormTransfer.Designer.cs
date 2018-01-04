namespace Proiect
{
    partial class FormTransfer
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
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.textNume = new System.Windows.Forms.TextBox();
            this.textPrenume = new System.Windows.Forms.TextBox();
            this.labelFunc = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            this.combofunc = new System.Windows.Forms.ComboBox();
            this.combodep = new System.Windows.Forms.ComboBox();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.radioFunctie = new System.Windows.Forms.RadioButton();
            this.radioDep = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(12, 22);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(38, 13);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume:";
            this.labelNume.Click += new System.EventHandler(this.labelNume_Click);
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(150, 22);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(52, 13);
            this.labelPrenume.TabIndex = 1;
            this.labelPrenume.Text = "Prenume:";
            this.labelPrenume.Click += new System.EventHandler(this.labelPrenume_Click);
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(15, 39);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(100, 20);
            this.textNume.TabIndex = 2;
            this.textNume.TextChanged += new System.EventHandler(this.textNume_TextChanged);
            // 
            // textPrenume
            // 
            this.textPrenume.Location = new System.Drawing.Point(153, 38);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(119, 20);
            this.textPrenume.TabIndex = 3;
            this.textPrenume.TextChanged += new System.EventHandler(this.textPrenume_TextChanged);
            // 
            // labelFunc
            // 
            this.labelFunc.AutoSize = true;
            this.labelFunc.Location = new System.Drawing.Point(44, 87);
            this.labelFunc.Name = "labelFunc";
            this.labelFunc.Size = new System.Drawing.Size(71, 13);
            this.labelFunc.TabIndex = 4;
            this.labelFunc.Text = "FunctieNoua:";
            this.labelFunc.Click += new System.EventHandler(this.labelFunc_Click);
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(181, 87);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(91, 13);
            this.labelDep.TabIndex = 5;
            this.labelDep.Text = "DepartamentNou:";
            this.labelDep.Click += new System.EventHandler(this.labelDep_Click);
            // 
            // combofunc
            // 
            this.combofunc.FormattingEnabled = true;
            this.combofunc.Location = new System.Drawing.Point(12, 118);
            this.combofunc.Name = "combofunc";
            this.combofunc.Size = new System.Drawing.Size(121, 21);
            this.combofunc.TabIndex = 6;
            this.combofunc.SelectedIndexChanged += new System.EventHandler(this.combofunc_SelectedIndexChanged);
            // 
            // combodep
            // 
            this.combodep.FormattingEnabled = true;
            this.combodep.Location = new System.Drawing.Point(153, 118);
            this.combodep.Name = "combodep";
            this.combodep.Size = new System.Drawing.Size(121, 21);
            this.combodep.TabIndex = 7;
            this.combodep.SelectedIndexChanged += new System.EventHandler(this.combodep_SelectedIndexChanged);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(166, 271);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(119, 23);
            this.buttonFinish.TabIndex = 8;
            this.buttonFinish.Text = "Finalizeaza Transfer";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // radioFunctie
            // 
            this.radioFunctie.AutoSize = true;
            this.radioFunctie.Location = new System.Drawing.Point(15, 87);
            this.radioFunctie.Name = "radioFunctie";
            this.radioFunctie.Size = new System.Drawing.Size(14, 13);
            this.radioFunctie.TabIndex = 9;
            this.radioFunctie.TabStop = true;
            this.radioFunctie.UseVisualStyleBackColor = true;
            this.radioFunctie.CheckedChanged += new System.EventHandler(this.radioFunctie_CheckedChanged);
            // 
            // radioDep
            // 
            this.radioDep.AutoSize = true;
            this.radioDep.Location = new System.Drawing.Point(153, 87);
            this.radioDep.Name = "radioDep";
            this.radioDep.Size = new System.Drawing.Size(14, 13);
            this.radioDep.TabIndex = 10;
            this.radioDep.TabStop = true;
            this.radioDep.UseVisualStyleBackColor = true;
            this.radioDep.CheckedChanged += new System.EventHandler(this.radioDep_CheckedChanged);
            // 
            // FormTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 306);
            this.Controls.Add(this.radioDep);
            this.Controls.Add(this.radioFunctie);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.combodep);
            this.Controls.Add(this.combofunc);
            this.Controls.Add(this.labelDep);
            this.Controls.Add(this.labelFunc);
            this.Controls.Add(this.textPrenume);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Name = "FormTransfer";
            this.Text = "FormTransfer";
            this.Load += new System.EventHandler(this.FormTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.TextBox textPrenume;
        private System.Windows.Forms.Label labelFunc;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.ComboBox combofunc;
        private System.Windows.Forms.ComboBox combodep;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.RadioButton radioFunctie;
        private System.Windows.Forms.RadioButton radioDep;
    }
}