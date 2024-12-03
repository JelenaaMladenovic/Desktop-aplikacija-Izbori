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
    public partial class TVDueliDodajForm : Form
    {
        TVDueliBasic duel;
        public TVDueliDodajForm()
        {
            InitializeComponent();
            duel = new TVDueliBasic();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu emisiju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.duel.NazivStanice = txbNazivStanice.Text;
                this.duel.NazivEmisije = txbNazivEmisije.Text;
                this.duel.ImeVoditelja = txbVoditelj.Text;
                try
                {
                    this.duel.Gledanost = Double.Parse(txbGledanost.Text);
                   
                    if ((this.duel.Gledanost >0) && (this.duel.Gledanost < 1))
                    {
                        List<TVDueliPregled> listaPostojecih = new List<TVDueliPregled>();
                        listaPostojecih = DTOManager.vratiSveTVDuele();

                        if ((this.duel.NazivStanice.Length != 0) && (this.duel.NazivEmisije.Length != 0) && (this.duel.ImeVoditelja.Length != 0))
                        {
                            int b = 0;
                            foreach (TVDueliPregled item in listaPostojecih)
                            {
                                if ((item.NazivStanice == this.duel.NazivStanice) && (item.NazivEmisije == this.duel.NazivEmisije) && (item.ImeVoditelja == this.duel.ImeVoditelja) && (item.Gledanost == this.duel.Gledanost))
                                {
                                    b += 1;
                                }
                            }
                            if (b == 0)
                            {
                                DTOManager.dodajDuel(this.duel);
                                MessageBox.Show("Uspesno ste dodali novi duel!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(" već postoji u bazi");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Sva polja moraju da budu popunjena!!");
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
