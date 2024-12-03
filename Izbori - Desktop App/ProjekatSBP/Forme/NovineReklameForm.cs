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
    public partial class NovineReklameForm : Form
    {
        public NovineReklameForm()
        {
            InitializeComponent();
        }

        private void NovineReklameForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {

            lvNovineReklame.Items.Clear();
            List<ReklamaPregled> podaci = DTOManager.vratiSveReklame();

            foreach (ReklamaPregled r in podaci)
            {
                if (r.FNovine == "Da")
                {

                    ListViewItem item = new ListViewItem(new string[] { r.ReklamaId.ToString(), r.CenaReklame.ToString(), r.VremenskiPeriod.ToString(), r.FNovine, r.NazivNovina, r.Boja });
                    lvNovineReklame.Items.Add(item);

                }
            }
            
            lvNovineReklame.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajNovineReklamu formaDodaj = new DodajNovineReklamu();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lvNovineReklame.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite reklamu cije podatke zelite da izmenite!");
                return;
            }

            int idReklame = Int32.Parse(lvNovineReklame.SelectedItems[0].SubItems[0].Text);
            ReklamaBasic ob = DTOManager.vratiReklamu(idReklame);

            
            IzmeniNovineReklamu forma = new IzmeniNovineReklamu(ob);
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }
}
