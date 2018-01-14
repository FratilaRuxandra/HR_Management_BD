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

            if (procentGrad != null && procentFunctie != null && procentSpor != null)
            {


                modfAngajatForm modf_salarii = new modfAngajatForm();
                modf_salarii.Show();
                boxGrad.Clear();
                boxFunctie.Clear();
                textBox1.Clear();
            }
            else if (procentGrad != null || procentFunctie != null || procentSpor != null)
            {
                modfAngajatForm modf_salarii = new modfAngajatForm();
                modf_salarii.Show();
                boxGrad.Clear();
                boxFunctie.Clear();
                textBox1.Clear();
            }
            else
            {
                DialogResult res = MessageBox.Show("Completati cel putin un camp!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void btnAngajati_Click(object sender, EventArgs e)
        {
            if (procentGrad != null && procentFunctie != null && procentSpor != null)
            {
                Chooseform chsalary = new Chooseform();
                chsalary.Show();

            }
            else if (procentGrad != null || procentFunctie != null || procentSpor != null)
            {
                Chooseform chsalary = new Chooseform();
                chsalary.Show();
            }
            else
            {
                DialogResult res = MessageBox.Show("Completati cel putin un camp!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }






        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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
