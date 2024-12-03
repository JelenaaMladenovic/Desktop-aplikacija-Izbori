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
    public partial class KrugoviForm : Form
    {
        public KrugoviForm()
        {
            InitializeComponent();
        }

        private void btnDodajKrug_Click(object sender, EventArgs e)
        {
            KrugoviDodajForm formaDodaj=new KrugoviDodajForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewSviKrugovi.Items.Clear();
            List<KrugoviPregled> podaci = DTOManager.vratiSveKrugove();

            foreach(KrugoviPregled p in podaci)
            {

                ListViewItem item = new ListViewItem(new string[] {p.Id.ToString(), p.BrKruga, p.BrBiracaIzasli.ToString(), p.ProcenatZa.ToString()});
                listViewSviKrugovi.Items.Add(item);
            }
            listViewSviKrugovi.Refresh();
        }

        private void btnObrisiKrug_Click(object sender, EventArgs e)
        {
            if (listViewSviKrugovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite krug cije podatke zelite da izmenite!");
                return;
            }

            int idKrug = Int32.Parse(listViewSviKrugovi.SelectedItems[0].SubItems[0].Text);
            KrugoviBasic ob = DTOManager.vratiKrug(idKrug);
            string poruka = $"Da li zelite da obrišete krug sa ID:{idKrug.ToString()}?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);


                if (result == DialogResult.OK)
                {
                  
                        DTOManager.ObrisiKrug(idKrug);
                        MessageBox.Show($"Uspesno ste obrisali krug sa ID: {idKrug.ToString()}!");
                        this.popuniPodacima();
                }
                else
                {
                       
                }
              
            
        }

        private void btnIzmeniKrug_Click(object sender, EventArgs e)
        {
            if (listViewSviKrugovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite krug cije podatke zelite da izmenite!");
                return;
            }

            int idKrug = Int32.Parse(listViewSviKrugovi.SelectedItems[0].SubItems[0].Text);
            KrugoviBasic ob = DTOManager.vratiKrug(idKrug);

            KrugoviIzmeniForm formaIzmeni = new KrugoviIzmeniForm(ob);
            formaIzmeni.ShowDialog();
            this.popuniPodacima();
        }

        private void KrugoviForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void listViewSviKrugovi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
