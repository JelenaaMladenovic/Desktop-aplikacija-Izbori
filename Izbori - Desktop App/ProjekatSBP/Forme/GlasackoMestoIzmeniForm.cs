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
    public partial class GlasackoMestoIzmeniForm : Form
    {
        public GlasackoMestoBasic glasackoMesto;
        public GlasackoMestoIzmeniForm()
        {
            InitializeComponent();
        }

        public GlasackoMestoIzmeniForm(GlasackoMestoBasic gMesto)
        {
            InitializeComponent();
            this.glasackoMesto = gMesto;
        }

        private void GlasackoMestoIzmeniForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text=$"Azuririaj glasacko mesto {glasackoMesto.NazivIzborneJedinice.ToUpper()}";
        }

        public void popuniPodacima()
        {
            txbNazivIzborneJedinice.Text = this.glasackoMesto.NazivIzborneJedinice;
            txbBrGlasackogMesta.Text=this.glasackoMesto.BrGlasackogMesta.ToString();
            txbBrBiraca.Text=this.glasackoMesto.BrBiraca.ToString();

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene glasackog mesta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if(result == DialogResult.OK)
            {
                this.glasackoMesto.NazivIzborneJedinice = txbNazivIzborneJedinice.Text;
                this.glasackoMesto.BrGlasackogMesta = Int32.Parse(txbBrGlasackogMesta.Text);
                this.glasackoMesto.BrBiraca=Int32.Parse(txbBrBiraca.Text);

                DTOManager.azurirajGlasackoMesto(this.glasackoMesto);
                MessageBox.Show("Azuriranje glasackog mesta je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
        
    }
}
