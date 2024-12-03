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
    public partial class KoordinatorDodajForm : Form
    {
        KoordinatorBasic koordinator;
        public KoordinatorDodajForm()
        {
            InitializeComponent();
            koordinator = new KoordinatorBasic();
        }

        private void button1Dodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog koordinatora?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.koordinator.Ime = txbIme.Text;
                this.koordinator.ImeRoditelja = txbImeRoditelja.Text;
                this.koordinator.Prezime = txbPrezime.Text;
                this.koordinator.DatumRodjenja = datumRodjenja.Value;
                this.koordinator.Adresa = txbAdresa.Text;
                this.koordinator.BrTel = Int32.Parse(txbBrTel.Text);
                this.koordinator.Email = txbEmail.Text;
                this.koordinator.ImeOpstine = txbImeOpstine.Text;
                this.koordinator.AdresaKancelarije = txbAdresaKancelarije.Text;

                List<KoordinatorPregled> listaPostojecih = new List<KoordinatorPregled>();
                listaPostojecih = DTOManager.vratiSveKoordinator();

                if ((this.koordinator.Ime.Length != 0) && (this.koordinator.ImeRoditelja.Length != 0) && (this.koordinator.Prezime.Length != 0)
                    && (this.koordinator.Adresa.Length != 0) && (this.koordinator.BrTel.ToString().Length != 0)
                    && (this.koordinator.Email.Length != 0))
                {
                    int b = 0;
                    foreach (KoordinatorPregled item in listaPostojecih)
                    {
                        if ((item.Ime == this.koordinator.Ime) && (item.ImeRoditelja == this.koordinator.ImeRoditelja) && (item.Prezime == this.koordinator.Prezime)
                            && (item.DatumRodjenja == this.koordinator.DatumRodjenja) && (item.Adresa == this.koordinator.Adresa) && (item.BrTel == this.koordinator.BrTel)
                            && (item.Email == this.koordinator.Email)&& (item.ImeOpstine == this.koordinator.ImeOpstine) && (item.AdresaKancelarije == this.koordinator.AdresaKancelarije))
                        {
                            b++;
                        }
                    }
                    if (b == 0)
                    {
                        DTOManager.dodajKoordinatora(this.koordinator);
                        MessageBox.Show("Uspesno ste dodali novog koordinatora!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Koordinator vec postoji u listi!");
                    }
                }
                else
                {
                    if ((this.koordinator.Ime.Length == 0) || (this.koordinator.Prezime.Length == 0) || (this.koordinator.ImeRoditelja.Length == 0)
                         || (this.koordinator.Adresa.Length == 0) || (this.koordinator.BrTel.ToString().Length == 0)
                        || (this.koordinator.ImeOpstine.Length == 0) || (this.koordinator.ImeOpstine.Length == 0) || (this.koordinator.AdresaKancelarije.Length == 0))
                    {
                        MessageBox.Show("Sva polja moraju biti popunjena!");
                    }
                }
            }
            else
            {

            }
        }

        private void txbIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void KoordinatorDodajForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
