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
    public partial class AktivistaForm : Form
    {
        public AktivistaForm()
        {
            InitializeComponent();
        }

        private void btnDodajAktivistu_Click(object sender, EventArgs e)
        {
            AktivistaDodajForm formaDodaj = new AktivistaDodajForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        public void popuniPodacima()
        {
            try
            {
                listViewSveAktiviste.Items.Clear();
                List<AktivistaPregled> podaci = DTOManager.vratiSveAktiviste();



                foreach (AktivistaPregled p in podaci)
                {
                    if ((p.Primedbe != null) && (p.PripadaGlasackomMestu != null))
                    {
                        ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Ime, p.ImeRoditelja, p.Prezime, p.DatumRodjenja.ToString(), p.Adresa, p.BrTel.ToString(), p.Email, p.Primedbe, p.PripadaGlasackomMestu.Id.ToString() });
                        listViewSveAktiviste.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Ime, p.ImeRoditelja, p.Prezime, p.DatumRodjenja.ToString(), p.Adresa, p.BrTel.ToString(), p.Email });
                        listViewSveAktiviste.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            listViewSveAktiviste.Refresh();

        }

        private void btnIzmeniAktivistu_Click(object sender, EventArgs e)
        {
            if (listViewSveAktiviste.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite aktivistu cije podatke zelite da izmenite!");
                return;
            }

            int idAktivista = Int32.Parse(listViewSveAktiviste.SelectedItems[0].SubItems[0].Text);
            AktivistaBasic ob = DTOManager.vratiAktivistu(idAktivista);

            AktivistaIzmeniForm formaIzmeni = new AktivistaIzmeniForm(ob);
            formaIzmeni.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisiAktivistu_Click(object sender, EventArgs e) 
        {
            if (listViewSveAktiviste.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite aktivistu kojeg želite da obrisete!");
                return;
            }
            int idAkcije = Int32.Parse(listViewSveAktiviste.SelectedItems[0].SubItems[0].Text);
            string poruka = $"Da li zelite da obrišete odabranog aktivistu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons); 
                if (result == DialogResult.OK)
                {
                   
                        DTOManager.ObrisiAktivistu(idAkcije);
                        MessageBox.Show($"Uspesno ste obrisali aktivistu sa ID: {idAkcije}!");
                        this.popuniPodacima();
                 }
                 else
                  {
                  }
        }

        private void AktivistaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnRasporedi_Click(object sender, EventArgs e)
        {
            if (listViewSveAktiviste.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite aktivistu kojeg rasporedjujete!");
                return;
            }

            int idAktivista = Int32.Parse(listViewSveAktiviste.SelectedItems[0].SubItems[0].Text);
            AktivistaBasic ob = DTOManager.vratiAktivistu(idAktivista);

            AktivistaRasporedForm formaIzmeni = new AktivistaRasporedForm(ob);
            formaIzmeni.ShowDialog();
            
        }

        private void btnPrimedba_Click(object sender, EventArgs e)
        {
            if (listViewSveAktiviste.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite aktivistu koje!");
                return;
            }

            int idAktivista = Int32.Parse(listViewSveAktiviste.SelectedItems[0].SubItems[0].Text);
            AktivistaBasic ob = DTOManager.vratiAktivistu(idAktivista);

            PrimedbaForm formaIzmeni = new PrimedbaForm(ob);
            formaIzmeni.ShowDialog();
  
            popuniPodacima();
        }
    }
}
