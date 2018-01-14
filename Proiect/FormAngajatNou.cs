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


namespace Proiect
{
    public partial class FormAngajatNou : Form
    {
        string nume, prenume, grad, cnp, telefon,
            email, strada, nr_strada,
            bloc, apartament, localitate, jud_sector,
            functie, departament, proiect, data_nasterestring;
        DateTime data_nastere;
        int id_fisamed = -1;



        public FormAngajatNou()
        {
            InitializeComponent();
        }

        private void populate_Grade()
        {
            using (var context = new HREntities1())
            {
                var results = from c in context.Grade
                              select new
                              {
                                  c.Denumire
                              };
                foreach (var item in results)
                {
                    comboBoxGrade.Items.Add(item.Denumire);
                }
            }

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
                    comboBoxFunctii.Items.Add(item.Denumire);
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
                    comboBoxDepartamente.Items.Add(item.Nume_Departament);
                }
            }
        }
        private void populate_Proiecte()
        {
            using (var context = new HREntities1())
            {
                var results = from c in context.Proiecte
                              select new
                              {
                                  c.Nume_Proiect
                              };
                foreach (var item in results)
                {
                    comboBoxProiect.Items.Add(item.Nume_Proiect);
                }
            }
        }
        private void FormAngajatNou_Load(object sender, EventArgs e)
        {
            populate_Grade();
            populate_Functii();
            populate_Departamente();
            populate_Proiecte();

        }
        private void labelTelefon_Click(object sender, EventArgs e)
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

        private void labelNume_Click(object sender, EventArgs e)
        {

        }

        private void labelPrenume_Click(object sender, EventArgs e)
        {

        }

        private void labelGrad_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

            grad = comboBoxGrade.Text;
        }


        private void labelCNP_Click(object sender, EventArgs e)
        {

        }

        private void textCNP_TextChanged(object sender, EventArgs e)
        {
            cnp = textCNP.Text;
        }

        private void textTelefon_TextChanged(object sender, EventArgs e)
        {
            telefon = textTelefon.Text;
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            email = textEmail.Text;
        }
        private void textDataNastere_TextChanged(object sender, EventArgs e)
        {
            data_nasterestring = textDataNastere.Text;
            

        }

      

        private void labelDataNastere_Click(object sender, EventArgs e)
        {

        }

        private void labelStrada_Click(object sender, EventArgs e)
        {

        }

      


        private void textStrada_TextChanged(object sender, EventArgs e)
        {
            strada = textStrada.Text;
        }

        private void labelNrStrada_Click(object sender, EventArgs e)
        {

        }

        private void textNrStrada_TextChanged(object sender, EventArgs e)
        {
            nr_strada = textNrStrada.Text;
        }

        private void buttonFisaMedicala_Click(object sender, EventArgs e)
        {
            FormFisaMed f = new FormFisaMed();
            f.ShowDialog();
            id_fisamed = f.getIdFisa(); 
        }
        string file;
        private void buttonCV_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (var fbd = new OpenFileDialog())
                {
                    DialogResult result = fbd.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        file = fbd.FileName;

                    }

                
                    var context = new HREntities1();
                    var newCV = new CVuri()
                    {
                        Id_Angajat = 1,
                        Cale_fisier = file
                    };
                    context.CVuri.Add(newCV);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void labelOptional_Click(object sender, EventArgs e)
        {

        }

        private void buttonTabelRude_Click(object sender, EventArgs e)
        {
            FormTabelRude f = new FormTabelRude();
            f.ShowDialog();
            
        }

        private void labelBloc_Click(object sender, EventArgs e)
        {

        }

        private void textBloc_TextChanged(object sender, EventArgs e)
        {
            bloc = textBloc.Text;
        }

        private void labelApartament_Click(object sender, EventArgs e)
        {

        }

        private void textApartament_TextChanged(object sender, EventArgs e)
        {
            apartament = textApartament.Text;
        }

        private void labelOras_Click(object sender, EventArgs e)
        {

        }

        private void textOras_TextChanged(object sender, EventArgs e)
        {
            localitate = textOras.Text;
        }

        private void labelJudSect_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            jud_sector = textJudet.Text;
        }
        private void labelDepartament_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDepartamente_SelectedIndexChanged(object sender, EventArgs e)
        {
            departament = comboBoxDepartamente.Text;
        }
        private void labelFunctie_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFunctii_SelectedIndexChanged(object sender, EventArgs e)
        {
            functie = comboBoxFunctii.Text;
        }
        private void labelProiect_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProiect_SelectedIndexChanged(object sender, EventArgs e)
        {
            proiect = comboBoxProiect.Text;
        }

        private void buttonAddAngajat_Click(object sender, EventArgs e)
        {
            try
            {
                IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
                data_nastere = DateTime.Parse(data_nasterestring, culture, System.Globalization.DateTimeStyles.AssumeLocal);
                using (var context = new HREntities1())
                {
                    var results_grad = (from c in context.Grade
                                        where c.Denumire == grad
                                        select new
                                        {
                                            c.Id_Grad
                                        }).First();
                    var results_functie = (from c in context.Functii
                                           where c.Denumire == functie
                                           select new
                                           {
                                               c.Id_Functie
                                           }).First();
                    var solda_functie = (from c in context.Functii
                                         where c.Denumire == functie
                                         select new
                                         {
                                             c.Solda_functie
                                         }).First();
                    var solda_grad = (from c in context.Grade
                                      where c.Denumire == grad
                                      select new
                                      {
                                          c.Solda_grad
                                      }).First();
                    var results_departament = (from c in context.Departamente
                                               where c.Nume_Departament == departament
                                               select new
                                               {
                                                   c.Id_Departament
                                               }).First();
                    var results_proiect = (from c in context.Proiecte
                                           where c.Nume_Proiect == proiect
                                           select new
                                           {
                                               c.Id_Proiect
                                           }).First();

                    var newAdresa = new Adrese()
                    {
                        Strada = strada,
                        Nr_Strada = Convert.ToInt32(nr_strada),
                        Bloc = bloc,
                        Apartament = Convert.ToInt32(apartament),
                        Oras = localitate,
                        Judet_Sector = jud_sector,

                    };
                    context.Adrese.Add(newAdresa);
                    context.SaveChanges();
                    var newSalariu = new Salarii()
                    {
                        Solda_functie = solda_functie.Solda_functie,
                        Solda_grad = solda_grad.Solda_grad,
                        Spor_conditii_de_munca = 500,
                        Total = solda_functie.Solda_functie + solda_grad.Solda_grad + 100

                    };
                    context.Salarii.Add(newSalariu);
                    context.SaveChanges();
                    var newAngajat = new Angajati()
                    {
                        Nume_Angajat = nume,
                        Prenume_Angajat = prenume,
                        Numar_Telefon = telefon,
                        Email = email,
                        Id_Grad = results_grad.Id_Grad,
                        CNP = cnp,
                        Data_Nastere = data_nastere,
                        Id_Salariu = newSalariu.Id_Salariu,
                        Id_Fisa_Med = id_fisamed,
                        Id_Adresa = newAdresa.Id_Adresa,
                        Id_Functie = results_functie.Id_Functie,
                        Id_Departament = results_departament.Id_Departament,
                        Id_Proiect_Curent = results_proiect.Id_Proiect,
                        Data_Angajare = DateTime.Now

                    };
                    context.Angajati.Add(newAngajat);
                    context.SaveChanges();
                    var update_rude = from c in context.Rude
                                      where c.Id_Angajat == null
                                      select c;

                    foreach (var item in update_rude)
                    {
                        item.Id_Angajat = newAngajat.Id_Angajat;
                    }
                    context.SaveChanges();

                    var update_CV = (from c in context.CVuri
                                     where c.Cale_fisier==file
                                     select c).First();
                    update_CV.Id_Angajat = newAngajat.Id_Angajat;
                   
                    context.SaveChanges();


                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
            
        }
    }

