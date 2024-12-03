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
    public partial class PomocnikForm : Form
    {
        KoordinatorBasic koor;
        public PomocnikForm()
        {
            InitializeComponent();
            koor = new KoordinatorBasic();
        }
        public PomocnikForm(KoordinatorBasic k)
        {
            InitializeComponent();
            koor = k;
        }

        private void btnDodajPomocnika_Click(object sender, EventArgs e)
        {
            PomocnikDodajForm formaDodaj = new PomocnikDodajForm(koor);
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewSviPomocnici.Items.Clear();
            List<PomocnikPregled> podaci = DTOManager.vratiSvePomocKoordinatora(koor.Id);

            foreach (PomocnikPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Ime, p.ImeRoditelja, p.Prezime, p.DatumRodjenja.ToString(), p.Adresa, p.BrTel.ToString(), p.Email });
                listViewSviPomocnici.Items.Add(item);
            }

            listViewSviPomocnici.Refresh();
        }

        private void btnIzmeniPomocnika_Click(object sender, EventArgs e)
        {
            if (listViewSviPomocnici.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pomocnika cije podatke zelite da izmenite!");
                return;
            }

            int idPomocnik = Int32.Parse(listViewSviPomocnici.SelectedItems[0].SubItems[0].Text);
            PomocnikBasic ob = DTOManager.vratiPomocnika(idPomocnik);

            PomocnikIzmeniForm formaIzmeni = new PomocnikIzmeniForm(ob);
            formaIzmeni.ShowDialog();
            this.popuniPodacima();
        }

        private void PomocnikForm_Load(object sender, EventArgs e)
        {
            this.Text = "KOORDINATOR " + koor.Ime +" "+ koor.Prezime;
            popuniPodacima();
        }

        private void btnObrisiPomocnika_Click(object sender, EventArgs e)
        {
            if (listViewSviPomocnici.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pomocnika cije podatke zelite da izmenite!");
                return;
            }

            int idPomocnik = Int32.Parse(listViewSviPomocnici.SelectedItems[0].SubItems[0].Text);
            PomocnikBasic ob = DTOManager.vratiPomocnika(idPomocnik);

            string poruka = $"Da li zelite da obrišete pomocnika sa ID:{idPomocnik}?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
           

                if (result == DialogResult.OK)
                {
                   
                        DTOManager.ObrisiPomocnika(idPomocnik);
                        MessageBox.Show($"Uspesno ste obrisali pomocnika sa ID: {idPomocnik}!");
                        this.popuniPodacima();
                    }
                    else
                    {
                       
                    }                
            
        }
    }
}
