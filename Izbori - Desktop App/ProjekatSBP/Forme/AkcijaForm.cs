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
    public partial class AkcijaForm : Form
    {
        public AkcijaForm()
        {
            InitializeComponent();
        }

        private void AkcijaForm_Load(object sender, EventArgs e)
        { 
            popuniPodacima();
        }
        
        public void popuniPodacima()
        {

            listView1.Items.Clear();
            List<AkcijaPregled> podaci = DTOManager.vratiSveAkcije();

            foreach (AkcijaPregled r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { r.Id.ToString(),r.Naziv,r.Grad,r.Lokacija,r.FDeljenjeLetaka,r.FSusretSaGradjanima,r.FMiting,r.Koordinator.Id.ToString() });
                listView1.Items.Add(item);
            }

            listView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajAkcijuForm formaDodaj = new DodajAkcijuForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite akciju cije podatke zelite da izmenite!");
                return;
            }

            int idAkcije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            AkcijaBasic ob = DTOManager.vratiAkciju(idAkcije);

            IzmeniAkcijuForm formaUpdate = new IzmeniAkcijuForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite akciju koju zelite da obrisete!");
                return;
            }

            int idAkcije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu akciju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiAkciju(idAkcije);
                MessageBox.Show("Brisanje akcije je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {
                MessageBox.Show("Neuspesno brisanje akcije");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite akciju cije podatke zelite da prikazete!");
                return;
            }

            int idAkcije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            AkcijaBasic ob = DTOManager.vratiAkciju(idAkcije);

            PrikaziAkcijuForm forma = new PrikaziAkcijuForm(ob);
            forma.ShowDialog();

            this.popuniPodacima();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
