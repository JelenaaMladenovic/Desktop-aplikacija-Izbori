using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  ProjekatSBP.Forme
{
    public partial class IntervjuNovineForm : Form
    {
       
        public IntervjuNovineForm()
        {
            InitializeComponent();
            
        }

        private void btnDodajIntervju_Click(object sender, EventArgs e)
        {
            IntervjuNovineDodajForm formaDodaj = new IntervjuNovineDodajForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void IntervjuNovineForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {


            listViewSviIntervjui.Items.Clear();
            List<IntervjuNovinePregled> podaci = DTOManager.vratiSveIntervjue();



            foreach (IntervjuNovinePregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.NazivLista, p.DatumPisanja.ToString(), p.DatumObjavljivanja.ToString(), p.Novinar1, p.Novinar2});
                listViewSviIntervjui.Items.Add(item);

            }

            listViewSviIntervjui.Refresh();
        }

        private void btnObrisiIntervju_Click(object sender, EventArgs e)
        {
            if (listViewSviIntervjui.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite intervju cije podatke zelite da izmenite!");
                return;
            }

            int idIntervjua = Int32.Parse(listViewSviIntervjui.SelectedItems[0].SubItems[0].Text);
            IntervjuNovineBasic ob = DTOManager.vratiIntervju(idIntervjua);

            string poruka = $"Da li zelite da obrišete intervju sa Id:{idIntervjua.ToString()}?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
       
             if (result == DialogResult.OK)
             {
               
                   DTOManager.obrisiIntervjuNovine(idIntervjua);
                   MessageBox.Show($"Uspesno ste obrisali intervju sa Id: {idIntervjua.ToString()}!");
                    this.popuniPodacima();
             }
              else
              {
                 
              }
      
        }

        private void btnIzmeniIntervjuNovine_Click(object sender, EventArgs e)
        {
            if (listViewSviIntervjui.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite intervju cije podatke zelite da izmenite!");
                return;
            }

            int idIntervjua = Int32.Parse(listViewSviIntervjui.SelectedItems[0].SubItems[0].Text);
            IntervjuNovineBasic ob = DTOManager.vratiIntervju(idIntervjua);

             IntervjuNovineIzmeniForm formaIzmeni = new IntervjuNovineIzmeniForm(ob);
            formaIzmeni.ShowDialog();

            this.popuniPodacima();

        }

        private void listViewSviIntervjui_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
