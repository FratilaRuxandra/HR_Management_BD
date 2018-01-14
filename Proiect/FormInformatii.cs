using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;

namespace Proiect
{
    public partial class FormInformatii : Form
    {
        string nume;
        string categorie;
        string cale;
        public FormInformatii()
        {
            InitializeComponent();
        }

        private void buttonTotiAngajatii_Click(object sender, EventArgs e)
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
                                     Telefon = c.Numar_Telefon,
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
                                         Telefon = c.Numar_Telefon,
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
                                         Telefon = c.Numar_Telefon,
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
                                         Telefon = c.Numar_Telefon,
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
                                         Telefon = c.Numar_Telefon,
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
                                         Telefon = c.Numar_Telefon,
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
                                         Telefon = c.Numar_Telefon,
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
                                         Telefon = c.Numar_Telefon,
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
                                         Telefon = c.Numar_Telefon,
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

        private void FormInformatii_Load(object sender, EventArgs e)
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
                                     Telefon = c.Numar_Telefon,
                                     Email = c.Email,
                                     Data_Nasterii = c.Data_Nastere,
                                     Data_Angajarii = c.Data_Angajare,
                                     Salariu = c.Salarii.Total,
                                     Proiect = c.Proiecte.Nume_Proiect,
                                     Data_Plecarii = c.Data_Plecare,
                                     Observatii = c.Observatii




                                 };
                    dataGridView1.DataSource = result.ToList();
                    dataGridView1.Columns[0].HeaderText = "ID Angajat";
                    dataGridView1.Columns[9].HeaderText = "Data nasterii";
                    dataGridView1.Columns[10].HeaderText = "Data angajarii";
                    dataGridView1.Columns[13].HeaderText = "Data plecarii";


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSalarii_Click(object sender, EventArgs e)
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
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         Solda_Grad = c.Salarii.Solda_grad,
                                         Solda_Functie = c.Salarii.Solda_functie,
                                         Spor_conditii = c.Salarii.Spor_conditii_de_munca,
                                         Salariu_Total = c.Salarii.Total


                                     };


                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Solda de grad";
                        dataGridView1.Columns[7].HeaderText = "Solda de functie";
                        dataGridView1.Columns[8].HeaderText = "Spor conditii de munca";
                        dataGridView1.Columns[9].HeaderText = "Total Salariu";
                    }

                    if (categorie == "Nume")
                    {
                        var result = from c in context.Angajati
                                     where c.Nume_Angajat.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         Solda_Grad = c.Salarii.Solda_grad,
                                         Solda_Functie = c.Salarii.Solda_functie,
                                         Spor_conditii = c.Salarii.Spor_conditii_de_munca,
                                         Salariu_Total = c.Salarii.Total
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Solda de grad";
                        dataGridView1.Columns[7].HeaderText = "Solda de functie";
                        dataGridView1.Columns[8].HeaderText = "Spor conditii de munca";
                        dataGridView1.Columns[9].HeaderText = "Total Salariu";
                    }

                    if (categorie == "Prenume")
                    {
                        var result = from c in context.Angajati
                                     where c.Prenume_Angajat.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         Solda_Grad = c.Salarii.Solda_grad,
                                         Solda_Functie = c.Salarii.Solda_functie,
                                         Spor_conditii = c.Salarii.Spor_conditii_de_munca,
                                         Salariu_Total = c.Salarii.Total
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Solda de grad";
                        dataGridView1.Columns[7].HeaderText = "Solda de functie";
                        dataGridView1.Columns[8].HeaderText = "Spor conditii de munca";
                        dataGridView1.Columns[9].HeaderText = "Total Salariu";
                    }

                    if (categorie == "Grad")
                    {
                        var result = from c in context.Angajati
                                     where c.Grade.Denumire.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         Solda_Grad = c.Salarii.Solda_grad,
                                         Solda_Functie = c.Salarii.Solda_functie,
                                         Spor_conditii = c.Salarii.Spor_conditii_de_munca,
                                         Salariu_Total = c.Salarii.Total
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Solda de grad";
                        dataGridView1.Columns[7].HeaderText = "Solda de functie";
                        dataGridView1.Columns[8].HeaderText = "Spor conditii de munca";
                        dataGridView1.Columns[9].HeaderText = "Total Salariu";
                    }

                    if (categorie == "Functie")
                    {
                        var result = from c in context.Angajati
                                     where c.Functii.Denumire.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         Solda_Grad = c.Salarii.Solda_grad,
                                         Solda_Functie = c.Salarii.Solda_functie,
                                         Spor_conditii = c.Salarii.Spor_conditii_de_munca,
                                         Salariu_Total = c.Salarii.Total
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Solda de grad";
                        dataGridView1.Columns[7].HeaderText = "Solda de functie";
                        dataGridView1.Columns[8].HeaderText = "Spor conditii de munca";
                        dataGridView1.Columns[9].HeaderText = "Total Salariu";
                    }

                    if (categorie == "Departament")
                    {
                        var result = from c in context.Angajati
                                     where c.Departamente.Nume_Departament.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         Solda_Grad = c.Salarii.Solda_grad,
                                         Solda_Functie = c.Salarii.Solda_functie,
                                         Spor_conditii = c.Salarii.Spor_conditii_de_munca,
                                         Salariu_Total = c.Salarii.Total
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Solda de grad";
                        dataGridView1.Columns[7].HeaderText = "Solda de functie";
                        dataGridView1.Columns[8].HeaderText = "Spor conditii de munca";
                        dataGridView1.Columns[9].HeaderText = "Total Salariu";
                    }


                    if (categorie == "Proiect")
                    {
                        var result = from c in context.Angajati
                                     where c.Proiecte.Nume_Proiect.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         Solda_Grad = c.Salarii.Solda_grad,
                                         Solda_Functie = c.Salarii.Solda_functie,
                                         Spor_conditii = c.Salarii.Spor_conditii_de_munca,
                                         Salariu_Total = c.Salarii.Total
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Solda de grad";
                        dataGridView1.Columns[7].HeaderText = "Solda de functie";
                        dataGridView1.Columns[8].HeaderText = "Spor conditii de munca";
                        dataGridView1.Columns[9].HeaderText = "Total Salariu";
                    }

                    if (categorie == "Anul angajarii")
                    {
                        var result = from c in context.Angajati
                                     where c.Data_Angajare.Year.ToString() == nume
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         Solda_Grad = c.Salarii.Solda_grad,
                                         Solda_Functie = c.Salarii.Solda_functie,
                                         Spor_conditii = c.Salarii.Spor_conditii_de_munca,
                                         Salariu_Total = c.Salarii.Total
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Solda de grad";
                        dataGridView1.Columns[7].HeaderText = "Solda de functie";
                        dataGridView1.Columns[8].HeaderText = "Spor conditii de munca";
                        dataGridView1.Columns[9].HeaderText = "Total Salariu";
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRude_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new HREntities1())
                {

                    if (categorie == "ID")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Rude on c.Id_Angajat equals o.Id_Angajat
                                     where c.Id_Angajat.ToString() == nume
                                     select new
                                     {
                                         ID_Angajat = c.Id_Angajat,
                                         o.Grad_rudenie,
                                         o.Nume,
                                         o.Prenume,
                                         o.CNP

                                     };


                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[1].HeaderText = "Grad de rudenie";

                    }

                    if (categorie == "Nume")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Rude on c.Id_Angajat equals o.Id_Angajat
                                     where c.Nume_Angajat.ToString() == nume
                                     select new
                                     {
                                         ID_Angajat = c.Id_Angajat,
                                         o.Grad_rudenie,
                                         o.Nume,
                                         o.Prenume,
                                         o.CNP
                                     };

                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[1].HeaderText = "Grad de rudenie";
                    }

                    if (categorie == "Prenume")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Rude on c.Id_Angajat equals o.Id_Angajat
                                     where c.Prenume_Angajat.ToString() == nume
                                     select new
                                     {
                                         ID_Angajat = c.Id_Angajat,
                                         o.Grad_rudenie,
                                         o.Nume,
                                         o.Prenume,
                                         o.CNP
                                     };

                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[1].HeaderText = "Grad de rudenie";
                    }

                    if (categorie == "Grad")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Rude on c.Id_Angajat equals o.Id_Angajat
                                     where c.Grade.Denumire.ToString() == nume
                                     select new
                                     {
                                         ID_Angajat = c.Id_Angajat,
                                         o.Grad_rudenie,
                                         o.Nume,
                                         o.Prenume,
                                         o.CNP
                                     };

                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[1].HeaderText = "Grad de rudenie";
                    }

                    if (categorie == "Functie")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Rude on c.Id_Angajat equals o.Id_Angajat
                                     where c.Functii.Denumire.ToString() == nume
                                     select new
                                     {
                                         ID_Angajat = c.Id_Angajat,
                                         o.Grad_rudenie,
                                         o.Nume,
                                         o.Prenume,
                                         o.CNP
                                     };

                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[1].HeaderText = "Grad de rudenie";
                    }

                    if (categorie == "Departament")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Rude on c.Id_Angajat equals o.Id_Angajat
                                     where c.Departamente.Nume_Departament.ToString() == nume
                                     select new
                                     {
                                         ID_Angajat = c.Id_Angajat,
                                         o.Grad_rudenie,
                                         o.Nume,
                                         o.Prenume,
                                         o.CNP
                                     };

                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[1].HeaderText = "Grad de rudenie";
                    }


                    if (categorie == "Proiect")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Rude on c.Id_Angajat equals o.Id_Angajat
                                     where c.Proiecte.Nume_Proiect.ToString() == nume
                                     select new
                                     {
                                         ID_Angajat = c.Id_Angajat,
                                         o.Grad_rudenie,
                                         o.Nume,
                                         o.Prenume,
                                         o.CNP
                                     };

                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[1].HeaderText = "Grad de rudenie";
                    }

                    if (categorie == "Anul angajarii")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Rude on c.Id_Angajat equals o.Id_Angajat
                                     where c.Data_Angajare.Year.ToString() == nume
                                     select new
                                     {
                                         ID_Angajat = c.Id_Angajat,
                                         o.Grad_rudenie,
                                         o.Nume,
                                         o.Prenume,
                                         o.CNP
                                     };

                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[1].HeaderText = "Grad de rudenie";
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFisaMed_Click(object sender, EventArgs e)
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
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Fise_Medicale.Stare_Sanatate,
                                         c.Fise_Medicale.Grupa_Sange,
                                         c.Fise_Medicale.Inaltime,
                                         c.Fise_Medicale.Greutate,


                                     };


                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Stare de sanatate";
                        dataGridView1.Columns[7].HeaderText = "Grupa de sange";

                    }

                    if (categorie == "Nume")
                    {
                        var result = from c in context.Angajati
                                     where c.Nume_Angajat.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Fise_Medicale.Stare_Sanatate,
                                         c.Fise_Medicale.Grupa_Sange,
                                         c.Fise_Medicale.Inaltime,
                                         c.Fise_Medicale.Greutate,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Stare de sanatate";
                        dataGridView1.Columns[7].HeaderText = "Grupa de sange";
                    }

                    if (categorie == "Prenume")
                    {
                        var result = from c in context.Angajati
                                     where c.Prenume_Angajat.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Fise_Medicale.Stare_Sanatate,
                                         c.Fise_Medicale.Grupa_Sange,
                                         c.Fise_Medicale.Inaltime,
                                         c.Fise_Medicale.Greutate,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Stare de sanatate";
                        dataGridView1.Columns[7].HeaderText = "Grupa de sange";
                    }

                    if (categorie == "Grad")
                    {
                        var result = from c in context.Angajati
                                     where c.Grade.Denumire.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Fise_Medicale.Stare_Sanatate,
                                         c.Fise_Medicale.Grupa_Sange,
                                         c.Fise_Medicale.Inaltime,
                                         c.Fise_Medicale.Greutate,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Stare de sanatate";
                        dataGridView1.Columns[7].HeaderText = "Grupa de sange";
                    }

                    if (categorie == "Functie")
                    {
                        var result = from c in context.Angajati
                                     where c.Functii.Denumire.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Fise_Medicale.Stare_Sanatate,
                                         c.Fise_Medicale.Grupa_Sange,
                                         c.Fise_Medicale.Inaltime,
                                         c.Fise_Medicale.Greutate,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Stare de sanatate";
                        dataGridView1.Columns[7].HeaderText = "Grupa de sange";
                    }

                    if (categorie == "Departament")
                    {
                        var result = from c in context.Angajati
                                     where c.Departamente.Nume_Departament.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Fise_Medicale.Stare_Sanatate,
                                         c.Fise_Medicale.Grupa_Sange,
                                         c.Fise_Medicale.Inaltime,
                                         c.Fise_Medicale.Greutate,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Stare de sanatate";
                        dataGridView1.Columns[7].HeaderText = "Grupa de sange";
                    }


                    if (categorie == "Proiect")
                    {
                        var result = from c in context.Angajati
                                     where c.Proiecte.Nume_Proiect.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Fise_Medicale.Stare_Sanatate,
                                         c.Fise_Medicale.Grupa_Sange,
                                         c.Fise_Medicale.Inaltime,
                                         c.Fise_Medicale.Greutate,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Stare de sanatate";
                        dataGridView1.Columns[7].HeaderText = "Grupa de sange";
                    }

                    if (categorie == "Anul angajarii")
                    {
                        var result = from c in context.Angajati
                                     where c.Data_Angajare.Year.ToString() == nume
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Fise_Medicale.Stare_Sanatate,
                                         c.Fise_Medicale.Grupa_Sange,
                                         c.Fise_Medicale.Inaltime,
                                         c.Fise_Medicale.Greutate,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Stare de sanatate";
                        dataGridView1.Columns[7].HeaderText = "Grupa de sange";
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonProiect_Click(object sender, EventArgs e)
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
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Proiecte.Nume_Proiect,
                                         c.Proiecte.Data_Inceput,
                                         c.Proiecte.Data_Sfarsit,

                                     };


                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Proiect";
                        dataGridView1.Columns[7].HeaderText = "Inceput";
                        dataGridView1.Columns[8].HeaderText = "Terminat";

                    }

                    if (categorie == "Nume")
                    {
                        var result = from c in context.Angajati
                                     where c.Nume_Angajat.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Proiecte.Nume_Proiect,
                                         c.Proiecte.Data_Inceput,
                                         c.Proiecte.Data_Sfarsit,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Proiect";
                        dataGridView1.Columns[7].HeaderText = "Inceput";
                        dataGridView1.Columns[8].HeaderText = "Terminat";
                    }

                    if (categorie == "Prenume")
                    {
                        var result = from c in context.Angajati
                                     where c.Prenume_Angajat.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Proiecte.Nume_Proiect,
                                         c.Proiecte.Data_Inceput,
                                         c.Proiecte.Data_Sfarsit,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Proiect";
                        dataGridView1.Columns[7].HeaderText = "Inceput";
                        dataGridView1.Columns[8].HeaderText = "Terminat";
                    }

                    if (categorie == "Grad")
                    {
                        var result = from c in context.Angajati
                                     where c.Grade.Denumire.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Proiecte.Nume_Proiect,
                                         c.Proiecte.Data_Inceput,
                                         c.Proiecte.Data_Sfarsit,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Proiect";
                        dataGridView1.Columns[7].HeaderText = "Inceput";
                        dataGridView1.Columns[8].HeaderText = "Terminat";
                    }

                    if (categorie == "Functie")
                    {
                        var result = from c in context.Angajati
                                     where c.Functii.Denumire.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Proiecte.Nume_Proiect,
                                         c.Proiecte.Data_Inceput,
                                         c.Proiecte.Data_Sfarsit,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Proiect";
                        dataGridView1.Columns[7].HeaderText = "Inceput";
                        dataGridView1.Columns[8].HeaderText = "Terminat";
                    }

                    if (categorie == "Departament")
                    {
                        var result = from c in context.Angajati
                                     where c.Departamente.Nume_Departament.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Proiecte.Nume_Proiect,
                                         c.Proiecte.Data_Inceput,
                                         c.Proiecte.Data_Sfarsit,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Proiect";
                        dataGridView1.Columns[7].HeaderText = "Inceput";
                        dataGridView1.Columns[8].HeaderText = "Terminat";
                    }


                    if (categorie == "Proiect")
                    {
                        var result = from c in context.Angajati
                                     where c.Proiecte.Nume_Proiect.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Proiecte.Nume_Proiect,
                                         c.Proiecte.Data_Inceput,
                                         c.Proiecte.Data_Sfarsit,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Proiect";
                        dataGridView1.Columns[7].HeaderText = "Inceput";
                        dataGridView1.Columns[8].HeaderText = "Terminat";
                    }

                    if (categorie == "Anul angajarii")
                    {
                        var result = from c in context.Angajati
                                     where c.Data_Angajare.Year.ToString() == nume
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         c.Proiecte.Nume_Proiect,
                                         c.Proiecte.Data_Inceput,
                                         c.Proiecte.Data_Sfarsit,
                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[6].HeaderText = "Proiect";
                        dataGridView1.Columns[7].HeaderText = "Inceput";
                        dataGridView1.Columns[8].HeaderText = "Terminat";
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdrese_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new HREntities1())
                {

                    if (categorie == "ID")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Adrese on c.Id_Adresa equals o.Id_Adresa
                                     where c.Id_Angajat.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         o.Strada,
                                         Nr = o.Nr_Strada,
                                         o.Bloc,
                                         o.Apartament,
                                         o.Oras,
                                         o.Judet_Sector



                                     };


                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[11].HeaderText = "Judet/Sector";
                    }

                    if (categorie == "Nume")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Adrese on c.Id_Adresa equals o.Id_Adresa
                                     where c.Nume_Angajat.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         o.Strada,
                                         Nr = o.Nr_Strada,
                                         o.Bloc,
                                         o.Apartament,
                                         o.Oras,
                                         o.Judet_Sector



                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[11].HeaderText = "Judet/Sector";
                    }

                    if (categorie == "Prenume")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Adrese on c.Id_Adresa equals o.Id_Adresa
                                     where c.Prenume_Angajat.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         o.Strada,
                                         Nr = o.Nr_Strada,
                                         o.Bloc,
                                         o.Apartament,
                                         o.Oras,
                                         o.Judet_Sector



                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[11].HeaderText = "Judet/Sector";
                    }

                    if (categorie == "Grad")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Adrese on c.Id_Adresa equals o.Id_Adresa
                                     where c.Grade.Denumire.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         o.Strada,
                                         Nr = o.Nr_Strada,
                                         o.Bloc,
                                         o.Apartament,
                                         o.Oras,
                                         o.Judet_Sector



                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[11].HeaderText = "Judet/Sector";
                    }

                    if (categorie == "Functie")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Adrese on c.Id_Adresa equals o.Id_Adresa
                                     where c.Functii.Denumire.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         o.Strada,
                                         Nr = o.Nr_Strada,
                                         o.Bloc,
                                         o.Apartament,
                                         o.Oras,
                                         o.Judet_Sector



                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[11].HeaderText = "Judet/Sector";
                    }

                    if (categorie == "Departament")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Adrese on c.Id_Adresa equals o.Id_Adresa
                                     where c.Departamente.Nume_Departament.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         o.Strada,
                                         Nr = o.Nr_Strada,
                                         o.Bloc,
                                         o.Apartament,
                                         o.Oras,
                                         o.Judet_Sector



                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[11].HeaderText = "Judet/Sector";
                    }


                    if (categorie == "Proiect")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Adrese on c.Id_Adresa equals o.Id_Adresa
                                     where c.Proiecte.Nume_Proiect.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         o.Strada,
                                         Nr = o.Nr_Strada,
                                         o.Bloc,
                                         o.Apartament,
                                         o.Oras,
                                         o.Judet_Sector



                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[11].HeaderText = "Judet/Sector";
                    }

                    if (categorie == "Anul angajarii")
                    {
                        var result = from c in context.Angajati
                                     join o in context.Adrese on c.Id_Adresa equals o.Id_Adresa
                                     where c.Data_Angajare.Year.ToString().Contains(nume)
                                     select new
                                     {
                                         ID = c.Id_Angajat,
                                         Grad = c.Grade.Denumire,
                                         Nume = c.Nume_Angajat,
                                         Prenume = c.Prenume_Angajat,
                                         Functie = c.Functii.Denumire,
                                         Departament = c.Departamente.Nume_Departament,
                                         o.Strada,
                                         Nr = o.Nr_Strada,
                                         o.Bloc,
                                         o.Apartament,
                                         o.Oras,
                                         o.Judet_Sector



                                     };
                        dataGridView1.DataSource = result.ToList();
                        dataGridView1.Columns[0].HeaderText = "ID Angajat";
                        dataGridView1.Columns[11].HeaderText = "Judet/Sector";
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDepartamente_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new HREntities1();
                var result = from dept in context.Departamente
                             join ang in context.Angajati on dept.Id_Sef_Departament equals ang.Id_Angajat
                             select new
                             {
                                 dept.Nume_Departament,
                                 Sef_Departament = ang.Nume_Angajat,


                             };
                dataGridView1.DataSource = result.ToList();
                dataGridView1.Columns[0].HeaderText = "Departament";
                dataGridView1.Columns[1].HeaderText = "Sef Departament";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonProiecte_Click(object sender, EventArgs e)
        {

            try
            {
                var context = new HREntities1();
                var result = from proj in context.Proiecte
                             join ang in context.Angajati on proj.Id_Responsabil equals ang.Id_Angajat
                             select new
                             {
                                 Nume = proj.Nume_Proiect,
                                 Responsabil = ang.Nume_Angajat,
                                 Inceput = proj.Data_Inceput,
                                 Terminat = proj.Data_Sfarsit
                             };
                dataGridView1.DataSource = result.ToList();
                dataGridView1.Columns[0].HeaderText = "Proiect";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVechime_Click(object sender, EventArgs e)
        {
            var context = new HREntities1();
            var result = from vec in context.Vechime_Angajati
                         join ang in context.Angajati on vec.Id_Angajat equals ang.Id_Angajat
                         select new
                         {
                             vec.Id_Angajat,
                             Functie = ang.Functii.Denumire,
                             Grad = ang.Grade.Denumire,
                             Nume = vec.Nume_Angajat,
                             Prenume = vec.Prenume_Angajat,
                             vec.Vechime
                         };

            dataGridView1.DataSource = result.ToList();
            dataGridView1.Columns[0].HeaderText = "ID Angajat";



        }

        private void textFilename_TextChanged(object sender, EventArgs e)
        {
            cale = textFilename.Text;
        }


        public void CSVExport()
        {
            try
            {
                var csv = new StringBuilder();
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
                                     Telefon = c.Numar_Telefon,
                                     Email = c.Email,
                                     Data_Nasterii = c.Data_Nastere,
                                     Data_Angajarii = c.Data_Angajare,

                                 };


                    foreach (var row in result)
                    {
                        var newline = string.Format("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t\t{6}\t\t{7}\t\t{8}\t\t{9}\t\t{10}", row.ID.ToString().Trim(),
                            row.Nume.ToString().Trim(), row.Prenume.ToString().Trim(), row.Grad.ToString().Trim(),
                            row.Functie.ToString().Trim(), row.Departament.ToString().Trim(), row.CNP.ToString().Trim(), row.Telefon.ToString().Trim(),
                            row.Email.ToString().Trim(), row.Data_Nasterii.ToString().Trim(), row.Data_Angajarii.ToString().Trim());

                        csv.AppendLine(newline);


                    }
                    cale = textFilename.Text;
                    File.WriteAllText(cale, csv.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        
        private void ExcelExport()
        {
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                    throw new Exception("Eroare exportare foaie de calcul!");

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
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
                                     Telefon = c.Numar_Telefon,
                                     Email = c.Email,
                                     Data_Nasterii = c.Data_Nastere,
                                     Data_Angajarii = c.Data_Angajare,
                                    
                                 };


                    int i = 1;
                    foreach (var row in result)
                    {
                        xlWorkSheet.Cells[i, 1] = row.ID.ToString().Trim();
                        xlWorkSheet.Cells[i, 2] = row.Nume.ToString().Trim();
                        xlWorkSheet.Cells[i, 3] = row.Prenume.ToString().Trim();
                        xlWorkSheet.Cells[i, 4] = row.Grad.ToString().Trim();
                        xlWorkSheet.Cells[i, 5] = row.Functie.ToString().Trim();
                        xlWorkSheet.Cells[i, 6] = row.Departament.ToString().Trim();
                        xlWorkSheet.Cells[i, 7] = row.CNP.ToString().Trim();
                        xlWorkSheet.Cells[i, 8] = row.Telefon.ToString().Trim();
                        xlWorkSheet.Cells[i, 9] = row.Email.ToString().Trim();
                        xlWorkSheet.Cells[i, 10] = row.Data_Nasterii.ToString().Trim();
                        xlWorkSheet.Cells[i, 11] = row.Data_Angajarii.ToString().Trim();
                        i++;
                    }
                }
                cale = textFilename.Text;
                xlWorkBook.SaveAs(cale);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PdfExport()
        {
            var Text = new StringBuilder();
            var pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            var htmlparser = new iTextSharp.text.html.simpleparser.HTMLWorker(pdfDoc);
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
                                 Telefon = c.Numar_Telefon,
                                 Email = c.Email,
                                 Data_Nasterii = c.Data_Nastere,
                                 Data_Angajarii = c.Data_Angajare,

                             };

                foreach (var row in result)
                {
                    var newline = string.Format("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t\t{6}\t\t{7}\t\t{8}\t\t{9}\t\t{10}\r\n", row.ID.ToString().Trim(),
                        row.Nume.ToString().Trim(), row.Prenume.ToString().Trim(), row.Grad.ToString().Trim(),
                        row.Functie.ToString().Trim(), row.Departament.ToString().Trim(), row.CNP.ToString().Trim(), row.Telefon.ToString().Trim(),
                        row.Email.ToString().Trim(), row.Data_Nasterii.ToString().Trim(), row.Data_Angajarii.ToString().Trim());

                    Text.AppendLine(newline);


                }
                //foreach (var row in query)
                //{
                //    var newline = string.Format("{0},{1},{2},{3},{4},\r\n", row.Nume.ToString().Trim(),
                //        row.CNP.ToString().Trim(), row.Serie_Buletin.ToString().Trim(), row.Numar_Buletin.ToString().Trim(),
                //        row.Data_Nasterii.ToString().Trim());
                //    Text.AppendLine(newline);
                //}

            }
            using (var memory = new MemoryStream())
            {
                var writer = PdfWriter.GetInstance(pdfDoc, memory);
                pdfDoc.Open();

                htmlparser.Parse(new StringReader(Text.ToString()));
                pdfDoc.Close();

                byte[] bytes = memory.ToArray();
                cale = textFilename.Text;
                File.WriteAllBytes(cale, bytes);


                memory.Close();
            }
        }

        private void buttonExportCSV_Click(object sender, EventArgs e)
        {

            CSVExport();

        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            ExcelExport();
        }

        private void buttonExportPDF_Click(object sender, EventArgs e)
        {
            PdfExport();
        }
    }
    }
    
    
    
    

