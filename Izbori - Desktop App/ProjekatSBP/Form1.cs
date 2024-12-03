using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdUcitavanjeUcesnika_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o ucesniku za zadatim brojem
                ProjekatSBP.Entiteti.Ucesnik u = s.Load<ProjekatSBP.Entiteti.Ucesnik>(101);
                MessageBox.Show(u.LIme + " " + u.Prezime + " " + u.Id);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            */
        }

        private void cmdDodajUcesnika_Click(object sender, EventArgs e)
        {
           /* try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.GlasackoMesto gm = new Entiteti.GlasackoMesto()
                {
                    NazivIzborneJedinice = "Novi Sad",
                    BrGlasackogMesta = 1,
                    BrBiraca = 2000
                };

                Ucesnik u1 = new Koordinator()
                {
                    LIme = "Lara",
                    ImeRoditelja = "Bogdan",
                    Prezime = "Milosevic",
                    Adresa = "Njegoseva 23",
                    BrTel1 = 0657896458,
                    BrTel2 = 0242361556,
                    Email1 = "l@gmail.com",
                    DatumRodjenja = new DateTime(1982, 11, 13)


                };

                Ucesnik u2 = new Pomocnik()
                {
                    LIme = "Zoran",
                    ImeRoditelja = "Uros",
                    Prezime = "Stefanovic",
                    Adresa = "Dusanova 15",
                    BrTel1 = 0689635497,
                    BrTel2 = 0247657923,
                    Email1 = "zoran@gmail.com",
                    DatumRodjenja = new DateTime(1982, 11, 13)


                };

                u1.PripadaGlasackomMestu = gm;
                u2.PripadaGlasackomMestu = gm;

                gm.Ucesnici.Add(u1);
                gm.Ucesnici.Add(u2);
                s.SaveOrUpdate(gm);
                s.Save(gm);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdUcesnik_GlasackoMesto_Click(object sender, EventArgs e)
        {/*
            try
            {
                //otvaranje sesije
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o ucesniku
                Ucesnik u = s.Load<Ucesnik>(105);

                MessageBox.Show(u.LIme + " " + u.Prezime);

                MessageBox.Show(u.PripadaGlasackomMestu.NazivIzborneJedinice);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdGlasackoMesto_Ucesnik_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o glasackom mestu sa zadatim brojem
                ProjekatSBP.Entiteti.GlasackoMesto gm = s.Load<ProjekatSBP.Entiteti.GlasackoMesto>(2);

                foreach (Ucesnik u in gm.Ucesnici)
                {
                    MessageBox.Show(u.LIme + " " + u.Prezime);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdVezaRezultati_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                Krugovi k1 = s.Load<Krugovi>(1);

                foreach (Entiteti.GlasackoMesto gm1 in k1.GlasackaMesta)
                {
                    MessageBox.Show("Naziv izborne jedinice:" + "\n" + gm1.NazivIzborneJedinice);
                }

                Entiteti.GlasackoMesto gm2 = s.Load<Entiteti.GlasackoMesto>(3);

                foreach (Krugovi k2 in gm2.KrugoviGlasanja)
                {
                    MessageBox.Show("Broj kruga:" + "\n" + k2.BrKruga.ToString());
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdDodavanjeKruga_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.GlasackoMesto gm = new Entiteti.GlasackoMesto()
                {
                    NazivIzborneJedinice = "Krusevac",
                    BrGlasackogMesta = 2,
                    BrBiraca = 1000
                };

                Krugovi k = new Krugovi()
                {
                    BrKruga = "Prvi",
                    BrBiracaIzasli = 800,
                    ProcenatZa = 0.32
                };

                k.GlasackaMesta.Add(gm);
                gm.KrugoviGlasanja.Add(k);

                s.Save(gm);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdDodajRezultat_Click(object sender, EventArgs e)
        {
           /* try
            {
                ISession s = DataLayer.GetSession();

                Krugovi k = s.Load<Krugovi>(5);
                Entiteti.GlasackoMesto gm = s.Load<Entiteti.GlasackoMesto>(1);

                Rezultati rez = new Rezultati();
                rez.Id.KrugoviRezultati = k;
                rez.Id.GlasackoMestoRezultati = gm;

                s.Save(rez);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/

        }

        private void cmdUcesniciTip_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Ucesnik> ucesnici = s.QueryOver<Ucesnik>()
                                            .List<Ucesnik>();

                foreach (Ucesnik u in ucesnici)
                {
                    if (u.GetType() == typeof(Koordinator))
                    {
                        Koordinator k = (Koordinator)u;
                        MessageBox.Show(u.Id + " " + "Koordinator");
                    }
                    else if (u.GetType() == typeof(Pomocnik))
                    {
                        Pomocnik p = (Pomocnik)u;
                        MessageBox.Show(u.Id + " " + "Pomoćnik");
                    }
                    else if (u.GetType() == typeof(Aktivista))
                    {
                        Aktivista a = (Aktivista)u;
                        MessageBox.Show(u.Id + " " + "Aktivista");
                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdUcesnikPodaciGet_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                Ucesnik u = s.Get<Ucesnik>(205);

                if (u != null)
                {
                    MessageBox.Show(u.LIme + " " + u.Prezime + " " + u.BrTel1 + " " + u.GetType());
                }
                else
                {
                    MessageBox.Show("Ne postoji ucesnik sa zadatim identifikatorom!");
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdRefreshUcesnik_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                Ucesnik u = s.Get<Ucesnik>(210);

                s.Refresh(u);

                MessageBox.Show("Refresh uradjen!");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdUpitGlasackoMesto_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from GlasackoMesto");

                IList<GlasackoMesto> glasackaMesta = q.List<GlasackoMesto>();

                foreach (GlasackoMesto g in glasackaMesta)
                {
                    MessageBox.Show(g.Id + " " + g.NazivIzborneJedinice);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdUpit2GlasackoMesto_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                //glasacka mesta koja imaju naziv izborne jedinice Nis
                IQuery q = s.CreateQuery("from GlasackoMesto as g where g.NazivIzborneJedinice='Nis'");

                IList<GlasackoMesto> GlasackaMesta = q.List<GlasackoMesto>();

                foreach (GlasackoMesto G in GlasackaMesta)
                {
                    MessageBox.Show(G.Id + " " + G.BrBiraca);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdParametrizovaniUpit_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                //Parametrizovani upit

                IQuery q = s.CreateQuery("from GlasackoMesto as g where g.NazivIzborneJedinice=? and g.BrBiraca>=?");
                q.SetParameter(0, "Valjevo");
                q.SetInt32(1, 1000);

                IList<GlasackoMesto> GlasackaMesta = q.List<GlasackoMesto>();

                foreach (GlasackoMesto G in GlasackaMesta)
                {
                    MessageBox.Show(G.Id + " " + G.BrGlasackogMesta);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdVratiJednuVrednost_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select sum(g.BrBiraca) from GlasackoMesto g");

                //upit vraca samo jednu vrednost
                Int64 brojBiraca = q.UniqueResult<Int64>();

                MessageBox.Show(brojBiraca.ToString());

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdGlasackoMestoJedanObjekat_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select g from GlasackoMesto g where g.Id=27");

                //za slucaj da vraca samo jednu vrednost
                GlasackoMesto g = q.UniqueResult<GlasackoMesto>();


                MessageBox.Show(g.NazivIzborneJedinice);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            */
        }

        private void cmdVisestrukiRezultat_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select g.NazivIzborneJedinice, sum(g.BrBiraca), count(g) from GlasackoMesto g "
                                        + " group by g.NazivIzborneJedinice ");

                //za slucaj da upit vraca visestruku vrednost
                IList<object[]> result = q.List<object[]>();

                foreach (object[] r in result)
                {
                    string tip = (string)r[0];
                    Int64 BrojBiraca = (Int64)r[1];
                    long broj = (long)r[2];

                    MessageBox.Show(tip + " " + broj.ToString() + " " + BrojBiraca.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdStranicenje_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Ucesnik");
                q.SetFirstResult(10);
                q.SetMaxResults(10);

                IList<Ucesnik> ucesnici = q.List<Ucesnik>();

                foreach (Ucesnik u in ucesnici)
                {
                    MessageBox.Show(u.Id.ToString() + " " + u.LIme + " "
                        + u.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdCriteria_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<GlasackoMesto>();

                c.Add(Expression.Ge("BrBiraca", 1600));
                c.Add(Expression.Eq("NazivIzborneJedinice", "Nis"));

                IList<GlasackoMesto> GlasackaMesta = c.List<GlasackoMesto>();

                foreach (GlasackoMesto g in GlasackaMesta)
                {
                    MessageBox.Show(g.Id.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdQueryOver_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                IList<GlasackoMesto> GlasackaMesta = s.QueryOver<GlasackoMesto>()
                                                .Where(x => x.BrBiraca >= 1600)
                                                .Where(x => x.NazivIzborneJedinice == "Beograd")
                                                .List<GlasackoMesto>();

                foreach (GlasackoMesto g in GlasackaMesta)
                {
                    MessageBox.Show(g.Id.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdDeleteUcesnik_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                Ucesnik u = s.Load<Ucesnik>(231);

                //brise se objekat iz baze ali ne i instanca objekta u memroiji
                s.Delete(u);
                

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdTransaction_Click(object sender, EventArgs e)
        {/*
            try
            {
                ISession s = DataLayer.GetSession();

                Ucesnik u = s.Load<Ucesnik>(232);

                ITransaction t = s.BeginTransaction();

                s.Delete(u);

                //t.Commit();
                t.Rollback();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdLinqGlasackoMesto_Click(object sender, EventArgs e)
        {
           /* try
            {
                ISession s = DataLayer.GetSession();

                IList<GlasackoMesto> glasackaMesta = (from g in s.Query<GlasackoMesto>()
                                              where (g.BrBiraca >= 1600 && g.NazivIzborneJedinice == "Nis")
                                              select g).ToList<GlasackoMesto>();

                foreach (GlasackoMesto g in glasackaMesta)
                {
                    MessageBox.Show(g.Id.ToString());
                }


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdLINQUcesnik_Click(object sender, EventArgs e)
        {
           /* try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ucesnik> ucesnici = s.Query<Ucesnik>()
                                                    .Where(u => (u.Prezime == "Jankovic" || u.Prezime == "Jovic"))
                                                    .OrderBy(u => u.Prezime).ThenBy(u => u.LIme.Length)
                                                    .Select(u => u);

                foreach (Ucesnik u in ucesnici)
                {
                    MessageBox.Show(u.LIme + " " + u.Prezime);
                }


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        
    }
}
