using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjekatSBP.Forme;
using NHibernate;

namespace ProjekatSBP
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {

        }

        private void btnUcesnici_Click(object sender, EventArgs e)
        {
            FormUcesnici forma = new FormUcesnici();
            forma.ShowDialog();
        }

        private void btnGlasackaMesta_Click(object sender, EventArgs e)
        {
            GlasackoMestoForm forma = new GlasackoMestoForm();
            forma.ShowDialog();
        }

        private void btnKrugovi_Click(object sender, EventArgs e)
        {
            KrugoviForm forma = new KrugoviForm();
            forma.ShowDialog();
        }

        private void btnAkcije_Click(object sender, EventArgs e)
        {
            PromoForm forma = new PromoForm();
            forma.ShowDialog();
        }

        private void btnMediji_Click(object sender, EventArgs e)
        {
             MedijiForm forma = new MedijiForm();
            forma.ShowDialog();
           /* try
          {
             ISession s = DataLayer.GetSession();

           
           
            Entiteti.TVDueli novi = new Entiteti.TVDueli()
            {
                NazivStanice = "List",
                NazivEmisije = "Lost",
                ImeVoditelja = "Neda Nedić",
                Gledanost = 0.53 
            };
            //s.SaveOrUpdate(novi);
             s.Save(novi);
            // s.Flush();
            // s.Close();

             }
             catch (Exception ec)
             {
                MessageBox.Show(ec.Message);
             }*/
            }
    }
}
