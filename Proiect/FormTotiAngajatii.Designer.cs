namespace Proiect
{
    partial class FormTotiAngajatii
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
            this.dataGridTotiAngajatii = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTotiAngajatii)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTotiAngajatii
            // 
            this.dataGridTotiAngajatii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTotiAngajatii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTotiAngajatii.Location = new System.Drawing.Point(0, 0);
            this.dataGridTotiAngajatii.Name = "dataGridTotiAngajatii";
            this.dataGridTotiAngajatii.RowTemplate.Height = 24;
            this.dataGridTotiAngajatii.Size = new System.Drawing.Size(1924, 506);
            this.dataGridTotiAngajatii.TabIndex = 0;
            // 
            // FormTotiAngajatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 506);
            this.Controls.Add(this.dataGridTotiAngajatii);
            this.Name = "FormTotiAngajatii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toti Angajatii";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTotiAngajatii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTotiAngajatii)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTotiAngajatii;
    }
}