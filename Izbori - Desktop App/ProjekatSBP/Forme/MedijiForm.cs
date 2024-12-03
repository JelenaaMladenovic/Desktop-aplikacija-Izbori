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
    public partial class MedijiForm : Form
    {
        public MedijiForm()
        {
            InitializeComponent();
        }

        private void btnIntervjuNovine_Click_1(object sender, EventArgs e)
        {
            IntervjuNovineForm forma = new IntervjuNovineForm();
            forma.ShowDialog();
        }

        private void btnTVIRadioEmisije_Click(object sender, EventArgs e)
        {
            TVIRadioEmisijeForm forma = new TVIRadioEmisijeForm();
            forma.ShowDialog();

        }

        private void btnTVDueli_Click(object sender, EventArgs e)
        {
            TVDueliForm forma = new TVDueliForm();
            forma.ShowDialog();
        }

        private void MedijiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
