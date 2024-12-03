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
    public partial class TVIRadioEmisijeIzmeniForm : Form
    {
        TVIRadioEmisijeBasic emisija;
        public TVIRadioEmisijeIzmeniForm()
        {
            InitializeComponent();
        }
        public TVIRadioEmisijeIzmeniForm(TVIRadioEmisijeBasic emisija)
        {
            InitializeComponent();
            this.emisija = emisija;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene podataka emisije?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.emisija.NazivStanice = txbNazivstanice.Text;
                this.emisija.NazivEmisije = txbNazivEmisije.Text;
                this.emisija.ImeVoditelja = txbVoditelj.Text;
                try
                {
                    this.emisija.Gledanost = Double.Parse(txbGledanost.Text);
                    if((this.emisija.Gledanost < 0) && (this.emisija.Gledanost > 1))
                    {
                        MessageBox.Show("Unesi broj za Gledanaost izmedju 0 i 1");

                    }
                    else
                    {
                        DTOManager.azurirajEmisiju(this.emisija);
                        MessageBox.Show("Azuriranje emisije je uspesno izvrseno!");
                        this.Close();

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Unesi broj za Gledanaost");
                }                  
            }
            else
            {

            }

        }

        private void TVIRadioEmisijeIzmeniForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE Emisije {emisija.NazivEmisije.ToUpper()}";
        }
        public void popuniPodacima()
        {
            txbNazivstanice.Text = this.emisija.NazivStanice;
            txbNazivEmisije.Text = this.emisija.NazivEmisije;
            txbVoditelj.Text = this.emisija.ImeVoditelja;
            txbGledanost.Text = this.emisija.Gledanost.ToString();
        }
    }
}
