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
    public partial class GlasackoMestoDodajForm : Form
    {
        GlasackoMestoBasic glasackoMesto;
        public GlasackoMestoDodajForm()
        {
            InitializeComponent();
            glasackoMesto=new GlasackoMestoBasic();
        }

        private void button1Dodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novo glasacko mesto?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.glasackoMesto.NazivIzborneJedinice = txbNazivIzborneJedinice.Text;
                this.glasackoMesto.BrGlasackogMesta = Int32.Parse(txbBrGlasackogMesta.Text);
                this.glasackoMesto.BrBiraca=Int32.Parse(txbBrBiraca.Text);

                List<GlasackoMestoPregled> listaPostojecih = new List<GlasackoMestoPregled>();
                listaPostojecih = DTOManager.vratiSvaGlasackaMesta();

                if((this.glasackoMesto.NazivIzborneJedinice.Length!=0) && (this.glasackoMesto.BrGlasackogMesta!=0) && (this.glasackoMesto.BrBiraca != 0))
                {
                    int b = 0;
                    foreach(GlasackoMestoPregled item in listaPostojecih)
                    {
                        if((item.NazivIzborneJedinice==this.glasackoMesto.NazivIzborneJedinice) && (item.BrGlasackogMesta==this.glasackoMesto.BrGlasackogMesta)
                            && (item.BrBiraca == this.glasackoMesto.BrBiraca))
                        {
                            b++;
                        }
                    }
                    if (b == 0)
                    {
                        DTOManager.dodajGlasackoMesto(this.glasackoMesto);
                        MessageBox.Show("Uspesno ste dodali novo glasacko mesto!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Glasacko mesto vec postoji u listi!");
                    }
                }
                else
                {
                    if((this.glasackoMesto.NazivIzborneJedinice.Length==0) || (this.glasackoMesto.BrGlasackogMesta.ToString().Length==0) 
                        || (this.glasackoMesto.BrBiraca.ToString().Length == 0))
                    {
                        MessageBox.Show("Sva polja moraju biti popunjena!");
                    }
                    else if((this.glasackoMesto.BrGlasackogMesta<=0) || (this.glasackoMesto.BrBiraca <= 0))
                    {
                        MessageBox.Show("Proverite broj glasackog mesta i broj biraca!");
                    }
                    
                }
            }
            else
            {

            }
        }

        private void GlasackoMestoDodajForm_Load(object sender, EventArgs e)
        {

        }
    }
}
