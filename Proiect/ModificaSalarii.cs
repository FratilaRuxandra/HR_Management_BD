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
    public partial class ModificaSalarii : Form
    {
        public static string procentGrad, procentFunctie, procentSpor;
        public static float marireGrad, marireFunctie, marireSpor;
        public static bool toate = false;
        public ModificaSalarii()
        {
            InitializeComponent();
        }

        private void ModificaSalarii_Load(object sender, EventArgs e)
        {
            List<States> list = new List<States>();
            list.Add(new States() { ID = "01", Name = "-Select-" });
            list.Add(new States() { ID = "02", Name = "Grad" });
            list.Add(new States() { ID = "03", Name = "Functie" });
            list.Add(new States() { ID = "04", Name = "Spor" });
            list.Add(new States() { ID = "05", Name = "Toate" });
            comboBox1.DataSource = list;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            button1.Enabled = false;
            btnAngajati.Enabled = false;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            States obj = comboBox1.SelectedItem as States;
            if (obj.Name.Contains("Grad"))
            {
                boxGrad.Clear();
                panel2.Enabled = true;
                panel3.Enabled = false;
                panel4.Enabled = false;
                boxFunctie.Clear();
                textBox1.Clear();
                button1.Enabled = true;
                btnAngajati.Enabled = true;


            }
            if (obj.Name.Contains("Functie"))
            {
                boxFunctie.Clear();
                panel3.Enabled = true;
                panel2.Enabled = false;
                panel4.Enabled = false;
                textBox1.Clear();
                boxGrad.Clear();
                button1.Enabled = true;
                btnAngajati.Enabled = true;

            }
            if (obj.Name.Contains("Spor"))
            {
                textBox1.Clear();
                panel3.Enabled = false;
                panel4.Enabled = true;
                panel2.Enabled = false;
                boxGrad.Clear();
                boxFunctie.Clear();
                button1.Enabled = true;
                btnAngajati.Enabled = true;
            }
            if (obj.Name.Contains("-Select-"))
            {
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
                boxGrad.Clear();
                boxFunctie.Clear();
                textBox1.Clear();
                button1.Enabled = false;
                btnAngajati.Enabled = false;

            }
            if (obj.Name.Contains("Toate"))
            {
                panel2.Enabled = true;
                panel3.Enabled = true;
                panel4.Enabled = true;
                toate = true;
                boxGrad.Clear();
                boxFunctie.Clear();
                textBox1.Clear();
                button1.Enabled = true;
                btnAngajati.Enabled = true;
            }
        }
        private void trecere_rezervaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCancel.PerformClick();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            modfAngajatForm modf_salarii = new modfAngajatForm();
            modf_salarii.Show();
            boxGrad.Clear();
            boxFunctie.Clear();
            textBox1.Clear();


        }

        private void btnAngajati_Click(object sender, EventArgs e)
        {
            Chooseform chsalary = new Chooseform();
            chsalary.Show();
        }



    
    //        boxGrad.Clear();
    //        boxFunctie.Clear();
    //        textBox1.Clear();
    //        var context = new HREntities1();

    //        if (grad != null)
    //        {
    //            double marire = 0;

    //            double newsolda;
    //            double.TryParse(grad, out marire);
    //            marire = marire / 100;


    //            var result = (from c in context.Grade

    //                          join t in context.Angajati on c.Id_Grad equals t.Id_Grad
    //                          where t.Nume_Angajat.Equals(nume) && t.Prenume_Angajat.Equals(prenume)
    //                          select c).First();
    //            newsolda = result.Solda_grad + result.Solda_grad * marire;
    //            result.Solda_grad = (int)newsolda;
    //            context.SaveChanges();



    //            var newsalariu = (from s in context.Angajati
    //                              join a in context.Salarii on s.Id_Salariu equals a.Id_Salariu
    //                              where s.Nume_Angajat.Equals(nume) && s.Prenume_Angajat.Equals(prenume)
    //                              select a).First();
    //            newsalariu.Solda_grad = (int)newsolda;
    //            context.SaveChanges();

    //        }
    //        if (functie != null)
    //        {

    //            double mariref = 0;
    //            double change;
    //            int newsoldaf = 0;
    //            double.TryParse(functie, out mariref);
    //            // mariref = mariref / 100;


    //            var result1 = (from c in context.Functii

    //                           join t in context.Angajati on c.Id_Functie equals t.Id_Functie
    //                           where t.Nume_Angajat.Equals(nume) && t.Prenume_Angajat.Equals(prenume)
    //                           select c).First();
    //            change = (double)result1.Solda_functie;
    //            change = change + (change * (mariref / 100));
    //            newsoldaf = (int)change;
    //            result1.Solda_functie = newsoldaf;
    //            context.SaveChanges();

    //            var newsalariu = (from s1 in context.Angajati
    //                              join a1 in context.Salarii on s1.Id_Salariu equals a1.Id_Salariu
    //                              where s1.Nume_Angajat.Equals(nume) && s1.Prenume_Angajat.Equals(prenume)
    //                              select a1).First();
    //            newsalariu.Solda_functie = (int)newsoldaf;
    //            context.SaveChanges();


    //        }
    //        if (spor != null)
    //        {
    //            double marires = 0;
    //            double changes;
    //            int newsoldas = 0;
    //            double.TryParse(spor, out marires);
    //            // mariref = mariref / 100;


    //            var result1 = (from c in context.Salarii

    //                           join t in context.Angajati on c.Id_Salariu equals t.Id_Salariu
    //                           where t.Nume_Angajat.Equals(nume) && t.Prenume_Angajat.Equals(prenume)
    //                           select c).First();
    //            changes = (double)result1.Spor_conditii_de_munca;
    //            changes = changes + (changes * (marires / 100));
    //            newsoldas = (int)changes;
    //            result1.Spor_conditii_de_munca = newsoldas;

    //            context.SaveChanges();

    //            var newsalariu = (from s2 in context.Angajati
    //                              join a2 in context.Salarii on s2.Id_Salariu equals a2.Id_Salariu
    //                              where s2.Nume_Angajat.Equals(nume) && s2.Prenume_Angajat.Equals(prenume)
    //                              select a2).First();
    //            newsalariu.Spor_conditii_de_munca = (int)newsoldas;
    //            context.SaveChanges();
    //        }
        

    //}

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boxGrad_TextChanged(object sender, EventArgs e)
        {
            procentGrad = boxGrad.Text;
        }

        private void boxFunctie_TextChanged(object sender, EventArgs e)
        {
            procentFunctie = boxFunctie.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           procentSpor = textBox1.Text;
        }
    }
}
