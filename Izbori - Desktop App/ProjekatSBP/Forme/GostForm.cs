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
    public partial class GostForm : Form
    {
        public GostForm()
        {
            InitializeComponent();
        }

        private void GostForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {

            listView1.Items.Clear();
            List<GostPregled> podaci = DTOManager.vratiSveGoste();

            foreach (GostPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.Id.ToString(), r.Ime,r.Prezime,r.Funkcija });
                listView1.Items.Add(item);
            }

            listView1.Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           /* int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            foreach (Akcija g in DTOManager.MitingGosti(id))
            {
                ListViewItem item = new ListViewItem(new string[] { g.naziv});
                listView2.Items.Add(item);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DodajGostaForm formaDodaj = new DodajGostaForm();
            //formaDodaj.ShowDialog();
            //this.popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite gosta cije podatke zelite da izmenite!");
                return;
            }

            int idGosta = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            GostBasic ob = DTOManager.vratiGosta(idGosta);

            IzmeniGostaForm formaUpdate = new IzmeniGostaForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite gosta kog zelite da obrisete!");
                return;
            }

            int idGosta = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog gosta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiGosta(idGosta);
                MessageBox.Show("Brisanje gosta je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {
                MessageBox.Show("Neuspesno brisanje gosta");
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
