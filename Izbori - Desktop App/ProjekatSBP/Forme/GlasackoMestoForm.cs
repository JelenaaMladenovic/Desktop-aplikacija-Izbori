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
    public partial class GlasackoMestoForm : Form
    {
        public GlasackoMestoForm()
        {
            InitializeComponent();
        }

        private void btnDodajGlasackoMesto_Click(object sender, EventArgs e)
        {
            GlasackoMestoDodajForm formaDodaj = new GlasackoMestoDodajForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewSvaGlasackaMesta.Items.Clear();
            List<GlasackoMestoPregled> podaci = DTOManager.vratiSvaGlasackaMesta();

            foreach (GlasackoMestoPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.NazivIzborneJedinice, p.BrGlasackogMesta.ToString(), p.BrBiraca.ToString() });
                listViewSvaGlasackaMesta.Items.Add(item);
            }

            listViewSvaGlasackaMesta.Refresh();
        }

        private void btnObrisiGlasackoMesto_Click(object sender, EventArgs e)
        {
            if (listViewSvaGlasackaMesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite glasacko mesto cije podatke zelite da izmenite!");
                return;
            }

            int idGlasackoMesto = Int32.Parse(listViewSvaGlasackaMesta.SelectedItems[0].SubItems[0].Text);
            GlasackoMestoBasic gb = DTOManager.vratiGlasackoMesto(idGlasackoMesto);

            string poruka = $"Da li zelite da obrišete glasacko mesto sa ID:{idGlasackoMesto.ToString()}?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

                if(result == DialogResult.OK)
                {
                   
                        DTOManager.ObrisiGlasackoMesto(idGlasackoMesto);
                        MessageBox.Show($"Uspesno ste obrisali glasacko mesto sa ID: {idGlasackoMesto.ToString()}!");
                        this.popuniPodacima();
    
                }
                else
                {
              
                }
        }

        private void btnIzmeniGlasackoMesto_Click(object sender, EventArgs e)
        {
            if(listViewSvaGlasackaMesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite glasacko mesto cije podatke zelite da izmenite!");
                return;
            }

            int idGlasackoMesto = Int32.Parse(listViewSvaGlasackaMesta.SelectedItems[0].SubItems[0].Text);
            GlasackoMestoBasic gb = DTOManager.vratiGlasackoMesto(idGlasackoMesto);

            GlasackoMestoIzmeniForm formaIzmeni = new GlasackoMestoIzmeniForm(gb);
            formaIzmeni.ShowDialog();
            this.popuniPodacima();
        }

        private void GlasackoMestoForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listViewSvaGlasackaMesta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
