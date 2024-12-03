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
    public partial class KoordinatorIzmeniForm : Form
    {
        public KoordinatorBasic koordinator;
        public KoordinatorIzmeniForm()
        {
            InitializeComponent();
        }

        public KoordinatorIzmeniForm(KoordinatorBasic k)
        {
            InitializeComponent();
            this.koordinator = k;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene koordinatora?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.koordinator.Ime = txbIme.Text;
                this.koordinator.Prezime = txbPrezime.Text;
                this.koordinator.Adresa = txbAdresa.Text;
                this.koordinator.BrTel = Int32.Parse(txbBrojTelefona.Text);
                this.koordinator.Email = txbEmail.Text;
                this.koordinator.ImeOpstine = txbImeOpstine.Text;
                this.koordinator.AdresaKancelarije = txbAdrKancelarije.Text;

                DTOManager.azurirajKoordinator(this.koordinator);
                MessageBox.Show("Azuriranje koordinatora je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }

        private void KoordinatorIzmeniForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"Azuriranje koordinatora {koordinator.Ime.ToUpper()}";
        }

        public void popuniPodacima()
        {
            txbIme.Text = this.koordinator.Ime;
            txbPrezime.Text = this.koordinator.Prezime;
            txbAdresa.Text = this.koordinator.Adresa;
            txbBrojTelefona.Text = this.koordinator.BrTel.ToString();
            txbEmail.Text = this.koordinator.Email;
            txbImeOpstine.Text = this.koordinator.ImeOpstine;
            txbAdrKancelarije.Text = this.koordinator.AdresaKancelarije;
        }

        private void txbAdrKancelarije_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
