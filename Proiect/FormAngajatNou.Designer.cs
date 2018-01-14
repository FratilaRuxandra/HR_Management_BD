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
            this.labelNume.BackColor = System.Drawing.Color.Transparent;
            this.labelNume.ForeColor = System.Drawing.Color.White;
            this.labelNume.Location = new System.Drawing.Point(25, 48);
            this.labelNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(45, 17);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            this.labelNume.Click += new System.EventHandler(this.labelNume_Click);
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.BackColor = System.Drawing.Color.Transparent;
            this.labelPrenume.ForeColor = System.Drawing.Color.White;
            this.labelPrenume.Location = new System.Drawing.Point(248, 47);
            this.labelPrenume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(65, 17);
            this.labelPrenume.TabIndex = 1;
            this.labelPrenume.Text = "Prenume";
            this.labelPrenume.Click += new System.EventHandler(this.labelPrenume_Click);
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(80, 43);
            this.textNume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(159, 22);
            this.textNume.TabIndex = 2;
            this.textNume.TextChanged += new System.EventHandler(this.textNume_TextChanged);
            // 
            // textPrenume
            // 
            this.textPrenume.Location = new System.Drawing.Point(321, 44);
            this.textPrenume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(157, 22);
            this.textPrenume.TabIndex = 3;
            this.textPrenume.TextChanged += new System.EventHandler(this.textPrenume_TextChanged);
            // 
            // labelGrad
            // 
            this.labelGrad.AutoSize = true;
            this.labelGrad.BackColor = System.Drawing.Color.Transparent;
            this.labelGrad.ForeColor = System.Drawing.Color.White;
            this.labelGrad.Location = new System.Drawing.Point(488, 48);
            this.labelGrad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrad.Name = "labelGrad";
            this.labelGrad.Size = new System.Drawing.Size(40, 17);
            this.labelGrad.TabIndex = 4;
            this.labelGrad.Text = "Grad";
            this.labelGrad.Click += new System.EventHandler(this.labelGrad_Click);
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Location = new System.Drawing.Point(536, 44);
            this.comboBoxGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(159, 24);
            this.comboBoxGrade.TabIndex = 6;
            this.comboBoxGrade.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrade_SelectedIndexChanged);
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.BackColor = System.Drawing.Color.Transparent;
            this.labelCNP.ForeColor = System.Drawing.Color.White;
            this.labelCNP.Location = new System.Drawing.Point(704, 48);
            this.labelCNP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(36, 17);
            this.labelCNP.TabIndex = 7;
            this.labelCNP.Text = "CNP";
            this.labelCNP.Click += new System.EventHandler(this.labelCNP_Click);
            // 
            // textCNP
            // 
            this.textCNP.Location = new System.Drawing.Point(751, 44);
            this.textCNP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCNP.Name = "textCNP";
            this.textCNP.Size = new System.Drawing.Size(157, 22);
            this.textCNP.TabIndex = 8;
            this.textCNP.TextChanged += new System.EventHandler(this.textCNP_TextChanged);
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefon.ForeColor = System.Drawing.Color.White;
            this.labelTelefon.Location = new System.Drawing.Point(25, 80);
            this.labelTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(56, 17);
            this.labelTelefon.TabIndex = 9;
            this.labelTelefon.Text = "Telefon";
            this.labelTelefon.Click += new System.EventHandler(this.labelTelefon_Click);
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(92, 80);
            this.textTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(147, 22);
            this.textTelefon.TabIndex = 10;
            this.textTelefon.TextChanged += new System.EventHandler(this.textTelefon_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(248, 84);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Email";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(321, 80);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(157, 22);
            this.textEmail.TabIndex = 12;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // labelFunctie
            // 
            this.labelFunctie.AutoSize = true;
            this.labelFunctie.BackColor = System.Drawing.Color.Transparent;
            this.labelFunctie.ForeColor = System.Drawing.Color.White;
            this.labelFunctie.Location = new System.Drawing.Point(352, 154);
            this.labelFunctie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunctie.Name = "labelFunctie";
            this.labelFunctie.Size = new System.Drawing.Size(54, 17);
            this.labelFunctie.TabIndex = 27;
            this.labelFunctie.Text = "Functie";
            this.labelFunctie.Click += new System.EventHandler(this.labelFunctie_Click);
            // 
            // comboBoxFunctii
            // 
            this.comboBoxFunctii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunctii.FormattingEnabled = true;
            this.comboBoxFunctii.Location = new System.Drawing.Point(419, 148);
            this.comboBoxFunctii.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFunctii.Name = "comboBoxFunctii";
            this.comboBoxFunctii.Size = new System.Drawing.Size(203, 24);
            this.comboBoxFunctii.TabIndex = 28;
            this.comboBoxFunctii.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunctii_SelectedIndexChanged);
            // 
            // labelDepartament
            // 
            this.labelDepartament.AutoSize = true;
            this.labelDepartament.BackColor = System.Drawing.Color.Transparent;
            this.labelDepartament.ForeColor = System.Drawing.Color.White;
            this.labelDepartament.Location = new System.Drawing.Point(25, 183);
            this.labelDepartament.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepartament.Name = "labelDepartament";
            this.labelDepartament.Size = new System.Drawing.Size(90, 17);
            this.labelDepartament.TabIndex = 29;
            this.labelDepartament.Text = "Departament";
            this.labelDepartament.Click += new System.EventHandler(this.labelDepartament_Click);
            // 
            // comboBoxDepartamente
            // 
            this.comboBoxDepartamente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartamente.FormattingEnabled = true;
            this.comboBoxDepartamente.Location = new System.Drawing.Point(124, 182);
            this.comboBoxDepartamente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDepartamente.Name = "comboBoxDepartamente";
            this.comboBoxDepartamente.Size = new System.Drawing.Size(205, 24);
            this.comboBoxDepartamente.TabIndex = 30;
            this.comboBoxDepartamente.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartamente_SelectedIndexChanged);
            // 
            // labelDataNastere
            // 
            this.labelDataNastere.AutoSize = true;
            this.labelDataNastere.BackColor = System.Drawing.Color.Transparent;
            this.labelDataNastere.ForeColor = System.Drawing.Color.White;
            this.labelDataNastere.Location = new System.Drawing.Point(488, 84);
            this.labelDataNastere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataNastere.Name = "labelDataNastere";
            this.labelDataNastere.Size = new System.Drawing.Size(92, 17);
            this.labelDataNastere.TabIndex = 13;
            this.labelDataNastere.Text = "Data Nastere";
            this.labelDataNastere.Click += new System.EventHandler(this.labelDataNastere_Click);
            // 
            // labelStrada
            // 
            this.labelStrada.AutoSize = true;
            this.labelStrada.BackColor = System.Drawing.Color.Transparent;
            this.labelStrada.ForeColor = System.Drawing.Color.White;
            this.labelStrada.Location = new System.Drawing.Point(25, 113);
            this.labelStrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStrada.Name = "labelStrada";
            this.labelStrada.Size = new System.Drawing.Size(50, 17);
            this.labelStrada.TabIndex = 15;
            this.labelStrada.Text = "Strada";
            this.labelStrada.Click += new System.EventHandler(this.labelStrada_Click);
            // 
            // textStrada
            // 
            this.textStrada.Location = new System.Drawing.Point(92, 112);
            this.textStrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textStrada.Name = "textStrada";
            this.textStrada.Size = new System.Drawing.Size(147, 22);
            this.textStrada.TabIndex = 16;
            this.textStrada.TextChanged += new System.EventHandler(this.textStrada_TextChanged);
            // 
            // labelNrStrada
            // 
            this.labelNrStrada.AutoSize = true;
            this.labelNrStrada.BackColor = System.Drawing.Color.Transparent;
            this.labelNrStrada.ForeColor = System.Drawing.Color.White;
            this.labelNrStrada.Location = new System.Drawing.Point(248, 116);
            this.labelNrStrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNrStrada.Name = "labelNrStrada";
            this.labelNrStrada.Size = new System.Drawing.Size(27, 17);
            this.labelNrStrada.TabIndex = 17;
            this.labelNrStrada.Text = "Nr.";
            this.labelNrStrada.Click += new System.EventHandler(this.labelNrStrada_Click);
            // 
            // textNrStrada
            // 
            this.textNrStrada.Location = new System.Drawing.Point(321, 112);
            this.textNrStrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNrStrada.Name = "textNrStrada";
            this.textNrStrada.Size = new System.Drawing.Size(56, 22);
            this.textNrStrada.TabIndex = 18;
            this.textNrStrada.TextChanged += new System.EventHandler(this.textNrStrada_TextChanged);
            // 
            // labelBloc
            // 
            this.labelBloc.AutoSize = true;
            this.labelBloc.BackColor = System.Drawing.Color.Transparent;
            this.labelBloc.ForeColor = System.Drawing.Color.White;
            this.labelBloc.Location = new System.Drawing.Point(405, 116);
            this.labelBloc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBloc.Name = "labelBloc";
            this.labelBloc.Size = new System.Drawing.Size(35, 17);
            this.labelBloc.TabIndex = 19;
            this.labelBloc.Text = "Bloc";
            this.labelBloc.Click += new System.EventHandler(this.labelBloc_Click);
            // 
            // textBloc
            // 
            this.textBloc.Location = new System.Drawing.Point(451, 112);
            this.textBloc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBloc.Name = "textBloc";
            this.textBloc.Size = new System.Drawing.Size(104, 22);
            this.textBloc.TabIndex = 20;
            this.textBloc.TextChanged += new System.EventHandler(this.textBloc_TextChanged);
            // 
            // labelApartament
            // 
            this.labelApartament.AutoSize = true;
            this.labelApartament.BackColor = System.Drawing.Color.Transparent;
            this.labelApartament.ForeColor = System.Drawing.Color.White;
            this.labelApartament.Location = new System.Drawing.Point(564, 116);
            this.labelApartament.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApartament.Name = "labelApartament";
            this.labelApartament.Size = new System.Drawing.Size(25, 17);
            this.labelApartament.TabIndex = 21;
            this.labelApartament.Text = "Ap";
            this.labelApartament.Click += new System.EventHandler(this.labelApartament_Click);
            // 
            // textApartament
            // 
            this.textApartament.Location = new System.Drawing.Point(599, 110);
            this.textApartament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textApartament.Name = "textApartament";
            this.textApartament.Size = new System.Drawing.Size(51, 22);
            this.textApartament.TabIndex = 22;
            this.textApartament.TextChanged += new System.EventHandler(this.textApartament_TextChanged);
            // 
            // labelOras
            // 
            this.labelOras.AutoSize = true;
            this.labelOras.BackColor = System.Drawing.Color.Transparent;
            this.labelOras.ForeColor = System.Drawing.Color.White;
            this.labelOras.Location = new System.Drawing.Point(659, 116);
            this.labelOras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOras.Name = "labelOras";
            this.labelOras.Size = new System.Drawing.Size(69, 17);
            this.labelOras.TabIndex = 23;
            this.labelOras.Text = "Localitate";
            this.labelOras.Click += new System.EventHandler(this.labelOras_Click);
            // 
            // textOras
            // 
            this.textOras.Location = new System.Drawing.Point(737, 113);
            this.textOras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textOras.Name = "textOras";
            this.textOras.Size = new System.Drawing.Size(171, 22);
            this.textOras.TabIndex = 24;
            this.textOras.TextChanged += new System.EventHandler(this.textOras_TextChanged);
            // 
            // labelJudSect
            // 
            this.labelJudSect.AutoSize = true;
            this.labelJudSect.BackColor = System.Drawing.Color.Transparent;
            this.labelJudSect.ForeColor = System.Drawing.Color.White;
            this.labelJudSect.Location = new System.Drawing.Point(25, 149);
            this.labelJudSect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJudSect.Name = "labelJudSect";
            this.labelJudSect.Size = new System.Drawing.Size(88, 17);
            this.labelJudSect.TabIndex = 25;
            this.labelJudSect.Text = "Judet/Sector";
            this.labelJudSect.Click += new System.EventHandler(this.labelJudSect_Click);
            // 
            // textJudet
            // 
            this.textJudet.Location = new System.Drawing.Point(124, 145);
            this.textJudet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textJudet.Name = "textJudet";
            this.textJudet.Size = new System.Drawing.Size(203, 22);
            this.textJudet.TabIndex = 26;
            this.textJudet.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelProiect
            // 
            this.labelProiect.AutoSize = true;
            this.labelProiect.BackColor = System.Drawing.Color.Transparent;
            this.labelProiect.ForeColor = System.Drawing.Color.White;
            this.labelProiect.Location = new System.Drawing.Point(641, 154);
            this.labelProiect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProiect.Name = "labelProiect";
            this.labelProiect.Size = new System.Drawing.Size(52, 17);
            this.labelProiect.TabIndex = 31;
            this.labelProiect.Text = "Proiect";
            this.labelProiect.Click += new System.EventHandler(this.labelProiect_Click);
            // 
            // comboBoxProiect
            // 
            this.comboBoxProiect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProiect.FormattingEnabled = true;
            this.comboBoxProiect.Location = new System.Drawing.Point(703, 154);
            this.comboBoxProiect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxProiect.Name = "comboBoxProiect";
            this.comboBoxProiect.Size = new System.Drawing.Size(205, 24);
            this.comboBoxProiect.TabIndex = 32;
            this.comboBoxProiect.SelectedIndexChanged += new System.EventHandler(this.comboBoxProiect_SelectedIndexChanged);
            // 
            // buttonAddAngajat
            // 
            this.buttonAddAngajat.Location = new System.Drawing.Point(396, 303);
            this.buttonAddAngajat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddAngajat.Name = "buttonAddAngajat";
            this.buttonAddAngajat.Size = new System.Drawing.Size(160, 47);
            this.buttonAddAngajat.TabIndex = 0;
            this.buttonAddAngajat.Text = "Finalizare";
            this.buttonAddAngajat.UseVisualStyleBackColor = true;
            this.buttonAddAngajat.Click += new System.EventHandler(this.buttonAddAngajat_Click);
            // 
            // textDataNastere
            // 
            this.textDataNastere.Location = new System.Drawing.Point(599, 78);
            this.textDataNastere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDataNastere.Name = "textDataNastere";
            this.textDataNastere.Size = new System.Drawing.Size(179, 22);
            this.textDataNastere.TabIndex = 14;
            this.textDataNastere.TextChanged += new System.EventHandler(this.textDataNastere_TextChanged);
            // 
            // buttonTabelRude
            // 
            this.buttonTabelRude.Location = new System.Drawing.Point(92, 233);
            this.buttonTabelRude.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTabelRude.Name = "buttonTabelRude";
            this.buttonTabelRude.Size = new System.Drawing.Size(236, 34);
            this.buttonTabelRude.TabIndex = 33;
            this.buttonTabelRude.Text = "Tabel Rude";
            this.buttonTabelRude.UseVisualStyleBackColor = true;
            this.buttonTabelRude.Click += new System.EventHandler(this.buttonTabelRude_Click);
            // 
            // buttonFisaMedicala
            // 
            this.buttonFisaMedicala.Location = new System.Drawing.Point(372, 233);
            this.buttonFisaMedicala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFisaMedicala.Name = "buttonFisaMedicala";
            this.buttonFisaMedicala.Size = new System.Drawing.Size(236, 34);
            this.buttonFisaMedicala.TabIndex = 34;
            this.buttonFisaMedicala.Text = "Fisa Medicala";
            this.buttonFisaMedicala.UseVisualStyleBackColor = true;
            this.buttonFisaMedicala.Click += new System.EventHandler(this.buttonFisaMedicala_Click);
            // 
            // buttonCV
            // 
            this.buttonCV.Location = new System.Drawing.Point(661, 233);
            this.buttonCV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCV.Name = "buttonCV";
            this.buttonCV.Size = new System.Drawing.Size(236, 34);
            this.buttonCV.TabIndex = 35;
            this.buttonCV.Text = "Upload CV";
            this.buttonCV.UseVisualStyleBackColor = true;
            this.buttonCV.Click += new System.EventHandler(this.buttonCV_Click);
            // 
            // labelOptional
            // 
            this.labelOptional.AutoSize = true;
            this.labelOptional.Location = new System.Drawing.Point(25, 396);
            this.labelOptional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOptional.Name = "labelOptional";
            this.labelOptional.Size = new System.Drawing.Size(0, 17);
            this.labelOptional.TabIndex = 36;
            this.labelOptional.Click += new System.EventHandler(this.labelOptional_Click);
            // 
            // FormAngajatNou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect.Properties.Resources._316016;
            this.ClientSize = new System.Drawing.Size(935, 368);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAngajatNou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formular de angajare-toate campurile obligatorii";
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