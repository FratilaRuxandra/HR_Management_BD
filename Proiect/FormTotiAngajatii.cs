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
    public partial class FormTotiAngajatii : Form
    {
        public FormTotiAngajatii()
        {
            InitializeComponent();
        }


        private void FormTotiAngajatii_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new HREntities1())
                {
                    var result = from c in context.Angajati
                                 select new
                                 {
                                     ID = c.Id_Angajat,
                                     Nume = c.Nume_Angajat,
                                     Prenume = c.Prenume_Angajat,
                                     Grad = c.Grade.Denumire,
                                     Functie = c.Functii.Denumire,
                                     Departament = c.Departamente.Nume_Departament,
                                     CNP = c.CNP,
                                     Tel = c.Numar_Telefon,
                                     Email = c.Email,
                                     Data_Nasterii = c.Data_Nastere,
                                     Data_Angajarii = c.Data_Angajare,
                                     Salariu = c.Salarii.Total,
                                     Proiect = c.Proiecte.Nume_Proiect,
                                     Data_Plecarii = c.Data_Plecare,
                                     Observatii = c.Observatii




                                 };
                    dataGridTotiAngajatii.DataSource = result.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
