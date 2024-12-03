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
    public partial class IzmeniPanoReklamu : Form
    {
        ReklamaBasic reklama;
        public IzmeniPanoReklamu()
        {
            InitializeComponent();
        }

        public IzmeniPanoReklamu(ReklamaBasic r)
        {
            InitializeComponent();
            this.reklama = r;
        }

        private void IzmeniPanoReklamu_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            textBox1.Text = this.reklama.CenaReklame.ToString();
            textBox2.Text = this.reklama.VremenskiPeriod.ToString();
            textBox3.Text = this.reklama.Grad;
            textBox4.Text = this.reklama.Ulica;
            textBox5.Text = this.reklama.Povrsina.ToString();
            textBox6.Text = this.reklama.Agencija;
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                this.reklama.FPano = "Da";
                this.reklama.Grad = textBox3.Text;
                this.reklama.Ulica = textBox4.Text;
                this.reklama.Povrsina = Double.Parse(textBox5.Text);
                this.reklama.Agencija = textBox6.Text;
                this.reklama.FNovine = "Ne";
                this.reklama.NazivNovina = "";
                this.reklama.Boja = "";
                this.reklama.FRadioTv = "Ne";
                this.reklama.NazivRadioTv = "";
                this.reklama.BrEmitovanja = 0;
                this.reklama.Trajanje = 0;


                DTOManager.azurirajReklamu(this.reklama);
                MessageBox.Show("Azuriranje pano reklame je uspesno izvrseno!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspesno azuriranje pano rekame");
            }
        }

       
    }
}
