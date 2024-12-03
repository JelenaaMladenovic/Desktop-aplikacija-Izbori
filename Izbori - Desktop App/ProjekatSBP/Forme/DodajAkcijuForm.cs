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
    public partial class DodajAkcijuForm : Form
    {
        AkcijaBasic akcija;
        public DodajAkcijuForm()
        {
            InitializeComponent();
            akcija = new AkcijaBasic();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu akciju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                
                this.akcija.Naziv = textBox1.Text;
                this.akcija.Grad = textBox2.Text;
                this.akcija.Lokacija = textBox3.Text;
                this.akcija.Koordinator = DTOManager.VratiKoordinatora(Int32.Parse(textBox4.Text));
                if (checkBox1.Checked)
                {
                    this.akcija.FDeljenjeLetaka = "Da";
                }
                else { this.akcija.FDeljenjeLetaka = "Ne"; }
                if (checkBox2.Checked) 
                { 
                    this.akcija.FSusretSaGradjanima = "Da";
                    this.akcija.Vreme = textBox5.Text;
                }
                else
                {
                    this.akcija.FSusretSaGradjanima = "Ne";
                    this.akcija.Vreme = "";
                }
                if (checkBox3.Checked)
                {
                    this.akcija.FNaOtvorenom = "Da";
                }
                else
                {
                    this.akcija.FNaOtvorenom = "Ne";
                }
                if (checkBox4.Checked)
                {
                    this.akcija.FNaZatvorenom = "Da";
                    this.akcija.NazivFirme = textBox6.Text;
                    this.akcija.CenaProstora = Double.Parse(textBox7.Text);
                }
                else
                {
                    
                    this.akcija.FNaZatvorenom = "Ne";
                    this.akcija.NazivFirme = "";
                    this.akcija.CenaProstora = 0;
                }
                if (checkBox3.Checked || checkBox4.Checked)
                {
                    this.akcija.FMiting = "Da";
                }
                else
                {
                    this.akcija.FMiting = "Ne";
                }


                DTOManager.dodajAkciju(this.akcija);
                MessageBox.Show("Uspesno ste dodali novu akciju!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspesno dodavanje akcije");
            }
        }

        private void DodajAkcijuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
