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
    public partial class PromoForm : Form
    {
        public PromoForm()
        {
            InitializeComponent();
        }

        private void btnAkcija_Click(object sender, EventArgs e)
        {
            AkcijaForm forma = new AkcijaForm();
            forma.ShowDialog();
        }

        private void btnReklame_Click(object sender, EventArgs e)
        {
           ReklameForm forma = new ReklameForm();
            forma.ShowDialog();
        }

        private void btnGosti_Click(object sender, EventArgs e)
        {
            GostForm forma = new GostForm();
            forma.ShowDialog();
        }
    }
}
