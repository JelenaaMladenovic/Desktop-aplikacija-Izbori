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
    public partial class ProtivkandidatiForm : Form
    {
        TVDueliBasic duel;
        public ProtivkandidatiForm()
        {
            InitializeComponent();
        }
        public ProtivkandidatiForm(TVDueliBasic duel)
        {
            InitializeComponent();
            this.duel = duel;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void ProtivkandidatiForm_Load(object sender, EventArgs e)
        {
            this.Text = "TVDuel " + duel.NazivEmisije.ToUpper();
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            listViewProtivkandidati.Items.Clear();
            List<ProjekatSBP.Entiteti.Protivkandidati> podaci = DTOManager.vratiProtivkandidateDuela(duel.Id);

            foreach (Protivkandidati p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.Protivkandidat });
                listViewProtivkandidati.Items.Add(item);
            }
            listViewProtivkandidati.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajProtivkandidata_Click(object sender, EventArgs e)
        {
            Protivkandidati o = new Protivkandidati();
            o.Id.Protivkandidat = txbProtiv.Text;
            int idD = duel.Id;
            int b = 0;
            foreach (ListViewItem item in listViewProtivkandidati.Items)
            {
                if (item.Text == o.Id.Protivkandidat)
                {
                    b++;
                }
            }
            if (b == 0)
            {
                DTOManager.sacuvajProtivkandidata(o, idD);
                MessageBox.Show("Uspešno ste dodali novog protivkandidata!");
                popuniPodacima();
            }
            else
            {
                MessageBox.Show("Protivkandidat već postoji!");
            }
           
        }

        private void btnObrisiProtivkandidata_Click(object sender, EventArgs e)
        {
            if (listViewProtivkandidati.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pitanje koje želite da obrišete!");
                return;
            }

            string protivkan = listViewProtivkandidati.SelectedItems[0].SubItems[0].Text;
            int idD = duel.Id;
            Protivkandidati pit = new Protivkandidati();
            pit.Id.Protivkandidat = protivkan;
            string poruka = "Da li želite da obrišete izabranog protivkandidata?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiProtivkandidata(pit, idD);
                MessageBox.Show("Brisanje protivkandidata je uspešno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
