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
    public partial class IzmeniRadioTVReklamu : Form
    {
        ReklamaBasic reklama;
        public IzmeniRadioTVReklamu()
        {
            InitializeComponent();
        }

        public IzmeniRadioTVReklamu(ReklamaBasic r)
        {
            InitializeComponent();
            this.reklama = r;
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
                this.reklama.FPano = "Ne";
                this.reklama.Grad = "";
                this.reklama.Ulica = "";
                this.reklama.Povrsina = 0;
                this.reklama.Agencija = "";
                this.reklama.FNovine = "Ne";
                this.reklama.NazivNovina = "";
                this.reklama.Boja = "";
                this.reklama.FRadioTv = "Da";
                this.reklama.NazivRadioTv = textBox3.Text;
                this.reklama.BrEmitovanja = Int32.Parse(textBox4.Text);
                this.reklama.Trajanje = Int32.Parse(textBox5.Text);


                DTOManager.azurirajReklamu(this.reklama);
                MessageBox.Show("Azuriranje pano reklame je uspesno izvrseno!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspesno azuriranje pano rekame");
            }
        }

        private void IzmeniRadioTVReklamu_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            textBox1.Text = this.reklama.CenaReklame.ToString();
            textBox2.Text = this.reklama.VremenskiPeriod.ToString();
            textBox3.Text = this.reklama.NazivRadioTv;
            textBox4.Text = this.reklama.BrEmitovanja.ToString();
            textBox5.Text = this.reklama.Trajanje.ToString();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
