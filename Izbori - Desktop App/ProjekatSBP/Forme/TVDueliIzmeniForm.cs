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
    public partial class TVDueliIzmeniForm : Form
    {
        TVDueliBasic duel;
        public TVDueliIzmeniForm()
        {
            InitializeComponent();
        }
        public TVDueliIzmeniForm(TVDueliBasic op)
        {
            InitializeComponent();
            duel = op;
        }

        private void btnIzmeniDuel_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene podataka duela?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.duel.NazivStanice = txbNazivstanice.Text;
                this.duel.NazivEmisije = txbNazivEmisije.Text;
                this.duel.ImeVoditelja = txbVoditelj.Text;
                try
                {
                    this.duel.Gledanost = Double.Parse(txbGledanost.Text);
                    if ((this.duel.Gledanost < 0) && (this.duel.Gledanost > 1))
                    {
                        MessageBox.Show("Unesi broj za Gledanaost izmedju 0 i 1");

                    }
                    else
                    {
                        DTOManager.azurirajDuel(this.duel);
                        MessageBox.Show("Azuriranje duela je uspesno izvrseno!");
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

        private void TVDueliIzmeniForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE TVDuela {duel.NazivEmisije.ToUpper()}";
        }
        public void popuniPodacima()
        {
            txbNazivstanice.Text = this.duel.NazivStanice;
            txbNazivEmisije.Text = this.duel.NazivEmisije;
            txbVoditelj.Text = this.duel.ImeVoditelja;
            txbGledanost.Text = this.duel.Gledanost.ToString();
        }
    }
}
