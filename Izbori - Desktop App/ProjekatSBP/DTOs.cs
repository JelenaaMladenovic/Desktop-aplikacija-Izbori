using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP
{
    #region Ucesnik
    public class UcesnikPregled
    {
        public int Id;
        public string Ime;
        public string ImeRoditelja;
        public string Prezime;
        public DateTime DatumRodjenja;
        public string Adresa;
        public int BrTel;
        public string Email;


        public UcesnikPregled()
        {

        }

        public UcesnikPregled(int Id, string Ime, string ImeRoditelja, string Prezime, DateTime DatumRodjenja, string Adresa, int BrTel, string Email)
        {
            this.Id = Id;
            this.Ime = Ime;
            this.ImeRoditelja = ImeRoditelja;
            this.Prezime = Prezime;
            this.DatumRodjenja = DatumRodjenja;
            this.Adresa = Adresa;
            this.BrTel = BrTel;
            this.Email = Email;

        }
    }
    public class KoordinatorPregled : UcesnikPregled
    {
        public string ImeOpstine;
        public string AdresaKancelarije;

        public KoordinatorPregled() : base()
        {

        }
        public KoordinatorPregled(int Id, string Ime, string ImeRoditelja, string Prezime, DateTime DatumRodjenja, string Adresa, int BrTel, string Email, string ImeOpstine, string AdresaKancelarije) : base(Id, Ime, ImeRoditelja, Prezime, DatumRodjenja, Adresa, BrTel, Email)
        {
            this.ImeOpstine = ImeOpstine;
            this.AdresaKancelarije = AdresaKancelarije;
        }

    }
    public class PomocnikPregled : UcesnikPregled
    {
        //public KoordinatorBasic PripadaKoordinatoru;
        public PomocnikPregled() : base()
        {

        }
        public PomocnikPregled(int Id, string Ime, string ImeRoditelja, string Prezime, DateTime DatumRodjenja, string Adresa, int BrTel, string Email/*,KoordinatorBasic PripadaKoordinatoru*/) : base(Id, Ime, ImeRoditelja, Prezime, DatumRodjenja, Adresa, BrTel, Email)
        {
            //this.PripadaKoordinatoru = PripadaKoordinatoru;
        }

    }

    public class AktivistaPregled : UcesnikPregled
    {
        public string Primedbe;
        public GlasackoMesto PripadaGlasackomMestu;
        public AktivistaPregled() : base() { }
        public AktivistaPregled(int Id, string Ime, string ImeRoditelja, string Prezime, DateTime DatumRodjenja, string Adresa, int BrTel, string Email, string Primedbe, GlasackoMesto PripadaGlasackomMestu) : base(Id, Ime, ImeRoditelja, Prezime, DatumRodjenja, Adresa, BrTel, Email)
        {
            this.Primedbe = Primedbe;
            this.PripadaGlasackomMestu = PripadaGlasackomMestu;
        }
        public AktivistaPregled(int Id, string Ime, string ImeRoditelja, string Prezime, DateTime DatumRodjenja, string Adresa, int BrTel, string Email) : base(Id, Ime, ImeRoditelja, Prezime, DatumRodjenja, Adresa, BrTel, Email)
        {

        }
    }

    public class UcesnikBasic
    {

        public int Id;
        public string Ime;
        public string ImeRoditelja;
        public string Prezime;
        public DateTime DatumRodjenja;
        public string Adresa;
        public int BrTel;
        public string Email;


        public UcesnikBasic()
        {

        }

        public UcesnikBasic(int Id, string Ime, string ImeRoditelja, string Prezime, DateTime DatumRodjenja, string Adresa, int BrTel, string Email)
        {
            this.Id = Id;
            this.Ime = Ime;
            this.ImeRoditelja = ImeRoditelja;
            this.Prezime = Prezime;
            this.DatumRodjenja = DatumRodjenja;
            this.Adresa = Adresa;
            this.BrTel = BrTel;
            this.Email = Email;

        }
    }
    public class KoordinatorBasic : UcesnikBasic
    {
        public string ImeOpstine;
        public string AdresaKancelarije;
        public List<Pomocnik> Pomocnici;

        public KoordinatorBasic() : base()
        {
            Pomocnici = new List<Pomocnik>();
        }
        public KoordinatorBasic(int Id, string Ime, string ImeRoditelja, string Prezime, DateTime DatumRodjenja, string Adresa, int BrTel, string Email, string ImeOpstine, string AdresaKancelarije) : base(Id, Ime, ImeRoditelja, Prezime, DatumRodjenja, Adresa, BrTel, Email)
        {
            this.ImeOpstine = ImeOpstine;
            this.AdresaKancelarije = AdresaKancelarije;
        }

    }
    public class PomocnikBasic : UcesnikBasic
    {
        public Koordinator PripadaKoordinatoru;
        public PomocnikBasic() : base()
        {

        }
        public PomocnikBasic(int Id, string Ime, string ImeRoditelja, string Prezime, DateTime DatumRodjenja, string Adresa, int BrTel, string Email, Koordinator PripadaKoordinatoru) : base(Id, Ime, ImeRoditelja, Prezime, DatumRodjenja, Adresa, BrTel, Email)
        {
            this.PripadaKoordinatoru = PripadaKoordinatoru;
        }

    }

    public class AktivistaBasic : UcesnikBasic
    {
        public string Primedbe;
        public GlasackoMesto PripadaGlasackomMestu;
        public AktivistaBasic() : base() { }
        public AktivistaBasic(int Id, string Ime, string ImeRoditelja, string Prezime, DateTime DatumRodjenja, string Adresa, int BrTel, string Email, string Primedba, GlasackoMesto pripada) : base(Id, Ime, ImeRoditelja, Prezime, DatumRodjenja, Adresa, BrTel, Email)
        {
            this.Primedbe = Primedbe;
            this.PripadaGlasackomMestu = pripada;
        }
    }

    #endregion

    #region GlasackoMesto
    public class GlasackoMestoPregled
    {
        public int Id;
        public string NazivIzborneJedinice;
        public int BrGlasackogMesta;
        public int BrBiraca;

        public GlasackoMestoPregled()
        {

        }

        public GlasackoMestoPregled(int Id, string NazivIzborneJedinice, int BrGlasackogMesta, int BrBiraca)
        {
            this.Id=Id;
            this.NazivIzborneJedinice = NazivIzborneJedinice;
            this.BrGlasackogMesta=BrGlasackogMesta;
            this.BrBiraca=BrBiraca;
        }
    }

    public class GlasackoMestoBasic
    {
        public int Id;
        public string NazivIzborneJedinice;
        public int BrGlasackogMesta;
        public int BrBiraca;
        public virtual IList<Ucesnik> Ucesnici { get; set; }
        public virtual IList<Krugovi> KrugoviGlasanja { get; set; }
        public virtual IList<Rezultati> RezultatiKrugovi { get; set; }

        public GlasackoMestoBasic()
        {
            Ucesnici = new List<Ucesnik>();
            KrugoviGlasanja = new List<Krugovi>();
            RezultatiKrugovi= new List<Rezultati>();
        }

        public GlasackoMestoBasic(int Id, string NazivIzborneJedinice, int BrGlasackogMesta, int BrBiraca)
        {
            this.Id = Id;
            this.NazivIzborneJedinice = NazivIzborneJedinice;
            this.BrGlasackogMesta = BrGlasackogMesta;
            this.BrBiraca = BrBiraca;
        }
    }
    #endregion

    #region Krugovi

    public class KrugoviPregled
    {
        public int Id;
        public string BrKruga;
        public int BrBiracaIzasli;
        public double ProcenatZa;

        public KrugoviPregled()
        {

        }

        public KrugoviPregled(int Id, string BrKruga, int BrBiracaIzasli, double ProcenatZa)
        {
            this.Id=Id;
            this.BrKruga=BrKruga;
            this.BrBiracaIzasli=BrBiracaIzasli;
            this.ProcenatZa=ProcenatZa;
        }
    }

    public class KrugoviBasic
    {
        public int Id;
        public string BrKruga;
        public int BrBiracaIzasli;
        public double ProcenatZa;

        public KrugoviBasic()
        {

        }

        public KrugoviBasic(int Id, string BrKruga, int BrBiracaIzasli, double ProcenatZa)
        {
            this.Id = Id;
            this.BrKruga = BrKruga;
            this.BrBiracaIzasli = BrBiracaIzasli;
            this.ProcenatZa = ProcenatZa;
        }
    }
    #endregion

    #region Rezultati

    public class RezultatiPregled
    {
        public RezultatiId Id;

        public RezultatiPregled()
        {
            Id=new RezultatiId();
        }

        public RezultatiPregled(RezultatiId Id)
        {
            this.Id=Id;
        }
    }

    public class RezultatiIdPregled
    {
        public KrugoviPregled KrugoviRezultati;
        public GlasackoMestoPregled GlasackoMestoRezultati;

        public RezultatiIdPregled()
        {

        }

    }

    public class RezultatiBasic
    {
        public RezultatiId Id;

        public RezultatiBasic()
        {
            Id = new RezultatiId();
        }

        public RezultatiBasic(RezultatiId Id)
        {
            this.Id = Id;
        }
    }

    public class ReziltatiIdBasic
    {
        public KrugoviPregled KrugoviRezultati;
        public GlasackoMestoPregled GlasackoMestoRezultati;

        public ReziltatiIdBasic()
        {

        }
    }
    #endregion


    #region Reklama
    public class ReklamaBasic
    {
        public int ReklamaId { get; set; }
        public double CenaReklame { get; set; }
        public int VremenskiPeriod { get; set; }
        public string FPano { get; set; }
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public double Povrsina { get; set; }
        public string Agencija { get; set; }
        public string FNovine { get; set; }
        public string NazivNovina { get; set; }
        public string Boja { get; set; }
        public string FRadioTv { get; set; }
        public string NazivRadioTv { get; set; }
        public int BrEmitovanja { get; set; }
        public int Trajanje { get; set; }

        public ReklamaBasic(int id, double cena, int vr, string fp, string grad, string ulica, double p, string agencija, string fn, string naziv, string boja, string frtv, string nazivrtv, int brem, int trajanje)
        {
            this.ReklamaId = id;
            this.CenaReklame = cena;
            this.VremenskiPeriod = vr;
            this.FPano = fp;
            this.Grad = grad;
            this.Ulica = ulica;
            this.Povrsina = p;
            this.Agencija = agencija;
            this.FNovine = fn;
            this.NazivNovina = naziv;
            this.Boja = boja;
            this.FRadioTv = frtv;
            this.NazivRadioTv = nazivrtv;
            this.BrEmitovanja = brem;
            this.Trajanje = trajanje;
        }

        public ReklamaBasic()
        {

        }
    }

    public class ReklamaPregled
    {
        public int ReklamaId;
        public double CenaReklame;
        public int VremenskiPeriod;
        public string FPano;
        public string Grad;
        public string Ulica;
        public double Povrsina;
        public string Agencija;
        public string FNovine;
        public string NazivNovina;
        public string Boja;
        public string FRadioTv;
        public string NazivRadioTv;
        public int BrEmitovanja;
        public int Trajanje;

        public ReklamaPregled(int id, double cena, int vr, string fp, string grad, string ulica, double p, string agencija, string fn, string naziv, string boja, string frtv, string nazivrtv, int brem, int trajanje)
        {
            this.ReklamaId = id;
            this.CenaReklame = cena;
            this.VremenskiPeriod = vr;
            this.FPano = fp;
            this.Grad = grad;
            this.Ulica = ulica;
            this.Povrsina = p;
            this.Agencija = agencija;
            this.FNovine = fn;
            this.NazivNovina = naziv;
            this.Boja = boja;
            this.FRadioTv = frtv;
            this.NazivRadioTv = nazivrtv;
            this.BrEmitovanja = brem;
            this.Trajanje = trajanje;
        }

        public ReklamaPregled()
        {

        }
    }
    /*
    public class ReklamaFlegBasic
    {
        public int ReklamaId { get; set; }
        public double CenaReklame { get; set; }
        public int VremenskiPeriod { get; set; }
        public string FPano { get; set; }
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public double Povrsina { get; set; }
        public string Agencija { get; set; }
        public string FNovine { get; set; }
        public string NazivNovina { get; set; }
        public string Boja { get; set; }
        public string FRadioTv { get; set; }
        public string NazivRadioTv { get; set; }
        public int BrEmitovanja { get; set; }
        public int Trajanje { get; set; }


        public ReklamaFlegBasic(int id, double cena, int vr, string fp, string grad, string ulica, double p, string agencija, string fn, string naziv, string boja, string frtv, string nazivrtv, int brem, int trajanje)
        {
            this.ReklamaId = id;
            this.CenaReklame = cena;
            this.VremenskiPeriod = vr;
            this.FPano = fp;
            this.Grad = grad;
            this.Ulica = ulica;
            this.Povrsina = p;
            this.Agencija = agencija;
            this.FNovine = fn;
            this.NazivNovina = naziv;
            this.Boja = boja;
            this.FRadioTv = frtv;
            this.NazivRadioTv = nazivrtv;
            this.BrEmitovanja = brem;
            this.Trajanje = trajanje;
        }

        public ReklamaFlegBasic()
        {

        }
    }

    public class ReklamaFlegPregled
    {
        public int ReklamaId;
        public double CenaReklame;
        public int VremenskiPeriod;
        public string FPano { get; set; }
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public double Povrsina { get; set; }
        public string Agencija { get; set; }
        public string FNovine { get; set; }
        public string NazivNovina { get; set; }
        public string Boja { get; set; }
        public string FRadioTv { get; set; }
        public string NazivRadioTv { get; set; }
        public int BrEmitovanja { get; set; }
        public int Trajanje { get; set; }

        public ReklamaFlegPregled(int id, double cena, int vr, string fp, string grad, string ulica, double p, string agencija, string fn, string naziv, string boja, string frtv, string nazivrtv, int brem, int trajanje)
        {
            this.ReklamaId = id;
            this.CenaReklame = cena;
            this.VremenskiPeriod = vr;
            this.FPano = fp;
            this.Grad = grad;
            this.Ulica = ulica;
            this.Povrsina = p;
            this.Agencija = agencija;
            this.FNovine = fn;
            this.NazivNovina = naziv;
            this.Boja = boja;
            this.FRadioTv = frtv;
            this.NazivRadioTv = nazivrtv;
            this.BrEmitovanja = brem;
            this.Trajanje = trajanje;
        }

        public ReklamaFlegPregled()
        {

        }
    }*/
    #endregion

    #region Akcija
    public class AkcijaPregled
    {
        public int Id;
        public string Naziv;
        public string Grad;
        public string Lokacija;
        public string FDeljenjeLetaka;
        public string FSusretSaGradjanima;
        public string Vreme;
        public string FMiting;
        public string FNaOtvorenom;
        public string FNaZatvorenom;
        public string NazivFirme;
        public double CenaProstora;
        public Koordinator Koordinator;
        public IList<GostBasic> GostiMitinga;

        public AkcijaPregled(int id, string naziv, string grad, string lok, string fl, string fs, string vreme, string fm, string fo, string fz, string nazivfirme, double cena, Koordinator koord)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Grad = grad;
            this.Lokacija = lok;
            this.FDeljenjeLetaka = fl;
            this.FSusretSaGradjanima = fs;
            this.Vreme = vreme;
            this.FMiting = fm;
            this.FNaOtvorenom = fo;
            this.FNaZatvorenom = fz;
            this.NazivFirme = nazivfirme;
            this.CenaProstora = cena;
            this.Koordinator = koord;

        }

        public AkcijaPregled()
        {
            GostiMitinga = new List<GostBasic>();
        }

    }

    public class AkcijaBasic
    {
        public int Id;
        public string Naziv;
        public string Grad;
        public string Lokacija;
        public string FDeljenjeLetaka;
        public string FSusretSaGradjanima;
        public string Vreme;
        public string FMiting;
        public string FNaOtvorenom;
        public string FNaZatvorenom;
        public string NazivFirme;
        public double CenaProstora;
        public Koordinator Koordinator;
        public IList<GostBasic> GostiMitinga;
        public AkcijaBasic()
        {
            GostiMitinga = new List<GostBasic>();
        }

        public AkcijaBasic(int id, string naziv, string grad, string lok, string fl, string fs, string vreme, string fm, string fo, string fz, string nazivfirme, double cena, Koordinator koord)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Grad = grad;
            this.Lokacija = lok;
            this.FDeljenjeLetaka = fl;
            this.FSusretSaGradjanima = fs;
            this.Vreme = vreme;
            this.FMiting = fm;
            this.FNaOtvorenom = fo;
            this.FNaZatvorenom = fz;
            this.NazivFirme = nazivfirme;
            this.CenaProstora = cena;
            this.Koordinator = koord;
        }
    }

    #endregion


    #region Gost
    public class GostPregled
    {
        public int Id;
        public string Ime;
        public string Prezime;
        public string Funkcija;
        public IList<AkcijaBasic> Mitinzi;

        public GostPregled()
        {
            Mitinzi = new List<AkcijaBasic>();
        }

        public GostPregled(int id, string ime, string prez, string func)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prez;
            this.Funkcija = func;
        }

    }

    public class GostBasic
    {
        public int Id;
        public string Ime;
        public string Prezime;
        public string Funkcija;

        public IList<AkcijaBasic> Mitinzi { get; set; }

        public GostBasic()
        {
            Mitinzi = new List<AkcijaBasic>();
        }

        public GostBasic(int id, string ime, string prez, string func)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prez;
            this.Funkcija = func;
        }
    }
    #endregion


    #region Intervjui
    public class IntervjuNovinePregled
    {
        public int Id;
        public string NazivLista;
        public DateTime DatumPisanja;
        public DateTime DatumObjavljivanja;
        public string Novinar1;
        public string Novinar2;

        public IntervjuNovinePregled()
        {

        }
        public IntervjuNovinePregled(int Id, string NazivLista, DateTime DatumPisanja, DateTime DatumObjavljivanja, string Novinar1, string Novinar2)
        {
            this.Id = Id;
            this.NazivLista = NazivLista;
            this.DatumPisanja = DatumPisanja;
            this.DatumObjavljivanja = DatumObjavljivanja;
            this.Novinar1 = Novinar1;
            this.Novinar2 = Novinar2;

        }
    }
    public class IntervjuNovineBasic
    {
        public int Id;
        public string NazivLista;
        public DateTime DatumPisanja;
        public DateTime DatumObjavljivanja;
        public string Novinar1;
        public string Novinar2;

        public IntervjuNovineBasic()
        {

        }
        public IntervjuNovineBasic(int Id, string NazivLista, DateTime DatumPisanja, DateTime DatumObjavljivanja, string Novinar1, string Novinar2)
        {
            this.Id = Id;
            this.NazivLista = NazivLista;
            this.DatumPisanja = DatumPisanja;
            this.DatumObjavljivanja = DatumObjavljivanja;
            this.Novinar1 = Novinar1;
            this.Novinar2 = Novinar2;

        }

    }
    #endregion
    #region Emisije
    public class TVIRadioEmisijePregled
    {
        public int Id;
        public string NazivStanice;
        public string NazivEmisije;
        public string ImeVoditelja;
        public double Gledanost;

        public TVIRadioEmisijePregled()
        {

        }
        public TVIRadioEmisijePregled(int Id, string NazivStanice, string NazivEmisije, string ImeVoditelja, double Gledanost)
        {
            this.Id = Id;
            this.NazivStanice = NazivStanice;
            this.NazivEmisije = NazivEmisije;
            this.ImeVoditelja = ImeVoditelja;
            this.Gledanost = Gledanost;
        }

    }
    public class TVIRadioEmisijeBasic
    {
        public int Id;
        public string NazivStanice;
        public string NazivEmisije;
        public string ImeVoditelja;
        public double Gledanost;

        public TVIRadioEmisijeBasic()
        {

        }
        public TVIRadioEmisijeBasic(int Id, string NazivStanice, string NazivEmisije, string ImeVoditelja, double Gledanost)
        {
            this.Id = Id;
            this.NazivStanice = NazivStanice;
            this.NazivEmisije = NazivEmisije;
            this.ImeVoditelja = ImeVoditelja;
            this.Gledanost = Gledanost;
        }

    }
    #endregion
    #region TVDueli
    public class TVDueliPregled
    {

        public int Id;
        public string NazivStanice;
        public string NazivEmisije;
        public string ImeVoditelja;
        public double Gledanost;

        public TVDueliPregled()
        {


        }
        public TVDueliPregled(int Id, string NazivStanice, string NazivEmisije, string ImeVoditelja, double Gledanost)
        {
            this.Id = Id;
            this.NazivStanice = NazivStanice;
            this.NazivEmisije = NazivEmisije;
            this.ImeVoditelja = ImeVoditelja;
            this.Gledanost = Gledanost;

        }

    }
    public class TVDueliBasic
    {

        public int Id;
        public string NazivStanice;
        public string NazivEmisije;
        public string ImeVoditelja;
        public double Gledanost;
        public virtual IList<Protivkandidati> Protivkandidatii { get; set; }
        public virtual IList<SpisakPitanja> Pitanja { get; set; }

        public TVDueliBasic()
        {
            Protivkandidatii = new List<Protivkandidati>();
            Pitanja = new List<SpisakPitanja>();
        }
        public TVDueliBasic(int Id, string NazivStanice, string NazivEmisije, string ImeVoditelja, double Gledanost)
        {
            this.Id = Id;
            this.NazivStanice = NazivStanice;
            this.NazivEmisije = NazivEmisije;
            this.ImeVoditelja = ImeVoditelja;
            this.Gledanost = Gledanost;

        }
    }
    #endregion
    #region SpisakPitanja
    public class SpisakPitanjaPregled
    {
        //public TVDueli PripadaTVDuelu;
        public SpisakPitanjaId Id;
        //public string Pitanje;

        public SpisakPitanjaPregled()
        {
            Id = new SpisakPitanjaId();
        }
        public SpisakPitanjaPregled(SpisakPitanjaId Id)
        {
            this.Id = Id;
            //this.PripadaTVDuelu=PripadaTVDuelu;
            //.Pitanje = Pitanje;
        }
    }
    public class SpisakPitanjaIdPregled
    {
        public TVDueli PripadaTVDuelu;
        public string Pitanje;

        public SpisakPitanjaIdPregled()
        {
        }
    }
    public class SpisakPitanjaBasic
    {
        //public TVDueliBasic PripadaTVDuelu;
        public SpisakPitanjaIdBasic Id;
        //public string Pitanje;

        public SpisakPitanjaBasic()
        {
            Id = new SpisakPitanjaIdBasic();
        }
        public SpisakPitanjaBasic(SpisakPitanjaIdBasic Id)
        {
            this.Id = Id;
            //this.PripadaTVDuelu = PripadaTVDuelu;
            //this.Pitanje = Pitanje;
        }
    }
    public class SpisakPitanjaIdBasic
    {
        public TVDueliBasic PripadaTVDuelu;
        public string Pitanje;

        public SpisakPitanjaIdBasic()
        {
        }
    }
    #endregion
    #region Protivkandidati
    public class ProtivkandidatiPregled
    {
        // virtual string Protivkandidat { get; set; }
        public ProtivkandidatiId Id;
        //public virtual TVDueli PripadaTVDuelu { get; set; }

        public ProtivkandidatiPregled()
        {
            Id = new ProtivkandidatiId();
        }
        public ProtivkandidatiPregled(ProtivkandidatiId Id)
        {
            this.Id = Id;
        }
    }
    public class ProtivkandidatiIdPregled
    {
        public string Protivkandidat;
        public TVDueli PripadaTVDuelu;
        public ProtivkandidatiIdPregled()
        {

        }

    }
    public class ProtivkandidatiBasic
    {
        // virtual string Protivkandidat { get; set; }
        public ProtivkandidatiIdBasic Id;
        //public virtual TVDueli PripadaTVDuelu { get; set; }

        public ProtivkandidatiBasic()
        {
            Id = new ProtivkandidatiIdBasic();
        }
        public ProtivkandidatiBasic(ProtivkandidatiIdBasic Id)
        {
            this.Id = Id;
        }
    }
    public class ProtivkandidatiIdBasic
    {
        public string Protivkandidat;
        public TVDueliBasic PripadaTVDuelu;
        public ProtivkandidatiIdBasic()
        {

        }

    }
    #endregion

}



