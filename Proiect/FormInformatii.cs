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
    public partial class FormInformatii : Form
    {
        string nume;
        string categorie;
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
                                       ID=c.Id_Angajat,
                                       Grad = c.Grade.Denumire,
                                       Nume =c.Nume_Angajat,
                                       Prenume=c.Prenume_Angajat,
                                       Functie=c.Functii.Denumire,
                                       Departament=c.Departamente.Nume_Departament,
                                       Solda_Grad=c.Salarii.Solda_grad,
                                       Solda_Functie=c.Salarii.Solda_functie,
                                       Spor_conditii=c.Salarii.Spor_conditii_de_munca,
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
                                        ID_Angajat=c.Id_Angajat,
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
                                         Nr=o.Nr_Strada,
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
                                   Sef_Departament=ang.Nume_Angajat,


                             };
                dataGridView1.DataSource = result.ToList();
                dataGridView1.Columns[0].HeaderText = "Departament";
                dataGridView1.Columns[1].HeaderText = "Sef Departament";
            }
            catch(Exception ex)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    
    

