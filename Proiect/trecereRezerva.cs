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
    
    public partial class trecereRezerva : Form
    {
        static string nume, prenume, data;
        static DateTime date;
        public trecereRezerva()
        {
            InitializeComponent();
        }

        private void trecereRezerva_Load(object sender, EventArgs e)
        {

        }

        private void trecere_rezervaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCancel.PerformClick();
                btnRezerva.PerformClick();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            nume = nameBox.Text;
        }

        private void prenumeBox_TextChanged(object sender, EventArgs e)
        {
            prenume = prenumeBox.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            data = textBox1.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trecereRezerva_Load_1(object sender, EventArgs e)
        {

        }

        //TRANZACTIE
        static void TrecereRezerva()
        {
            using (var context = new HREntities1())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {

                    try
                    {

                        IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
                        date = DateTime.Parse(data, culture, System.Globalization.DateTimeStyles.AssumeLocal);
                        DateTime data_plecare = date.Date;

                        var angajat = (from c in context.Angajati
                                       where c.Nume_Angajat.Equals(nume) && c.Prenume_Angajat.Equals(prenume)
                                       select c).First();
                        angajat.Observatii = " Trecut in Rezerva";
                        angajat.Data_Plecare = data_plecare;
                        context.SaveChanges();
                        DialogResult res = MessageBox.Show(nume+" "+prenume+" "+"a fost trecut in rezerva!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        dbContextTransaction.Commit();

                    }

                    catch (Exception)
                    {
                        
                        DialogResult res = MessageBox.Show("Nu exista numele cautat!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        dbContextTransaction.Rollback();
                    }
                }
            }
        }
        private void btnRezerva_Click(object sender, EventArgs e)
        {
            
            TrecereRezerva();
            nameBox.Clear();
            prenumeBox.Clear();
            textBox1.Clear();



        }
    }
}
