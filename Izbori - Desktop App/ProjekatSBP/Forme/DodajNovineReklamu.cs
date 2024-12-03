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
    public partial class DodajNovineReklamu : Form
    {
        ReklamaBasic r;
        public DodajNovineReklamu()
        {
            InitializeComponent();
            r = new ReklamaBasic();
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
                this.r.FPano = "Ne";
                this.r.Grad = "";
                this.r.Ulica = "";
                this.r.Povrsina = 0;
                this.r.Agencija = "";
                this.r.FNovine = "Da";
                this.r.NazivNovina = textBox3.Text; ;
                this.r.Boja = textBox4.Text; ;
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

        private void DodajNovineReklamu_Load(object sender, EventArgs e)
        {

        }
    }
}
