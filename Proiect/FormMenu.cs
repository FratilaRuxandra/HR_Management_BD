﻿using System;
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
            this.Hide();
            formAngajatNou.ShowDialog();
            this.Show();
        }

     
    }
}
