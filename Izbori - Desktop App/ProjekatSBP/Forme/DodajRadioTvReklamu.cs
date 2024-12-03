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
    public partial class DodajRadioTvReklamu : Form
    {
        ReklamaBasic reklama;
        public DodajRadioTvReklamu()
        {
            InitializeComponent();
            reklama = new ReklamaBasic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu reklamu?";
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


                DTOManager.dodajReklamu(this.reklama);
                MessageBox.Show("Uspesno ste dodali novu reklamu!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspesno dodavanje reklame");
            }
        }

        private void DodajRadioTvReklamu_Load(object sender, EventArgs e)
        {

        }
    }
}
