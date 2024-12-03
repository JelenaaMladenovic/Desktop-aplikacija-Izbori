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
    public partial class FormUcesnici : Form
    {
        public FormUcesnici()
        {
            InitializeComponent();
        }

        private void btnUcesnici_Click(object sender, EventArgs e)
        {

            //UcesnikForm forma = new UcesnikForm();
           // forma.ShowDialog();
            
        }

        private void btnKoordinatori_Click(object sender, EventArgs e)
        {
            KoordinatorForm forma = new KoordinatorForm();
            forma.ShowDialog();
        }

        private void btnPomocnici_Click(object sender, EventArgs e)
        {
           // PomocnikForm forma = new PomocnikForm();
           // forma.ShowDialog();
        }

        private void btnAktivisti_Click(object sender, EventArgs e)
        {
            AktivistaForm forma = new AktivistaForm();
            forma.ShowDialog();
        }

        private void FormUcesnici_Load(object sender, EventArgs e)
        {

        }
    }
}
