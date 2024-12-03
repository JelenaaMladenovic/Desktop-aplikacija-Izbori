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
    public partial class IzmeniNovineReklamu : Form
    {
        ReklamaBasic r;
        public IzmeniNovineReklamu()
        {
            InitializeComponent();
        }

        public IzmeniNovineReklamu(ReklamaBasic p)
        {
            InitializeComponent();
            this.r = p;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IzmeniNovineReklamu_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            textBox1.Text = this.r.CenaReklame.ToString();
            textBox2.Text = this.r.VremenskiPeriod.ToString();
            textBox3.Text = this.r.NazivNovina;
            textBox4.Text = this.r.Boja;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene reklame?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.r.CenaReklame = Double.Parse(textBox1.Text);
                this.r.VremenskiPeriod = Int32.Parse(textBox2.Text);
                this.r.Grad = "";
                this.r.Ulica = "";
                this.r.Povrsina = 0;
                this.r.Agencija = "";
                this.r.FPano = "Ne";
                this.r.FNovine = "Da";
                this.r.FRadioTv = "Ne";
                this.r.NazivNovina = textBox3.Text;
                this.r.Boja = textBox4.Text;
                this.r.NazivRadioTv = "";
                this.r.BrEmitovanja = 0;
                this.r.Trajanje = 0;


                DTOManager.azurirajReklamu(this.r);
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
