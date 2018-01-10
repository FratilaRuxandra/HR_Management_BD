using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

//neterminata ptr ca am  gresit baza de date #lacrima 
namespace Proiect
{
    public partial class  FormTabelRude : Form
    {
        string grad_rudenie, nume, prenume, cnp;
        public FormTabelRude()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void textGrad_TextChanged(object sender, EventArgs e)
        {
            grad_rudenie = textGrad.Text;
        }

        private void labelNume_Click(object sender, EventArgs e)
        {

        }

        private void labelPrenume_Click(object sender, EventArgs e)
        {

        }

        private void labelCNP_Click(object sender, EventArgs e)
        {

        }

        private void labelGradRudenie_Click(object sender, EventArgs e)
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

        private void textCNP_TextChanged(object sender, EventArgs e)
        {
            cnp = textCNP.Text;
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new HREntities1())
                {
                    var newRuda = new Rude()
                    {
                        Grad_rudenie = grad_rudenie,
                        Nume = nume,
                        Prenume = prenume,
                        CNP = cnp


                    };
                    context.Rude.Add(newRuda);
                    context.SaveChanges();
                    ClearTextBoxes();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }
    }
}
