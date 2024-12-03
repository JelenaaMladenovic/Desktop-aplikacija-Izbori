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
    public partial class DodajReklamuForm : Form
    {
        ReklamaBasic reklama;
        public DodajReklamuForm()
        {
            InitializeComponent();
            reklama = new ReklamaBasic();
        }

        private void DodajReklamuForm_Load(object sender, EventArgs e)
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
                this.reklama.CenaReklame = Double.Parse(textBox1.Text);
                this.reklama.VremenskiPeriod = Int32.Parse(textBox2.Text);
                

                DTOManager.dodajReklamu(this.reklama);
                MessageBox.Show("Uspesno ste dodali novu reklamu!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspesno dodavanje reklame");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
