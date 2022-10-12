using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Delivery
{
    public partial class Form2 : Form
    {

        List<Pizza> comanda_client;

        Dictionary<int, string> adrese = new Dictionary<int, string>();
        //DataSet DSClienti = new DataSet();
        //string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Proiect;Integrated Security=True";
        //string SelectCommand = "Select * from dbo.Clienti";


        public Form2(List<Pizza> comanda)
        {
            comanda_client = comanda;
            InitializeComponent();
        }

        //afisare date din fisier text
        private void buttonBon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            StreamReader sr = new StreamReader("comanda.txt");
            textBoxBon.TextAlign = HorizontalAlignment.Center;
            textBoxBon.Text = "BON COMANDA" + Environment.NewLine;
            textBoxBon.Text += sr.ReadToEnd();
            textBoxBon.Text += "--------------------------------------------------------";
            textBoxBon.Text += "Valoare comanda: " + textBoxValoare.Text + " RON";
        }


        // lipseste private void tb_cod_KeyPress
        ErrorProvider errorProvider1 = new ErrorProvider();
        private void buttonCalculeaza_Click(object sender, EventArgs e)
        {
            float valoare = 0;
            if (textBoxNume.Text == "")
            {
                errorProvider1.SetError(textBoxNume, "Introduceti numele!");
            }
            else if (textBoxTelefon.Text == "")
            {
                errorProvider1.SetError(textBoxTelefon, "Introduceti numarul de telefon!");
            }
            else if (textBoxStrada.Text == "")
            {
                errorProvider1.SetError(textBoxStrada, "Introduceti numele strazii!");
            }
            else if (textBoxNumar.Text == "")
            {
                errorProvider1.SetError(textBoxNumar, "Introduceti numarul strazii!");
            }
            else
            {
                try
                {
                    string nume = textBoxNume.Text;
                    string nr_tel = textBoxNumar.Text;
                    string plata = comboBox1.SelectedText;
                    Client c = new Client(nume, plata, nr_tel, comanda_client);
                    string nume_strada = textBoxStrada.Text;
                    int nr_strada = Convert.ToInt32(textBoxNumar.Text);

                    Adresa a = new Adresa(nume_strada, nr_strada);

                    valoare = c.calculeaza_comanda(comanda_client);
                    string valoare_comanda = valoare.ToString();
                    textBoxValoare.Text = valoare_comanda;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        void pd_print(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBoxBon.Text, new Font("Calibri", 16), new SolidBrush(Color.Black), 150.0F, 150.0F);
        }

        
        private void textBoxBon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                StreamReader sr = new StreamReader("comanda.txt");
                textBoxBon.Text = "BON COMANDA" + Environment.NewLine;
                textBoxBon.Text += sr.ReadToEnd();
                textBoxBon.Text += "--------------------------------------------------------";
                textBoxBon.Text += "Valoare comanda: " + textBoxValoare.Text + " RON";
            }
            if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(pd_print);

                PrintPreviewDialog dlg = new PrintPreviewDialog();
                dlg.Document = pd;
                dlg.ShowDialog();
            }
            if (e.KeyCode == Keys.W && e.Modifiers == Keys.Control)
            {
                textBoxBon.Clear();
            }
        }

        private void buttonAnuleaza_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Esti sigur ca vrei sa anulezi comanda?", "Intrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Close();
        }

        // string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Proiect;Integrated Security=True";

        //private void IncarcaDate()
        //{
        //    SqlConnection conexiune = new SqlConnection(stringConexiune);
        //    conexiune.Open();
        //    //SqlDataAdapter adaptor = new SqlDataAdapter(SelectCommand, conexiune);
        //}

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            // string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Proiect;Integrated Security=True";

        }

        private void buttonAnuleaza_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Esti sigur ca vrei sa anulezi comanda?", "Intrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Close();
        }

        private void buttonCalculeaza_Click_1(object sender, EventArgs e)
        {
            float valoare = 0;
            if (textBoxNume.Text == "")
            {
                errorProvider1.SetError(textBoxNume, "Introduceti numele!");
            }
            else if (textBoxTelefon.Text == "")
            {
                errorProvider1.SetError(textBoxTelefon, "Introduceti numarul de telefon!");
            }
            else if (textBoxStrada.Text == "")
            {
                errorProvider1.SetError(textBoxStrada, "Introduceti numele strazii!");
            }
            else if (textBoxNumar.Text == "")
            {
                errorProvider1.SetError(textBoxNumar, "Introduceti numarul strazii!");
            }
            else
            {
                try
                {
                    string nume = textBoxNume.Text;
                    string nr_tel = textBoxNumar.Text;
                    string plata = comboBox1.SelectedText;
                    Client c = new Client(nume, plata, nr_tel, comanda_client);
                    string nume_strada = textBoxStrada.Text;
                    int nr_strada = Convert.ToInt32(textBoxNumar.Text);

                    Adresa a = new Adresa(nume_strada, nr_strada);

                    valoare = c.calculeaza_comanda(comanda_client);
                    string valoare_comanda = valoare.ToString();
                    textBoxValoare.Text = valoare_comanda;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
        

        

        