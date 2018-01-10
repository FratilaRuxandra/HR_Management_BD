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
    public partial class FormFisaMed : Form
    {
        string inaltime, greutate, grupa, observatii, stare;
        int id_fisamed = -1;
        public FormFisaMed()
        {
            InitializeComponent();
        }
        public int getIdFisa()
        {
            return id_fisamed;
        }
        private void populate_Grupa()
        {
            string[] results = { "A+", "A-", "B+", "B-", "C+", "C-", "AB+", "AB-", "0+", "0-" };
                foreach (var item in results)
                {
                    comboGrupa.Items.Add(item);
                }
            

        }
        private void populate_Stare()
        {
            string[] results = { "Foarte buna","Buna","Medie","Necesita investigatie","Nesatisfacatoare" };
            foreach (var item in results)
            {
                comboStare.Items.Add(item);
            }


        }


        private void labelInaltime_Click(object sender, EventArgs e)
        {

        }

        private void comboGrupa_SelectedIndexChanged(object sender, EventArgs e)
        {
            grupa = comboGrupa.Text;
        }

        private void labelGrupa_Click(object sender, EventArgs e)
        {

        }

        private void labelGreutate_Click(object sender, EventArgs e)
        {
           
        }

        private void labelStareSanatate_Click(object sender, EventArgs e)
        {

        }

        private void labelObservatii_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new HREntities1())
                {
                    var newFisa = new Fise_Medicale()
                    {
                        Inaltime = Convert.ToDouble(inaltime),
                        Greutate = Convert.ToInt32(greutate),
                        Stare_Sanatate = stare,
                        Observatii = observatii,
                        Grupa_Sange = grupa


                    };
                    context.Fise_Medicale.Add(newFisa);
                    context.SaveChanges();
                    id_fisamed = newFisa.Id_FisaMed;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void FormFisaMed_Load(object sender, EventArgs e)
        {
            populate_Grupa();
            populate_Stare();
        }

        private void textInaltime_TextChanged(object sender, EventArgs e)
        {
            inaltime = textInaltime.Text;
        }

        private void textGreutate_TextChanged(object sender, EventArgs e)
        {
            greutate = textGreutate.Text;
        }

        private void comboStare_SelectedIndexChanged(object sender, EventArgs e)
        {
            stare = comboStare.Text;
        }

        private void textObservatii_TextChanged(object sender, EventArgs e)
        {
            observatii = textObservatii.Text;
        }
    }
}
