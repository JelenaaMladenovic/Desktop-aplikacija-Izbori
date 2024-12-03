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
    public partial class PanoReklameForm : Form
    {
        public PanoReklameForm()
        {
            InitializeComponent();
        }

        private void PanoReklameForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {

            lvPanoReklame.Items.Clear();
            List<ReklamaPregled> podaci = DTOManager.vratiSveReklame();

            foreach (ReklamaPregled r in podaci)
            {
                if (r.FPano == "Da")
                {

                ListViewItem item = new ListViewItem(new string[] { r.ReklamaId.ToString(), r.CenaReklame.ToString(), r.VremenskiPeriod.ToString(), r.FPano, r.Grad, r.Ulica, r.Povrsina.ToString(), r.Agencija });
                lvPanoReklame.Items.Add(item);

                }
            }

            lvPanoReklame.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajPanoReklamu formaDodaj = new DodajPanoReklamu();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lvPanoReklame.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite reklamu cije podatke zelite da izmenite!");
                return;
            }

            int idReklame = Int32.Parse(lvPanoReklame.SelectedItems[0].SubItems[0].Text);
            ReklamaBasic ob = DTOManager.vratiReklamu(idReklame);
            IzmeniPanoReklamu forma = new IzmeniPanoReklamu(ob);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void lvPanoReklame_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
