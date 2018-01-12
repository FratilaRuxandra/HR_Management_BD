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
    public partial class FormInfoAngajati : Form
    {
        string nume;
        string categorie;
        public FormInfoAngajati()
        {
            InitializeComponent();
        }

        private void buttonTotiAngajatii_Click(object sender, EventArgs e)
        {
            FormTotiAngajatii formTotiAngajatii = new FormTotiAngajatii();
            formTotiAngajatii.ShowDialog();

        }

        private void buttonCautaAngajat_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new HREntities1())
                {

                    if (categorie == "ID")
                    {
                        var result = from c in context.Angajati
                                     where c.Id_Angajat.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         CNP = c.CNP,
                                         Tel = c.Numar_Telefon,
                                         Email = c.Email,
                                         Data_Nasterii = c.Data_Nastere,
                                         Data_Angajarii = c.Data_Angajare,
                                         Salariu = c.Salarii.Total,
                                         Proiect = c.Proiecte.Nume_Proiect,
                                         Data_Plecarii = c.Data_Plecare,
                                         Observatii = c.Observatii
                                     };
                        dataGridView1.DataSource = result.ToList();
                    }

                    if (categorie == "Nume")
                    {
                        var result = from c in context.Angajati
                                     where c.Nume_Angajat.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         CNP = c.CNP,
                                         Tel = c.Numar_Telefon,
                                         Email = c.Email,
                                         Data_Nasterii = c.Data_Nastere,
                                         Data_Angajarii = c.Data_Angajare,
                                         Salariu = c.Salarii.Total,
                                         Proiect = c.Proiecte.Nume_Proiect,
                                         Data_Plecarii = c.Data_Plecare,
                                         Observatii = c.Observatii
                                     };
                        dataGridView1.DataSource = result.ToList();
                    }

                    if (categorie == "Prenume")
                    {
                        var result = from c in context.Angajati
                                     where c.Prenume_Angajat.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         CNP = c.CNP,
                                         Tel = c.Numar_Telefon,
                                         Email = c.Email,
                                         Data_Nasterii = c.Data_Nastere,
                                         Data_Angajarii = c.Data_Angajare,
                                         Salariu = c.Salarii.Total,
                                         Proiect = c.Proiecte.Nume_Proiect,
                                         Data_Plecarii = c.Data_Plecare,
                                         Observatii = c.Observatii
                                     };
                        dataGridView1.DataSource = result.ToList();
                    }

                    if (categorie == "Grad")
                    {
                        var result = from c in context.Angajati
                                     where c.Grade.Denumire.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         CNP = c.CNP,
                                         Tel = c.Numar_Telefon,
                                         Email = c.Email,
                                         Data_Nasterii = c.Data_Nastere,
                                         Data_Angajarii = c.Data_Angajare,
                                         Salariu = c.Salarii.Total,
                                         Proiect = c.Proiecte.Nume_Proiect,
                                         Data_Plecarii = c.Data_Plecare,
                                         Observatii = c.Observatii
                                     };
                        dataGridView1.DataSource = result.ToList();
                    }

                    if (categorie == "Functie")
                    {
                        var result = from c in context.Angajati
                                     where c.Functii.Denumire.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         CNP = c.CNP,
                                         Tel = c.Numar_Telefon,
                                         Email = c.Email,
                                         Data_Nasterii = c.Data_Nastere,
                                         Data_Angajarii = c.Data_Angajare,
                                         Salariu = c.Salarii.Total,
                                         Proiect = c.Proiecte.Nume_Proiect,
                                         Data_Plecarii = c.Data_Plecare,
                                         Observatii = c.Observatii
                                     };
                        dataGridView1.DataSource = result.ToList();
                    }

                    if (categorie == "Departament")
                    {
                        var result = from c in context.Angajati
                                     where c.Departamente.Nume_Departament.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         CNP = c.CNP,
                                         Tel = c.Numar_Telefon,
                                         Email = c.Email,
                                         Data_Nasterii = c.Data_Nastere,
                                         Data_Angajarii = c.Data_Angajare,
                                         Salariu = c.Salarii.Total,
                                         Proiect = c.Proiecte.Nume_Proiect,
                                         Data_Plecarii = c.Data_Plecare,
                                         Observatii = c.Observatii
                                     };
                        dataGridView1.DataSource = result.ToList();
                    }


                    if (categorie == "Proiect")
                    {
                        var result = from c in context.Angajati
                                     where c.Proiecte.Nume_Proiect.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         CNP = c.CNP,
                                         Tel = c.Numar_Telefon,
                                         Email = c.Email,
                                         Data_Nasterii = c.Data_Nastere,
                                         Data_Angajarii = c.Data_Angajare,
                                         Salariu = c.Salarii.Total,
                                         Proiect = c.Proiecte.Nume_Proiect,
                                         Data_Plecarii = c.Data_Plecare,
                                         Observatii = c.Observatii
                                     };
                        dataGridView1.DataSource = result.ToList();
                    }

                    if (categorie == "Anul angajarii")
                    {
                        var result = from c in context.Angajati
                                     where c.Data_Angajare.Year.ToString() == nume
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         CNP = c.CNP,
                                         Tel = c.Numar_Telefon,
                                         Email = c.Email,
                                         Data_Nasterii = c.Data_Nastere,
                                         Data_Angajarii = c.Data_Angajare,
                                         Salariu = c.Salarii.Total,
                                         Proiect = c.Proiecte.Nume_Proiect,
                                         Data_Plecarii = c.Data_Plecare,
                                         Observatii = c.Observatii
                                     };
                        dataGridView1.DataSource = result.ToList();
                    }
                   
                }

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormInfoAngajati_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new HREntities1())
                {
                    var result = from c in context.Angajati
                                 select new
                                 {
                                     ID = c.Id_Angajat,
                                     Nume = c.Nume_Angajat,
                                     Prenume = c.Prenume_Angajat,
                                     Grad = c.Grade.Denumire,
                                     Functie = c.Functii.Denumire,
                                     Departament = c.Departamente.Nume_Departament,
                                     CNP = c.CNP,
                                     Tel = c.Numar_Telefon,
                                     Email = c.Email,
                                     Data_Nasterii = c.Data_Nastere,
                                     Data_Angajarii = c.Data_Angajare,
                                     Salariu = c.Salarii.Total,
                                     Proiect = c.Proiecte.Nume_Proiect,
                                     Data_Plecarii = c.Data_Plecare,
                                     Observatii = c.Observatii




                                 };
                    dataGridView1.DataSource = result.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nume = textBox1.Text;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            categorie = comboBox1.Text;
        }

       
    }
}
