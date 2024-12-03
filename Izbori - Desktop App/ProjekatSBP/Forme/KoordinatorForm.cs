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
    public partial class KoordinatorForm : Form
    {
       
        public KoordinatorForm()
        {
            InitializeComponent();
            
        }

        private void btnDodajKoordinatora_Click(object sender, EventArgs e)
        {
            KoordinatorDodajForm formaDodaj = new KoordinatorDodajForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewSviKoordinatori.Items.Clear();
            List<KoordinatorPregled> podaci = DTOManager.vratiSveKoordinator();

            foreach (KoordinatorPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Ime, p.ImeRoditelja, p.Prezime, p.DatumRodjenja.ToString(), p.Adresa, p.BrTel.ToString(), p.Email,p.ImeOpstine,p.AdresaKancelarije });
                listViewSviKoordinatori.Items.Add(item);
            }

            listViewSviKoordinatori.Refresh();
        }

        private void btnIzmeniKoordinatora_Click(object sender, EventArgs e)
        {
            if (listViewSviKoordinatori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite koordinatora cije podatke zelite da izmenite!");
                return;
            }

            int idKoordinatora = Int32.Parse(listViewSviKoordinatori.SelectedItems[0].SubItems[0].Text);
            KoordinatorBasic ob = DTOManager.vratiKoordinatora(idKoordinatora);

            KoordinatorIzmeniForm formaIzmeni = new KoordinatorIzmeniForm(ob);
            formaIzmeni.ShowDialog();
            this.popuniPodacima();
        }

        private void KoordinatorForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnObrisiKoordinatora_Click(object sender, EventArgs e)
        {
            if (listViewSviKoordinatori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite koordinatora cije podatke zelite da izmenite!");
                return;
            }

            int idKoordinatora = Int32.Parse(listViewSviKoordinatori.SelectedItems[0].SubItems[0].Text);
            KoordinatorBasic ob = DTOManager.vratiKoordinatora(idKoordinatora);

            string poruka = $"Da li zelite da obrišete koordinatora sa ID:{idKoordinatora.ToString()}?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
           

                if (result == DialogResult.OK)
                {
                   
                        DTOManager.ObrisiKoordinatora(idKoordinatora);
                        MessageBox.Show($"Uspesno ste obrisali koordinatora sa ID: {idKoordinatora.ToString()}!");
                        this.popuniPodacima();
                }
                else
                {
                     
                 }            
     
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewSviKoordinatori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite koordinatora cije pomoćnike zelite da vidite!");
                return;
            }

            int idKoordinatora = Int32.Parse(listViewSviKoordinatori.SelectedItems[0].SubItems[0].Text);
            KoordinatorBasic p = DTOManager.vratiKoordinatora(idKoordinatora);
            PomocnikForm form = new PomocnikForm(p);
            form.ShowDialog();    
        }

        private void listViewSviKoordinatori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
