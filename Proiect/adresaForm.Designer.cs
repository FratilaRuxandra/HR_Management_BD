namespace Proiect
{
    partial class adresaForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnCh = new System.Windows.Forms.Button();
            this.textJudet = new System.Windows.Forms.TextBox();
            this.labelJudSect = new System.Windows.Forms.Label();
            this.textOras = new System.Windows.Forms.TextBox();
            this.labelOras = new System.Windows.Forms.Label();
            this.textApartament = new System.Windows.Forms.TextBox();
            this.labelApartament = new System.Windows.Forms.Label();
            this.textBloc = new System.Windows.Forms.TextBox();
            this.labelBloc = new System.Windows.Forms.Label();
            this.textNrStrada = new System.Windows.Forms.TextBox();
            this.labelNrStrada = new System.Windows.Forms.Label();
            this.textStrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(608, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(507, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 58;
            this.label3.Text = "Nume";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(212, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 28);
            this.label2.TabIndex = 57;
            this.label2.Text = "Introduceti adresa pentru:";
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(665, 306);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(154, 47);
            this.btncancel.TabIndex = 56;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // btnCh
            // 
            this.btnCh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCh.Location = new System.Drawing.Point(63, 306);
            this.btnCh.Name = "btnCh";
            this.btnCh.Size = new System.Drawing.Size(156, 48);
            this.btnCh.TabIndex = 55;
            this.btnCh.Text = "Modifica";
            this.btnCh.UseVisualStyleBackColor = true;
            this.btnCh.Click += new System.EventHandler(this.btnCh_Click_1);
            // 
            // textJudet
            // 
            this.textJudet.Location = new System.Drawing.Point(649, 226);
            this.textJudet.Margin = new System.Windows.Forms.Padding(4);
            this.textJudet.Name = "textJudet";
            this.textJudet.Size = new System.Drawing.Size(203, 22);
            this.textJudet.TabIndex = 54;
            this.textJudet.TextChanged += new System.EventHandler(this.textJudet_TextChanged_1);
            // 
            // labelJudSect
            // 
            this.labelJudSect.AutoSize = true;
            this.labelJudSect.BackColor = System.Drawing.Color.Transparent;
            this.labelJudSect.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudSect.ForeColor = System.Drawing.Color.White;
            this.labelJudSect.Location = new System.Drawing.Point(521, 226);
            this.labelJudSect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJudSect.Name = "labelJudSect";
            this.labelJudSect.Size = new System.Drawing.Size(103, 21);
            this.labelJudSect.TabIndex = 53;
            this.labelJudSect.Text = "Judet/Sector";
            this.labelJudSect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textOras
            // 
            this.textOras.Location = new System.Drawing.Point(282, 224);
            this.textOras.Margin = new System.Windows.Forms.Padding(4);
            this.textOras.Name = "textOras";
            this.textOras.Size = new System.Drawing.Size(171, 22);
            this.textOras.TabIndex = 52;
            this.textOras.TextChanged += new System.EventHandler(this.textOras_TextChanged_1);
            // 
            // labelOras
            // 
            this.labelOras.AutoSize = true;
            this.labelOras.BackColor = System.Drawing.Color.Transparent;
            this.labelOras.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOras.ForeColor = System.Drawing.Color.White;
            this.labelOras.Location = new System.Drawing.Point(192, 224);
            this.labelOras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOras.Name = "labelOras";
            this.labelOras.Size = new System.Drawing.Size(82, 21);
            this.labelOras.TabIndex = 51;
            this.labelOras.Text = "Localitate";
            this.labelOras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textApartament
            // 
            this.textApartament.Location = new System.Drawing.Point(96, 224);
            this.textApartament.Margin = new System.Windows.Forms.Padding(4);
            this.textApartament.Name = "textApartament";
            this.textApartament.Size = new System.Drawing.Size(51, 22);
            this.textApartament.TabIndex = 50;
            this.textApartament.TextChanged += new System.EventHandler(this.textApartament_TextChanged_1);
            // 
            // labelApartament
            // 
            this.labelApartament.AutoSize = true;
            this.labelApartament.BackColor = System.Drawing.Color.Transparent;
            this.labelApartament.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApartament.ForeColor = System.Drawing.Color.White;
            this.labelApartament.Location = new System.Drawing.Point(60, 224);
            this.labelApartament.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApartament.Name = "labelApartament";
            this.labelApartament.Size = new System.Drawing.Size(33, 21);
            this.labelApartament.TabIndex = 49;
            this.labelApartament.Text = "Ap";
            this.labelApartament.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBloc
            // 
            this.textBloc.Location = new System.Drawing.Point(533, 153);
            this.textBloc.Margin = new System.Windows.Forms.Padding(4);
            this.textBloc.Name = "textBloc";
            this.textBloc.Size = new System.Drawing.Size(104, 22);
            this.textBloc.TabIndex = 48;
            this.textBloc.TextChanged += new System.EventHandler(this.textBloc_TextChanged_1);
            // 
            // labelBloc
            // 
            this.labelBloc.AutoSize = true;
            this.labelBloc.BackColor = System.Drawing.Color.Transparent;
            this.labelBloc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloc.ForeColor = System.Drawing.Color.White;
            this.labelBloc.Location = new System.Drawing.Point(440, 154);
            this.labelBloc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBloc.Name = "labelBloc";
            this.labelBloc.Size = new System.Drawing.Size(45, 21);
            this.labelBloc.TabIndex = 47;
            this.labelBloc.Text = "Bloc";
            this.labelBloc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textNrStrada
            // 
            this.textNrStrada.Location = new System.Drawing.Point(348, 153);
            this.textNrStrada.Margin = new System.Windows.Forms.Padding(4);
            this.textNrStrada.Name = "textNrStrada";
            this.textNrStrada.Size = new System.Drawing.Size(56, 22);
            this.textNrStrada.TabIndex = 46;
            this.textNrStrada.TextChanged += new System.EventHandler(this.textNrStrada_TextChanged_1);
            // 
            // labelNrStrada
            // 
            this.labelNrStrada.AutoSize = true;
            this.labelNrStrada.BackColor = System.Drawing.Color.Transparent;
            this.labelNrStrada.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNrStrada.ForeColor = System.Drawing.Color.White;
            this.labelNrStrada.Location = new System.Drawing.Point(302, 152);
            this.labelNrStrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNrStrada.Name = "labelNrStrada";
            this.labelNrStrada.Size = new System.Drawing.Size(33, 21);
            this.labelNrStrada.TabIndex = 45;
            this.labelNrStrada.Text = "Nr.";
            this.labelNrStrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textStrada
            // 
            this.textStrada.Location = new System.Drawing.Point(136, 152);
            this.textStrada.Margin = new System.Windows.Forms.Padding(4);
            this.textStrada.Name = "textStrada";
            this.textStrada.Size = new System.Drawing.Size(147, 22);
            this.textStrada.TabIndex = 44;
            this.textStrada.TextChanged += new System.EventHandler(this.textStrada_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Strada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect.Properties.Resources._316016;
            this.ClientSize = new System.Drawing.Size(910, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnCh);
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
            this.Controls.Add(this.label1);
            this.Name = "adresaForm";
            this.Text = "Adresa";
            this.Load += new System.EventHandler(this.adresaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnCh;
        private System.Windows.Forms.TextBox textJudet;
        private System.Windows.Forms.Label labelJudSect;
        private System.Windows.Forms.TextBox textOras;
        private System.Windows.Forms.Label labelOras;
        private System.Windows.Forms.TextBox textApartament;
        private System.Windows.Forms.Label labelApartament;
        private System.Windows.Forms.TextBox textBloc;
        private System.Windows.Forms.Label labelBloc;
        private System.Windows.Forms.TextBox textNrStrada;
        private System.Windows.Forms.Label labelNrStrada;
        private System.Windows.Forms.TextBox textStrada;
        private System.Windows.Forms.Label label1;
    }
}