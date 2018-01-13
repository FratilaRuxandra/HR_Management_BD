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
        string grad, functie, spor,nume,prenume;
        float modificare;
        public modfAngajatForm()
        {
            InitializeComponent();
        }

        private void modfAngajatForm_Load(object sender, EventArgs e)
        {
            bool check = false;
             grad=textBox2.Text = ModificaSalarii.procentGrad;
             functie=textBox3.Text = ModificaSalarii.procentFunctie;
             spor =textBox4.Text = ModificaSalarii.procentSpor;
            if(grad!=null && functie!=null && spor!=null)
            {
                check = true;
            }
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox2.Enabled = false;
            if (check==true)
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

        }

        private void label4_Click(object sender, EventArgs e)
        {

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
