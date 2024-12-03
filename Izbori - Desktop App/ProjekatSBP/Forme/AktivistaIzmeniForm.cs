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
    public partial class AktivistaIzmeniForm : Form
    {
        public AktivistaBasic aktivista;
        public AktivistaIzmeniForm()
        {
            InitializeComponent();
        }

        public AktivistaIzmeniForm(AktivistaBasic a)
        {
            InitializeComponent();
            this.aktivista = a;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene aktiviste?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.aktivista.Ime = txbIme.Text;
                this.aktivista.Prezime = txbPrezime.Text;
                this.aktivista.Adresa = txbAdresa.Text;
                this.aktivista.BrTel = Int32.Parse(txbBrojTelefona.Text);
                this.aktivista.Email = txbEmail.Text;

                DTOManager.azurirajAktivistu(this.aktivista);
                MessageBox.Show("Azuriranje aktiviste je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }

        private void AktivistaIzmeniForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            txbIme.Text = this.aktivista.Ime;
            txbPrezime.Text = this.aktivista.Prezime;
            txbAdresa.Text = this.aktivista.Adresa;
            txbBrojTelefona.Text = this.aktivista.BrTel.ToString();
            txbEmail.Text = this.aktivista.Email;
        }
    }
}
