using ProjekatSBP.Entiteti;
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
    public partial class DodajGostaForm : Form
    {
        GostBasic gost;
        AkcijaBasic akcija;
        public DodajGostaForm()
        {
            InitializeComponent();
            gost = new GostBasic();
        }
        public DodajGostaForm(AkcijaBasic a)
        {
            InitializeComponent();
            gost = new GostBasic();
            this.akcija = a;
        }

        private void DodajGostaForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string poruka = "Da li zelite da dodate novog gosta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                Gost g = new Gost();
                
                g.ime = textBox1.Text;
                g.prezime = textBox2.Text;
                g.funkcija = textBox3.Text;
                int idAkcije = akcija.Id;

                DTOManager.dodajGosta(g, idAkcije);
                //this.gost.Mitinzi.Add(DTOManager.VratiAkciju(this.akcija.id);

            
                /*
                DTOManager.dodajGosta(this.gost);*/
                MessageBox.Show("Uspesno ste dodali novog gosta!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspesno dodavanje gosta");
            }
        }
    }
}
