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
    public partial class TVIRadioEmisijeForm : Form
    {
        public TVIRadioEmisijeForm()
        {
            InitializeComponent();
        }

        private void TVIRadioEmisijeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {

            listViewEmisije.Items.Clear();
            List<TVIRadioEmisijePregled> podaci = DTOManager.vratiSveEmisije();

            foreach (TVIRadioEmisijePregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.NazivStanice, p.NazivEmisije, p.ImeVoditelja, p.Gledanost.ToString() });
                listViewEmisije.Items.Add(item);

            }
            listViewEmisije.Refresh();
        }

        private void btnDodajEmisiju_Click(object sender, EventArgs e)
        {
            TVIRadioEmisijeDodajForm formaDodaj = new TVIRadioEmisijeDodajForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisiEmisiju_Click(object sender, EventArgs e)
        {
            if (listViewEmisije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite emisiju cije podatke zelite da izmenite!");
                return;
            }

            int idEmisije = Int32.Parse(listViewEmisije.SelectedItems[0].SubItems[0].Text);
            TVIRadioEmisijeBasic ob = DTOManager.vratiEmisiju(idEmisije);
            string poruka = $"Da li zelite da obrišete intervju sa Id:{idEmisije}?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
           
                if (result == DialogResult.OK)
                {
                   
                   
                        DTOManager.obrisiEmisiju(idEmisije);
                        MessageBox.Show($"Uspesno ste obrisali intervju sa Id: {idEmisije}!");
                        this.popuniPodacima();
                 }
                    else
                    {
                        
                    }
                
            
        }
        private void btnIzmeniEmisiju_Click(object sender, EventArgs e)
        {
            if (listViewEmisije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite emisiju cije podatke zelite da izmenite!");
                return;
            }

            int idEmisije = Int32.Parse(listViewEmisije.SelectedItems[0].SubItems[0].Text);
            TVIRadioEmisijeBasic ob = DTOManager.vratiEmisiju(idEmisije);

            TVIRadioEmisijeIzmeniForm formaIzmeni = new TVIRadioEmisijeIzmeniForm(ob);
            formaIzmeni.ShowDialog();

            this.popuniPodacima();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
