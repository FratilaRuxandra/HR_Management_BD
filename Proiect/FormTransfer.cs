using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormTransfer : Form
    {

        string nume, prenume, departament, functie;
        bool dep = false;
        bool func = false;
        public FormTransfer()
        {
            InitializeComponent();
        }
        private void populate_Functii()
        {
            using (var context = new HREntities1())
            {
                var results = from c in context.Functii
                              select new
                              {
                                  c.Denumire
                              };
                foreach (var item in results)
                {
                    combofunc.Items.Add(item.Denumire);
                }
            }
        }
        private void search(string nume)
        {
            using (var context = new HREntities1())
            {
                var results = (from c in context.Angajati
                               where c.Nume_Angajat == nume
                               select new
                               {
                                   c.Nume_Angajat
                               }).FirstOrDefault();
                if (results==null)
                {
                    MessageBox.Show("Numele introdus nu se afla in baza de date");
                    
                }

            }
        }
        private void populate_Departamente()
        {
            using (var context = new HREntities1())
            {
                var results = from c in context.Departamente
                              select new
                              {
                                  c.Nume_Departament
                              };
                foreach (var item in results)
                {
                    combodep.Items.Add(item.Nume_Departament);
                }
            }
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            //populate_Departamente();
           // populate_Functii();
        }

        private void combofunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            functie = combofunc.Text;
            func = true;
        }

        private void labelPrenume_Click(object sender, EventArgs e)
        {

        }

        private void textNume_TextChanged(object sender, EventArgs e)
        {
            nume = textNume.Text;
            
           

        }

        private void textPrenume_TextChanged(object sender, EventArgs e)
        {
            prenume = textPrenume.Text;
        }

        private void labelFunc_Click(object sender, EventArgs e)
        {

        }

        private void labelDep_Click(object sender, EventArgs e)
        {

        }

        private void radioDep_CheckedChanged(object sender, EventArgs e)
        {
            populate_Departamente();
        }

        private void radioFunctie_CheckedChanged(object sender, EventArgs e)
        {
            populate_Functii();
        }

        private void labelNume_Click(object sender, EventArgs e)
        {

        }

        private void combodep_SelectedIndexChanged(object sender, EventArgs e)
        {
            departament = combodep.Text;
            dep = true;
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new HREntities1();
                search(nume);
                if (func == true)
                    context.MoveFunctie1(nume, prenume, functie);
                if (dep == true)
                    context.MoveDepartament1(nume, prenume, departament);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
