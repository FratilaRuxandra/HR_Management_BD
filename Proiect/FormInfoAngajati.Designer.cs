namespace Proiect
{
    partial class FormInfoAngajati
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
            this.buttonTotiAngajatii = new System.Windows.Forms.Button();
            this.buttonCautaAngajat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProiect = new System.Windows.Forms.Button();
            this.buttonFisaMed = new System.Windows.Forms.Button();
            this.buttonRude = new System.Windows.Forms.Button();
            this.buttonSalarii = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdrese = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTotiAngajatii
            // 
            this.buttonTotiAngajatii.Location = new System.Drawing.Point(906, 616);
            this.buttonTotiAngajatii.Name = "buttonTotiAngajatii";
            this.buttonTotiAngajatii.Size = new System.Drawing.Size(147, 74);
            this.buttonTotiAngajatii.TabIndex = 0;
            this.buttonTotiAngajatii.Text = "Toti Angajatii";
            this.buttonTotiAngajatii.UseVisualStyleBackColor = true;
            this.buttonTotiAngajatii.Click += new System.EventHandler(this.buttonTotiAngajatii_Click);
            // 
            // buttonCautaAngajat
            // 
            this.buttonCautaAngajat.Location = new System.Drawing.Point(40, 163);
            this.buttonCautaAngajat.Name = "buttonCautaAngajat";
            this.buttonCautaAngajat.Size = new System.Drawing.Size(96, 45);
            this.buttonCautaAngajat.TabIndex = 1;
            this.buttonCautaAngajat.Text = "Cauta Angajati";
            this.buttonCautaAngajat.UseVisualStyleBackColor = true;
            this.buttonCautaAngajat.Click += new System.EventHandler(this.buttonCautaAngajat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1923, 366);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Nume",
            "Prenume",
            "Grad",
            "Functie",
            "Departament",
            "Proiect",
            "Anul angajarii"});
            this.comboBox1.Location = new System.Drawing.Point(171, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAdrese);
            this.panel1.Controls.Add(this.buttonProiect);
            this.panel1.Controls.Add(this.buttonFisaMed);
            this.panel1.Controls.Add(this.buttonRude);
            this.panel1.Controls.Add(this.buttonSalarii);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.buttonCautaAngajat);
            this.panel1.Location = new System.Drawing.Point(61, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 287);
            this.panel1.TabIndex = 5;
            // 
            // buttonProiect
            // 
            this.buttonProiect.Location = new System.Drawing.Point(217, 239);
            this.buttonProiect.Name = "buttonProiect";
            this.buttonProiect.Size = new System.Drawing.Size(96, 45);
            this.buttonProiect.TabIndex = 11;
            this.buttonProiect.Text = "Proiecte";
            this.buttonProiect.UseVisualStyleBackColor = true;
            this.buttonProiect.Click += new System.EventHandler(this.buttonProiect_Click);
            // 
            // buttonFisaMed
            // 
            this.buttonFisaMed.Location = new System.Drawing.Point(40, 237);
            this.buttonFisaMed.Name = "buttonFisaMed";
            this.buttonFisaMed.Size = new System.Drawing.Size(96, 45);
            this.buttonFisaMed.TabIndex = 10;
            this.buttonFisaMed.Text = "Fise Medicale";
            this.buttonFisaMed.UseVisualStyleBackColor = true;
            this.buttonFisaMed.Click += new System.EventHandler(this.buttonFisaMed_Click);
            // 
            // buttonRude
            // 
            this.buttonRude.Location = new System.Drawing.Point(398, 163);
            this.buttonRude.Name = "buttonRude";
            this.buttonRude.Size = new System.Drawing.Size(96, 45);
            this.buttonRude.TabIndex = 9;
            this.buttonRude.Text = "Rude";
            this.buttonRude.UseVisualStyleBackColor = true;
            this.buttonRude.Click += new System.EventHandler(this.buttonRude_Click);
            // 
            // buttonSalarii
            // 
            this.buttonSalarii.Location = new System.Drawing.Point(217, 163);
            this.buttonSalarii.Name = "buttonSalarii";
            this.buttonSalarii.Size = new System.Drawing.Size(96, 45);
            this.buttonSalarii.TabIndex = 8;
            this.buttonSalarii.Text = "Salarii";
            this.buttonSalarii.UseVisualStyleBackColor = true;
            this.buttonSalarii.Click += new System.EventHandler(this.buttonSalarii_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Informatii Generale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valoare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Camp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(679, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 180);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Salariu";
            // 
            // buttonAdrese
            // 
            this.buttonAdrese.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAdrese.Location = new System.Drawing.Point(398, 239);
            this.buttonAdrese.Name = "buttonAdrese";
            this.buttonAdrese.Size = new System.Drawing.Size(96, 43);
            this.buttonAdrese.TabIndex = 12;
            this.buttonAdrese.Text = "Adrese";
            this.buttonAdrese.UseVisualStyleBackColor = true;
            this.buttonAdrese.Click += new System.EventHandler(this.buttonAdrese_Click);
            // 
            // FormInfoAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonTotiAngajatii);
            this.Name = "FormInfoAngajati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informatii Angajati";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInfoAngajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTotiAngajatii;
        private System.Windows.Forms.Button buttonCautaAngajat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSalarii;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRude;
        private System.Windows.Forms.Button buttonFisaMed;
        private System.Windows.Forms.Button buttonProiect;
        private System.Windows.Forms.Button buttonAdrese;
    }
}