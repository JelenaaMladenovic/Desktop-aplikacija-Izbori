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
    public partial class PrimedbaForm : Form
    {
        AktivistaBasic akt;
        public PrimedbaForm()
        {
            InitializeComponent();
            akt = new AktivistaBasic();
        }
        public PrimedbaForm(AktivistaBasic ak)
        {
            InitializeComponent();
            akt = ak;
        }

        private void PrimedbaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrimedba_Click(object sender, EventArgs e)
        {
            string poruka = txbPrimedba.Text;
           
            if (akt.PripadaGlasackomMestu != null)
            {
                DTOManager.DodajPrimedbu(akt.Id, poruka);
                this.Close();
                MessageBox.Show($"Uspesno dodata primedba za glasačko mesto {akt.PripadaGlasackomMestu.Id}!");
            }
            else
            {
                MessageBox.Show("Aktivista nije rasporedjen na glasačko mesto!");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
