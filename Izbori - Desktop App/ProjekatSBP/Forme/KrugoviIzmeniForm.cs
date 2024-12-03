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
    public partial class KrugoviIzmeniForm : Form
    {
        public KrugoviBasic krug;
        public KrugoviIzmeniForm()
        {
            InitializeComponent();
        }

        public KrugoviIzmeniForm(KrugoviBasic k)
        {
            InitializeComponent();
            this.krug = k;
        }

        private void KrugoviIzmeniForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text =$"Azuriranje krugova {krug.BrKruga.ToUpper()}";

        }

        public void popuniPodacima()
        {
            txbBrKruga.Text = this.krug.BrKruga;
            txbBrBiracaIzasli.Text=this.krug.BrBiracaIzasli.ToString();
            txbProcenatZa.Text=this.krug.ProcenatZa.ToString();

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene kruga?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if(result == DialogResult.OK)
            {
                this.krug.BrKruga = txbBrKruga.Text;
                this.krug.BrBiracaIzasli = Int32.Parse(txbBrBiracaIzasli.Text);
                this.krug.ProcenatZa=Int32.Parse(txbProcenatZa.Text);

                DTOManager.azurirajKrug(this.krug);
                MessageBox.Show("Azuriranje kruga je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }

       
    }
}
