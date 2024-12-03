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
    public partial class PomocnikDodajForm : Form
    {
        PomocnikBasic pomocnik;
        KoordinatorBasic kor;
        public PomocnikDodajForm()
        {
            InitializeComponent();
            pomocnik = new PomocnikBasic();
        }
        public PomocnikDodajForm(KoordinatorBasic kor)
        {
            InitializeComponent();
            pomocnik = new PomocnikBasic();
            this.kor = kor;
        }


        private void txbIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1Dodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog pomocnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.pomocnik.Ime = txbIme.Text;
                this.pomocnik.ImeRoditelja = txbImeRoditelja.Text;
                this.pomocnik.Prezime = txbPrezime.Text;
                this.pomocnik.DatumRodjenja = datumRodjenja.Value.Date;
                this.pomocnik.Adresa = txbAdresa.Text;
                this.pomocnik.BrTel = Int32.Parse(txbBrTel.Text);
                this.pomocnik.Email = txbEmail.Text;

                List<PomocnikPregled> listaPostojecih = new List<PomocnikPregled>();
                listaPostojecih = DTOManager.vratiSvePomocnike();

                if ((this.pomocnik.Ime.Length != 0) && (this.pomocnik.ImeRoditelja.Length != 0) && (this.pomocnik.Prezime.Length != 0)
                    && (this.pomocnik.Adresa.Length != 0) && (this.pomocnik.BrTel.ToString().Length != 0)
                    && (this.pomocnik.Email.Length != 0))
                {
                    int b = 0;
                    foreach (PomocnikPregled item in listaPostojecih)
                    {
                        if ((item.Ime == this.pomocnik.Ime) && (item.ImeRoditelja == this.pomocnik.ImeRoditelja) && (item.Prezime == this.pomocnik.Prezime)
                            && (item.DatumRodjenja == this.pomocnik.DatumRodjenja) && (item.Adresa == this.pomocnik.Adresa) && (item.BrTel == this.pomocnik.BrTel)
                            && (item.Email == this.pomocnik.Email))
                        {
                            b++;
                        }
                    }
                    if (b == 0)
                    {
                        DTOManager.dodajPomocnika(this.pomocnik,kor.Id);
                        //MessageBox.Show("Uspesno ste dodali novog pomocnik!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Pomocnik vec postoji u listi!");
                    }
                }
                else
                {
                    if ((this.pomocnik.Ime.Length == 0) || (this.pomocnik.Prezime.Length == 0) || (this.pomocnik.ImeRoditelja.Length == 0)
                         || (this.pomocnik.Adresa.Length == 0) || (this.pomocnik.BrTel.ToString().Length == 0)
                        || (this.pomocnik.Email.Length == 0))
                    {
                        MessageBox.Show("Sva polja moraju biti popunjena!");
                    }
                }
            }
            else
            {

            }
        }
    }
  }

