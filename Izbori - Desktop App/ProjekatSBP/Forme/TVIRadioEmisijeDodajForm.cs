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
    public partial class TVIRadioEmisijeDodajForm : Form
    {
        TVIRadioEmisijeBasic emisija;
        public TVIRadioEmisijeDodajForm()
        {
            InitializeComponent();
            emisija = new TVIRadioEmisijeBasic();
        }

        private void btnDodajEmisiju_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu emisiju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

             /*if (result == DialogResult.OK)
             {
                 this.emisija.NazivStanice = txbNazivstanice.Text;
                 this.emisija.NazivEmisije = txbNazivEmisije.Text;
                 this.emisija.ImeVoditelja = txbVoditelj.Text;
                 this.emisija.Gledanost = Double.Parse(txbGledanost.Text);
               
                DTOManager.dodajEmisiju(this.emisija);
                MessageBox.Show("Uspesno ste dodali novi emisiju!");
                this.Close();
            }
            else
            {

            }*/


                 if (result == DialogResult.OK)
                 {
                     this.emisija.NazivStanice = txbNazivstanice.Text;
                     this.emisija.NazivEmisije = txbNazivEmisije.Text;
                     this.emisija.ImeVoditelja = txbVoditelj.Text;
                      try
                     {
                         this.emisija.Gledanost = Double.Parse(txbGledanost.Text);
                         if ((this.emisija.Gledanost > 0) && (this.emisija.Gledanost < 1))
                         {
                             List<TVIRadioEmisijePregled> listaPostojecih = new List<TVIRadioEmisijePregled>();
                             listaPostojecih = DTOManager.vratiSveEmisije();

                             if ((this.emisija.NazivStanice.Length != 0) && (this.emisija.NazivEmisije.Length != 0) && (this.emisija.ImeVoditelja.Length != 0))
                             {
                                 int b = 0;
                                 foreach (TVIRadioEmisijePregled item in listaPostojecih)
                                 {
                                     if ((item.NazivStanice == this.emisija.NazivStanice) && (item.NazivEmisije == this.emisija.NazivEmisije) && (item.ImeVoditelja == this.emisija.ImeVoditelja) && (item.Gledanost == this.emisija.Gledanost))
                                     {
                                         b += 1;
                                     }
                                 }
                                 if (b == 0)
                                 {
                                     DTOManager.dodajEmisiju(this.emisija);
                                     MessageBox.Show("Uspesno ste dodali novi emisiju!");
                                     this.Close();
                                 }
                                 else
                                 {
                                     MessageBox.Show("Emisija već postoji u bazi");

                                 }
                             }
                             else
                             {
                                 MessageBox.Show("Sva polja osim gledanosti moraju da budu popunjena!!");
                             }
                         }
                         else
                         {
                             MessageBox.Show("Gledanost ima vrednost izmedju 0 i 1!");
                         }

                     }
                     catch (Exception)
                     {

                         MessageBox.Show("UNESITE BROJ ZA GLEDANOST!");
                     }

                 }
                 else
                 {

                 }
            }
    }
}
