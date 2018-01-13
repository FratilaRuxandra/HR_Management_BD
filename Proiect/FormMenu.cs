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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
       

        private void buttonAngajatNou_Click(object sender, EventArgs e)
        {
            FormAngajatNou formAngajatNou = new FormAngajatNou();
            //this.Hide();
            formAngajatNou.ShowDialog();
            this.Show();
        }

        private void buttonModificariAngajati_Click(object sender, EventArgs e)
        {
            FormTEST formTransfer = new FormTEST();
            //this.Hide();
            formTransfer.ShowDialog();
            this.Show();
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            FormTransfer formTransfer = new FormTransfer();
            //this.Hide();
            formTransfer.ShowDialog();
            this.Show();
        }

        private void buttonRezerva_Click(object sender, EventArgs e)
        {
            trecereRezerva trecere_rezerva = new trecereRezerva();
            trecere_rezerva.Show();
        }

        

        private void buttonVeziInfo_Click(object sender, EventArgs e)
        {
            FormInfoAngajati formInfoAngajati = new FormInfoAngajati();
            formInfoAngajati.ShowDialog();
        }

        private void btnSalarii_Click(object sender, EventArgs e)
        {
            ModificaSalarii modf = new ModificaSalarii();
            modf.Show();
        }
    }
}
