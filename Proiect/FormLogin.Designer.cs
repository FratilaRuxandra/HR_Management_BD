namespace Proiect
{
    partial class FormLogin
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPasswd = new System.Windows.Forms.Label();
            this.buttonConectare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(116, 177);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(195, 22);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Location = new System.Drawing.Point(116, 265);
            this.textBoxPasswd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.PasswordChar = '*';
            this.textBoxPasswd.Size = new System.Drawing.Size(195, 22);
            this.textBoxPasswd.TabIndex = 1;
            this.textBoxPasswd.UseSystemPasswordChar = true;
            this.textBoxPasswd.TextChanged += new System.EventHandler(this.textBoxPasswd_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(112, 137);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(90, 18);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username:";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // labelPasswd
            // 
            this.labelPasswd.AutoSize = true;
            this.labelPasswd.BackColor = System.Drawing.Color.Transparent;
            this.labelPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswd.ForeColor = System.Drawing.Color.White;
            this.labelPasswd.Location = new System.Drawing.Point(112, 233);
            this.labelPasswd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasswd.Name = "labelPasswd";
            this.labelPasswd.Size = new System.Drawing.Size(62, 18);
            this.labelPasswd.TabIndex = 3;
            this.labelPasswd.Text = "Parola:";
            // 
            // buttonConectare
            // 
            this.buttonConectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectare.Location = new System.Drawing.Point(156, 331);
            this.buttonConectare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConectare.Name = "buttonConectare";
            this.buttonConectare.Size = new System.Drawing.Size(120, 30);
            this.buttonConectare.TabIndex = 4;
            this.buttonConectare.Text = "Conectare\r\n";
            this.buttonConectare.UseVisualStyleBackColor = true;
            this.buttonConectare.Click += new System.EventHandler(this.buttonConectare_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect.Properties.Resources._316016;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(410, 503);
            this.Controls.Add(this.buttonConectare);
            this.Controls.Add(this.labelPasswd);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPasswd);
            this.Controls.Add(this.textBoxUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPasswd;
        private System.Windows.Forms.Button buttonConectare;
    }
}

