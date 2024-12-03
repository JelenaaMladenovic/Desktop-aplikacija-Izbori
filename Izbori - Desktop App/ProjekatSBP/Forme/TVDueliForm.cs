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
    public partial class TVDueliForm : Form
    {
        public TVDueliForm()
        {
            InitializeComponent();
        }

        private void TVDueliForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {

            listViewTVDueli.Items.Clear();

            List<TVDueliPregled> podaci = DTOManager.vratiSveTVDuele();
            foreach (TVDueliPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.NazivStanice, p.NazivEmisije, p.ImeVoditelja, p.Gledanost.ToString() });
                listViewTVDueli.Items.Add(item);

            }

            listViewTVDueli.Refresh();
        }

        private void listViewTVDueli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajDuel_Click(object sender, EventArgs e)
        {
            TVDueliDodajForm forma = new TVDueliDodajForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnIzmeniDuel_Click(object sender, EventArgs e)
        {
            if (listViewTVDueli.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite duel cije podatke zelite da izmenite!");
                return;
            }

            int idDuela = Int32.Parse(listViewTVDueli.SelectedItems[0].SubItems[0].Text);
            TVDueliBasic ob = DTOManager.vratiDuel(idDuela);

            TVDueliIzmeniForm formaIzmeni = new TVDueliIzmeniForm(ob);
            formaIzmeni.ShowDialog();

            this.popuniPodacima();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnObrisiTVDuel_Click(object sender, EventArgs e)
        {
            if (listViewTVDueli.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite duel cije podatke zelite da izmenite!");
                return;
            }

            int idDuela = Int32.Parse(listViewTVDueli.SelectedItems[0].SubItems[0].Text);
            TVDueliBasic ob = DTOManager.vratiDuel(idDuela);
            string poruka = $"Da li zelite da obrišete duel sa Id:{idDuela}?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                   
                        DTOManager.obrisiDuel(idDuela);
                        MessageBox.Show($"Uspesno ste obrisali duel sa Id: {idDuela}!");
                        this.popuniPodacima();
                    }
                    else
                    {
                        
                    }
                
           
        }

        private void btnSpisakPitanja_Click(object sender, EventArgs e)
        {
            if (listViewTVDueli.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite duel čija pitanja želite da vidite!");
                return;
            }

            int idDuela = Int32.Parse(listViewTVDueli.SelectedItems[0].SubItems[0].Text);
            TVDueliBasic p = DTOManager.vratiDuel(idDuela);
            SpisakPitanjaForm forma = new SpisakPitanjaForm(p);
            forma.ShowDialog();
        }

        private void btnProtivkandidati_Click(object sender, EventArgs e)
        {
            if (listViewTVDueli.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite duel čija pitanja želite da vidite!");
                return;
            }

            int idDuela = Int32.Parse(listViewTVDueli.SelectedItems[0].SubItems[0].Text);
            TVDueliBasic p = DTOManager.vratiDuel(idDuela);
            ProtivkandidatiForm forma = new ProtivkandidatiForm(p);
            forma.ShowDialog();

        }

        private void btnNaj_Click(object sender, EventArgs e)
        {
            DTOManager.najgledanijiDueli();
        }
    }
    
}
