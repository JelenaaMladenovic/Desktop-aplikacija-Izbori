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
    public partial class AktivistaDodajForm : Form
    {
        AktivistaBasic aktivista;
        public AktivistaDodajForm()
        {
            InitializeComponent();
            aktivista = new AktivistaBasic();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1Dodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog aktivistu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.aktivista.Ime = txbIme.Text;
                this.aktivista.ImeRoditelja = txbImeRoditelja.Text;
                this.aktivista.Prezime = txbPrezime.Text;
                this.aktivista.DatumRodjenja = datumRodjenja.Value.Date;
                this.aktivista.Adresa = txbAdresa.Text;
                this.aktivista.BrTel = Int32.Parse(txbBrojTelefona.Text);
                this.aktivista.Email = txbEmail.Text;


                List<AktivistaPregled> listaPostojecih = new List<AktivistaPregled>();
                listaPostojecih = DTOManager.vratiSveAktiviste();

                if ((this.aktivista.Ime.Length != 0) && (this.aktivista.ImeRoditelja.Length != 0) && (this.aktivista.Prezime.Length != 0)
                     && (this.aktivista.Adresa.Length != 0) && (this.aktivista.BrTel.ToString().Length != 0)
                    && (this.aktivista.Email.Length != 0))
                {
                    int b = 0;
                    foreach (AktivistaPregled item in listaPostojecih)
                    {
                        if ((item.Ime == this.aktivista.Ime) && (item.ImeRoditelja == this.aktivista.ImeRoditelja) && (item.Prezime == this.aktivista.Prezime)
                            && (item.DatumRodjenja == this.aktivista.DatumRodjenja) && (item.Adresa == this.aktivista.Adresa) && (item.BrTel == this.aktivista.BrTel)
                            && (item.Email == this.aktivista.Email))
                        {
                            b++;
                        }
                    }
                    if (b == 0)
                    {
                        DTOManager.dodajAktivistu(aktivista);
                        MessageBox.Show("Uspesno ste dodali novog aktivistu!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Aktivista vec postoji u listi!");
                    }
                }
                else
                {
                    if ((this.aktivista.Ime.Length == 0) || (this.aktivista.Prezime.Length == 0) || (this.aktivista.ImeRoditelja.Length == 0)
                        || (this.aktivista.DatumRodjenja.ToString().Length == 0) || (this.aktivista.Adresa.Length == 0) || (this.aktivista.BrTel.ToString().Length == 0)
                        || (this.aktivista.Email.Length == 0))
                    {
                        MessageBox.Show("Sva polja moraju biti popunjena!");
                    }
                }
            }
            else
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
