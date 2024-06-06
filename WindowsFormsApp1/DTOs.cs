using Microsoft.Identity.Client;
using System.Drawing;


namespace WindowsFormsApp1
{
    #region Zaposleni
    public class TehnickoLiceDTO
    {
        public long MaticniBroj;
        public string Ime;
        public string Prezime;
        public char? Pol;
        public DateTime DatumRodjenja;
        public string StrucnaSprema;
        public string Oblast;

        public IList<AlarmniSistemDTO> OdrzavaAS;

        public TehnickoLiceDTO(long maticniBroj, string ime, string prezime, char? pol, DateTime datumRodjenja, string strucnaSprema, string oblast)
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
        public TehnickoLiceDTO(long maticniBroj, string ime, string prezime, char? pol, DateTime datumRodjenja)
        {
            MaticniBroj = maticniBroj;
            Ime = ime;
            Prezime = prezime;
            Pol = pol;
            DatumRodjenja = datumRodjenja;
        }
        public TehnickoLiceDTO()
        {

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
        public Ekipa PEkipi;
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

        public FizickoObezbedjenjeDTO(long maticniBroj, string ime, string prezime, char? pol, DateTime datumRodjenja, string borilackaVestina, Ekipa e)
        {
            MaticniBroj = maticniBroj;
            Ime = ime;
            Prezime = prezime;
            Pol = pol;
            DatumRodjenja = datumRodjenja;
            BorilackaVestina = borilackaVestina;
            PEkipi = e;
        }

        public FizickoObezbedjenjeDTO()
        {

        }

        public override string ToString()
        {
            return MaticniBroj + " " + Ime + " " + Prezime;
        }
    }

    public class MenadzerDTO
    {
        public long MaticniBroj;
        public string Ime;
        public string Prezime;
        public char? Pol;
        public DateTime DatumRodjenja;

        public IList<RegionalniCentarDTO> RegionalniCentri;
        public IList<string> Gradovi;

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

        public MenadzerDTO(long maticniBroj, string ime, string prezime, char? pol, DateTime datumRodjenja)
        {
            MaticniBroj = maticniBroj;
            Ime = ime;
            Prezime = prezime;
            Pol = pol;
            DatumRodjenja = datumRodjenja;
            RegionalniCentri = new List<RegionalniCentarDTO>();
            Gradovi = new List<string>();
        }

        public MenadzerDTO()
        {

        }
    }

    #endregion

    #region RegionalniCentar

    public class RegionalniCentarDTO
    {
        public int Id;
        public string Adresa;
        public MenadzerDTO Menadzer;
        public IList<int> BrojeviTelefona;
        public IList<string> ImenaGradova;
        public IList<string> RegOznakaVozila;

        public RegionalniCentarDTO(int id, string adresa, MenadzerDTO menadzer)
        {
            Id = id;
            Adresa = adresa;
            Menadzer = menadzer;
            BrojeviTelefona = new List<int>();
            ImenaGradova = new List<string>();
            RegOznakaVozila = new List<string>();
        }
        public RegionalniCentarDTO(int id, string adresa)
        {
            Id = id;
            Adresa = adresa;
            BrojeviTelefona = new List<int>();
            ImenaGradova = new List<string>();
            RegOznakaVozila = new List<string>();
        }
        public RegionalniCentarDTO()
        {
            BrojeviTelefona = new List<int>();
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
        public IList<FizickoObezbedjenjeDTO> clanoviEkipe;
        public string RegOznakaVozila;
        public Vozilo DuziVozilo;

        public EkipaDTO(int redniBroj)
        {
            RedniBroj = redniBroj;    
            clanoviEkipe = new List<FizickoObezbedjenjeDTO>();
        }
        public EkipaDTO()
        {

        }

    }

    #endregion

    #region Odrzava

    public class OdrzavaDTO
    {
        public int Id;
        public AlarmniSistemDTO AlarmniSistem;
        public TehnickoLiceDTO TehnickoLice;
        public DateTime DatumOd;
        public DateTime DatumDo;

        public OdrzavaDTO(int id, AlarmniSistemDTO alarmniSistem, TehnickoLiceDTO tehnickoLice, DateTime datumOd, DateTime datumDo)
        {
            Id = id;
            AlarmniSistem = alarmniSistem;
            TehnickoLice = tehnickoLice;
            DatumOd = datumOd;
            DatumDo = datumDo;
        }
        public OdrzavaDTO()
        {

        }
    }

    #endregion

    #region AlarmniSistem

    public class AlarmniSistemDTO
    {

        public int Id;
        public string Proizvodjac;
        public int? GodinaProizvodnje;
        public DateTime DatumInstalacije;
        public ObjekatDTO ObjekatKomePripada;
        public Objekat Obj;
        public IList<TehnickoLiceDTO> LiceKojeOdrzava;

        public AlarmniSistemDTO(int id, string proizvodjac, int? godinaProizvodnje, DateTime datumInstalacije, ObjekatDTO objekat)
        {
            Id = id;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
            DatumInstalacije = datumInstalacije;
            ObjekatKomePripada = objekat;
            LiceKojeOdrzava = new List<TehnickoLiceDTO>();
        }

        public AlarmniSistemDTO(int id, string proizvodjac, int? godinaProizvodnje, DateTime datumInstalacije, Objekat objekat)
        {
            Id = id;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
            DatumInstalacije = datumInstalacije;
            Obj = objekat;
            LiceKojeOdrzava = new List<TehnickoLiceDTO>();
        }

        public AlarmniSistemDTO()
        {

        }

    }



    public class UltrazvucniSenzorDTO : AlarmniSistemDTO
    {
        public int? MinFrekvencija;
        public int? MaxFrekvencija;

        public UltrazvucniSenzorDTO(int id, string proizvodjac, int? godinaProizvodnje, DateTime datumInstalacije, Objekat objekat, int? minFrek, int? maxFrekv)
            : base(id, proizvodjac, godinaProizvodnje, datumInstalacije, objekat)
        {
            MinFrekvencija = minFrek;
            MaxFrekvencija = maxFrekv;
        }
        public UltrazvucniSenzorDTO()
        {

        }
    }

    public class DetektorToplotnogOdrazaDTO : AlarmniSistemDTO
    {
        public int? HorRezolucija;
        public int? VerRezolucija;

        public DetektorToplotnogOdrazaDTO(int id, string proizvodjac, int? godinaProizvodnje, DateTime datumInstalacije, Objekat objekat, int? horRez, int? verRez)
            : base(id, proizvodjac, godinaProizvodnje, datumInstalacije, objekat)
        {
            HorRezolucija = horRez;
            VerRezolucija = verRez;
        }

        public DetektorToplotnogOdrazaDTO()
        {

        }
    }

    public class DetektorPokretaDTO : AlarmniSistemDTO
    {
        public int? Osetljivost;

        public DetektorPokretaDTO(int id, string proizvodjac, int? godinaProizvodnje, DateTime datumInstalacije, Objekat objekat, int? osetljivost)
            : base(id, proizvodjac, godinaProizvodnje, datumInstalacije, objekat)
        {
            Osetljivost = osetljivost;
        }

        public DetektorPokretaDTO()
        {

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
        public Ekipa EkipaSmene;
        public IList<ObjekatDTO> ObjektiZaSmenu;
        public IList<FizickoObezbedjenjeDTO> clanoviSmene;

        public SmenaDTO() { }
        public SmenaDTO(int id, DateTime vremePocetka, DateTime vremeKraja, EkipaDTO ekipa)
        {
            Id = id;
            VremePocetka = vremePocetka;
            VremeKraja = vremeKraja;
            EkipaZaSmenu = ekipa;
            ObjektiZaSmenu = new List<ObjekatDTO>();
        }

        public SmenaDTO(int id, DateTime vremePocetka, DateTime vremeKraja, Ekipa ekipa)
        {
            Id = id;
            VremePocetka = vremePocetka;
            VremeKraja = vremeKraja;
            EkipaSmene = ekipa;
            ObjektiZaSmenu = new List<ObjekatDTO>();
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
        public string adresaObjekta;

        public IntervencijaDTO(int id, DateTime datum, DateTime vreme, string tip, ObjekatDTO intervencijaObjekta, EkipaDTO intervencijaEkipe)
        {
            Id = id;
            Datum = datum;
            Vreme = vreme;
            Tip = tip;
            IntervencijaObjekta = intervencijaObjekta;
            IntervencijaEkipe = intervencijaEkipe;
        }
        public IntervencijaDTO() { }
    }

    #endregion

    #region Objekat

    public class ObjekatDTO
    {
        public int Id;
        public string Adresa;
        public string Tip;
        public float? Povrsina;
        public IList<long> KontaktTelefoni;
        public IList<ObuhvataDTO> SmeneZaObjekat;
        public IList<IntervencijaDTO> Intervencije;
        public IList<AlarmniSistemDTO> AlarmniSistemi;

        public ObjekatDTO(int id, string adresa, string tip, float? povrsina)
        {
            Id = id;
            Adresa = adresa;
            Tip = tip;
            Povrsina = povrsina;
            KontaktTelefoni = new List<long>();
            SmeneZaObjekat = new List<ObuhvataDTO>();
            Intervencije = new List<IntervencijaDTO>();
            AlarmniSistemi = new List<AlarmniSistemDTO>();
        }

        public ObjekatDTO()
        {

        }
    }

    #endregion

    #region Obuhvatanje

    public class ObuhvataDTO
    {
        public int Id;
        public ObjekatDTO Objekat;
        public SmenaDTO Smena;

        public ObuhvataDTO(int id, SmenaDTO s, ObjekatDTO o)
        {
            this.Id = id;
            this.Smena = s;
            this.Objekat = o;
        }

        public ObuhvataDTO()
        {

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
        public VoziloDTO(string registarskaOznaka, string boja, string? tip, string? model, string? proizvodjac, DateTime datumOd, DateTime datumDo)
        {
            RegOznaka = registarskaOznaka;
            Boja = boja;
            Tip = tip;
            Model = model;
            Proizvodjac = proizvodjac;
            DatumOd = datumOd;
            DatumDo = datumDo;
        }
        public VoziloDTO()
        {

        }
    }

    #endregion


}
