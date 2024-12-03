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
    public partial class IzmeniReklamuForm : Form
    {
        ReklamaBasic reklama;
        public IzmeniReklamuForm()
        {
            InitializeComponent();
        }
        public IzmeniReklamuForm(ReklamaBasic r)
        {
            InitializeComponent();
            this.reklama = r;
        }

        private void IzmeniReklamuForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
           
        }

        public void popuniPodacima()
        {
            textBox1.Text = this.reklama.CenaReklame.ToString();
            textBox2.Text = this.reklama.VremenskiPeriod.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene reklame?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.reklama.CenaReklame = Double.Parse(textBox1.Text);
                this.reklama.VremenskiPeriod = Int32.Parse(textBox2.Text);
               

                DTOManager.azurirajReklamu(this.reklama);
                MessageBox.Show("Azuriranje reklame je uspesno izvrseno!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspesno azuriranje rekame");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
