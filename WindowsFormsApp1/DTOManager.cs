using NHibernate.SqlCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public class DTOManager
    {
        #region Zaposleni

        public static List<FizickoObezbedjenjeDTO> PopuniFizickoObezbedjenje()
        {
            List<FizickoObezbedjenjeDTO> lista = new List<FizickoObezbedjenjeDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<FizickoObezbedjenje> lica = from o in s.Query<FizickoObezbedjenje>()
                                                        select o;

                foreach (FizickoObezbedjenje a in lica)
                {
                    FizickoObezbedjenjeDTO b = new FizickoObezbedjenjeDTO(a.MaticniBroj, a.Ime, a.Prezime, a.Pol, a.DatumRodjenja, a.BorilackaVestina);
                    if (a.PripadaEkipi != null)
                    {
                        b.PripadaEkipi = new EkipaDTO(a.PripadaEkipi.RedniBroj);
                    }

                    lista.Add(b);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return lista;
        }

        public static List<TehnickoLiceDTO> PopuniTehnickoLice()
        {
            List<TehnickoLiceDTO> lista = new List<TehnickoLiceDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<TehnickoLice> lica = from o in s.Query<TehnickoLice>()
                                                 select o;

                foreach (TehnickoLice a in lica)
                {
                    TehnickoLiceDTO b = new TehnickoLiceDTO(a.MaticniBroj, a.Ime, a.Prezime, a.Pol, a.DatumRodjenja, a.StrucnaSprema, a.Oblast);
                    lista.Add(b);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return lista;
        }

        public static List<MenadzerDTO> PopuniMenadzera()
        {
            List<MenadzerDTO> lista = new List<MenadzerDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Menadzer> lica = from o in s.Query<Menadzer>()
                                             select o;

                foreach (Menadzer a in lica)
                {
                    MenadzerDTO b = new MenadzerDTO(a.MaticniBroj, a.Ime, a.Prezime, a.Pol, a.DatumRodjenja);
                    lista.Add(b);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return lista;
        }


        public static FizickoObezbedjenjeDTO azurirajFizickoObezbedjenje(FizickoObezbedjenjeDTO fo, int redniBrojEkipe)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje fizobz = s.Load<FizickoObezbedjenje>(fo.MaticniBroj);

                fizobz.Ime = fo.Ime;
                fizobz.Prezime = fo.Prezime;
                fizobz.Pol = fo.Pol;
                fizobz.BorilackaVestina = fo.BorilackaVestina;
                fizobz.DatumRodjenja = fo.DatumRodjenja;
                if (redniBrojEkipe == -1)
                    fizobz.PripadaEkipi = null;
                else
                    fizobz.PripadaEkipi = s.Load<Ekipa>(redniBrojEkipe);

                s.Update(fizobz);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return fo;
        }

        public static FizickoObezbedjenjeDTO vratiFizickoObezbedjenje(long maticniBrojFizickog)
        {
            FizickoObezbedjenjeDTO fo = new FizickoObezbedjenjeDTO();
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje fizobz = s.Load<FizickoObezbedjenje>(maticniBrojFizickog);
                fo = new FizickoObezbedjenjeDTO(fizobz.MaticniBroj, fizobz.Ime, fizobz.Prezime, fizobz.Pol, fizobz.DatumRodjenja, fizobz.BorilackaVestina, fizobz.PripadaEkipi);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return fo;
        }

        public static void obrisiFizickoObezbedjenje(long maticniBrojFizickog)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje fo = s.Load<FizickoObezbedjenje>(maticniBrojFizickog);
                s.Delete(fo);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static void dodajFizickoObezbedjenje(FizickoObezbedjenjeDTO f, int redniBrojEkipe)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje fo = new FizickoObezbedjenje();
                fo.MaticniBroj = f.MaticniBroj;
                fo.Ime = f.Ime;
                fo.Prezime = f.Prezime;
                fo.Pol = f.Pol;
                fo.BorilackaVestina = f.BorilackaVestina;
                fo.DatumRodjenja = f.DatumRodjenja;
                if (redniBrojEkipe != -1)
                    fo.PripadaEkipi = s.Load<Ekipa>(redniBrojEkipe);
                else
                    fo.PripadaEkipi = null;

                s.SaveOrUpdate(fo);

                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static void dodajTehnickoLice(TehnickoLiceDTO t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoLice tl = new TehnickoLice();
                tl.MaticniBroj = t.MaticniBroj;
                tl.Ime = t.Ime;
                tl.Prezime = t.Prezime;
                tl.Pol = t.Pol;
                tl.DatumRodjenja = t.DatumRodjenja;
                tl.StrucnaSprema = t.StrucnaSprema;
                tl.Oblast = t.Oblast;
                tl.OdrzavaAS = null;

                s.SaveOrUpdate(tl);

                s.Flush();

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static TehnickoLiceDTO azurirajTehnickoLice(TehnickoLiceDTO t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoLice tl = s.Load<TehnickoLice>(t.MaticniBroj);

                tl.Ime = t.Ime;
                tl.Prezime = t.Prezime;
                tl.Pol = t.Pol;
                tl.DatumRodjenja = t.DatumRodjenja;
                tl.StrucnaSprema = t.StrucnaSprema;
                tl.Oblast = t.Oblast;

                s.Update(tl);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return t;
        }

        public static TehnickoLiceDTO vratiTehnickoLice(long maticniBrojTehnickog)
        {
            TehnickoLiceDTO tl = new TehnickoLiceDTO();
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoLice t = s.Load<TehnickoLice>(maticniBrojTehnickog);
                tl = new TehnickoLiceDTO(t.MaticniBroj, t.Ime, t.Prezime, t.Pol, t.DatumRodjenja, t.StrucnaSprema, t.Oblast);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return tl;
        }

        public static void obrisiTehnickoLice(long maticniBrojFizickog)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoLice tl = s.Load<TehnickoLice>(maticniBrojFizickog);
                s.Delete(tl);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static void dodajMenadzera(MenadzerDTO m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer me = new Menadzer();
                me.MaticniBroj = m.MaticniBroj;
                me.Ime = m.Ime;
                me.Prezime = m.Prezime;
                me.Pol = m.Pol;
                me.DatumRodjenja = m.DatumRodjenja;

                s.SaveOrUpdate(me);

                s.Flush();

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static MenadzerDTO azurirajMenadzera(MenadzerDTO m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer men = s.Load<Menadzer>(m.MaticniBroj);

                men.Ime = m.Ime;
                men.Prezime = m.Prezime;
                men.Pol = m.Pol;
                men.DatumRodjenja = m.DatumRodjenja;

                s.Update(men);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return m;
        }

        public static MenadzerDTO vratiMenadzera(long maticniBrojMenadzer)
        {
            MenadzerDTO m = new MenadzerDTO();
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer men = s.Load<Menadzer>(maticniBrojMenadzer);
                m = new MenadzerDTO(men.MaticniBroj, men.Ime, men.Prezime, men.Pol, men.DatumRodjenja);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return m;
        }

        public static void obrisiMenadzera(long maticniBrojMenadzera)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer m = s.Load<Menadzer>(maticniBrojMenadzera);
                s.Delete(m);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }
        #endregion

        #region MenGradovi

        public static IList<string> dodajMenadzeruGradove(MenadzerDTO m)
        {
            IList<string> gradovi = new List<string>();

            try
            {
                ISession s = DataLayer.GetSession();

                List<MenGradovi> listagradova = s.Query<MenGradovi>().Fetch(x => x.Menadzer).Where(x => x.Menadzer.MaticniBroj == m.MaticniBroj).ToList();

                foreach (MenGradovi gr in listagradova)
                {
                    gradovi.Add(gr.Grad);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return gradovi;
        }

        public static void dodajMenadzeruGrad(string grad, MenadzerDTO m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MenGradovi gr = new MenGradovi();
                gr.Menadzer = s.Load<Menadzer>(m.MaticniBroj);
                gr.Grad = grad;
                s.Save(gr);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static void obrisiMenadzeruGrad(string grad, MenadzerDTO m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MenGradovi gr = s.Query<MenGradovi>().Fetch(x => x.Menadzer).Where(x => x.Menadzer.MaticniBroj == m.MaticniBroj && x.Grad == grad).FirstOrDefault();
                s.Delete(gr);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }
        #endregion

        #region Vozilo
        public static List<VoziloDTO> PopuniVozila()
        {
            List<VoziloDTO> lista = new List<VoziloDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozilo> vozila = from v in s.Query<Vozilo>()
                                             select v;

                foreach (Vozilo vv in vozila)
                {
                    VoziloDTO voziloDTO = new VoziloDTO(vv.RegistarskaOznaka, vv.Boja, vv.Tip, vv.Model, vv.Proizvodjac, vv.DatumOd, vv.DatumDo);
                    lista.Add(voziloDTO);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return lista;
        }

        #endregion

        #region AlarmniSistem
        public static List<AlarmniSistemDTO> PopuniAlarmniSistem()
        {
            List<AlarmniSistemDTO> lista = new List<AlarmniSistemDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<AlarmniSistem> lica = from o in s.Query<AlarmniSistem>()
                                                  select o;

                foreach (AlarmniSistem a in lica)
                {
                    AlarmniSistemDTO b = new AlarmniSistemDTO(a.Id, a.Proizvodjac, a.GodinaProizvodnje, a.DatumInstalacije, a.Objekat);
                    lista.Add(b);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return lista;
        }
        public static List<DetektorToplotnogOdrazaDTO> PopuniToplotniAlarmniSistem()
        {
            List<DetektorToplotnogOdrazaDTO> lista = new List<DetektorToplotnogOdrazaDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<AlarmniSistem> lica = from o in s.Query<AlarmniSistem>().Where(x => x.DetektorToplotnogOdraza == 'T')
                                                  select o;

                foreach (AlarmniSistem a in lica)
                {
                    DetektorToplotnogOdrazaDTO b = new DetektorToplotnogOdrazaDTO(a.Id, a.Proizvodjac, a.GodinaProizvodnje, a.DatumInstalacije, a.Objekat, a.HorRezolucija, a.VerRezolucija);
                    lista.Add(b);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return lista;
        }
        public static List<DetektorPokretaDTO> PopuniPokretniAlarmniSistem()
        {
            List<DetektorPokretaDTO> lista = new List<DetektorPokretaDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<AlarmniSistem> lica = from o in s.Query<AlarmniSistem>().Where(x => x.DetektorPokreta == 'T')
                                                  select o;

                foreach (AlarmniSistem a in lica)
                {
                    DetektorPokretaDTO b = new DetektorPokretaDTO(a.Id, a.Proizvodjac, a.GodinaProizvodnje, a.DatumInstalacije, a.Objekat, a.Osetljivost);
                    lista.Add(b);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return lista;
        }

        public static List<UltrazvucniSenzorDTO> PopuniZvucniAlarmniSistem()
        {
            List<UltrazvucniSenzorDTO> lista = new List<UltrazvucniSenzorDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<AlarmniSistem> lica = from o in s.Query<AlarmniSistem>().Where(x => x.UltrazvucniSenzor == 'T')
                                                  select o;

                foreach (AlarmniSistem a in lica)
                {
                    UltrazvucniSenzorDTO b = new UltrazvucniSenzorDTO(a.Id, a.Proizvodjac, a.GodinaProizvodnje, a.DatumInstalacije, a.Objekat, a.MinFrekvencija, a.MaxFrekvencija);
                    lista.Add(b);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return lista;
        }

        public static AlarmniSistemDTO vratiAlarmniSistem(int id)
        {
            AlarmniSistemDTO alsis = new AlarmniSistemDTO();
            try
            {
                ISession s = DataLayer.GetSession();

                AlarmniSistem alarm = s.Load<AlarmniSistem>(id);
                alsis = new AlarmniSistemDTO(alarm.Id, alarm.Proizvodjac, alarm.GodinaProizvodnje, alarm.DatumInstalacije, alarm.Objekat);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return alsis;
        }

        public static List<TehnickoLiceDTO> vratiListuTehnickih(int id)
        {
            List<TehnickoLiceDTO> lista = new List<TehnickoLiceDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                var query = s.Query<Odrzava>()
                             .Where(x => x.AlarmniSistem.Id == id)
                             .Select(x => new TehnickoLiceDTO
                             {
                                 MaticniBroj = x.TehnickoLice.MaticniBroj,
                                 Ime = x.TehnickoLice.Ime,
                                 Prezime = x.TehnickoLice.Prezime,
                                 Pol = x.TehnickoLice.Pol,
                                 DatumRodjenja = x.TehnickoLice.DatumRodjenja
                             });

                lista = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return lista;
        }
        #endregion

        #region Objekat

        public static ObjekatDTO vratiObjekat(int id)
        {
            ObjekatDTO o = new ObjekatDTO();
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat obj = s.Load<Objekat>(id);
                o = new ObjekatDTO(obj.Id, obj.Adresa, obj.TipObjekta, obj.Povrsina);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return o;
        }

        #endregion

        #region Smena

        public static SmenaDTO vratiSmenu(int id)
        {
            SmenaDTO smena = new SmenaDTO();
            try
            {
                ISession s = DataLayer.GetSession();

                Smena sm = s.Load<Smena>(id);
                smena = new SmenaDTO(sm.Id, sm.VremePocetka, sm.VremeKraja, sm.EkipaZaSmenu);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return smena;
        }

        public static List<ObjekatDTO> vratiListuObjekataSmene(int id)
        {
            List<ObjekatDTO> lista = new List<ObjekatDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                var query = s.Query<Obuhvata>()
                             .Where(x => x.Smena.Id == id)
                             .Select(x => new ObjekatDTO
                             {
                                 Id = x.Objekat.Id,
                                 Adresa = x.Objekat.Adresa,
                                 Tip = x.Objekat.TipObjekta,
                                 Povrsina = x.Objekat.Povrsina,                             
                             });

                lista = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return lista;
        }

        public static List<FizickoObezbedjenjeDTO> vratiListuClanovaEkipeSmene(int rb)
        {
            List<FizickoObezbedjenjeDTO> lista = new List<FizickoObezbedjenjeDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                var query = s.Query<FizickoObezbedjenje>()
                             .Where(x => x.PripadaEkipi.RedniBroj == rb)
                             .Select(x => new FizickoObezbedjenjeDTO
                             {
                                 MaticniBroj = x.MaticniBroj,
                                 Ime = x.Ime,
                                 Prezime = x.Prezime,
                                 Pol = x.Pol,
                                 DatumRodjenja = x.DatumRodjenja,
                                 BorilackaVestina = x.BorilackaVestina
                             });

                lista = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return lista;
        }

        public static List<SmenaDTO> PopuniSmenu()
        {
            List<SmenaDTO> lista = new List<SmenaDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Smena> smene = from v in s.Query<Smena>()
                                             select v;

                foreach (Smena sm in smene)
                {
                    SmenaDTO smenaDTO = new SmenaDTO(sm.Id, sm.VremePocetka, sm.VremeKraja, sm.EkipaZaSmenu);
                    lista.Add(smenaDTO);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return lista;
        }
        #endregion
    }
}