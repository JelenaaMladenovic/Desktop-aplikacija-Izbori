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
    public partial class IzmeniAkcijuForm : Form
    {
        AkcijaBasic akcija;
        public IzmeniAkcijuForm()
        {
            InitializeComponent();

        }
        public IzmeniAkcijuForm(AkcijaBasic a)
        {
            InitializeComponent();
            this.akcija = a;

        }

        private void IzmeniAkcijuForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            textBox1.Text = this.akcija.Naziv;
            textBox2.Text = this.akcija.Grad;
            textBox3.Text = this.akcija.Lokacija;
            textBox4.Text = this.akcija.Koordinator.Id.ToString();
            if (this.akcija.FDeljenjeLetaka == "Da")
            {
                checkBox1.Checked=true;
            }
            if (this.akcija.FSusretSaGradjanima == "Da")
            {
                checkBox2.Checked = true;
                textBox5.Text = this.akcija.Vreme;
            }
            if (this.akcija.FNaOtvorenom == "Da")
            {
                checkBox3.Checked = true;
            }
            if (this.akcija.FNaZatvorenom == "Da")
            {
                checkBox4.Checked = true;
                textBox6.Text = this.akcija.NazivFirme;
                textBox7.Text = this.akcija.CenaProstora.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene akcije?";
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


                DTOManager.azurirajAkciju(this.akcija);
                MessageBox.Show("Azuriranje akcije je uspesno izvrseno!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspesno azuriranje akcije");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
