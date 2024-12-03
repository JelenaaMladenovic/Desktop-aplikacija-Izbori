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
    public partial class IntervjuNovineIzmeniForm : Form
    {
        public IntervjuNovineBasic inter;
        public IntervjuNovineIzmeniForm()
        {
            InitializeComponent();
        }
        public IntervjuNovineIzmeniForm(IntervjuNovineBasic no)
        {
            InitializeComponent();
            this.inter = no;
        }

        private void IntervjuNovineIzmeniForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE PRODAVNICE {inter.NazivLista.ToUpper()}";

        }
        public void popuniPodacima()
        {
            txbNazivLista.Text = this.inter.NazivLista;
            datumPisanja.Value = this.inter.DatumPisanja;
            datumObjavljivanja.Value = this.inter.DatumObjavljivanja;
            txbNovinar1.Text = this.inter.Novinar1;
            txbNovinar2.Text = this.inter.Novinar2;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene intervjua?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.inter.NazivLista = txbNazivLista.Text;
                this.inter.DatumPisanja = datumPisanja.Value;
                this.inter.DatumObjavljivanja = datumObjavljivanja.Value;
                this.inter.Novinar1 = txbNovinar1.Text;
                this.inter.Novinar2 = txbNovinar2.Text;
                

                DTOManager.azurirajIntervjuNovine(this.inter);
                MessageBox.Show("Azuriranje intervjua je uspesno izvrseno!");
                this.Close();
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
