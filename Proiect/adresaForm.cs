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
    public partial class adresaForm : Form
    {
        string numemdf, prenumemdf, strada, bloc, oras, judsector;
        int nr_strada, apartament;
        public adresaForm()
        {
            InitializeComponent();
        }





        private bool search(string nume, string prenume)
        {
            using (var context = new HREntities1())
            {
                var results = (from c in context.Angajati
                               where c.Nume_Angajat == nume && c.Prenume_Angajat == prenume
                               select new
                               {
                                   c.Nume_Angajat

                               }).FirstOrDefault();
                if (results == null)
                {
                    MessageBox.Show("Numele introdus nu se afla in baza de date");
                    return false;

                }
                else
                {
                    return true;
                }

            }
        }
        

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textStrada_TextChanged_1(object sender, EventArgs e)
        {
            strada = textStrada.Text;
        }

        private void textBloc_TextChanged_1(object sender, EventArgs e)
        {
            bloc = textBloc.Text;
        }

        private void textNrStrada_TextChanged_1(object sender, EventArgs e)
        {
            Int32.TryParse(textNrStrada.Text, out nr_strada);
        }

        private void textApartament_TextChanged_1(object sender, EventArgs e)
        {
            Int32.TryParse(textApartament.Text, out apartament);
        }
    

        private void textOras_TextChanged_1(object sender, EventArgs e)
        {
            oras = textOras.Text;
        }

        private void textJudet_TextChanged_1(object sender, EventArgs e)
        {
        judsector = textJudet.Text;
    }

        private void btnCh_Click_1(object sender, EventArgs e)
        {
            var context = new HREntities1();
            if (search(numemdf, prenumemdf) == true)
            {
                var resutl = (from c in context.Adrese
                              join a in context.Angajati on c.Id_Adresa equals a.Id_Adresa
                              where a.Nume_Angajat.Contains(numemdf) && a.Prenume_Angajat.Contains(prenumemdf)
                              select c).First();
                resutl.Strada = strada;
                resutl.Nr_Strada = nr_strada;
                resutl.Bloc = bloc;
                resutl.Apartament = apartament;
                resutl.Oras = oras;
                resutl.Judet_Sector = judsector;
                context.SaveChanges();

            }
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
        private void adresaForm_Load(object sender, EventArgs e)
        {
            numemdf = label3.Text = FormTEST.nume;
            prenumemdf = label4.Text = FormTEST.prenume;
        }
    }
}

