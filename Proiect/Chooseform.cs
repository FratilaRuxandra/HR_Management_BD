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
    public partial class Chooseform : Form
    {
        string grad = ModificaSalarii.procentGrad;
        string functie = ModificaSalarii.procentFunctie;
        string spor = ModificaSalarii.procentSpor;
        public Chooseform()
        {
            InitializeComponent();
        }


        private void btnCreste_Click(object sender, EventArgs e)
        {
            string selected = comboGrad.Text;
            string selectfunctie = comboFunctie.Text;
            var context = new HREntities1();
            if (selected != null)
            {



                if (grad != null)
                {

                    double marire = 0;

                    double newsolda;
                    double.TryParse(grad, out marire);
                    marire = marire / 100;


                    var result = (from c in context.Grade
                                  where c.Denumire.Equals(selected)
                                  select c).First();


                    newsolda =Convert.ToDouble( result.Solda_grad + result.Solda_grad * marire);
                    result.Solda_grad = (int)newsolda;
                    context.SaveChanges();

                    var result1 = (from a in context.Angajati
                                   join g in context.Grade on a.Id_Grad equals g.Id_Grad
                                   where g.Denumire.Equals(selected)
                                   select a.Id_Salariu);

                    foreach (var item in result1)
                    {
                        var salary = (from s in context.Salarii
                                      where s.Id_Salariu == (item)
                                      select s).First();
                        salary.Solda_grad = (int)newsolda;
                        context.SaveChanges();

                    }



                }
            }
            if (selectfunctie != null)
            {

                if (functie != null)
                {

                    double mariref = 0;

                    double newsoldaf;
                    double.TryParse(functie, out mariref);
                    mariref = mariref / 100;


                    var result = (from c in context.Functii
                                  where c.Denumire.Equals(selectfunctie)
                                  select c).First();

                    int aux = (int)result.Solda_functie;
                    newsoldaf = aux + aux * mariref;
                    result.Solda_functie = (int)newsoldaf;
                    context.SaveChanges();

                    var result1 = (from a in context.Angajati
                                   join g in context.Functii on a.Id_Functie equals g.Id_Functie
                                   where g.Denumire.Equals(selectfunctie)
                                   select a.Id_Salariu);
                    foreach (var item in result1)
                    {
                        var salary = (from s in context.Salarii
                                      where s.Id_Salariu == (item)
                                      select s).First();
                        salary.Solda_functie = (int)newsoldaf;
                        context.SaveChanges();

                    }



                }
            }
            if (spor != null)
            {
                double marires = 0;

                double newsoldas;
                double.TryParse(spor, out marires);
                marires = marires / 100;
                var results = from s in context.Salarii
                              select s.Spor_conditii_de_munca;
                foreach (var items in results)
                {
                    var newspor = (from ns in context.Salarii
                                   where ns.Spor_conditii_de_munca == items
                                   select ns).First();
                    int changespor = (int)newspor.Spor_conditii_de_munca;
                    newsoldas = changespor + changespor * marires;
                    newspor.Spor_conditii_de_munca = (int)newsoldas;
                    context.SaveChanges();

                }

            }
            DialogResult res = MessageBox.Show("Marire Efectuata!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Chooseform_Load(object sender, EventArgs e)
        {
            if (grad != null && functie != null)
            {
                comboGrad.Enabled = true;
                comboFunctie.Enabled = true;
            }
            else if (grad != null && functie == null)
            {
                comboGrad.Enabled = true;
                comboFunctie.Enabled = false;
            }
            else if (grad == null && functie != null)
            {
                comboGrad.Enabled = false;
                comboFunctie.Enabled = true;
            }
            else if (grad == null && functie == null)
            {
                comboGrad.Enabled = false;
                comboFunctie.Enabled = false;
            }

            boxSpor.Text = ModificaSalarii.procentSpor;
            if (spor != null)
            {
                boxSpor.Enabled = false;
            }
            else
            {
                boxSpor.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScade_Click(object sender, EventArgs e)
        {
            string selected = comboGrad.Text;
            string selectfunctie = comboFunctie.Text;
            var context = new HREntities1();
            if (selected != null)
            {



                if (grad != null)
                {

                    double marire = 0;

                    double newsolda;
                    double.TryParse(grad, out marire);
                    marire = marire / 100;


                    var result = (from c in context.Grade
                                  where c.Denumire.Equals(selected)
                                  select c).First();


                    newsolda =Convert.ToDouble( result.Solda_grad - result.Solda_grad * marire);
                    result.Solda_grad = (int)newsolda;
                    context.SaveChanges();

                    var result1 = (from a in context.Angajati
                                   join g in context.Grade on a.Id_Grad equals g.Id_Grad
                                   where g.Denumire.Equals(selected)
                                   select a.Id_Salariu);
                    foreach (var item in result1)
                    {
                        var salary = (from s in context.Salarii
                                      where s.Id_Salariu == (item)
                                      select s).First();
                        salary.Solda_grad = (int)newsolda;
                        context.SaveChanges();

                    }



                }

            }
            if (selectfunctie != null)
            {

                if (functie != null)
                {

                    double mariref = 0;

                    double newsoldaf;
                    double.TryParse(functie, out mariref);
                    mariref = mariref / 100;


                    var result = (from c in context.Functii
                                  where c.Denumire.Equals(selectfunctie)
                                  select c).First();

                    int aux = (int)result.Solda_functie;
                    newsoldaf = aux - aux * mariref;
                    result.Solda_functie = (int)newsoldaf;
                    context.SaveChanges();

                    var result1 = (from a in context.Angajati
                                   join g in context.Functii on a.Id_Functie equals g.Id_Functie
                                   where g.Denumire.Equals(selectfunctie)
                                   select a.Id_Salariu);
                    foreach (var item in result1)
                    {
                        var salary = (from s in context.Salarii
                                      where s.Id_Salariu == (item)
                                      select s).First();
                        salary.Solda_functie = (int)newsoldaf;
                        context.SaveChanges();

                    }



                }
            }
            if (spor != null)
            {

                double marires = 0;

                double newsoldas;
                double.TryParse(spor, out marires);
                marires = marires / 100;
                var results = from s in context.Salarii
                              select s.Spor_conditii_de_munca;
                foreach (var items in results)
                {
                    var newspor = (from ns in context.Salarii
                                   where ns.Spor_conditii_de_munca == items
                                   select ns).First();
                    int changespor = (int)newspor.Spor_conditii_de_munca;
                    newsoldas = changespor - changespor * marires;
                    newspor.Spor_conditii_de_munca = (int)newsoldas;
                    context.SaveChanges();

                }
            }
            DialogResult res = MessageBox.Show("Scadere Efectuata!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void boxSpor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
