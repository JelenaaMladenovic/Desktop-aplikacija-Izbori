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
    public partial class IzmeniGostaForm : Form
    {
        GostBasic gost;

        public IzmeniGostaForm()
        {
            InitializeComponent();
        }
        public IzmeniGostaForm(GostBasic g)
        {
            InitializeComponent();
            this.gost = g;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene gosta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.gost.Ime = textBox1.Text;
                this.gost.Prezime = textBox2.Text;
                this.gost.Funkcija = textBox3.Text;

                DTOManager.azurirajGosta(this.gost);
                MessageBox.Show("Azuriranje gosta je uspesno izvrseno!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspesno azuriranje gosta");
            }
        }

        private void IzmeniGostaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            textBox1.Text = this.gost.Ime;
            textBox2.Text = this.gost.Prezime;
            textBox3.Text = this.gost.Funkcija;

        }
    }
}
