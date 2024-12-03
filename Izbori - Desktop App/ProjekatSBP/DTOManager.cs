using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP
{
    class DTOManager
    {
       
        #region Glasacko Mesto

        public static List<GlasackoMestoPregled> vratiSvaGlasackaMesta()
        {
            List<GlasackoMestoPregled> glasackaMesta = new List<GlasackoMestoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.GlasackoMesto> svaGlasackaMesta = from o in s.Query<ProjekatSBP.Entiteti.GlasackoMesto>()
                                                                        select o;
                foreach (ProjekatSBP.Entiteti.GlasackoMesto g in svaGlasackaMesta)
                {
                    glasackaMesta.Add(new GlasackoMestoPregled(g.Id, g.NazivIzborneJedinice, g.BrGlasackogMesta, g.BrBiraca));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }
            return glasackaMesta;
        }

        public static void dodajGlasackoMesto(GlasackoMestoBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.GlasackoMesto g = new ProjekatSBP.Entiteti.GlasackoMesto();

                g.NazivIzborneJedinice = p.NazivIzborneJedinice;
                g.BrGlasackogMesta = p.BrGlasackogMesta;
                g.BrBiraca = p.BrBiraca;

                s.SaveOrUpdate(g);
                //s.Save(g)

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static void ObrisiGlasackoMesto(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.GlasackoMesto g = s.Load<Entiteti.GlasackoMesto>(p);

                s.Delete(g);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static GlasackoMestoBasic vratiGlasackoMesto(int id)
        {
            GlasackoMestoBasic pb = new GlasackoMestoBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.GlasackoMesto o = s.Load<ProjekatSBP.Entiteti.GlasackoMesto>(id);
                pb = new GlasackoMestoBasic(o.Id, o.NazivIzborneJedinice, o.BrGlasackogMesta, o.BrBiraca);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }

            return pb;
        }

        public static GlasackoMestoBasic azurirajGlasackoMesto(GlasackoMestoBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.GlasackoMesto o = s.Load<ProjekatSBP.Entiteti.GlasackoMesto>(p.Id);
               
                
                o.NazivIzborneJedinice = p.NazivIzborneJedinice;
                o.BrGlasackogMesta = p.BrGlasackogMesta;
                o.BrBiraca = p.BrBiraca;
               

                s.SaveOrUpdate(o);
                //s.Save(g)

                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                //handle exceptin
            }
            return p;
        }
        #endregion
        #region Krugovi

        public static List<KrugoviPregled> vratiSveKrugove()
        {
            List<KrugoviPregled> krugovi = new List<KrugoviPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.Krugovi> sviKrugovi = from o in s.Query<ProjekatSBP.Entiteti.Krugovi>()
                                                                                   select o;
                foreach (ProjekatSBP.Entiteti.Krugovi k in sviKrugovi)
                {
                    krugovi.Add(new KrugoviPregled(k.Id, k.BrKruga, k.BrBiracaIzasli, k.ProcenatZa));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);//handle exception
            }
            return krugovi;
        }

        public static void dodajKrug(KrugoviBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Krugovi k = new ProjekatSBP.Entiteti.Krugovi();

                k.BrKruga = p.BrKruga;
                k.BrBiracaIzasli = p.BrBiracaIzasli;
                k.ProcenatZa = p.ProcenatZa;
               
                s.SaveOrUpdate(k);
                //s.Save(k)

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void ObrisiKrug(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Krugovi k = s.Load<Entiteti.Krugovi>(p);

                s.Delete(k);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static KrugoviBasic vratiKrug(int id)
        {
            KrugoviBasic pb = new KrugoviBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Krugovi o = s.Load<ProjekatSBP.Entiteti.Krugovi>(id);
                pb = new KrugoviBasic(o.Id, o.BrKruga, o.BrBiracaIzasli, o.ProcenatZa);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }

            return pb;
        }

        public static KrugoviBasic azurirajKrug(KrugoviBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Krugovi k = s.Load<ProjekatSBP.Entiteti.Krugovi>(p.Id);

                k.BrKruga= p.BrKruga;
                k.BrBiracaIzasli = p.BrBiracaIzasli;
                k.ProcenatZa = p.ProcenatZa;
                


                s.SaveOrUpdate(k);
                //s.Save(g)

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptin
            }
            return p;
        }
        #endregion
        #region Koordinator
        public static List<KoordinatorPregled> vratiSveKoordinator()
        {
            List<KoordinatorPregled> koordinatori = new List<KoordinatorPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.Koordinator> sviKoordinatori = from o in s.Query<ProjekatSBP.Entiteti.Koordinator>()
                                                                                select o;


                foreach (Koordinator u in sviKoordinatori)
                {
                    koordinatori.Add(new KoordinatorPregled(u.Id, u.LIme, u.ImeRoditelja, u.Prezime, u.DatumRodjenja, u.Adresa, u.BrTel1, u.Email1, u.ImeOpstine, u.AdresaKancelarije));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);//handle exception
            }
            return koordinatori;
        }

        public static void dodajKoordinatora(KoordinatorBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Koordinator u = new ProjekatSBP.Entiteti.Koordinator();

                u.LIme = p.Ime;
                u.ImeRoditelja = p.ImeRoditelja;
                u.Prezime = p.Prezime;
                u.DatumRodjenja = p.DatumRodjenja;
                u.Adresa = p.Adresa;
                u.BrTel1 = p.BrTel;
                u.Email1 = p.Email;
                u.ImeOpstine = p.ImeOpstine;
                u.AdresaKancelarije = p.AdresaKancelarije;

                s.SaveOrUpdate(u);
                //s.Save(o)

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);//handle exception
            }
        }

        public static void ObrisiKoordinatora(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Koordinator u = s.Load<Entiteti.Koordinator>(p);

                s.Delete(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static KoordinatorBasic vratiKoordinatora(int id)
        {
            KoordinatorBasic pb = new KoordinatorBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Koordinator o = s.Load<ProjekatSBP.Entiteti.Koordinator>(id);
                pb = new KoordinatorBasic(o.Id, o.LIme, o.ImeRoditelja, o.Prezime, o.DatumRodjenja, o.Adresa, o.BrTel1, o.Email1, o.ImeOpstine, o.AdresaKancelarije);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }

            return pb;
        }

        public static KoordinatorBasic azurirajKoordinator(KoordinatorBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Koordinator o = s.Load<ProjekatSBP.Entiteti.Koordinator>(p.Id);
                o.LIme = p.Ime;
                o.Prezime = p.Prezime;
                o.Adresa = p.Adresa;
                o.BrTel1 = p.BrTel;
                o.Email1 = p.Email;
                o.ImeOpstine = p.ImeOpstine;
                o.AdresaKancelarije = p.AdresaKancelarije;

                s.SaveOrUpdate(o);
                //s.Save(g)

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptin
            }
            return p;
        }
        #endregion
        #region Pomocnik
        public static List<PomocnikPregled> vratiSvePomocnike()
        {
            List<PomocnikPregled> pomocnici = new List<PomocnikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.Pomocnik> sviPomocnici = from o in s.Query<ProjekatSBP.Entiteti.Pomocnik>()
                                                                          select o;


                foreach (Pomocnik u in sviPomocnici)
                {
                    pomocnici.Add(new PomocnikPregled(u.Id, u.LIme, u.ImeRoditelja, u.Prezime, u.DatumRodjenja, u.Adresa, u.BrTel1, u.Email1));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }
            return pomocnici;
        }
        public static List<PomocnikPregled> vratiSvePomocKoordinatora(int kor)
        {
            List<PomocnikPregled> pomocnici = new List<PomocnikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Pomocnik> sviPom = from o in s.Query<Pomocnik>()
                                               where o.PripadaKoordinatoru.Id == kor
                                               select o;

                foreach (Pomocnik u in sviPom)
                {
                    pomocnici.Add(new PomocnikPregled(u.Id, u.LIme, u.ImeRoditelja, u.Prezime, u.DatumRodjenja, u.Adresa, u.BrTel1, u.Email1));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }
            return pomocnici;
        }
        public static void dodajPomocnika(PomocnikBasic p, int idK)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Pomocnik u = new ProjekatSBP.Entiteti.Pomocnik();
                Entiteti.Koordinator k = s.Load<Entiteti.Koordinator>(idK);
                if (k.Pomocnici.Count < 4)
                {
                    u.LIme = p.Ime;
                    u.ImeRoditelja = p.ImeRoditelja;
                    u.Prezime = p.Prezime;
                    u.DatumRodjenja = p.DatumRodjenja;
                    u.Adresa = p.Adresa;
                    u.BrTel1 = p.BrTel;
                    u.Email1 = p.Email;
                    u.PripadaKoordinatoru = k;
                    s.SaveOrUpdate(u);
                    //s.Save(o)

                    s.Flush();
                    s.Close();
                }
                else
                {
                    MessageBox.Show("Koordinator vec ima max broj pomoćnika(4)");
                    s.Close();
                }

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static void ObrisiPomocnika(int p)
        {
            /* try
             {
                 ISession s = DataLayer.GetSession();

                 Entiteti.Pomocnik u = s.Load<Entiteti.Pomocnik>(p);

                 s.Delete(u);
                 s.Flush();
                 s.Close();

             }
             catch (Exception ec)
             {
                 //handle exception
             }*/
        }

        public static PomocnikBasic vratiPomocnika(int id)
        {
            PomocnikBasic pb = new PomocnikBasic();
            /* try
             {
                 ISession s = DataLayer.GetSession();

                 ProjekatSBP.Entiteti.Pomocnik o = s.Load<ProjekatSBP.Entiteti.Pomocnik>(id);
                 pb = new PomocnikBasic(o.Id, o.LIme, o.ImeRoditelja, o.Prezime, o.DatumRodjenja.ToString(), o.Adresa, o.BrTel1, o.Email1);

                 s.Close();
             }
             catch (Exception ec)
             {
                 //handle exception
             }
            */
            return pb;
        }

        public static PomocnikBasic azurirajPomocnika(PomocnikBasic p)
        {
            /* try
             {
                 ISession s = DataLayer.GetSession();

                 ProjekatSBP.Entiteti.Pomocnik o = s.Load<ProjekatSBP.Entiteti.Pomocnik>(p.Id);
                 o.LIme = p.Ime;
                 o.Prezime = p.Prezime;
                 o.Adresa = p.Adresa;
                 o.BrTel1 = p.BrTel;
                 o.Email1 = p.Email;


                 s.SaveOrUpdate(o);
                 //s.Save(g)

                 s.Flush();
                 s.Close();
             }
             catch (Exception ec)
             {
                 //handle exceptin
             }*/
            return p;
        }

        #endregion
        #region Aktivista

        public static List<AktivistaPregled> vratiSveAktiviste()
        {
            List<AktivistaPregled> aktiviste = new List<AktivistaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.Aktivista> sveAktiviste = from o in s.Query<ProjekatSBP.Entiteti.Aktivista>()
                                                                           select o;


                foreach (Aktivista u in sveAktiviste)
                {
                    aktiviste.Add(new AktivistaPregled(u.Id, u.LIme, u.ImeRoditelja, u.Prezime, u.DatumRodjenja, u.Adresa, u.BrTel1, u.Email1, u.Primedbe, u.PripadaGlasackomMestu));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }
            return aktiviste;
        }

        public static void dodajAktivistu(AktivistaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Aktivista u = new ProjekatSBP.Entiteti.Aktivista();

                u.LIme = p.Ime;
                u.ImeRoditelja = p.ImeRoditelja;
                u.Prezime = p.Prezime;
                u.DatumRodjenja = p.DatumRodjenja;
                u.Adresa = p.Adresa;
                u.BrTel1 = p.BrTel;
                u.Email1 = p.Email;

                s.SaveOrUpdate(u);
                //s.Save(o)

                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static void ObrisiAktivistu(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Aktivista u = s.Load<Entiteti.Aktivista>(p);

                s.Delete(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static AktivistaBasic vratiAktivistu(int id)
        {
            AktivistaBasic pb = new AktivistaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Aktivista o = s.Load<ProjekatSBP.Entiteti.Aktivista>(id);
                pb = new AktivistaBasic(o.Id, o.LIme, o.ImeRoditelja, o.Prezime, o.DatumRodjenja, o.Adresa, o.BrTel1, o.Email1, o.Primedbe, o.PripadaGlasackomMestu);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }
            return pb;
        }

        public static AktivistaBasic azurirajAktivistu(AktivistaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Aktivista o = s.Load<ProjekatSBP.Entiteti.Aktivista>(p.Id);
                o.LIme = p.Ime;
                o.Prezime = p.Prezime;
                o.Adresa = p.Adresa;
                o.BrTel1 = p.BrTel;
                o.Email1 = p.Email;


                s.SaveOrUpdate(o);
                //s.Save(g)

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptin
            }
            return p;
        }
        public static void poveziAktivistuSaGM(int IdAkt, int IdGM)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Aktivista a = s.Load<ProjekatSBP.Entiteti.Aktivista>(IdAkt);
                ProjekatSBP.Entiteti.GlasackoMesto g = s.Load<GlasackoMesto>(IdGM);
                a.PripadaGlasackomMestu = g;
                g.Aktivisti.Add(a);

                s.SaveOrUpdate(a);
                //s.Save(g)
                //s.Update(a);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspešno rasporedjen!");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message); //handle exceptin
            }

        }

        public static void DodajPrimedbu(int id, string po)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Aktivista a = s.Load<ProjekatSBP.Entiteti.Aktivista>(id);
                a.Primedbe = po;


                s.SaveOrUpdate(a);
                //s.Save(g)
                //s.Update(a);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message); //handle exceptin
            }

        }


        #endregion


        #region Reklama
        public static List<ReklamaPregled> vratiSveReklame()
        {
            List<ReklamaPregled> reklame = new List<ReklamaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ProjekatSBP.Entiteti.Reklama> sveReklame = from r in s.Query<ProjekatSBP.Entiteti.Reklama>()
                                                                       select r;
                foreach (ProjekatSBP.Entiteti.Reklama r in sveReklame)
                {
                    reklame.Add(new ReklamaPregled(r.id, r.cena, r.vremenski_period, r.f_pano, r.grad, r.ulica, r.povrsina, r.agencija, r.f_novine, r.naziv_novina, r.boja, r.f_radio_tv, r.naziv_radio_tv, r.br_emitovanja, r.trajanje));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reklame;
        }
        /*
        public static List<ReklamaFlegPregled> vratiSveReklameFleg()
        {
            List<ReklamaFlegPregled> reklame = new List<ReklamaFlegPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ProjekatSBP.Entiteti.Reklama> sveReklame = from r in s.Query<ProjekatSBP.Entiteti.Reklama>()
                                                                       select r;
                foreach (ProjekatSBP.Entiteti.Reklama r in sveReklame)
                {
                    reklame.Add(new ReklamaFlegPregled(r.id, r.cena, r.vremenski_period, r.f_pano,r.grad,r.ulica,r.povrsina,r.agencija,r.f_novine,r.naziv_novina,r.boja,r.f_radio_tv,r.naziv_radio_tv,r.br_emitovanja,r.trajanje));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reklame;
        }*/

        public static void dodajReklamu(ReklamaBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProjekatSBP.Entiteti.Reklama o = new ProjekatSBP.Entiteti.Reklama();
                o.cena = r.CenaReklame;
                o.vremenski_period = r.VremenskiPeriod;
                o.f_pano = r.FPano;
                o.grad = r.Grad;
                o.ulica = r.Ulica;
                o.povrsina = r.Povrsina;
                o.agencija = r.Agencija;
                o.f_novine = r.FNovine;
                o.naziv_novina = r.NazivNovina;
                o.boja = r.Boja;
                o.f_radio_tv = r.FRadioTv;
                o.naziv_radio_tv = r.NazivRadioTv;
                o.br_emitovanja = r.BrEmitovanja;
                o.trajanje = r.Trajanje;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /*
        public static void dodajFlagReklamu(ReklamaFlegBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProjekatSBP.Entiteti.Reklama o = new ProjekatSBP.Entiteti.Reklama();
                o.cena = r.CenaReklame;
                o.vremenski_period = r.VremenskiPeriod;
                o.f_pano = r.FPano;
                o.grad = r.Grad;
                o.ulica = r.Ulica;
                o.povrsina = r.Povrsina;
                o.agencija = r.Agencija;
                o.f_novine = r.FNovine;
                o.naziv_novina = r.NazivNovina;
                o.boja = r.Boja;
                o.f_radio_tv = r.FRadioTv;
                o.naziv_radio_tv = r.NazivRadioTv;
                o.br_emitovanja = r.BrEmitovanja;
                o.trajanje = r.Trajanje;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/

        public static ReklamaBasic azurirajReklamu(ReklamaBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Reklama o = s.Load<ProjekatSBP.Entiteti.Reklama>(r.ReklamaId);
                o.cena = r.CenaReklame;
                o.vremenski_period = r.VremenskiPeriod;
                o.f_pano = r.FPano;
                o.grad = r.Grad;
                o.ulica = r.Ulica;
                o.povrsina = r.Povrsina;
                o.agencija = r.Agencija;
                o.f_novine = r.FNovine;
                o.naziv_novina = r.NazivNovina;
                o.boja = r.Boja;
                o.f_radio_tv = r.FRadioTv;
                o.naziv_radio_tv = r.NazivRadioTv;
                o.br_emitovanja = r.BrEmitovanja;
                o.trajanje = r.Trajanje;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return r;
        }
        /*
        public static ReklamaFlegBasic azurirajReklamuFleg(ReklamaFlegBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Reklama o = s.Load<ProjekatSBP.Entiteti.Reklama>(r.ReklamaId);
                o.cena = r.CenaReklame;
                o.vremenski_period = r.VremenskiPeriod;
                o.f_pano = r.FPano;
                o.grad = r.Grad;
                o.ulica = r.Ulica;
                o.povrsina = r.Povrsina;
                o.agencija = r.Agencija;
                o.f_novine = r.FNovine;
                o.naziv_novina = r.NazivNovina;
                o.boja = r.Boja;
                o.f_radio_tv = r.FRadioTv;
                o.naziv_radio_tv = r.NazivRadioTv;
                o.br_emitovanja = r.BrEmitovanja;
                o.trajanje = r.Trajanje;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return r;
        }*/

        public static ReklamaBasic vratiReklamu(int id)
        {
            ReklamaBasic rb = new ReklamaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Reklama o = s.Load<ProjekatSBP.Entiteti.Reklama>(id);
                rb = new ReklamaBasic(o.id, o.cena, o.vremenski_period, o.f_pano, o.grad, o.ulica, o.povrsina, o.agencija, o.f_novine, o.naziv_novina, o.boja, o.f_radio_tv, o.naziv_radio_tv, o.br_emitovanja, o.trajanje);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rb;
        }

        public static void obrisiReklamu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Reklama o = s.Load<ProjekatSBP.Entiteti.Reklama>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region Akcija
        public static List<AkcijaPregled> vratiSveAkcije()
        {
            List<AkcijaPregled> akcije = new List<AkcijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ProjekatSBP.Entiteti.Akcija> sveAkcije = from a in s.Query<ProjekatSBP.Entiteti.Akcija>()
                                                                     select a;
                foreach (ProjekatSBP.Entiteti.Akcija a in sveAkcije)
                {
                    akcije.Add(new AkcijaPregled(a.id, a.naziv, a.grad, a.lokacija, a.f_deljenje_letaka, a.f_susret_sa_gradjanima, a.vreme, a.f_miting, a.f_na_otvorenom, a.f_na_zatvorenom, a.naziv_firme, a.cena_prostora, a.koordinator));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return akcije;
        }



        public static void dodajAkciju(AkcijaBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProjekatSBP.Entiteti.Akcija o = new ProjekatSBP.Entiteti.Akcija();
                o.naziv = a.Naziv;
                o.grad = a.Grad;
                o.lokacija = a.Lokacija;
                o.f_deljenje_letaka = a.FDeljenjeLetaka;
                o.f_susret_sa_gradjanima = a.FSusretSaGradjanima;
                o.vreme = a.Vreme;
                o.f_miting = a.FMiting;
                o.f_na_otvorenom = a.FNaOtvorenom;
                o.f_na_zatvorenom = a.FNaZatvorenom;
                o.naziv_firme = a.NazivFirme;
                o.cena_prostora = a.CenaProstora;
                o.koordinator = a.Koordinator;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static AkcijaBasic azurirajAkciju(AkcijaBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Akcija o = s.Load<ProjekatSBP.Entiteti.Akcija>(a.Id);
                o.naziv = a.Naziv;
                o.grad = a.Grad;
                o.lokacija = a.Lokacija;
                o.naziv = a.Naziv;
                o.grad = a.Grad;
                o.lokacija = a.Lokacija;
                o.f_deljenje_letaka = a.FDeljenjeLetaka;
                o.f_susret_sa_gradjanima = a.FSusretSaGradjanima;
                o.vreme = a.Vreme;
                o.f_miting = a.FMiting;
                o.f_na_otvorenom = a.FNaOtvorenom;
                o.f_na_zatvorenom = a.FNaZatvorenom;
                o.naziv_firme = a.NazivFirme;
                o.cena_prostora = a.CenaProstora;
                //o.koordinator.Id = a.IdKoordinatora;
                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return a;
        }

        public static AkcijaBasic vratiAkciju(int id)
        {
            AkcijaBasic ab = new AkcijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Akcija o = s.Load<ProjekatSBP.Entiteti.Akcija>(id);
                ab = new AkcijaBasic(o.id, o.naziv, o.grad, o.lokacija, o.f_deljenje_letaka, o.f_susret_sa_gradjanima, o.vreme, o.f_miting, o.f_na_otvorenom, o.f_na_zatvorenom, o.naziv_firme, o.cena_prostora, o.koordinator);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ab;
        }

        public static Akcija VratiAkciju(int id)
        {
            Akcija a = new Akcija();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Akcija o = s.Load<ProjekatSBP.Entiteti.Akcija>(id);
                a = o;

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return a;
        }

        public static Koordinator VratiKoordinatora(int id)
        {
            Koordinator k = new Koordinator();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Koordinator o = s.Load<ProjekatSBP.Entiteti.Koordinator>(id);

                k = o;
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return k;
        }
        public static void obrisiAkciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Akcija o = s.Load<ProjekatSBP.Entiteti.Akcija>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static List<Akcija> MitingGosti(int idGosta)
        {
            List<Akcija> mitinzi = new List<Akcija>();
            //List<GostPregled> gosti = new List<GostPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ProjekatSBP.Entiteti.Akcija> sveAkcije = from g in s.Query<ProjekatSBP.Entiteti.Akcija>()
                                                                     where g.gosti_mitinga.Contains((VratiGosta(idGosta)))
                                                                     select g;
                foreach (ProjekatSBP.Entiteti.Akcija g in sveAkcije)
                {
                    //gosti.Add(new GostPregled(g.id, g.ime, g.prezime, g.funkcija));
                    // if (g.mitinzi.Contains(VratiAkciju(idMitinga)))
                    //{
                    mitinzi.Add(g);
                    //MessageBox.Show(g.ime);
                    //}
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return mitinzi;
        }
        #endregion
        #region Gost
        public static List<GostPregled> vratiSveGoste()
        {
            List<GostPregled> gosti = new List<GostPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ProjekatSBP.Entiteti.Gost> sviGosti = from g in s.Query<ProjekatSBP.Entiteti.Gost>()
                                                                  select g;
                foreach (ProjekatSBP.Entiteti.Gost g in sviGosti)
                {
                    gosti.Add(new GostPregled(g.id, g.ime, g.prezime, g.funkcija));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return gosti;
        }

        public static void dodajGosta(Gost g, int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Gost gost = new Gost();

                ProjekatSBP.Entiteti.Akcija a = s.Load<ProjekatSBP.Entiteti.Akcija>(id);
                gost = g;
                gost.mitinzi.Add(a);
                /*Gost o = new ProjekatSBP.Entiteti.Gost()
            {
                ime = g.Ime,
                prezime = g.Prezime,
                funkcija = g.Funkcija
            };  */

                //mitinzi
                s.SaveOrUpdate(gost);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static GostBasic azurirajGosta(GostBasic g)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Gost o = s.Load<ProjekatSBP.Entiteti.Gost>(g.Id);
                o.ime = g.Ime;
                o.prezime = g.Prezime;
                o.funkcija = g.Funkcija;
                //mitinzi?
                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return g;
        }

        public static GostBasic vratiGosta(int id)
        {
            GostBasic gb = new GostBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Gost o = s.Load<ProjekatSBP.Entiteti.Gost>(id);
                gb = new GostBasic(o.id, o.ime, o.prezime, o.funkcija);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return gb;
        }

        public static Gost VratiGosta(int id)
        {
            Gost g = new Gost();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Gost o = s.Load<ProjekatSBP.Entiteti.Gost>(id);
                g = o;

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return g;
        }

        public static void obrisiGosta(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Gost o = s.Load<ProjekatSBP.Entiteti.Gost>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static List<Gost> GostiMitinga(int idMitinga)
        {
            List<Gost> gosti = new List<Gost>();
            //List<GostPregled> gosti = new List<GostPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ProjekatSBP.Entiteti.Gost> sviGosti = from g in s.Query<ProjekatSBP.Entiteti.Gost>()
                                                                  where g.mitinzi.Contains((VratiAkciju(idMitinga)))
                                                                  select g;
                foreach (ProjekatSBP.Entiteti.Gost g in sviGosti)
                {
                    //gosti.Add(new GostPregled(g.id, g.ime, g.prezime, g.funkcija));
                    // if (g.mitinzi.Contains(VratiAkciju(idMitinga)))
                    //{
                    gosti.Add(g);
                    //MessageBox.Show(g.ime);
                    //}
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return gosti;
        }
        #endregion

        #region Intervjui
        public static List<IntervjuNovinePregled> vratiSveIntervjue()
        {
            List<IntervjuNovinePregled> intervjui = new List<IntervjuNovinePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.IntervjuNovine> sviIntervjui = from o in s.Query<ProjekatSBP.Entiteti.IntervjuNovine>()
                                                                           select o;

                foreach (ProjekatSBP.Entiteti.IntervjuNovine i in sviIntervjui)
                {
                    intervjui.Add(new IntervjuNovinePregled(i.Id, i.NazivLista, i.DatumPisanja, i.DatumObjavljivanja, i.Novinar1, i.Novinar2));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return intervjui;
        }

        public static void dodajIntervjuNovine(IntervjuNovineBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.IntervjuNovine o = new ProjekatSBP.Entiteti.IntervjuNovine();

                o.NazivLista = p.NazivLista;
                o.DatumPisanja = p.DatumPisanja;
                o.DatumObjavljivanja = p.DatumObjavljivanja;
                o.Novinar1 = p.Novinar1;
                o.Novinar2 = p.Novinar2;


                s.SaveOrUpdate(o);
                //s.Save(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greska:{ec.Message}!"); //handle exceptions
            }
        }
        public static void obrisiIntervjuNovine(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.IntervjuNovine u = s.Load<Entiteti.IntervjuNovine>(p);

                //brise se objekat iz baze ali ne i instanca objekta u memroiji
                s.Delete(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static IntervjuNovineBasic vratiIntervju(int id)
        {
            IntervjuNovineBasic pb = new IntervjuNovineBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.IntervjuNovine o = s.Load<ProjekatSBP.Entiteti.IntervjuNovine>(id);
                pb = new IntervjuNovineBasic(o.Id, o.NazivLista, o.DatumPisanja, o.DatumObjavljivanja, o.Novinar1, o.Novinar2);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static IntervjuNovineBasic azurirajIntervjuNovine(IntervjuNovineBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.IntervjuNovine o = s.Load<ProjekatSBP.Entiteti.IntervjuNovine>(p.Id);
                o.NazivLista = p.NazivLista;
                o.DatumPisanja = p.DatumPisanja;
                o.DatumObjavljivanja = p.DatumObjavljivanja;
                o.Novinar1 = p.Novinar1;
                o.Novinar2 = p.Novinar2;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }
        #endregion 
        #region Emisije
        public static List<TVIRadioEmisijePregled> vratiSveEmisije()
        {
            List<TVIRadioEmisijePregled> emisije = new List<TVIRadioEmisijePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.TVIRadioEmisije> sveEmisije = from o in s.Query<ProjekatSBP.Entiteti.TVIRadioEmisije>()
                                                                          select o;

                foreach (ProjekatSBP.Entiteti.TVIRadioEmisije i in sveEmisije)
                {
                    emisije.Add(new TVIRadioEmisijePregled(i.Id, i.NazivStanice, i.NazivEmisije, i.ImeVoditelja, i.Gledanost));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return emisije;
        }
        public static void dodajEmisiju(TVIRadioEmisijeBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.TVIRadioEmisije o = new ProjekatSBP.Entiteti.TVIRadioEmisije();

                o.NazivStanice = p.NazivStanice;
                o.NazivEmisije = p.NazivEmisije;
                o.ImeVoditelja = p.ImeVoditelja;
                o.Gledanost = p.Gledanost;


                s.SaveOrUpdate(o);
                //s.Save(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greska:{ec.Message}!");//handle exceptions
            }
        }
        public static TVIRadioEmisijeBasic vratiEmisiju(int id)
        {
            TVIRadioEmisijeBasic pb = new TVIRadioEmisijeBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.TVIRadioEmisije o = s.Load<ProjekatSBP.Entiteti.TVIRadioEmisije>(id);
                pb = new TVIRadioEmisijeBasic(o.Id, o.NazivStanice, o.NazivEmisije, o.ImeVoditelja, o.Gledanost);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }
        public static TVIRadioEmisijeBasic azurirajEmisiju(TVIRadioEmisijeBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.TVIRadioEmisije o = s.Load<ProjekatSBP.Entiteti.TVIRadioEmisije>(p.Id);
                o.NazivStanice = p.NazivStanice;
                o.NazivEmisije = p.NazivEmisije;
                o.ImeVoditelja = p.ImeVoditelja;
                o.Gledanost = p.Gledanost;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }
        public static void obrisiEmisiju(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.TVIRadioEmisije u = s.Load<Entiteti.TVIRadioEmisije>(p);

                //brise se objekat iz baze ali ne i instanca objekta u memroiji
                s.Delete(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion
        #region TVDueli
        public static List<TVDueliPregled> vratiSveTVDuele()
        {
            List<TVDueliPregled> dueli = new List<TVDueliPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.TVDueli> sviTVDueli = from o in s.Query<ProjekatSBP.Entiteti.TVDueli>()
                                                                  select o;

                foreach (ProjekatSBP.Entiteti.TVDueli i in sviTVDueli)
                {
                    dueli.Add(new TVDueliPregled(i.Id, i.NazivStanice, i.NazivEmisije, i.ImeVoditelja, i.Gledanost));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return dueli;
        }
        public static void dodajDuel(TVDueliBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.TVDueli o = new ProjekatSBP.Entiteti.TVDueli();

                o.NazivStanice = p.NazivStanice;
                o.NazivEmisije = p.NazivEmisije;
                o.ImeVoditelja = p.ImeVoditelja;
                o.Gledanost = p.Gledanost;


                s.SaveOrUpdate(o);
                //s.Save(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greska:{ec.Message}!");//handle exceptions
            }
        }
        public static TVDueliBasic vratiDuel(int id)
        {
            TVDueliBasic pb = new TVDueliBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.TVDueli o = s.Load<ProjekatSBP.Entiteti.TVDueli>(id);
                pb = new TVDueliBasic(o.Id, o.NazivStanice, o.NazivEmisije, o.ImeVoditelja, o.Gledanost);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }
        public static TVDueliBasic azurirajDuel(TVDueliBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.TVDueli o = s.Load<ProjekatSBP.Entiteti.TVDueli>(p.Id);
                o.NazivStanice = p.NazivStanice;
                o.NazivEmisije = p.NazivEmisije;
                o.ImeVoditelja = p.ImeVoditelja;
                o.Gledanost = p.Gledanost;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }
        public static void obrisiDuel(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.TVDueli u = s.Load<Entiteti.TVDueli>(p);

                //brise se objekat iz baze ali ne i instanca objekta u memroiji
                s.Delete(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void najgledanijiDueli()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<TVDueli> dueli = from o in s.Query<TVDueli>()
                                             where o.Gledanost > 0.5
                                             select o;


                foreach (TVDueli o in dueli)
                {
                    MessageBox.Show(" Id: " + o.Id + " emisija: " + o.NazivEmisije + " " + o.Gledanost.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);//handle exceptions
            }

        }

        #endregion
        #region SpisakPitanja
        public static List<SpisakPitanja> vratiPitanjaDuela(int duelId)
        {
            List<SpisakPitanja> odInfos = new List<SpisakPitanja>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<SpisakPitanja> pitanja = from o in s.Query<SpisakPitanja>()
                                                     where o.Id.PripadaTVDuelu.Id == duelId
                                                     select o;


                foreach (SpisakPitanja o in pitanja)
                {
                    odInfos.Add(new SpisakPitanja(o.Id));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);//handle exceptions
            }

            return odInfos;
        }

        public static void sacuvajPitanje(SpisakPitanja pitanje, int idD)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpisakPitanja o = new SpisakPitanja();

                ProjekatSBP.Entiteti.TVDueli p = s.Load<ProjekatSBP.Entiteti.TVDueli>(idD);
                o = pitanje;
                o.Id.Pitanje = pitanje.Id.Pitanje;
                o.Id.PripadaTVDuelu = p;

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);//handle exceptions
            }
        }
        public static void obrisiPitanje(SpisakPitanja pit, int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakPitanja o = new SpisakPitanja();
                ProjekatSBP.Entiteti.TVDueli p = s.Load<ProjekatSBP.Entiteti.TVDueli>(id);
                o = pit;
                o.Id.Pitanje = pit.Id.Pitanje;
                o.Id.PripadaTVDuelu = p;

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion
        #region Protivkandidati
        public static List<Protivkandidati> vratiProtivkandidateDuela(int duelId)
        {
            List<Protivkandidati> odInfos = new List<Protivkandidati>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Protivkandidati> protiv = from o in s.Query<Protivkandidati>()
                                                      where o.Id.PripadaTVDuelu.Id == duelId
                                                      select o;


                foreach (Protivkandidati o in protiv)
                {
                    odInfos.Add(new Protivkandidati(o.Id));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);//handle exceptions
            }

            return odInfos;
        }
        public static void sacuvajProtivkandidata(Protivkandidati protiv, int idD)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Protivkandidati o = new Protivkandidati();

                ProjekatSBP.Entiteti.TVDueli p = s.Load<ProjekatSBP.Entiteti.TVDueli>(idD);
                o = protiv;
                o.Id.Protivkandidat = protiv.Id.Protivkandidat;
                o.Id.PripadaTVDuelu = p;

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);//handle exceptions
            }
        }
        public static void obrisiProtivkandidata(Protivkandidati pit, int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Protivkandidati o = new Protivkandidati();
                ProjekatSBP.Entiteti.TVDueli p = s.Load<ProjekatSBP.Entiteti.TVDueli>(id);
                o = pit;
                o.Id.Protivkandidat = pit.Id.Protivkandidat;
                o.Id.PripadaTVDuelu = p;

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        #endregion
    }
}
