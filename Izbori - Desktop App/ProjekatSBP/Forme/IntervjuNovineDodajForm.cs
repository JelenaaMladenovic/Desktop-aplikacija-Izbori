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
    public partial class IntervjuNovineDodajForm : Form
    {
        IntervjuNovineBasic intervju;
        public IntervjuNovineDodajForm()
        {
            InitializeComponent();
            intervju = new IntervjuNovineBasic();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1Dodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi intervju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.intervju.NazivLista = txbNazivLista.Text;
                this.intervju.DatumPisanja = datumPisanja.Value.Date;
                this.intervju.DatumObjavljivanja = datumObjavljivanja.Value.Date;
                this.intervju.Novinar1 = txbNovinar1.Text;
                this.intervju.Novinar2 = txbNovinar2.Text;
                if (this.intervju.Novinar2 == "")
                    this.intervju.Novinar2 = null;

                List<IntervjuNovinePregled> listaPostojecih = new List<IntervjuNovinePregled>();
                listaPostojecih = DTOManager.vratiSveIntervjue();

                if ((this.intervju.NazivLista.Length!=0) && (this.intervju.DatumPisanja <= this.intervju.DatumObjavljivanja) && (this.intervju.Novinar1.Length!=0))
                {
                    int b = 0;
                    foreach (IntervjuNovinePregled item in listaPostojecih)
                    {
                        if((item.NazivLista == this.intervju.NazivLista)&& (item.DatumPisanja == this.intervju.DatumPisanja)&& (item.DatumObjavljivanja == this.intervju.DatumObjavljivanja)&& (item.Novinar1 == this.intervju.Novinar1)&& (item.Novinar2 == this.intervju.Novinar2))
                        {
                            b += 1;
                        }
                    }
                    if (b == 0)
                    {
                        DTOManager.dodajIntervjuNovine(this.intervju);
                        MessageBox.Show("Uspesno ste dodali novi intervju!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ovakav intervju već postoji u listi");
                        
                    }
                }
                else 
                {
                    if ((this.intervju.NazivLista.Length == 0)|| (this.intervju.Novinar1.Length == 0))
                        MessageBox.Show("Sva polja osim imena i prezimena drugog novinara moraju da budu popunjena!!");
                    else
                    {
                        MessageBox.Show("Proverite ispravnost datuma!");
                    }

                }
                
            }
            else
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
