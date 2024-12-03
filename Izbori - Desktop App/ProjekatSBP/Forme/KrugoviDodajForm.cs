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
    public partial class KrugoviDodajForm : Form
    {
        KrugoviBasic krug;
        public KrugoviDodajForm()
        {
            InitializeComponent();
            krug = new KrugoviBasic();
        }

        private void button1Dodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi krug?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if(result == DialogResult.OK)
            {
                this.krug.BrKruga = txbBrojKruga.Text;
                this.krug.BrBiracaIzasli = Int32.Parse(txbBrBiracaIzasli.Text);
                this.krug.ProcenatZa = Double.Parse(txbProcenatZa.Text);

                List<KrugoviPregled> listaPostojecih = new List<KrugoviPregled>();
                listaPostojecih = DTOManager.vratiSveKrugove();

                if((this.krug.BrKruga.Length!=0) && (this.krug.BrBiracaIzasli.ToString().Length!=0) 
                    && (this.krug.ProcenatZa.ToString().Length != 0))
                {
                    int b = 0;
                    foreach(KrugoviPregled item in listaPostojecih)
                    {
                        if((item.BrKruga == this.krug.BrKruga) && (item.BrBiracaIzasli == this.krug.BrBiracaIzasli)
                            && (item.ProcenatZa == this.krug.ProcenatZa))
                        {
                            b++;
                        }

                    }
                    if (b == 0)
                    {
                        DTOManager.dodajKrug(this.krug);
                        MessageBox.Show("Uspesno ste dodali novi krug!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Krug vec postoji u listi!");
                    }
                }
                else
                {
                    if((this.krug.BrKruga.Length == 0) && (this.krug.BrBiracaIzasli.ToString().Length == 0)
                    && (this.krug.ProcenatZa.ToString().Length == 0))
                    {
                        MessageBox.Show("Sva polja moraju biti popunjena!");
                    }
                    else if (this.krug.BrBiracaIzasli < 0)
                    {
                        MessageBox.Show("Proverite polje brolj biraca koji su izasli!");
                    }
                }
            }
            else
            {

            }
        }

        private void KrugoviDodajForm_Load(object sender, EventArgs e)
        {

        }
    }
}
