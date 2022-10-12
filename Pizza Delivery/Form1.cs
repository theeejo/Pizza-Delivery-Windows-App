using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Delivery
{
    public partial class Form1 : Form
    {
        // string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Proiect;Integrated Security=True";

        List<Pizza> comanda = new List<Pizza>();
        Pizza pizza;
        public Form1()
        {
            InitializeComponent();
            
          //  pizza.ev_modificare += Pizza_ev_modificare;
        }
        private void Pizza_ev_modificare(object sender, EventArgs e)
        {
            Pizza locp = (Pizza)sender;
            listView1.Items.Clear();
            if (listView1.Items.Count == 0) buttonSterge.Enabled = false;
            else
            {
                buttonSterge.Enabled = true;
               // listView1.Items[(e).Index].Selected = true;
            }
        }
        
        private void buttonAdaugaComanda_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem itm = new ListViewItem(comboBox1.SelectedItem.ToString());
                
                string denumire = itm.Text;
                string[] extra_topping = new string[checkedListBoxTopping.CheckedItems.Count];
                string topping = "";
                for(int i = 0; i < checkedListBoxTopping.CheckedItems.Count; i++)
                {
                    topping += checkedListBoxTopping.CheckedItems[i].ToString() + ";";
                }
                extra_topping = topping.Split(';'); //transformam string in string[]
                Pizza p = new Pizza(denumire, extra_topping);

                itm.SubItems.Add(p.calculeaza_dupa_nume().ToString());

                itm.SubItems.Add(topping);

                textBoxPret.Text = p.calculeaza_total().ToString();
                itm.SubItems.Add(textBoxPret.Text);
                listView1.Items.Add(itm);

                MessageBox.Show("Produs adaugat! Pentru finalizare apasati 'Finalizeaza Comanda'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                comboBox1.ResetText();
                textBoxPret.Clear();
                foreach(int i in checkedListBoxTopping.CheckedIndices)
                {
                    checkedListBoxTopping.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        

        private void buttonFinalizeazaComanda_Click(object sender, EventArgs e)
        {
            double pret = 0;

            DialogResult dialogResult = MessageBox.Show("Ati finalizat comanda?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                FileStream fs = new FileStream("comanda.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);



                foreach (ListViewItem itm in listView1.Items)
                {
                    Pizza p = new Pizza();
                    sw.WriteLine("Pizza " + itm.Text + " cu extra toppingurile " + itm.SubItems[2].Text + " are pretul de " + itm.SubItems[3].Text);
                    pret += Convert.ToDouble(itm.SubItems[3].Text);
                    p.Extra_Topping = itm.SubItems[2].Text.Split(';');
                    p.Denumire = itm.Text;
                    comanda.Add(p);
                }
                sw.Close();


                Form2 form = new Form2(comanda);
                form.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Continuati comanda.");
            }
        }

        private void buttonFinalizeazaComanda_Click1(object sender, EventArgs e)
        {
            double pret = 0;

            DialogResult dialogResult = MessageBox.Show("Ati finalizat comanda?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                FileStream fs = new FileStream("comanda.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);



                foreach (ListViewItem itm in listView1.Items)
                {
                    Pizza p = new Pizza();
                    sw.WriteLine("Pizza " + itm.Text + " cu extra toppingurile " + itm.SubItems[2].Text + " are pretul de " + itm.SubItems[3].Text);
                    pret += Convert.ToDouble(itm.SubItems[3].Text);
                    p.Extra_Topping = itm.SubItems[2].Text.Split(';');
                    p.Denumire = itm.Text;
                    comanda.Add(p);
                }
                sw.Close();


                Form2 form = new Form2(comanda);
                form.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Continuati comanda.");
            }
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.Yes == MessageBox.Show("Esti sigur ca vrei sa stergi produsul?", "Intrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                pizza.sterge_pizza(listView1.SelectedItems[0].Index, listView1);
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(Keys.Delete == e.KeyCode)
            {
                foreach(ListViewItem listViewItem in ((ListView)sender).SelectedItems)
                {
                    listViewItem.Remove();
                }
            }
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comanda anulata. O zi buna!");
            this.Close();
        }



  



    }
    
}
