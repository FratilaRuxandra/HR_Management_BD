using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//departamente, proiecte, functii 

// la departamente:
/*
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

        private void populate_Angajati(ComboBox comboparam)
        {
            using (var context = new HREntities1())
            {
                var results = from c in context.Angajati
                              select new
                              {
                                  c.Nume_Angajat,
                                  c.Prenume_Angajat
                              };
                foreach (var item in results)
                {
                    comboparam.Items.Add(item.Nume_Angajat.ToString() + " " + item.Prenume_Angajat.ToString());
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
        private void populate_Proiecte(ComboBox comboparam)
        {
            using (var context = new HREntities1())
            {
                var results = from c in context.Proiecte
                              select new
                              {
                                  c.Nume_Proiect
                              };
                foreach (var item in results)
                {
                    comboparam.Items.Add(item.Nume_Proiect);
                }
            }
        }

        private void populate_Users(ComboBox comboparam)
        {
            using (var context = new HREntities1())
            {
                var results = from c in context.Logins
                              select new
                              {
                                  c.Username
                              };
                foreach (var item in results)
                {
                    comboparam.Items.Add(item.Username);
                }
            }
        }
        //populari----------------------------------------------------

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            panelLogins.Visible = false;
            if (Depselected==true)
            {
                panelDepDelete.Visible = false;
                panelModDep.Visible = false;
                panelAdaugaDep.Visible = true;
                panelFuncAdd.Visible= false;
                panelFuncMod.Visible = false;
                panelFuncDel.Visible = false;
                panelPrDel.Visible = false;
                panelPrMod.Visible = false;
                panelProiectAdd.Visible = false;
            }
            if(Functiiselected==true)
            {
                panelDepDelete.Visible = false;
                panelModDep.Visible = false;
                panelAdaugaDep.Visible = false;
                panelFuncAdd.Visible = true;
                panelFuncMod.Visible = false;
                panelFuncDel.Visible = false;
                panelPrDel.Visible = false;
                panelPrMod.Visible = false;
                panelProiectAdd.Visible = false;
            }
            if(Proiectselected==true)
            {
                panelDepDelete.Visible = false;
                panelModDep.Visible = false;
                panelAdaugaDep.Visible = false;
                panelFuncAdd.Visible = false;
                panelFuncMod.Visible = false;
                panelFuncDel.Visible = false;
                panelPrDel.Visible = false;
                panelPrMod.Visible = false;
                panelProiectAdd.Visible = true;
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
            panelLogins.Visible = false;
            if (Depselected==true)
            {
                panelDepDelete.Visible = false;
                panelModDep.Visible = true;
                panelAdaugaDep.Visible = false;
                panelFuncAdd.Visible = false;
                panelFuncMod.Visible = false;
                panelFuncDel.Visible = false;
                panelPrDel.Visible = false;
                panelPrMod.Visible = false;
                panelProiectAdd.Visible = false;

            }
            if(Functiiselected==true)
            {
                panelDepDelete.Visible = false;
                panelModDep.Visible = false;
                panelAdaugaDep.Visible = false;
                panelFuncAdd.Visible = false;
                panelFuncMod.Visible = true;
                panelFuncDel.Visible = false;
                panelPrDel.Visible = false;
                panelPrMod.Visible = false;
                panelProiectAdd.Visible = false;
            }
            if(Proiectselected==true)
            {
                panelDepDelete.Visible = false;
                panelModDep.Visible = false;
                panelAdaugaDep.Visible = false;
                panelFuncAdd.Visible = false;
                panelFuncMod.Visible = false;
                panelFuncDel.Visible = false;
                panelPrDel.Visible = false;
                panelPrMod.Visible = true;
                panelProiectAdd.Visible = false;
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
            try
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

                if (angajatiInDep != null)
                { MessageBox.Show("Transferati angajatii la alt departament inainte de a-l sterge.Modificarea nu a fost efectuata!"); }
                else
                {
                    context.Departamente.Remove(result);
                    context.SaveChanges();
                    panelDepDelete.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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
            panelLogins.Visible = false;

            if (Depselected==true)
            {
                panelDepDelete.Visible = true;
                panelModDep.Visible = false;
                panelAdaugaDep.Visible = false;
                panelFuncAdd.Visible = false;
                panelFuncMod.Visible = false;
                panelFuncDel.Visible = false;
                panelPrDel.Visible = false;
                panelPrMod.Visible = false;
                panelProiectAdd.Visible = false;
            }
            if (Functiiselected == true )
            {
                panelDepDelete.Visible = false;
                panelModDep.Visible = false;
                panelAdaugaDep.Visible = false;
                panelFuncAdd.Visible = false;
                panelFuncMod.Visible = false;
                panelFuncDel.Visible = true;
                panelPrDel.Visible = false;
                panelPrMod.Visible = false;
                panelProiectAdd.Visible = false;

            }
            if(Proiectselected==true)
            {
                panelDepDelete.Visible = false;
                panelModDep.Visible = false;
                panelAdaugaDep.Visible = true;
                panelFuncAdd.Visible = false;
                panelFuncMod.Visible = false;
                panelFuncDel.Visible = false;
                panelPrDel.Visible = true;
                panelPrMod.Visible = false;
                panelProiectAdd.Visible = false;
            }
        }
        //modificare dep
        private void FinalizareDepMod_Click(object sender, EventArgs e)
        {

            var context = new HREntities1();
            context.ModifyDepartamente1(nume_dep, nume_nou_dep, nume_sef_nou);
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
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
            try
            {
                var context = new HREntities1();
                var newFunc = new Functii()
                {
                    Denumire = functie_noua,
                    Solda_functie = solda_functie_noua
                };
                context.Functii.Add(newFunc);
                context.SaveChanges();
                panelFuncAdd.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

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
            try
            {
                var context = new HREntities1();
                var functie = (from c in context.Functii
                               where c.Denumire == functia_veche
                               select c).First();
                functie.Denumire = functie_noua;
                functie.Solda_functie = solda_functie_noua;
                var ang = (from c in context.Angajati
                           where c.Id_Functie == functie.Id_Functie
                           select c.Id_Salariu);
                foreach (var item in ang)
                {
                    var result = (from c in context.Salarii
                                  where c.Id_Salariu == item
                                  select c.Solda_functie).First();
                    result = solda_functie_noua;
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //sterge functie
        
        private void buttonFuncDel_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new HREntities1();
                var result = (from c in context.Functii
                              where c.Denumire == functia_veche
                              select c).First();
                context.Functii.Remove(result);
                context.SaveChanges();
                panelFuncDel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
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

        //proiect add
        string nume_proiect, responsabil;
        DateTime datainceput, datasfarsit;

        private void buttonPrAdd_Click(object sender, EventArgs e)
        {
            IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
            try
            {
                datainceput = DateTime.Parse(textDataAdd.Text, culture, System.Globalization.DateTimeStyles.AssumeLocal);
                datasfarsit = DateTime.Parse(textDataSfAdd.Text, culture, System.Globalization.DateTimeStyles.AssumeLocal);
                if (datasfarsit <= datainceput)
                {
                    MessageBox.Show("Data introdusa incorect");
                    panelProiectAdd.Visible = false;
                }

            responsabil = responsabil.Split(' ')[0];
            var context = new HREntities1();
            var result = (from c in context.Angajati
                          where c.Nume_Angajat == responsabil
                          select c.Id_Angajat).First();
            var newProiect = new Proiecte()
            {
                Nume_Proiect = nume_proiect,
                Id_Responsabil = result,
                Data_Inceput = datainceput,
                Data_Sfarsit = datasfarsit
            };
            context.Proiecte.Add(newProiect);
            context.SaveChanges();
            panelProiectAdd.Visible = false;
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                panelProiectAdd.Visible = false;
            }

        }

        private void comboPrAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            responsabil = comboPrAdd.Text;
        }

        private void textDataAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDataSfAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrAdd_TextChanged(object sender, EventArgs e)
        {
            nume_proiect = textPrAdd.Text;
        }

        //proiect mod 
        string nume_proiect_mod;
        private void buttonPrMod_Click(object sender, EventArgs e)
        {
            try
            {
                IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
                datainceput = DateTime.Parse(textDataMod.Text, culture, System.Globalization.DateTimeStyles.AssumeLocal);
                datasfarsit = DateTime.Parse(textDataSfMod.Text, culture, System.Globalization.DateTimeStyles.AssumeLocal);
                if (datasfarsit <= datainceput)
                {
                    MessageBox.Show("Data introdusa incorect");
                    panelPrMod.Visible = false;
                }
                var context = new HREntities1();
                var result = (from c in context.Proiecte
                              where c.Nume_Proiect == nume_proiect
                              select c).First();
                var id = (from c in context.Angajati
                          where c.Nume_Angajat == responsabil
                          select c.Id_Angajat).First();
                result.Nume_Proiect = nume_proiect_mod;
                result.Id_Responsabil = id;
                result.Data_Inceput = datainceput;
                result.Data_Sfarsit = datasfarsit;
                context.SaveChanges();
                panelPrMod.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

      

        private void textPrMod_TextChanged(object sender, EventArgs e)
        {
            nume_proiect_mod = textPrMod.Text;
        }

        private void panelFuncAdd_Paint(object sender, PaintEventArgs e)
        {

        }
        
        

        private void comboResMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            responsabil = comboResMod.Text;
            responsabil = responsabil.Split(' ')[0];
        }

        private void textDataMod_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textDataSfMod_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboPrMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            nume_proiect = comboPrMod.Text;
        }
        //proiect delete
        private void buttonPrDel_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new HREntities1();
                var result = (from c in context.Proiecte
                              where c.Nume_Proiect == comboPrDel.Text
                              select c).First();
                var ang = from c in context.Angajati
                          where c.Id_Proiect_Curent == result.Id_Proiect
                          select c;
                foreach (var item in ang)
                {
                    item.Id_Proiect_Curent = null;
                }
                context.Proiecte.Remove(result);
                context.SaveChanges();
                panelPrDel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        //gestiune parole
        string user, parola1, parola2;
        private void button1_Click(object sender, EventArgs e)
        {
            panelLogins.Visible = true;
            panelDepDelete.Visible = false;
            panelModDep.Visible = false;
            panelAdaugaDep.Visible = false;
            panelFuncAdd.Visible = false;
            panelFuncMod.Visible = false;
            panelFuncDel.Visible = false;
            panelPrDel.Visible = false;
            panelPrMod.Visible = false;
            panelProiectAdd.Visible = false;
        }

        private void buttonFinalizare_Click(object sender, EventArgs e)
        {
            try
            {

                if (parola1 != parola2)
                {
                    MessageBox.Show("Ati introdus noua parola gresit.Reincercati");
                    panelLogins.Visible = false;
                }
                else
                {
                    var context = new HREntities1();
                    var result = (from c in context.Logins
                                  where c.Username == user
                                  select c).First();

                    result.Parola = Convert.ToBase64String(Encoding.Unicode.GetBytes(parola1));
                    context.SaveChanges();
                    panelLogins.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void textParolaNoua_TextChanged(object sender, EventArgs e)
        {
            parola1 = textParolaNoua.Text;
        }

        private void textConfirma_TextChanged(object sender, EventArgs e)
        {
            parola2 = textConfirma.Text;
        }

        private void comboUseri_SelectedIndexChanged(object sender, EventArgs e)
        {
            user = comboUseri.Text;
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {
            populate_Departamente(comboDepDel);
            populate_Departamente(comboBoxDep);
            populate_Sefi(comboSefMod);
            populate_Sefi(comboSefAdd);
            populate_Functii(comboFuncMod);
            populate_Functii(comboFuncDel);
            populate_Angajati(comboResMod);
            populate_Angajati(comboPrAdd);
            populate_Proiecte(comboPrMod);
            populate_Proiecte(comboPrDel);
            populate_Users(comboUseri);

        }
    }
}
