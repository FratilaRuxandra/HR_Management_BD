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
            //SqlConnectionStringBuilder bu = new SqlConnectionStringBuilder();

            //bu.DataSource = ".";
            //bu.InitialCatalog = "HR";
            //bu.IntegratedSecurity = false;
            //bu.UserID = username;
            //bu.Password = password;

            //SqlConnection con = new SqlConnection(bu.ConnectionString);
            //try
            //{
            //    con.Open();
            //}catch(SqlException exp)
            //{
            //    ///////////de facut o exceptie ptr conexiune esuata si una ptr username/parola incorecta
            //    MessageBox.Show("Username sau parola incorecta");
            //    this.Close();
            //}
            if (username == "DepHR" && password == "parolahr")
            {
                FormMenu f2 = new FormMenu();
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
            if(username =="admin" && password == "admin")
            {
                FormMenuAdmin f3 = new FormMenuAdmin();
                this.Hide();
                f3.ShowDialog();
                this.Close();
            }

        }
       
    }

}
