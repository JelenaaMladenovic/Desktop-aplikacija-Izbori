using ProjekatSBP.Entiteti;
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
    public partial class PrikaziAkcijuForm : Form
    {
        AkcijaBasic akcija;
        public PrikaziAkcijuForm()
        {
            InitializeComponent();
        }

        public PrikaziAkcijuForm(AkcijaBasic a)
        {
            InitializeComponent();
            this.akcija = a;
        }

        private void PrikaziAkcijuForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            popuniPodacima2();
        }

        public void popuniPodacima()
        {
            label12.Text = this.akcija.Naziv;
            label13.Text = this.akcija.Grad;
            label14.Text = this.akcija.Lokacija;
            //string koord = this.akcija.Koordinator.Id.ToString() + " " + this.akcija.Koordinator.LIme + " " + this.akcija.Koordinator.Prezime;
            label15.Text = this.akcija.Koordinator.Id.ToString();
            if (this.akcija.FDeljenjeLetaka == "Da")
            {
                label16.Text = "Da";
            }
            else { label16.Text = "Ne"; }
            if (this.akcija.FSusretSaGradjanima == "Da")
            {
                label17.Text = "Da";
                label18.Text = this.akcija.Vreme;
            }
            else
            {
                label17.Text = "Ne";
                label18.Text = "/";
            }
            if (this.akcija.FNaOtvorenom == "Da" || this.akcija.FNaZatvorenom == "Da")
            {
                label19.Text = "Da";
                //DTOManager.GostiMitinga(this.akcija.Id);
                /*string str = "";
                foreach (GostBasic s in this.akcija.GostiMitinga)
                {
                    str += s.Ime + " " + s.Prezime + " " + s.Funkcija + "\n";
                }
                label22.Text = this.akcija.GostiMitinga.ToString();*/
                //label22.Text

                foreach (Gost g in DTOManager.GostiMitinga(this.akcija.Id))
                {
                    ListViewItem item = new ListViewItem(new string[] { g.ime, g.prezime,g.funkcija });
                    listView1.Items.Add(item);
                }
                //textBox1.Text = DTOManager.GostiMitinga(this.akcija.Id);
                //MessageBox.Show(DTOManager.GostiMitinga(this.akcija.Id));
            }
            else { label19.Text = "Ne"; }
            if (this.akcija.FNaZatvorenom == "Da")
            {
                label20.Text = this.akcija.NazivFirme;
                label21.Text = this.akcija.CenaProstora.ToString();
            }
            else
            {
                label20.Text = "/";
                label21.Text = "/";
                label22.Text = "/";
            }
        }
        public void popuniPodacima2()
        {
          /*  listView1.Items.Clear();
            List<AkcijaPregled> podaci = DTOManager.vratiSveAkcije();

            foreach (AkcijaPregled r in podaci)
            {
                foreach (Gost g in r.GostiMitinga)
                {
                    string gost = $"{g.ime} {g.prezime} {g.funkcija}";
                    ListViewItem item = new ListViewItem(new string[] { gost});
                    listView1.Items.Add(item);
                }
            }

            listView1.Refresh();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = this.akcija.Id;
            DodajGostaForm formaDodaj = new DodajGostaForm(this.akcija);
            formaDodaj.ShowDialog();
           
            listView1.Items.Clear();
            this.popuniPodacima();
        }
    }
}
