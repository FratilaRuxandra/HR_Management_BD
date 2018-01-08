namespace Proiect
{
    partial class FormAngajatNou
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
            this.labelGrad = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.labelCNP = new System.Windows.Forms.Label();
            this.textCNP = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelFunctie = new System.Windows.Forms.Label();
            this.comboBoxFunctii = new System.Windows.Forms.ComboBox();
            this.labelDepartament = new System.Windows.Forms.Label();
            this.comboBoxDepartamente = new System.Windows.Forms.ComboBox();
            this.labelDataNastere = new System.Windows.Forms.Label();
            this.labelStrada = new System.Windows.Forms.Label();
            this.textStrada = new System.Windows.Forms.TextBox();
            this.labelNrStrada = new System.Windows.Forms.Label();
            this.textNrStrada = new System.Windows.Forms.TextBox();
            this.labelBloc = new System.Windows.Forms.Label();
            this.textBloc = new System.Windows.Forms.TextBox();
            this.labelApartament = new System.Windows.Forms.Label();
            this.textApartament = new System.Windows.Forms.TextBox();
            this.labelOras = new System.Windows.Forms.Label();
            this.textOras = new System.Windows.Forms.TextBox();
            this.labelJudSect = new System.Windows.Forms.Label();
            this.textJudet = new System.Windows.Forms.TextBox();
            this.labelProiect = new System.Windows.Forms.Label();
            this.comboBoxProiect = new System.Windows.Forms.ComboBox();
            this.buttonAddAngajat = new System.Windows.Forms.Button();
            this.textDataNastere = new System.Windows.Forms.TextBox();
            this.buttonTabelRude = new System.Windows.Forms.Button();
            this.buttonFisaMedicala = new System.Windows.Forms.Button();
            this.buttonCV = new System.Windows.Forms.Button();
            this.labelOptional = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(19, 39);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(35, 13);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            this.labelNume.Click += new System.EventHandler(this.labelNume_Click);
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(186, 38);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(49, 13);
            this.labelPrenume.TabIndex = 1;
            this.labelPrenume.Text = "Prenume";
            this.labelPrenume.Click += new System.EventHandler(this.labelPrenume_Click);
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(60, 35);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(120, 20);
            this.textNume.TabIndex = 2;
            this.textNume.TextChanged += new System.EventHandler(this.textNume_TextChanged);
            // 
            // textPrenume
            // 
            this.textPrenume.Location = new System.Drawing.Point(241, 36);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(119, 20);
            this.textPrenume.TabIndex = 3;
            this.textPrenume.TextChanged += new System.EventHandler(this.textPrenume_TextChanged);
            // 
            // labelGrad
            // 
            this.labelGrad.AutoSize = true;
            this.labelGrad.Location = new System.Drawing.Point(366, 39);
            this.labelGrad.Name = "labelGrad";
            this.labelGrad.Size = new System.Drawing.Size(30, 13);
            this.labelGrad.TabIndex = 4;
            this.labelGrad.Text = "Grad";
            this.labelGrad.Click += new System.EventHandler(this.labelGrad_Click);
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Location = new System.Drawing.Point(402, 36);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(120, 21);
            this.comboBoxGrade.TabIndex = 6;
            this.comboBoxGrade.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrade_SelectedIndexChanged);
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Location = new System.Drawing.Point(528, 39);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(29, 13);
            this.labelCNP.TabIndex = 7;
            this.labelCNP.Text = "CNP";
            this.labelCNP.Click += new System.EventHandler(this.labelCNP_Click);
            // 
            // textCNP
            // 
            this.textCNP.Location = new System.Drawing.Point(563, 36);
            this.textCNP.Name = "textCNP";
            this.textCNP.Size = new System.Drawing.Size(119, 20);
            this.textCNP.TabIndex = 8;
            this.textCNP.TextChanged += new System.EventHandler(this.textCNP_TextChanged);
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(19, 65);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(43, 13);
            this.labelTelefon.TabIndex = 9;
            this.labelTelefon.Text = "Telefon";
            this.labelTelefon.Click += new System.EventHandler(this.labelTelefon_Click);
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(69, 65);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(111, 20);
            this.textTelefon.TabIndex = 10;
            this.textTelefon.TextChanged += new System.EventHandler(this.textTelefon_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(186, 68);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Email";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(241, 65);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(119, 20);
            this.textEmail.TabIndex = 12;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // labelFunctie
            // 
            this.labelFunctie.AutoSize = true;
            this.labelFunctie.Location = new System.Drawing.Point(19, 181);
            this.labelFunctie.Name = "labelFunctie";
            this.labelFunctie.Size = new System.Drawing.Size(42, 13);
            this.labelFunctie.TabIndex = 27;
            this.labelFunctie.Text = "Functie";
            this.labelFunctie.Click += new System.EventHandler(this.labelFunctie_Click);
            // 
            // comboBoxFunctii
            // 
            this.comboBoxFunctii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunctii.FormattingEnabled = true;
            this.comboBoxFunctii.Location = new System.Drawing.Point(69, 176);
            this.comboBoxFunctii.Name = "comboBoxFunctii";
            this.comboBoxFunctii.Size = new System.Drawing.Size(153, 21);
            this.comboBoxFunctii.TabIndex = 28;
            this.comboBoxFunctii.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunctii_SelectedIndexChanged);
            // 
            // labelDepartament
            // 
            this.labelDepartament.AutoSize = true;
            this.labelDepartament.Location = new System.Drawing.Point(238, 179);
            this.labelDepartament.Name = "labelDepartament";
            this.labelDepartament.Size = new System.Drawing.Size(68, 13);
            this.labelDepartament.TabIndex = 29;
            this.labelDepartament.Text = "Departament";
            this.labelDepartament.Click += new System.EventHandler(this.labelDepartament_Click);
            // 
            // comboBoxDepartamente
            // 
            this.comboBoxDepartamente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartamente.FormattingEnabled = true;
            this.comboBoxDepartamente.Location = new System.Drawing.Point(312, 178);
            this.comboBoxDepartamente.Name = "comboBoxDepartamente";
            this.comboBoxDepartamente.Size = new System.Drawing.Size(155, 21);
            this.comboBoxDepartamente.TabIndex = 30;
            this.comboBoxDepartamente.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartamente_SelectedIndexChanged);
            // 
            // labelDataNastere
            // 
            this.labelDataNastere.AutoSize = true;
            this.labelDataNastere.Location = new System.Drawing.Point(366, 68);
            this.labelDataNastere.Name = "labelDataNastere";
            this.labelDataNastere.Size = new System.Drawing.Size(70, 13);
            this.labelDataNastere.TabIndex = 13;
            this.labelDataNastere.Text = "Data Nastere";
            this.labelDataNastere.Click += new System.EventHandler(this.labelDataNastere_Click);
            // 
            // labelStrada
            // 
            this.labelStrada.AutoSize = true;
            this.labelStrada.Location = new System.Drawing.Point(19, 92);
            this.labelStrada.Name = "labelStrada";
            this.labelStrada.Size = new System.Drawing.Size(38, 13);
            this.labelStrada.TabIndex = 15;
            this.labelStrada.Text = "Strada";
            this.labelStrada.Click += new System.EventHandler(this.labelStrada_Click);
            // 
            // textStrada
            // 
            this.textStrada.Location = new System.Drawing.Point(69, 91);
            this.textStrada.Name = "textStrada";
            this.textStrada.Size = new System.Drawing.Size(111, 20);
            this.textStrada.TabIndex = 16;
            this.textStrada.TextChanged += new System.EventHandler(this.textStrada_TextChanged);
            // 
            // labelNrStrada
            // 
            this.labelNrStrada.AutoSize = true;
            this.labelNrStrada.Location = new System.Drawing.Point(186, 94);
            this.labelNrStrada.Name = "labelNrStrada";
            this.labelNrStrada.Size = new System.Drawing.Size(21, 13);
            this.labelNrStrada.TabIndex = 17;
            this.labelNrStrada.Text = "Nr.";
            this.labelNrStrada.Click += new System.EventHandler(this.labelNrStrada_Click);
            // 
            // textNrStrada
            // 
            this.textNrStrada.Location = new System.Drawing.Point(241, 91);
            this.textNrStrada.Name = "textNrStrada";
            this.textNrStrada.Size = new System.Drawing.Size(43, 20);
            this.textNrStrada.TabIndex = 18;
            this.textNrStrada.TextChanged += new System.EventHandler(this.textNrStrada_TextChanged);
            // 
            // labelBloc
            // 
            this.labelBloc.AutoSize = true;
            this.labelBloc.Location = new System.Drawing.Point(304, 94);
            this.labelBloc.Name = "labelBloc";
            this.labelBloc.Size = new System.Drawing.Size(28, 13);
            this.labelBloc.TabIndex = 19;
            this.labelBloc.Text = "Bloc";
            this.labelBloc.Click += new System.EventHandler(this.labelBloc_Click);
            // 
            // textBloc
            // 
            this.textBloc.Location = new System.Drawing.Point(338, 91);
            this.textBloc.Name = "textBloc";
            this.textBloc.Size = new System.Drawing.Size(79, 20);
            this.textBloc.TabIndex = 20;
            this.textBloc.TextChanged += new System.EventHandler(this.textBloc_TextChanged);
            // 
            // labelApartament
            // 
            this.labelApartament.AutoSize = true;
            this.labelApartament.Location = new System.Drawing.Point(423, 94);
            this.labelApartament.Name = "labelApartament";
            this.labelApartament.Size = new System.Drawing.Size(20, 13);
            this.labelApartament.TabIndex = 21;
            this.labelApartament.Text = "Ap";
            this.labelApartament.Click += new System.EventHandler(this.labelApartament_Click);
            // 
            // textApartament
            // 
            this.textApartament.Location = new System.Drawing.Point(449, 89);
            this.textApartament.Name = "textApartament";
            this.textApartament.Size = new System.Drawing.Size(39, 20);
            this.textApartament.TabIndex = 22;
            this.textApartament.TextChanged += new System.EventHandler(this.textApartament_TextChanged);
            // 
            // labelOras
            // 
            this.labelOras.AutoSize = true;
            this.labelOras.Location = new System.Drawing.Point(494, 94);
            this.labelOras.Name = "labelOras";
            this.labelOras.Size = new System.Drawing.Size(53, 13);
            this.labelOras.TabIndex = 23;
            this.labelOras.Text = "Localitate";
            this.labelOras.Click += new System.EventHandler(this.labelOras_Click);
            // 
            // textOras
            // 
            this.textOras.Location = new System.Drawing.Point(553, 92);
            this.textOras.Name = "textOras";
            this.textOras.Size = new System.Drawing.Size(129, 20);
            this.textOras.TabIndex = 24;
            this.textOras.TextChanged += new System.EventHandler(this.textOras_TextChanged);
            // 
            // labelJudSect
            // 
            this.labelJudSect.AutoSize = true;
            this.labelJudSect.Location = new System.Drawing.Point(19, 121);
            this.labelJudSect.Name = "labelJudSect";
            this.labelJudSect.Size = new System.Drawing.Size(69, 13);
            this.labelJudSect.TabIndex = 25;
            this.labelJudSect.Text = "Judet/Sector";
            this.labelJudSect.Click += new System.EventHandler(this.labelJudSect_Click);
            // 
            // textJudet
            // 
            this.textJudet.Location = new System.Drawing.Point(93, 118);
            this.textJudet.Name = "textJudet";
            this.textJudet.Size = new System.Drawing.Size(153, 20);
            this.textJudet.TabIndex = 26;
            this.textJudet.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelProiect
            // 
            this.labelProiect.AutoSize = true;
            this.labelProiect.Location = new System.Drawing.Point(473, 181);
            this.labelProiect.Name = "labelProiect";
            this.labelProiect.Size = new System.Drawing.Size(40, 13);
            this.labelProiect.TabIndex = 31;
            this.labelProiect.Text = "Proiect";
            this.labelProiect.Click += new System.EventHandler(this.labelProiect_Click);
            // 
            // comboBoxProiect
            // 
            this.comboBoxProiect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProiect.FormattingEnabled = true;
            this.comboBoxProiect.Location = new System.Drawing.Point(519, 178);
            this.comboBoxProiect.Name = "comboBoxProiect";
            this.comboBoxProiect.Size = new System.Drawing.Size(155, 21);
            this.comboBoxProiect.TabIndex = 32;
            this.comboBoxProiect.SelectedIndexChanged += new System.EventHandler(this.comboBoxProiect_SelectedIndexChanged);
            // 
            // buttonAddAngajat
            // 
            this.buttonAddAngajat.Location = new System.Drawing.Point(497, 332);
            this.buttonAddAngajat.Name = "buttonAddAngajat";
            this.buttonAddAngajat.Size = new System.Drawing.Size(154, 50);
            this.buttonAddAngajat.TabIndex = 0;
            this.buttonAddAngajat.Text = "Finalizare";
            this.buttonAddAngajat.UseVisualStyleBackColor = true;
            this.buttonAddAngajat.Click += new System.EventHandler(this.buttonAddAngajat_Click);
            // 
            // textDataNastere
            // 
            this.textDataNastere.Location = new System.Drawing.Point(449, 63);
            this.textDataNastere.Name = "textDataNastere";
            this.textDataNastere.Size = new System.Drawing.Size(135, 20);
            this.textDataNastere.TabIndex = 14;
            this.textDataNastere.TextChanged += new System.EventHandler(this.textDataNastere_TextChanged);
            // 
            // buttonTabelRude
            // 
            this.buttonTabelRude.Location = new System.Drawing.Point(22, 285);
            this.buttonTabelRude.Name = "buttonTabelRude";
            this.buttonTabelRude.Size = new System.Drawing.Size(93, 24);
            this.buttonTabelRude.TabIndex = 33;
            this.buttonTabelRude.Text = "Tabel Rude";
            this.buttonTabelRude.UseVisualStyleBackColor = true;
            this.buttonTabelRude.Click += new System.EventHandler(this.buttonTabelRude_Click);
            // 
            // buttonFisaMedicala
            // 
            this.buttonFisaMedicala.Location = new System.Drawing.Point(153, 285);
            this.buttonFisaMedicala.Name = "buttonFisaMedicala";
            this.buttonFisaMedicala.Size = new System.Drawing.Size(93, 24);
            this.buttonFisaMedicala.TabIndex = 34;
            this.buttonFisaMedicala.Text = "Fisa Medicala";
            this.buttonFisaMedicala.UseVisualStyleBackColor = true;
            this.buttonFisaMedicala.Click += new System.EventHandler(this.buttonFisaMedicala_Click);
            // 
            // buttonCV
            // 
            this.buttonCV.Location = new System.Drawing.Point(303, 285);
            this.buttonCV.Name = "buttonCV";
            this.buttonCV.Size = new System.Drawing.Size(93, 23);
            this.buttonCV.TabIndex = 35;
            this.buttonCV.Text = "Upload CV";
            this.buttonCV.UseVisualStyleBackColor = true;
            this.buttonCV.Click += new System.EventHandler(this.buttonCV_Click);
            // 
            // labelOptional
            // 
            this.labelOptional.AutoSize = true;
            this.labelOptional.Location = new System.Drawing.Point(19, 322);
            this.labelOptional.Name = "labelOptional";
            this.labelOptional.Size = new System.Drawing.Size(0, 13);
            this.labelOptional.TabIndex = 36;
            this.labelOptional.Click += new System.EventHandler(this.labelOptional_Click);
            // 
            // FormAngajatNou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 405);
            this.Controls.Add(this.labelOptional);
            this.Controls.Add(this.buttonCV);
            this.Controls.Add(this.buttonFisaMedicala);
            this.Controls.Add(this.buttonTabelRude);
            this.Controls.Add(this.textDataNastere);
            this.Controls.Add(this.buttonAddAngajat);
            this.Controls.Add(this.comboBoxProiect);
            this.Controls.Add(this.labelProiect);
            this.Controls.Add(this.textJudet);
            this.Controls.Add(this.labelJudSect);
            this.Controls.Add(this.textOras);
            this.Controls.Add(this.labelOras);
            this.Controls.Add(this.textApartament);
            this.Controls.Add(this.labelApartament);
            this.Controls.Add(this.textBloc);
            this.Controls.Add(this.labelBloc);
            this.Controls.Add(this.textNrStrada);
            this.Controls.Add(this.labelNrStrada);
            this.Controls.Add(this.textStrada);
            this.Controls.Add(this.labelStrada);
            this.Controls.Add(this.labelDataNastere);
            this.Controls.Add(this.comboBoxDepartamente);
            this.Controls.Add(this.labelDepartament);
            this.Controls.Add(this.comboBoxFunctii);
            this.Controls.Add(this.labelFunctie);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textTelefon);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.textCNP);
            this.Controls.Add(this.labelCNP);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.labelGrad);
            this.Controls.Add(this.textPrenume);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Name = "FormAngajatNou";
            this.Text = "FormAngajatNou";
            this.Load += new System.EventHandler(this.FormAngajatNou_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.TextBox textPrenume;
        private System.Windows.Forms.Label labelGrad;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.TextBox textCNP;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelFunctie;
        private System.Windows.Forms.ComboBox comboBoxFunctii;
        private System.Windows.Forms.Label labelDepartament;
        private System.Windows.Forms.ComboBox comboBoxDepartamente;
        private System.Windows.Forms.Label labelDataNastere;
        private System.Windows.Forms.Label labelStrada;
        private System.Windows.Forms.TextBox textStrada;
        private System.Windows.Forms.Label labelNrStrada;
        private System.Windows.Forms.TextBox textNrStrada;
        private System.Windows.Forms.Label labelBloc;
        private System.Windows.Forms.TextBox textBloc;
        private System.Windows.Forms.Label labelApartament;
        private System.Windows.Forms.TextBox textApartament;
        private System.Windows.Forms.Label labelOras;
        private System.Windows.Forms.TextBox textOras;
        private System.Windows.Forms.Label labelJudSect;
        private System.Windows.Forms.TextBox textJudet;
        private System.Windows.Forms.Label labelProiect;
        private System.Windows.Forms.ComboBox comboBoxProiect;
        private System.Windows.Forms.Button buttonAddAngajat;
        private System.Windows.Forms.TextBox textDataNastere;
        private System.Windows.Forms.Button buttonTabelRude;
        private System.Windows.Forms.Button buttonFisaMedicala;
        private System.Windows.Forms.Button buttonCV;
        private System.Windows.Forms.Label labelOptional;
    }
}