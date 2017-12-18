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
    public partial class FormAngajatNou : Form
    {
        string nume, prenume, grad, cnp, telefon, 
            email, strada, nr_strada, 
            bloc, apartament, localitate, jud_sector,
            functie, departament,proiect;
        DateTime data_nastere;
        public FormAngajatNou()
        {
            InitializeComponent();
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

        private void labelFunctie_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFunctii_SelectedIndexChanged(object sender, EventArgs e)
        {
            functie = comboBoxFunctii.Text;
        }

        private void labelDepartament_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDepartamente_SelectedIndexChanged(object sender, EventArgs e)
        {
            departament = comboBoxDepartamente.Text;
        }

        private void labelDataNastere_Click(object sender, EventArgs e)
        {

        }

        private void labelStrada_Click(object sender, EventArgs e)
        {
            
        }

        private void textDataNastere_TextChanged(object sender, EventArgs e)
        {
            IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
            data_nastere = DateTime.Parse(textDataNastere.Text, culture, System.Globalization.DateTimeStyles.AssumeLocal);

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

        private void labelProiect_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProiect_SelectedIndexChanged(object sender, EventArgs e)
        {
            proiect = comboBoxProiect.Text;
        }

        private void buttonAddAngajat_Click(object sender, EventArgs e)
        {

        }
    }
}
