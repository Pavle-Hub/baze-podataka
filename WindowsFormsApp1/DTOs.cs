using System.Drawing;

namespace WindowsFormsApp1
{
    #region Zaposleni
    public class TehnickoLiceDTO
    {
        public long MaticniBroj;
        public string Ime;
        public string Prezime;
        public string Pol;
        public DateTime DatumRodjenja;
        public string StrucnaSprema;
        public string Oblast;

        public IList<AlarmniSistemDTO> OdrzavaAS;

        public TehnickoLiceDTO(long maticniBroj, string ime, string prezime, string pol, DateTime datumRodjenja, string strucnaSprema, string oblast)
        {
            MaticniBroj = maticniBroj;
            Ime = ime;
            Prezime = prezime;
            Pol = pol;
            DatumRodjenja = datumRodjenja;
            StrucnaSprema = strucnaSprema;
            Oblast = oblast;

            OdrzavaAS = new List<AlarmniSistemDTO>();
        }

    }

    public class FizickoObezbedjenjeDTO
    {
        public long MaticniBroj;
        public string Ime;
        public string Prezime;
        public char? Pol;
        public DateTime DatumRodjenja;
        public string BorilackaVestina;
        public EkipaDTO PripadaEkipi;

        public FizickoObezbedjenjeDTO(long maticniBroj, string ime, string prezime, char? pol, DateTime datumRodjenja, string borilackaVestina)
        {
            MaticniBroj = maticniBroj;
            Ime = ime;
            Prezime = prezime;
            Pol = pol;
            DatumRodjenja = datumRodjenja;
            BorilackaVestina = borilackaVestina;
        }

        public override string ToString()
        {
            return MaticniBroj + " " + Ime + " " + Prezime;
        }
    }

    public class MenadzerDTO
    {
        public string MaticniBroj;
        public string Ime;
        public string Prezime;
        public string Pol;
        public DateTime DatumRodjenja;

        public IList<RegionalniCentarDTO> RegionalniCentri;
        public IList<string> Gradovi;

        public MenadzerDTO(string maticniBroj, string ime, string prezime, string pol, DateTime datumRodjenja)
        {
            MaticniBroj = maticniBroj;
            Ime = ime;
            Prezime = prezime;
            Pol = pol;
            DatumRodjenja = datumRodjenja;
            RegionalniCentri = new List<RegionalniCentarDTO>();
            Gradovi = new List<string>();
        }
    }

    #endregion

    #region RegionalniCentar

    public class RegionalniCentarDTO
    {
        public int Id;
        public string Adresa;
        public string ImeMenadzera;
        public IList<string> BrojeviTelefona;
        public IList<string> ImenaGradova;
        public IList<string> RegOznakaVozila;

        public RegionalniCentarDTO(int id, string adresa, string imeMenadzera)
        {
            Id = id;
            Adresa = adresa;
            ImeMenadzera = imeMenadzera;
            BrojeviTelefona = new List<string>();
            ImenaGradova = new List<string>();
            RegOznakaVozila = new List<string>();
        }


    }


    #endregion

    #region Ekipa

    public class EkipaDTO
    {
        public int RedniBroj;
        public FizickoObezbedjenjeDTO Vodja;
        public IList<string> ImenaClanova;
        public IList<SmenaDTO> SmeneEkipe;
        public IList<IntervencijaDTO> IntervencijeEkipe;
        public string RegOznakaVozila;

        public EkipaDTO(int redniBroj)
        {
            RedniBroj = redniBroj;
        }
    }

    #endregion

    #region Odrzava

    public class OdrzavaDTO
    {
        public int Id;
        public AlarmniSistemDTO AlarmniSistem;
        public TehnickoLiceDTO TehnickoLice;
        public DateOnly DatumOd;
        public DateOnly DatumDo;

        public OdrzavaDTO(int id, AlarmniSistemDTO alarmniSistem, TehnickoLiceDTO tehnickoLice, DateOnly datumOd, DateOnly datumDo)
        {
            Id = id;
            AlarmniSistem = alarmniSistem;
            TehnickoLice = tehnickoLice;
            DatumOd = datumOd;
            DatumDo = datumDo;
        }
    }

    #endregion

    #region AlarmniSistem

    public class AlarmniSistemDTO
    {

        public int Id;
        public string Proizvodjac;
        public int GodinaProizvodnje;
        public DateTime DatumInstalacije;
        public ObjekatDTO ObjekatKomePripada;
        public IList<TehnickoLiceDTO> LiceKojeOdrzava;

        public AlarmniSistemDTO(int id, string proizvodjac, int godinaProizvodnje, DateTime datumInstalacije, ObjekatDTO objekat)
        {
            Id = id;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
            DatumInstalacije = datumInstalacije;
            ObjekatKomePripada = objekat;
            LiceKojeOdrzava = new List<TehnickoLiceDTO>();
        }
    }

    public class UltrazvucniSenzorDTO : AlarmniSistemDTO
    {
        public double MinFrekvencija;
        public double MaxFrekvencija;

        public UltrazvucniSenzorDTO(int id, string proizvodjac, int godinaProizvodnje, DateTime datumInstalacije, ObjekatDTO objekat, double minFrek, double maxFrekv)
            : base(id, proizvodjac, godinaProizvodnje, datumInstalacije, objekat)
        {
            MinFrekvencija = minFrek;
            MaxFrekvencija = maxFrekv;
        }
    }

    public class DetektorToplotnogOdrazaDTO : AlarmniSistemDTO
    {
        public int HorRezolucija;
        public int VerRezolucija;

        public DetektorToplotnogOdrazaDTO(int id, string proizvodjac, int godinaProizvodnje, DateTime datumInstalacije, ObjekatDTO objekat, int horRez, int verRez)
            : base(id, proizvodjac, godinaProizvodnje, datumInstalacije, objekat)
        {
            HorRezolucija = horRez;
            VerRezolucija = verRez;
        }
    }

    public class DetektorPokretaDTO : AlarmniSistemDTO
    {
        public double Osetljivost;

        public DetektorPokretaDTO(int id, string proizvodjac, int godinaProizvodnje, DateTime datumInstalacije, ObjekatDTO objekat, double osetljivost)
            : base(id, proizvodjac, godinaProizvodnje, datumInstalacije, objekat)
        {
            Osetljivost = osetljivost;
        }
    }

    #endregion

    #region Smena

    public class SmenaDTO
    {
        public int Id;
        public DateTime VremePocetka;
        public DateTime VremeKraja;
        public EkipaDTO EkipaZaSmenu;
        public IList<ObuhvataDTO> ObjektiZaSmenu;

        public SmenaDTO(int id, DateTime vremePocetka, DateTime vremeKraja, EkipaDTO ekipa)
        {
            Id = id;
            VremePocetka = vremePocetka;
            VremeKraja = vremeKraja;
            EkipaZaSmenu = ekipa;
            ObjektiZaSmenu = new List<ObuhvataDTO>();
        }
    }

    #endregion

    #region Intervencija

    public class IntervencijaDTO
    {
        public int Id;
        public DateTime Datum;
        public DateTime Vreme;
        public string Tip;
        public ObjekatDTO IntervencijaObjekta;
        public EkipaDTO IntervencijaEkipe;

        public IntervencijaDTO(int id, DateTime datum, DateTime vreme, string tip, ObjekatDTO intervencijaObjekta, EkipaDTO intervencijaEkipe)
        {
            Id = id;
            Datum = datum;
            Vreme = vreme;
            Tip = tip;
            IntervencijaObjekta = intervencijaObjekta;
            IntervencijaEkipe = intervencijaEkipe;
        }
    }

    #endregion

    #region Objekat

    public class ObjekatDTO
    {
        public int Id;
        public string Adresa;
        public string Tip;
        public float Povrsina;
        public IList<int> KontaktTelefoni;
        public IList<ObuhvataDTO> SmeneZaObjekat;
        public IList<IntervencijaDTO> Intervencije;
        public IList<AlarmniSistemDTO> AlarmniSistemi;

        public ObjekatDTO(int id, string adresa, string tip, float povrsina)
        { 
            Id = id;
            Adresa = adresa;
            Tip = tip;
            Povrsina = povrsina;
            KontaktTelefoni = new List<int>();
            SmeneZaObjekat = new List<ObuhvataDTO>();
            Intervencije = new List<IntervencijaDTO>();
            AlarmniSistemi = new List<AlarmniSistemDTO>();
        }
    }

    #endregion

    #region Obuhvatanje

    public class ObuhvataDTO
    {
        public int Id;
        public ObjekatDTO Objekat;
        public SmenaDTO Smena;

        public ObuhvataDTO(int id, ObjekatDTO o, SmenaDTO s)
        {
            this.Id = id;
            this.Objekat = o;
            this.Smena = s;
        }
    }

    #endregion

    #region Vozilo

    public class VoziloDTO
    {
        public string RegOznaka;
        public string Boja;
        public string Tip;
        public string Model;
        public string Proizvodjac;
        public DateTime DatumOd;
        public DateTime DatumDo;
        public RegionalniCentarDTO RC;
        public EkipaDTO DuziGaEkipa;

        public VoziloDTO(string regOznaka, string boja, string tip, string model, string proizvodjac, DateTime datumOd, DateTime datumDo, RegionalniCentarDTO rC, EkipaDTO duziGaEkipa)
        {
            RegOznaka = regOznaka;
            Boja = boja;
            Tip = tip;
            Model = model;
            Proizvodjac = proizvodjac;
            DatumOd = datumOd;
            DatumDo = datumDo;
            RC = rC;
            DuziGaEkipa = duziGaEkipa;
        }
    }

    #endregion

}
