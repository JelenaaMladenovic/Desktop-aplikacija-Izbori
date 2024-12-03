using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatSBP.Forme
{
    public partial class PomocnikIzmeniForm : Form
    {
        public PomocnikBasic pomocnik;
        public PomocnikIzmeniForm()
        {
            InitializeComponent();
        }

        public PomocnikIzmeniForm(PomocnikBasic p)
        {
            InitializeComponent();
            this.pomocnik = p;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene pomocnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.pomocnik.Ime = txbIme.Text;
                this.pomocnik.Prezime = txbPrezime.Text;
                this.pomocnik.Adresa = txbAdresa.Text;
                this.pomocnik.BrTel = Int32.Parse(txbBrojTelefona.Text);
                this.pomocnik.Email = txbEmail.Text;

                DTOManager.azurirajPomocnika(this.pomocnik);
                MessageBox.Show("Azuriranje pomocnika je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }

        private void PomocnikIzmeniForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"Azuriranje pomocnika {pomocnik.Ime.ToUpper()}";
        }

        public void popuniPodacima()
        {
            txbIme.Text = this.pomocnik.Ime;
            txbPrezime.Text = this.pomocnik.Prezime;
            txbAdresa.Text = this.pomocnik.Adresa;
            txbBrojTelefona.Text = this.pomocnik.BrTel.ToString();
            txbEmail.Text = this.pomocnik.Email;
        }
    }
}
