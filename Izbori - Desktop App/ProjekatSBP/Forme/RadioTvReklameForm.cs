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
    public partial class RadioTvReklameForm : Form
    {
        public RadioTvReklameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajRadioTvReklamu formaDodaj = new DodajRadioTvReklamu();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }


        private void RadioTvReklameForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {

            lvRadioTv.Items.Clear();
            List<ReklamaPregled> podaci = DTOManager.vratiSveReklame();

            foreach (ReklamaPregled r in podaci)
            {
                if (r.FRadioTv == "Da")
                {

                    ListViewItem item = new ListViewItem(new string[] { r.ReklamaId.ToString(), r.CenaReklame.ToString(), r.VremenskiPeriod.ToString(), r.FRadioTv, r.NazivRadioTv,r.BrEmitovanja.ToString(),r.Trajanje.ToString() });
                    lvRadioTv.Items.Add(item);

                }
            }

            lvRadioTv.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lvRadioTv.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite reklamu cije podatke zelite da izmenite!");
                return;
            }

            int idReklame = Int32.Parse(lvRadioTv.SelectedItems[0].SubItems[0].Text);
            ReklamaBasic ob = DTOManager.vratiReklamu(idReklame);
            IzmeniRadioTVReklamu forma = new IzmeniRadioTVReklamu(ob);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void lvRadioTv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
