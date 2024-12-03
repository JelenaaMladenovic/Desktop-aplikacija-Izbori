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
    public partial class ReklameForm : Form
    {
        public ReklameForm()
        {
            InitializeComponent();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReklameForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            
                Reklame.Items.Clear();
                List<ReklamaPregled> podaci = DTOManager.vratiSveReklame();

                foreach (ReklamaPregled r in podaci)
                {
                    ListViewItem item = new ListViewItem(new string[] { r.ReklamaId.ToString(), r.CenaReklame.ToString(), r.VremenskiPeriod.ToString() });
                    Reklame.Items.Add(item);
                }

                Reklame.Refresh();
            
        }

        private void btnDodajReklamu_Click(object sender, EventArgs e)
        {
            DodajReklamuForm formaDodaj = new DodajReklamuForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnIzmeniReklamu_Click(object sender, EventArgs e)
        {
            if (Reklame.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite reklamu cije podatke zelite da izmenite!");
                return;
            }

            int idReklame = Int32.Parse(Reklame.SelectedItems[0].SubItems[0].Text);
            ReklamaBasic ob = DTOManager.vratiReklamu(idReklame);

            IzmeniReklamuForm formaUpdate = new IzmeniReklamuForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Reklame.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite reklamu koju zelite da obrisete!");
                return;
            }

            int idReklame = Int32.Parse(Reklame.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu reklamu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiReklamu(idReklame);
                MessageBox.Show("Brisanje reklame je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {
                MessageBox.Show("Neuspesno brisanje reklame");
            }
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            PanoReklameForm forma = new PanoReklameForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NovineReklameForm forma = new NovineReklameForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RadioTvReklameForm forma = new RadioTvReklameForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
