using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 //departamente, proiecte, functii 

    // la departamente:
    /*
     * -cand sterge un departament sa se asigure ca in departamentul ala nu mai sunt oameni
     * -solda functiei sa se modifice si in salariu 
     * -sa nu poti sterge un proiect daca nu s-a terminat 
     * 
     */
namespace Proiect
{
    public partial class FormMenuAdmin : Form
    {
        bool Depselected = false, Proiectselected = false, Functiiselected = false;
        string nume_dep, nume_nou_dep;
        string nume_sef_curent, nume_sef_nou;
        public FormMenuAdmin()
        {
            InitializeComponent();
        }
        //populari----------------------------------------------------
        private void populate_Departamente(ComboBox comboparam)
        {
            using (var context = new HREntities1())
            {
                var results = from c in context.Departamente
                              select new
                              {
                                  c.Nume_Departament
                              };
                foreach (var item in results)
                {
                    comboparam.Items.Add(item.Nume_Departament);
                }
            }

        }
        private bool resultcontains(int x)
        {
            using (var context = new HREntities1())
            {
                var ids = from c in context.Departamente
                          select new
                          {
                              c.Id_Sef_Departament
                          };
                //var results = from c in context.Angajati
                //              select new
                //              {
                //                  c.Id_Angajat,
                //                  c.Nume_Angajat,
                //                  c.Prenume_Angajat
                //              };
                foreach (var item in ids)
                { 
                   if (item.Id_Sef_Departament == x)
                   {
                            return true;
                   }
                  
                }
                return false;
            }


        }
        private void populate_Sefi(ComboBox comboparam)
        {
            using (var context = new HREntities1())
            {
                var results= from c in context.Angajati
                             select new
                             {
                                 c.Id_Angajat,
                                 c.Nume_Angajat,
                                 c.Prenume_Angajat
                             };
                
               
                foreach (var item in results)
                {
                    if(!resultcontains(item.Id_Angajat))
                    {
                        comboparam.Items.Add(item.Nume_Angajat.ToString() + " " + item.Prenume_Angajat.ToString());
                    }
                }
            }

        }

        private void populate_Functii(ComboBox comboparam)
        {
            using (var context = new HREntities1())
            {
                var results = from c in context.Functii
                              select new
                              {
                                  c.Denumire
                              };
                foreach (var item in results)
                {
                    comboparam.Items.Add(item.Denumire);
                }
            }
        }
        //populari----------------------------------------------------

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            if(Depselected==true)
            {
                panelDepDelete.Visible = false;
                panelModDep.Visible = false;
                panelAdaugaDep.Visible = true;
                panelFuncAdd.Visible= false;
                panelFuncMod.Visible = false;
            }
            if(Functiiselected==true)
            {
                panelFuncAdd.Visible = true;
                panelDepDelete.Visible = false;
                panelModDep.Visible = false;
                panelAdaugaDep.Visible = false;
                panelFuncMod.Visible = false;

            }
            if(Proiectselected==true)
            {
                panelFuncMod.Visible = false;
            }
            
        }

        private void buttonFunctii_Click(object sender, EventArgs e)
        {
            Functiiselected = true;
            Depselected = false;
            Proiectselected = false;
            
        }

        private void buttonProiecte_Click(object sender, EventArgs e)
        {
            Proiectselected = true;
            Functiiselected = false;
            Depselected = false;

        }

        private void buttonDepartamente_Click(object sender, EventArgs e)
        {
            Depselected = true;
            Proiectselected = false;
            Functiiselected = false;
            
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            if(Depselected==true)
            {
                panelDepDelete.Visible = false;
                panelAdaugaDep.Visible = false;
                panelModDep.Visible = true;
                panelFuncMod.Visible = false;
                panelFuncAdd.Visible = false;

            }
            if(Functiiselected==true)
            {
                panelFuncMod.Visible = true;
                panelDepDelete.Visible = false;
                panelAdaugaDep.Visible = false;
                panelModDep.Visible = false;
                panelFuncAdd.Visible = false;
            }
        }


        //
        //
        //
        //delete departament

        private void comboDepDel_SelectedIndexChanged(object sender, EventArgs e)
        {
            nume_dep = comboDepDel.Text;
        }

        private void FinalizareDepDel_Click(object sender, EventArgs e)
        {
            var context = new HREntities1();
            var result = (from c in context.Departamente
                          where c.Nume_Departament.Equals(nume_dep)
                          select c).First();
            var id_dep = (from c in context.Departamente
                          where c.Nume_Departament.Equals(nume_dep)
                          select c.Id_Departament).First();
            
            var angajatiInDep = (from c in context.Angajati
                                 where c.Id_Departament == id_dep
                                 select c).FirstOrDefault();
                                 
            if (angajatiInDep!=null)
            { MessageBox.Show("Transferati angajatii la alt departament inainte de a-l sterge.Modificarea nu a fost efectuata!"); }
            else
            {
                context.Departamente.Remove(result);
                context.SaveChanges();
                panelDepDelete.Visible = false;
            }
            
        }

        private void panelDepDelete_Paint(object sender, PaintEventArgs e)
        {

        }

       

        //
        //
        //
        // end dep delete

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            
            if (Depselected==true)
            {
                panelDepDelete.Visible = true;
                panelAdaugaDep.Visible = false;
                panelModDep.Visible = false;
                panelFuncDel.Visible = false;
            }
            if (Functiiselected == true )
            {
                panelFuncDel.Visible = true;
                panelFuncMod.Visible = false;
                panelDepDelete.Visible = false;
                panelAdaugaDep.Visible = false;
                panelModDep.Visible = false;
                panelFuncAdd.Visible = false;
                
            }
        }
        //modificare dep
        private void FinalizareDepMod_Click(object sender, EventArgs e)
        {

            var context = new HREntities1();
            context.ModifyDepartamente(nume_dep, nume_nou_dep, nume_sef_nou);
            panelModDep.Visible = false;
        }

        private void textNumeDepMod_TextChanged(object sender, EventArgs e)
        {
            nume_nou_dep = textNumeDepMod.Text;
            
        }

        private void labelNumeMod_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBoxDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            nume_dep = comboBoxDep.Text;
            var context = new HREntities1();
            var result = (from c in context.Departamente
                          where c.Nume_Departament.Equals(nume_dep)
                          select c).First();
            var id_dep = (from c in context.Departamente
                          where c.Nume_Departament.Equals(nume_dep)
                          select c.Id_Sef_Departament).First();

            var angajatiInDep = (from c in context.Angajati
                                 where c.Id_Departament == id_dep
                                 select c).FirstOrDefault();
            nume_sef_curent = angajatiInDep.ToString();
           
        }

        private void labelSefDepMod_Click(object sender, EventArgs e)
        {

        }

        private void labelNumeDepMod_Click(object sender, EventArgs e)
        {

        }
        //end modificare dep
        //adaugare dep


        private void comboSefMod_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBoxDep.Items.Add(nume_sef_curent);
            nume_sef_nou = comboSefMod.Text;
            nume_sef_nou = nume_sef_nou.Split(' ')[0];
            MessageBox.Show(nume_sef_nou);
        }
        private void buttonFinalizareAdd_Click(object sender, EventArgs e)
        {
            nume_sef_nou = nume_sef_nou.Split(' ')[0];
            var context = new HREntities1();
            var result = (from c in context.Angajati
                          where c.Nume_Angajat == nume_sef_nou
                          select c.Id_Angajat).First();
            var newDep = new Departamente()
            {
                Nume_Departament = nume_dep,
                Id_Sef_Departament = result
            };
            context.Departamente.Add(newDep);
            context.SaveChanges();
        }

        private void comboSefAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            nume_sef_nou = comboSefAdd.Text;
        }

        private void textNumeDep_TextChanged(object sender, EventArgs e)
        {
            nume_dep = textNumeDep.Text;

        }


        //end adaugare 
        //adaugare functie -----------------------------------
        string functie_noua;
        int solda_functie_noua;
        
       

        private void buttonFinAddFunc_Click(object sender, EventArgs e)
        {
            var context = new HREntities1();
            var newFunc = new Functii()
            {
                Denumire=functie_noua,
                Solda_functie=solda_functie_noua
            };
            context.Functii.Add(newFunc);
            context.SaveChanges();
            panelFuncAdd.Visible = false;
            
        }

        private void textSoldaFunc_TextChanged(object sender, EventArgs e)
        {
            solda_functie_noua = Convert.ToInt32(textSoldaFunc.Text);
        }

        private void textFuncAdd_TextChanged(object sender, EventArgs e)
        {
            functie_noua = textFuncAdd.Text;
        }
        //modifica functie 
        string functia_veche;
        private void buttonFinFuncMod_Click(object sender, EventArgs e)
        {
            var context = new HREntities1();
            var functie= (from c in context.Functii
                                where c.Denumire==functia_veche
                                select c).First();
            functie.Denumire = functie_noua;
            functie.Solda_functie = solda_functie_noua;
            var ang = (from c in context.Angajati
                       where c.Id_Functie == functie.Id_Functie
                       select c.Id_Salariu);
            foreach(var item in ang)
            {
                var result = (from c in context.Salarii
                              where c.Id_Salariu == item
                              select c.Solda_functie).First();
                result = solda_functie_noua;
            }
            context.SaveChanges();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //sterge functie
        
        private void buttonFuncDel_Click(object sender, EventArgs e)
        {
            var context = new HREntities1();
            var result = (from c in context.Functii
                          where c.Denumire==functia_veche
                          select c).First();
            context.Functii.Remove(result);
            context.SaveChanges();
            panelFuncDel.Visible = false;
        }

        private void comboFuncDel_SelectedIndexChanged(object sender, EventArgs e)
        {
            functia_veche = comboFuncDel.Text;
        }

        private void labelDepDel_Click(object sender, EventArgs e)
        {

        }

        //end sterge functie
        private void textFuncMod_TextChanged(object sender, EventArgs e)
        {
            functie_noua = textFuncMod.Text;
        }
        
        private void textSoldaMod_TextChanged(object sender, EventArgs e)
        {
            string aux = textSoldaMod.Text;
            solda_functie_noua = Convert.ToInt32(aux);
        }

        private void comboFuncMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            functia_veche = comboFuncMod.Text;
        }


        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {
            populate_Departamente(comboDepDel);
            populate_Departamente(comboBoxDep);
            populate_Sefi(comboSefMod);
            populate_Sefi(comboSefAdd);
            populate_Functii(comboFuncMod);
            populate_Functii(comboFuncDel);
        }
    }
}
