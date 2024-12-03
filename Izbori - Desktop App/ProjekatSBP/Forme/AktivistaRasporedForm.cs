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
    public partial class AktivistaRasporedForm : Form
    {
        AktivistaBasic aktivista;
        public AktivistaRasporedForm()
        {
            InitializeComponent();
            aktivista = new AktivistaBasic();
        }
        public AktivistaRasporedForm(AktivistaBasic ak)
        {
            InitializeComponent();
            aktivista = ak;
        }

        private void AktivistaRasporedForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewSvaGlasackaMesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite aktivistu cije podatke zelite da izmenite!");
                return;
            }
            if (aktivista.PripadaGlasackomMestu == null)
            {
                int idGlasackoMesto = Int32.Parse(listViewSvaGlasackaMesta.SelectedItems[0].SubItems[0].Text);
                GlasackoMestoBasic gb = DTOManager.vratiGlasackoMesto(idGlasackoMesto);
                DTOManager.poveziAktivistuSaGM(aktivista.Id, gb.Id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aktivista je već rasporedjen!");
            }

            
        }

        private void listViewSvaGlasackaMesta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
