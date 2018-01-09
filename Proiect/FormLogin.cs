using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Proiect 
{
    public partial class FormLogin : Form
    {
        string username;
        string password;
        public FormLogin()
        {
            InitializeComponent();
        }
        
            
        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;

        }

        private void textBoxPasswd_TextChanged(object sender, EventArgs e)
        {
            password = textBoxPasswd.Text;
            
        }

        private void buttonConectare_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new HREntities1();
                var result = (from c in context.Logins
                              where c.Username == username
                              select c.Username).FirstOrDefault();
                if (result == null)
                {
                    MessageBox.Show("Username incorect");
                    this.Close();
                }
                else
                {
                    var result1 = (from c in context.Logins
                                   where c.Username == username
                                   select c.Parola).FirstOrDefault();
                    if (password != Encoding.Unicode.GetString(Convert.FromBase64String(result1)))
                    {
                        MessageBox.Show("Parola incorecta");
                        this.Close();
                    }
                    else
                    {
                        if (username == "hr")
                        {
                            FormMenu f2 = new FormMenu();
                            this.Hide();
                            f2.ShowDialog();
                            this.Close();
                        }
                        if (username == "admin")
                        {
                            FormMenuAdmin f3 = new FormMenuAdmin();
                            this.Hide();
                            f3.ShowDialog();
                            this.Close();
                        }
                        if (username == "guest")
                        {
                            MessageBox.Show("in constructie");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
       
    }

}
