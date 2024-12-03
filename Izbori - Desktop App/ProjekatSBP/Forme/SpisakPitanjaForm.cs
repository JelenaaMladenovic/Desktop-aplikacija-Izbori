using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.Forme
{
    public partial class SpisakPitanjaForm : Form
    {
        TVDueliBasic duel;
        public SpisakPitanjaForm()
        {
            InitializeComponent();
        }
        public SpisakPitanjaForm(TVDueliBasic duel)
        {
            InitializeComponent();
            this.duel = duel;
        }

       private void SpisakPitanjaForm_Load(object sender, EventArgs e)
        {
           this.Text = "TVDuel " + duel.NazivEmisije.ToUpper();
           popuniPodacima();
        }
        public void popuniPodacima()
        {
            listViewPitanja.Items.Clear();
            List<SpisakPitanja> podaci = DTOManager.vratiPitanjaDuela(duel.Id);

            foreach (SpisakPitanja p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.Pitanje});
                listViewPitanja.Items.Add(item);
            }
            listViewPitanja.Refresh();
        }

       private void btnDodajPitanje_Click(object sender, EventArgs e)
        {
            SpisakPitanja o = new SpisakPitanja();
            o.Id.Pitanje = txbDodajPitanje.Text;
            int idD = duel.Id;
            int b = 0;
            foreach(ListViewItem item in listViewPitanja.Items)
            {
                if(item.Text==o.Id.Pitanje)
                {
                    b++;
                }
            }
            if(b==0)
            {
                DTOManager.sacuvajPitanje(o, idD);
                MessageBox.Show("Uspešno ste dodali novo pitanje!");
                popuniPodacima();
            }
            else
            {
                MessageBox.Show("Pitanje već postoji!");
            }
           
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewPitanja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pitanje koje želite da obrišete!");
                return;
            }

            string pitanje =listViewPitanja.SelectedItems[0].SubItems[0].Text;
            int idD = duel.Id;
            SpisakPitanja pit = new SpisakPitanja();
            pit.Id.Pitanje = pitanje;
            string poruka = "Da li želite da obrišete izabrano pitanje?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPitanje(pit,idD);
                MessageBox.Show("Brisanje pitanja je uspešno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void listViewPitanja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
