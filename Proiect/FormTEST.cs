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
    public partial class FormTEST : Form
    {
        public static string nume, prenume, valIntrodusa;
        public FormTEST()
        {
            InitializeComponent();
        }

        private void FormTEST_Load(object sender, EventArgs e)
        {

            List<States> list = new List<States>();
            list.Add(new States() { ID = "01", Name = "-Select-" });
            list.Add(new States() { ID = "02", Name = "CNP" });
            list.Add(new States() { ID = "03", Name = "Numar_Telefon" });
            list.Add(new States() { ID = "04", Name = "Email" });
            list.Add(new States() { ID = "05", Name = "Observatii" });
            list.Add(new States() { ID = "06", Name = "Adresa" });
            list.Add(new States() { ID = "06", Name = "Nume_Angajat" });
            comboBox1.DataSource = list;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";
        }










        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Adresa")
            {
                boxNewVal.Enabled = false;
                adresaForm adresa = new adresaForm();
                adresa.Show();

            }

            if (comboBox1.Text != "Adresa")
            { boxNewVal.Enabled = true; }
        }

        private void boxNume_TextChanged(object sender, EventArgs e)
        {
            nume = boxNume.Text;
        }

        private void boxPrenume_TextChanged(object sender, EventArgs e)
        {
            prenume = boxPrenume.Text;
        }

        private void boxNewVal_TextChanged(object sender, EventArgs e)
        {
            valIntrodusa = boxNewVal.Text;
            if (comboBox1.Text.Contains("CNP"))
            {


                if (valIntrodusa.Length > 13)
                {
                    DialogResult res = MessageBox.Show("CNP incorect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (search(nume, prenume) == true)
            {
                var context = new HREntities1();
                if (comboBox1.Text == "CNP")
                {

                    var result = (from a in context.Angajati
                                  where a.Nume_Angajat.Contains(nume) && a.Prenume_Angajat.Contains(prenume)
                                  select a).First();
                    result.CNP = String.Copy(valIntrodusa);
                    context.SaveChanges();
                    DialogResult res = MessageBox.Show("Modificare CNP reusita!", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    boxNume.Clear();
                    boxPrenume.Clear();
                    boxNewVal.Clear();
                }
                if (comboBox1.Text.Contains("Numar_Telefon"))
                {
                    var resultnr = (from n in context.Angajati
                                    where n.Nume_Angajat.Contains(nume) && n.Prenume_Angajat.Contains(prenume)
                                    select n
                                 ).First();
                    resultnr.Numar_Telefon = String.Copy(valIntrodusa);
                    context.SaveChanges();
                    DialogResult res = MessageBox.Show("Modificare Numar Telefon reusita!", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    boxNume.Clear();
                    boxPrenume.Clear();
                    boxNewVal.Clear();
                }
                if (comboBox1.Text.Contains("Email"))
                {
                    var resultemail = (from em in context.Angajati
                                       where em.Nume_Angajat.Contains(nume) && em.Prenume_Angajat.Contains(prenume)

                                       select em).First();


                    resultemail.Email = String.Copy(valIntrodusa);
                    context.SaveChanges();
                    DialogResult res = MessageBox.Show("Modificare Email reusita!", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    boxNume.Clear();
                    boxPrenume.Clear();
                    boxNewVal.Clear();
                }
                if (comboBox1.Text.Contains("Observatii"))
                {
                    var resultobs = (from obs in context.Angajati
                                     where obs.Nume_Angajat.Contains(nume) && obs.Prenume_Angajat.Contains(prenume)
                                     select obs).First();

                    resultobs.Observatii = valIntrodusa;
                    context.SaveChanges();
                    DialogResult res = MessageBox.Show("Modificare Observatii reusita!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    boxNume.Clear();
                    boxPrenume.Clear();
                    boxNewVal.Clear();
                }
                if (comboBox1.Text.Contains("Nume_Angajat"))
                {
                    var resultobs = (from obs in context.Angajati
                                     where obs.Nume_Angajat.Contains(nume) && obs.Prenume_Angajat.Contains(prenume)
                                     select obs).First();

                    resultobs.Nume_Angajat = valIntrodusa;
                    context.SaveChanges();
                    DialogResult res = MessageBox.Show("Modificare Nume reusita!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    boxNume.Clear();
                    boxPrenume.Clear();
                    boxNewVal.Clear();
                }

            }
        }
 

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
           
    }
}
