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
    public partial class modfAngajatForm : Form
    {
        string grad, functie, spor, nume, prenume;

        public modfAngajatForm()
        {
            InitializeComponent();
        }

        private void modfAngajatForm_Load(object sender, EventArgs e)
        {
            bool check = false;
            grad = textBox2.Text = ModificaSalarii.procentGrad;
            functie = textBox3.Text = ModificaSalarii.procentFunctie;
            spor = textBox4.Text = ModificaSalarii.procentSpor;
            if (grad != null && functie != null && spor != null)
            {
                check = true;
            }
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox2.Enabled = false;
            if (check == true)
            {
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox2.Enabled = false;
            }

        }

        private void boxName_TextChanged(object sender, EventArgs e)
        {
            nume = boxName.Text;
        }

        //prenume
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            prenume = textBox1.Text;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            var context = new HREntities1();

            if (grad != null)
            {
                double marire = 0;

                double newsolda;
                double.TryParse(grad, out marire);
                marire = marire / 100;
               
                
                    var result = (from c in context.Grade

                                  join t in context.Angajati on c.Id_Grad equals t.Id_Grad
                                  where t.Nume_Angajat.Equals(nume) && t.Prenume_Angajat.Equals(prenume)
                                  select c).First();
                    newsolda =Convert.ToDouble(result.Solda_grad + result.Solda_grad * marire);
                    result.Solda_grad = (int)newsolda;
                context.SaveChanges();



                var newsalariu = (from s in context.Angajati
                                   join a in context.Salarii on s.Id_Salariu equals a.Id_Salariu
                                  where s.Nume_Angajat.Equals(nume) && s.Prenume_Angajat.Equals(prenume)
                                  select a).First();
                newsalariu.Solda_grad = (int)newsolda;
                newsalariu.Total = newsalariu.Spor_conditii_de_munca + newsalariu.Solda_grad + newsalariu.Solda_functie;
                context.SaveChanges();
                
            }
            if (functie != null)
            {

                double mariref = 0;
                double change;
                int newsoldaf=0;
                double.TryParse(functie, out mariref);
               // mariref = mariref / 100;
                
                
                    var result1 = (from c in context.Functii

                                  join t in context.Angajati on c.Id_Functie equals t.Id_Functie
                                  where t.Nume_Angajat.Equals(nume) && t.Prenume_Angajat.Equals(prenume)
                                  select c).First();
                change = (double)result1.Solda_functie;
                change = change + (change *( mariref / 100));
                newsoldaf = (int)change;
                 result1.Solda_functie=newsoldaf;
                    context.SaveChanges();

                var newsalariu = (from s1 in context.Angajati
                                  join a1 in context.Salarii on s1.Id_Salariu equals a1.Id_Salariu
                                  where s1.Nume_Angajat.Equals(nume) && s1.Prenume_Angajat.Equals(prenume)
                                  select a1).First();
                newsalariu.Solda_functie = (int)newsoldaf;
                newsalariu.Total = newsalariu.Solda_functie + newsalariu.Solda_grad + newsalariu.Spor_conditii_de_munca;
                context.SaveChanges();


            }
            if(spor!=null)
            {
                double marires = 0;
                double changes;
                int newsoldas = 0;
                double.TryParse(spor, out marires);
                // mariref = mariref / 100;


                var result1 = (from c in context.Salarii

                               join t in context.Angajati on c.Id_Salariu equals t.Id_Salariu
                               where t.Nume_Angajat.Equals(nume) && t.Prenume_Angajat.Equals(prenume)
                               select c).First();
                changes = (double)result1.Spor_conditii_de_munca;
                changes = changes + (changes * (marires / 100));
                newsoldas = (int)changes;
                result1.Spor_conditii_de_munca = newsoldas;

                context.SaveChanges();

                var newsalariu = (from s2 in context.Angajati
                                  join a2 in context.Salarii on s2.Id_Salariu equals a2.Id_Salariu
                                  where s2.Nume_Angajat.Equals(nume) && s2.Prenume_Angajat.Equals(prenume)
                                  select a2).First();
                newsalariu.Spor_conditii_de_munca = (int)newsoldas;
                newsalariu.Total = newsalariu.Spor_conditii_de_munca + newsalariu.Solda_grad + newsalariu.Solda_functie;
                context.SaveChanges();

                
            }
        }
    


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnScade_Click(object sender, EventArgs e)
        {
            var context = new HREntities1();

            if (grad != null)
            {
                double marire = 0;

                double newsolda;
                double.TryParse(grad, out marire);
                marire = marire / 100;


                var result = (from c in context.Grade

                              join t in context.Angajati on c.Id_Grad equals t.Id_Grad
                              where t.Nume_Angajat.Equals(nume) && t.Prenume_Angajat.Equals(prenume)
                              select c).First();
                newsolda = Convert.ToDouble(result.Solda_grad -result.Solda_grad * marire);
                result.Solda_grad = (int)newsolda;
                context.SaveChanges();



                var newsalariu = (from s in context.Angajati
                                  join a in context.Salarii on s.Id_Salariu equals a.Id_Salariu
                                  where s.Nume_Angajat.Equals(nume) && s.Prenume_Angajat.Equals(prenume)
                                  select a).First();
                newsalariu.Solda_grad = (int)newsolda;
                newsalariu.Total = newsalariu.Spor_conditii_de_munca + newsalariu.Solda_grad + newsalariu.Solda_functie;
                context.SaveChanges();

            }
            if (functie != null)
            {

                double mariref = 0;
                double change;
                int newsoldaf = 0;
                double.TryParse(functie, out mariref);
                // mariref = mariref / 100;


                var result1 = (from c in context.Functii

                               join t in context.Angajati on c.Id_Functie equals t.Id_Functie
                               where t.Nume_Angajat.Equals(nume) && t.Prenume_Angajat.Equals(prenume)
                               select c).First();
                change = (double)result1.Solda_functie;
                change = change-(change * (mariref / 100));
                newsoldaf = (int)change;
                result1.Solda_functie = newsoldaf;
                context.SaveChanges();

                var newsalariu = (from s1 in context.Angajati
                                  join a1 in context.Salarii on s1.Id_Salariu equals a1.Id_Salariu
                                  where s1.Nume_Angajat.Equals(nume) && s1.Prenume_Angajat.Equals(prenume)
                                  select a1).First();
                newsalariu.Solda_functie = (int)newsoldaf;
                newsalariu.Total = newsalariu.Spor_conditii_de_munca + newsalariu.Solda_grad + newsalariu.Solda_functie;
                context.SaveChanges();


            }
            if (spor != null)
            {
                double marires = 0;
                double changes;
                int newsoldas = 0;
                double.TryParse(spor, out marires);
                // mariref = mariref / 100;


                var result1 = (from c in context.Salarii

                               join t in context.Angajati on c.Id_Salariu equals t.Id_Salariu
                               where t.Nume_Angajat.Equals(nume) && t.Prenume_Angajat.Equals(prenume)
                               select c).First();
                changes = (double)result1.Spor_conditii_de_munca;
                changes = changes - (changes * (marires / 100));
                newsoldas = (int)changes;
                result1.Spor_conditii_de_munca = newsoldas;

                context.SaveChanges();

                var newsalariu = (from s2 in context.Angajati
                                  join a2 in context.Salarii on s2.Id_Salariu equals a2.Id_Salariu
                                  where s2.Nume_Angajat.Equals(nume) && s2.Prenume_Angajat.Equals(prenume)
                                  select a2).First();
                newsalariu.Spor_conditii_de_munca = (int)newsoldas;
                newsalariu.Total = newsalariu.Spor_conditii_de_munca + newsalariu.Solda_grad + newsalariu.Solda_functie;
                context.SaveChanges();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
