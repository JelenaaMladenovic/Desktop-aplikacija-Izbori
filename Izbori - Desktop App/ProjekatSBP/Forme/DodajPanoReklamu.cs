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
    public partial class DodajPanoReklamu : Form
    {
        ReklamaBasic r;
        public DodajPanoReklamu()
        {
            InitializeComponent();
            r = new ReklamaBasic();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu reklamu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.r.CenaReklame = Double.Parse(textBox1.Text);
                this.r.VremenskiPeriod = Int32.Parse(textBox2.Text);
                this.r.FPano = "Da";
                this.r.Grad = textBox3.Text;
                this.r.Ulica = textBox4.Text;
                this.r.Povrsina = Double.Parse(textBox5.Text);
                this.r.Agencija = textBox6.Text;
                this.r.FNovine = "Ne";
                this.r.NazivNovina = "";
                this.r.Boja = "";
                this.r.FRadioTv = "Ne";
                this.r.NazivRadioTv = "";
                this.r.BrEmitovanja = 0;
                this.r.Trajanje = 0;


                DTOManager.dodajReklamu(this.r);
                MessageBox.Show("Uspesno ste dodali novu reklamu!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspesno dodavanje reklame");
            }

        }

        private void DodajPanoReklamu_Load(object sender, EventArgs e)
        {

        }
    }
}
