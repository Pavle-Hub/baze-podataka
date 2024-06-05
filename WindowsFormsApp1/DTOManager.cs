using Microsoft.Identity.Client;
using NHibernate.SqlCommand;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public static List<AlarmniSistemDTO> vratiListuAlarma(long maticni)
        {
            List<AlarmniSistemDTO> lista = new List<AlarmniSistemDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                var query = s.Query<Odrzava>()
                             .Where(x => x.TehnickoLice.MaticniBroj == maticni)
                             .Select(x => new AlarmniSistemDTO
                             {
                                 Id = x.AlarmniSistem.Id,
                                 Proizvodjac = x.AlarmniSistem.Proizvodjac,
                                 GodinaProizvodnje = x.AlarmniSistem.GodinaProizvodnje
                             }) ;

                lista = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return lista;
        }
        public static List<long> VratiDostupneClanove()
        {
            List<long> dostupniClanovi = new List<long>();
            try
            {
                ISession s = DataLayer.GetSession();
                dostupniClanovi = s.Query<FizickoObezbedjenje>()
                                .Where(c => c.PripadaEkipi == null)
                                .Select(c => c.MaticniBroj)
                                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dohvatu dostupnih članova: " + ex.Message);
            }
            return dostupniClanovi;
        }

        public static List<MenadzerDTO> VratiSveMenadzere()
        {
            List<MenadzerDTO> menadzeri = new List<MenadzerDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    menadzeri = s.Query<Menadzer>()
                                 .Select(m => new MenadzerDTO
                                 {
                                     MaticniBroj = m.MaticniBroj,
                                     Ime = m.Ime,
                                     Prezime = m.Prezime
                                 })
                                 .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }

            return menadzeri;
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
        public static void dodajVozilo(VoziloDTO v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo vozilo = new Vozilo();
                vozilo.RegistarskaOznaka = v.RegOznaka;
                vozilo.Boja = v.Boja;
                vozilo.Tip = v.Tip;
                vozilo.Model = v.Model;
                vozilo.Proizvodjac = v.Proizvodjac;
                vozilo.DatumOd = v.DatumOd;
                vozilo.DatumDo = v.DatumDo;


                vozilo.RegistrovanNaRegCentar = s.Load<RegionalniCentar>(v.RC.Id);
                vozilo.EkipaKojaGaDuzi = s.Load<Ekipa>(v.DuziGaEkipa.RedniBroj);

                s.SaveOrUpdate(vozilo);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }
        public static void obrisiVozilo(string registarskaOznaka)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo vozilo = s.Load<Vozilo>(registarskaOznaka);
                s.Delete(vozilo);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static VoziloDTO VratiVoziloZaEkipu(int ekipaId)
        {
            VoziloDTO voziloDTO = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var vozilo = s.Query<Vozilo>()
                                  .FirstOrDefault(v => v.EkipaKojaGaDuzi.RedniBroj == ekipaId);

                    if (vozilo != null)
                    {
                        voziloDTO = new VoziloDTO
                        {
                            RegOznaka = vozilo.RegistarskaOznaka,
                            DatumOd = vozilo.DatumOd,
                            DatumDo = vozilo.DatumDo
                        };
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message);
            }

            return voziloDTO;
        }
        public static VoziloDTO VratiVoziloPoRegistarskojOznaci(string registarskaOznaka)
        {
            VoziloDTO voziloDTO = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var vozilo = s.Query<Vozilo>()
                                  .Where(v => v.RegistarskaOznaka == registarskaOznaka)
                                  .Select(v => new VoziloDTO
                                  {
                                      RegOznaka = v.RegistarskaOznaka,
                                      Boja = v.Boja,
                                      Tip = v.Tip,
                                      Model = v.Model,
                                      Proizvodjac = v.Proizvodjac,
                                      DatumOd = v.DatumOd,
                                      DatumDo = v.DatumDo,
                                      RC = new RegionalniCentarDTO
                                      {
                                          Id = v.RegistrovanNaRegCentar.Id,
                                          Adresa = v.RegistrovanNaRegCentar.Adresa
                                      },
                                      DuziGaEkipa = v.EkipaKojaGaDuzi != null ? new EkipaDTO
                                      {
                                          RedniBroj = v.EkipaKojaGaDuzi.RedniBroj
                                      } : null
                                  })
                                  .FirstOrDefault();

                    voziloDTO = vozilo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }

            return voziloDTO;
        }

        public static void IzmeniVozilo(VoziloDTO voziloDTO)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction transaction = s.BeginTransaction())
                    {
                        Vozilo vozilo = s.Get<Vozilo>(voziloDTO.RegOznaka);

                        if (vozilo != null)
                        {
                            vozilo.Boja = voziloDTO.Boja;
                            vozilo.Tip = voziloDTO.Tip;
                            vozilo.Model = voziloDTO.Model;
                            vozilo.Proizvodjac = voziloDTO.Proizvodjac;
                            vozilo.DatumOd = voziloDTO.DatumOd;
                            vozilo.DatumDo = voziloDTO.DatumDo;
                            vozilo.RegistrovanNaRegCentar = s.Get<RegionalniCentar>(voziloDTO.RC.Id);
                            vozilo.EkipaKojaGaDuzi = s.Get<Ekipa>(voziloDTO.DuziGaEkipa.RedniBroj);

                            s.Update(vozilo);
                            transaction.Commit();
                        }
                        else
                        {
                            MessageBox.Show("Vozilo nije pronađeno.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom izmene vozila: {ex.Message}");
            }
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

        public static void dodajUltrazvucniSenzor(UltrazvucniSenzorDTO uzs)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AlarmniSistem als = new AlarmniSistem();
                als.Id = uzs.Id;
                als.Proizvodjac = uzs.Proizvodjac;
                als.GodinaProizvodnje = uzs.GodinaProizvodnje;
                als.DatumInstalacije = uzs.DatumInstalacije;
                als.UltrazvucniSenzor = 'T';
                als.MinFrekvencija = uzs.MinFrekvencija;
                als.MaxFrekvencija = uzs.MaxFrekvencija;
                als.DetektorPokreta = 'F';
                als.Osetljivost = null;
                als.DetektorToplotnogOdraza = 'F';
                als.HorRezolucija = null;
                als.VerRezolucija = null;
                als.Objekat = null;
                als.Odrzava = null;

                s.SaveOrUpdate(als);

                s.Flush();

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static void dodajToplotniOdraz(DetektorToplotnogOdrazaDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AlarmniSistem als = new AlarmniSistem();
                als.Id = dto.Id;
                als.Proizvodjac = dto.Proizvodjac;
                als.GodinaProizvodnje = dto.GodinaProizvodnje;
                als.DatumInstalacije = dto.DatumInstalacije;
                als.UltrazvucniSenzor = 'F';
                als.MinFrekvencija = null;
                als.MaxFrekvencija = null;
                als.DetektorPokreta = 'F';
                als.Osetljivost = null;
                als.DetektorToplotnogOdraza = 'T';
                als.HorRezolucija = dto.HorRezolucija;
                als.VerRezolucija = dto.VerRezolucija;
                als.Objekat = null;
                als.Odrzava = null;

                s.SaveOrUpdate(als);

                s.Flush();

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static void dodajDetektorPokreta(DetektorPokretaDTO dp)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AlarmniSistem als = new AlarmniSistem();
                als.Id = dp.Id;
                als.Proizvodjac = dp.Proizvodjac;
                als.GodinaProizvodnje = dp.GodinaProizvodnje;
                als.DatumInstalacije = dp.DatumInstalacije;
                als.UltrazvucniSenzor = 'F';
                als.MinFrekvencija = null;
                als.MaxFrekvencija = null;
                als.DetektorPokreta = 'T';
                als.Osetljivost = dp.Osetljivost;
                als.DetektorToplotnogOdraza = 'F';
                als.HorRezolucija = null;
                als.VerRezolucija = null;
                als.Objekat = null;
                als.Odrzava = null;

                s.SaveOrUpdate(als);

                s.Flush();

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static AlarmniSistemDTO vratiAlarmniSistemZaIzmenu(int id)
        {
            AlarmniSistemDTO als = new AlarmniSistemDTO();
            try
            {
                ISession s = DataLayer.GetSession();

                AlarmniSistem alarm = s.Load<AlarmniSistem>(id);
                if (alarm.DetektorPokreta == 'T')
                {
                    als = new DetektorPokretaDTO(alarm.Id, alarm.Proizvodjac, alarm.GodinaProizvodnje, alarm.DatumInstalacije, alarm.Objekat, alarm.Osetljivost);
                }
                else if (alarm.UltrazvucniSenzor == 'T')
                {
                    als = new UltrazvucniSenzorDTO(alarm.Id, alarm.Proizvodjac, alarm.GodinaProizvodnje, alarm.DatumInstalacije, alarm.Objekat, alarm.MinFrekvencija, alarm.MaxFrekvencija);
                }
                else if (alarm.DetektorToplotnogOdraza == 'T')
                {
                    als = new DetektorToplotnogOdrazaDTO(alarm.Id, alarm.Proizvodjac, alarm.GodinaProizvodnje, alarm.DatumInstalacije, alarm.Objekat, alarm.HorRezolucija, alarm.VerRezolucija);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return als;
        }

        public static DetektorPokretaDTO azurirajDetektorPokreta(DetektorPokretaDTO dp)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AlarmniSistem alarm = s.Load<AlarmniSistem>(dp.Id);

                alarm.Proizvodjac = dp.Proizvodjac;
                alarm.GodinaProizvodnje = dp.GodinaProizvodnje;
                alarm.UltrazvucniSenzor = 'F';
                alarm.MinFrekvencija = null;
                alarm.MaxFrekvencija = null;
                alarm.DetektorPokreta = 'T';
                alarm.Osetljivost = dp.Osetljivost;
                alarm.DetektorToplotnogOdraza = 'F';
                alarm.HorRezolucija = null;
                alarm.VerRezolucija = null;
                alarm.DatumInstalacije = dp.DatumInstalacije;

                s.Update(alarm);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return dp;
        }

        public static DetektorToplotnogOdrazaDTO azurirajDetektorToplote(DetektorToplotnogOdrazaDTO dp)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AlarmniSistem alarm = s.Load<AlarmniSistem>(dp.Id);

                alarm.Proizvodjac = dp.Proizvodjac;
                alarm.GodinaProizvodnje = dp.GodinaProizvodnje;
                alarm.UltrazvucniSenzor = 'F';
                alarm.MinFrekvencija = null;
                alarm.MaxFrekvencija = null;
                alarm.DetektorPokreta = 'F';
                alarm.Osetljivost = null;
                alarm.DetektorToplotnogOdraza = 'T';
                alarm.HorRezolucija = dp.HorRezolucija;
                alarm.VerRezolucija = dp.VerRezolucija;
                alarm.DatumInstalacije = dp.DatumInstalacije;

                s.Update(alarm);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return dp;
        }

        public static UltrazvucniSenzorDTO azurirajUltrazvuk(UltrazvucniSenzorDTO dp)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AlarmniSistem alarm = s.Load<AlarmniSistem>(dp.Id);

                alarm.Proizvodjac = dp.Proizvodjac;
                alarm.GodinaProizvodnje = dp.GodinaProizvodnje;
                alarm.UltrazvucniSenzor = 'T';
                alarm.MinFrekvencija = dp.MinFrekvencija;
                alarm.MaxFrekvencija = dp.MaxFrekvencija;
                alarm.DetektorPokreta = 'F';
                alarm.Osetljivost = null;
                alarm.DetektorToplotnogOdraza = 'F';
                alarm.HorRezolucija = null;
                alarm.VerRezolucija = null;
                alarm.DatumInstalacije = dp.DatumInstalacije;

                s.Update(alarm);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return dp;
        }

        public static void obrisiAlarm(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AlarmniSistem a = s.Load<AlarmniSistem>(id);
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static bool dodajObjekatAlarmu(int idObjekta, AlarmniSistemDTO alarm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat o = s.Load<Objekat>(idObjekta);
                AlarmniSistem a = s.Load<AlarmniSistem>(alarm.Id);

                a.Objekat = o;

                s.Update(a);
                s.Flush();

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ne postoji objekat sa datim ID-om!");
                return false;
            }
            return true;
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
        public static void dodajObjekat(ObjekatDTO objekatDTO)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction transaction = s.BeginTransaction())
                    {
                        Objekat objekat = new Objekat
                        {
                            Adresa = objekatDTO.Adresa,
                            TipObjekta = objekatDTO.Tip,
                            Povrsina = objekatDTO.Povrsina
                        };

                        s.Save(objekat);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
        }

        public static List<ObjekatDTO> vratiSveObjekte()
        {
            List<ObjekatDTO> objekti = new List<ObjekatDTO>();

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var sviObjekti = s.Query<Objekat>().ToList();

                    foreach (var objekat in sviObjekti)
                    {
                        objekti.Add(new ObjekatDTO
                        {
                            Id = objekat.Id,
                            Adresa = objekat.Adresa,
                            Tip = objekat.TipObjekta,
                            Povrsina = objekat.Povrsina
                        }) ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }

            return objekti;
        }

        public static void ObrisiObjekat(int objekatId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction transaction = s.BeginTransaction())
                    {
                        Objekat objekatZaBrisanje = s.Get<Objekat>(objekatId);

                        if (objekatZaBrisanje != null)
                        {
                            s.Delete(objekatZaBrisanje);
                            transaction.Commit();
                        }
                        else
                        {
                            MessageBox.Show("Objekat nije pronađen.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
        }

        public static List<AlarmniSistemDTO> vratiAlarmneSistemeZaObjekat(int objekatId)
        {
            List<AlarmniSistemDTO> alarmniSistemi = new List<AlarmniSistemDTO>();

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var alarmi = s.Query<AlarmniSistem>()
                                  .Where(a => a.Objekat.Id == objekatId)
                                  .ToList();

                    foreach (var alarm in alarmi)
                    {
                        alarmniSistemi.Add(new AlarmniSistemDTO
                        {
                            Id = alarm.Id,
                            Proizvodjac = alarm.Proizvodjac,
                            GodinaProizvodnje = alarm.GodinaProizvodnje,
                            DatumInstalacije = alarm.DatumInstalacije
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }

            return alarmniSistemi;
        }
        public static List<long> vratiTelefoneZaObjekat(int objekatID)
        {
            List<long> brojevi = new List<long>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    brojevi = s.Query<ObjektiTelefoni>()
                               .Where(o => o.Objekat.Id == objekatID)
                               .Select(o => o.Telefon)
                               .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }

            return brojevi;
        }

        public static void DodajBrojTelefonaObjektu(int objekatId, int brojTelefona)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction transaction = s.BeginTransaction())
                    {
                        Objekat objekat = s.Load<Objekat>(objekatId);

                        ObjektiTelefoni noviBroj = new ObjektiTelefoni
                        {
                            Telefon = brojTelefona,
                            Objekat = objekat
                        };

                        s.Save(noviBroj);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
        }
        public static void ObrisiBrojTelefonaObjektu(int brojTelefona, int objekatId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction transaction = s.BeginTransaction())
                    {
                        ObjektiTelefoni brojZaBrisanje = s.Query<ObjektiTelefoni>()
                                                       .Where(bt => bt.Telefon == brojTelefona && bt.Objekat.Id == objekatId)
                                                       .FirstOrDefault();

                        if (brojZaBrisanje != null)
                        {
                            s.Delete(brojZaBrisanje);
                            transaction.Commit();
                            MessageBox.Show("Broj telefona uspešno obrisan.");
                        }
                        else
                        {
                            MessageBox.Show("Broj telefona nije pronađen.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
        }
        public static List<SmenaDTO> VratiSmeneZaObjekat(int objekatId)
        {
            List<SmenaDTO> smene = new List<SmenaDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var obilasci = s.Query<Obuhvata>()
                                    .Where(o => o.Objekat.Id == objekatId)
                                    .Select(o => o.Smena)
                                    .ToList();

                    smene = obilasci.Select(smena => new SmenaDTO(smena.Id, smena.VremePocetka, smena.VremeKraja, smena.EkipaZaSmenu)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
            return smene;
        }

        public static List<IntervencijaDTO> VratiIntervencijeZaObjekat(int objekatId)
        {
            List<IntervencijaDTO> intervencije = new List<IntervencijaDTO>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    var objekat = session.Get<Objekat>(objekatId);
                    if (objekat != null)
                    {
                        var intervencijeZaObjekat = session.Query<Intervencija>()
                                                            .Where(i => i.Objekat.Id == objekatId)
                                                            .ToList();

                        foreach (var intervencija in intervencijeZaObjekat)
                        {
                            var ekipaDTO = new EkipaDTO
                            {
                                RedniBroj = intervencija.Ekipa.RedniBroj,
                            };

                            var intervencijaDTO = new IntervencijaDTO
                            {
                                Id = intervencija.Id,
                                Datum = intervencija.Datum,
                                Vreme = intervencija.Vreme,
                                Tip = intervencija.Tip,
                                IntervencijaObjekta = new ObjekatDTO
                                {
                                    Id = intervencija.Objekat.Id,
                                    Adresa = intervencija.Objekat.Adresa,
                                },
                                IntervencijaEkipe = ekipaDTO
                            };

                            intervencije.Add(intervencijaDTO);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Objekat nije pronađen.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }

            return intervencije;
        }


        #endregion

        #region Smena

        public static void dodajSmenu(SmenaDTO sme)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smena sm = new Smena();
                sm.Id = sme.Id;
                sm.VremePocetka = sme.VremePocetka;
                sm.VremeKraja = sme.VremeKraja;
                sm.EkipaZaSmenu = sme.EkipaSmene;
                

                s.SaveOrUpdate(sm);

                s.Flush();

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static void obrisiSmenu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smena m = s.Load<Smena>(id);
                s.Delete(m);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static SmenaDTO azurirajSmenu(SmenaDTO fo, int redniBrojEkipe)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smena sm = s.Load<Smena>(fo.Id);

                sm.Id = fo.Id;
                sm.VremePocetka = fo.VremePocetka;
                sm.VremeKraja = fo.VremeKraja;                
                if (redniBrojEkipe == -1)
                    sm.EkipaZaSmenu = null;
                else
                    sm.EkipaZaSmenu = s.Load<Ekipa>(redniBrojEkipe);

                s.Update(sm);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return fo;
        }

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

        public static List<ObjekatDTO> VratiListuObjekataSmene(int id)
        {
            List<ObjekatDTO> lista = new List<ObjekatDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var smena = s.Load<Smena>(id);
                    if (smena == null)
                    {
                        MessageBox.Show($"Smena sa ID {id} ne postoji.");
                        return lista;
                    }

                    var query = s.Query<Obuhvata>()
                                 .Where(x => x.Smena.Id == id)
                                 .Select(x => new ObjekatDTO
                                 {
                                     Id = x.Objekat.Id,
                                     Adresa = x.Objekat.Adresa,
                                     Tip = x.Objekat.TipObjekta,
                                     Povrsina = x.Objekat.Povrsina
                                 });

                    lista = query.ToList();
                }
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

        public static List<SmenaDTO> VratiSmeneZaEkipu(int ekipaId)
        {
            List<SmenaDTO> smeneDTO = new List<SmenaDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var smene = s.Query<Smena>()
                                 .Where(sm => sm.EkipaZaSmenu.RedniBroj == ekipaId)
                                 .ToList();

                    smeneDTO = smene.Select(sm => new SmenaDTO
                    {
                        VremePocetka = sm.VremePocetka,
                        VremeKraja = sm.VremeKraja
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message);
            }

            return smeneDTO;
        }

        public static SmenaDTO VratiPodatkeOSmeni(int smenaId)
        {
            SmenaDTO smenaDTO = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Smena smena = s.Load<Smena>(smenaId);

                    smenaDTO = new SmenaDTO
                    {
                        Id = smena.Id,
                        EkipaZaSmenu = new EkipaDTO
                        {
                            RedniBroj = smena.EkipaZaSmenu.RedniBroj,
                            clanoviEkipe = smena.EkipaZaSmenu.Clanovi.Select(cl => new FizickoObezbedjenjeDTO
                            {
                                MaticniBroj = cl.MaticniBroj,
                                Ime = cl.Ime,
                                Prezime = cl.Prezime
                            }).ToList()
                        },
                        ObjektiZaSmenu = s.Query<Obuhvata>()
                                          .Where(ob => ob.Smena.Id == smenaId)
                                          .Select(ob => new ObjekatDTO
                                          {
                                              Id = ob.Objekat.Id,
                                              Adresa = ob.Objekat.Adresa,
                                              Tip = ob.Objekat.TipObjekta,
                                              Povrsina = ob.Objekat.Povrsina
                                          }).ToList()
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message);
            }

            return smenaDTO;
        }

        #endregion

        #region RegionalniCentar
        public static List<RegionalniCentarDTO> VratiRegionalneCentre()
        {
            List<RegionalniCentarDTO> centri = new List<RegionalniCentarDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var query = s.Query<RegionalniCentar>()
                                 .Select(rc => new RegionalniCentarDTO
                                 {
                                     Id = rc.Id,
                                     Adresa = rc.Adresa,
                                     Menadzer = new MenadzerDTO
                                     {
                                         MaticniBroj = rc.AngazovanMenadzer.MaticniBroj,
                                         Ime = rc.AngazovanMenadzer.Ime,
                                         Prezime = rc.AngazovanMenadzer.Prezime
                                     }
                                 })
                                 .ToList();

                    centri = query;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }

            return centri;
        }

        public static List<int> VratiSveRegionalneCentre()
        {
            List<int> regionalniCentri = new List<int>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    regionalniCentri = s.Query<RegionalniCentar>()
                                        .Select(rc => rc.Id)
                                        .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
            return regionalniCentri;
        }

        public static RegionalniCentarDTO vratiRegCnt(int id)
        {
            RegionalniCentarDTO regcnt = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    regcnt = s.Query<RegionalniCentar>()
                              .Where(rc => rc.Id == id)
                              .Select(rc => new RegionalniCentarDTO
                              {
                                  Id = rc.Id,
                                  Adresa = rc.Adresa,
                                  Menadzer = new MenadzerDTO
                                  {
                                      MaticniBroj = rc.AngazovanMenadzer.MaticniBroj,
                                      Ime = rc.AngazovanMenadzer.Ime,
                                      Prezime = rc.AngazovanMenadzer.Prezime
                                  },
                              }).FirstOrDefault();
                              
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }

            return regcnt;
        }

        public static List<string> vratiGradoveZaRegCentar(int regCentarId)
        {
            List<string> gradovi = new List<string>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    gradovi = s.Query<Gradovi>()
                               .Where(g => g.RegCentar.Id == regCentarId)
                               .Select(g => g.Grad)
                               .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }

            return gradovi;
        }
        public static List<int> vratiTelefoneZaRegCentar(int regCentarId)
        {
            List<int> brojevi = new List<int>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    brojevi = s.Query<Telefoni>()
                               .Where(t => t.RegCentar.Id == regCentarId)
                               .Select(t => t.Telefon)
                               .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }

            return brojevi;
        }
        public static List<string> vratiVozilaZaRegCentar(int regCentarId)
        {
            List<string> vozila = new List<string>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    vozila = s.Query<Vozilo>()
                               .Where(v => v.RegistrovanNaRegCentar.Id == regCentarId)
                               .Select(v => v.RegistarskaOznaka)
                               .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }

            return vozila;
        }

        public static void DodajNoviGrad(string imeGrada, int idRegionalnogCentra)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction transaction = s.BeginTransaction())
                    {
                        var regionalniCentar = s.Load<RegionalniCentar>(idRegionalnogCentra);

                        Gradovi noviGrad = new Gradovi
                        {
                            Grad = imeGrada,
                            RegCentar = regionalniCentar
                        };

                        
                        s.Save(noviGrad);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
        }
        public static void ObrisiGrad(string grad, int regCentarId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction transaction = s.BeginTransaction())
                    {
                        Gradovi gradZaBrisanje = s.Query<Gradovi>()
                                                .Where(g => g.Grad == grad && g.RegCentar.Id == regCentarId)
                                                .FirstOrDefault();

                        if (gradZaBrisanje != null)
                        {
                            s.Delete(gradZaBrisanje);
                            transaction.Commit();
                            MessageBox.Show("Grad uspešno obrisan.");
                        }
                        else
                        {
                            MessageBox.Show("Grad nije pronađen.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
        }

        public static void DodajBrojTelefona(int regCentarId, int brojTelefona)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction transaction = s.BeginTransaction())
                    {
                        RegionalniCentar regCentar = s.Load<RegionalniCentar>(regCentarId);

                        Telefoni noviBroj = new Telefoni
                        {
                            Telefon = brojTelefona,
                            RegCentar = regCentar
                        };

                        s.Save(noviBroj);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
        }
        public static void ObrisiBrojTelefona(int brojTelefona, int regCentarId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction transaction = s.BeginTransaction())
                    {
                        Telefoni brojZaBrisanje = s.Query<Telefoni>()
                                                       .Where(bt => bt.Telefon == brojTelefona && bt.RegCentar.Id == regCentarId)
                                                       .FirstOrDefault();

                        if (brojZaBrisanje != null)
                        {
                            s.Delete(brojZaBrisanje);
                            transaction.Commit();
                            MessageBox.Show("Broj telefona uspešno obrisan.");
                        }
                        else
                        {
                            MessageBox.Show("Broj telefona nije pronađen.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
        }
        public static void DodajNoviRegionalniCentar(string adresa, long menadzerId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction transaction = s.BeginTransaction())
                    {
                        Menadzer menadzer = s.Load<Menadzer>(menadzerId);

                        RegionalniCentar noviCentar = new RegionalniCentar
                        {
                            Adresa = adresa,
                            AngazovanMenadzer = menadzer
                        };
                        s.Save(noviCentar);
                        transaction.Commit();
                    }
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
        }
        public static void ObrisiRegionalniCentar(int regCentarId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction transaction = s.BeginTransaction())
                    {
                        RegionalniCentar regCentar = s.Get<RegionalniCentar>(regCentarId);

                        if (regCentar != null)
                        {
                            s.Delete(regCentar);
                            transaction.Commit();
                        }
                        else
                        {
                            MessageBox.Show("Regionalni centar sa datim ID-jem ne postoji.");
                        }
                        s.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
        }

        #endregion

        #region Ekipa
        public static List<EkipaDTO> PopuniEkipe()
        {
            List<EkipaDTO> lista = new List<EkipaDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ekipa> ekipe = from e in s.Query<Ekipa>()
                                           select e;

                foreach (Ekipa ek in ekipe)
                {
                    EkipaDTO ekipaDTO = new EkipaDTO(ek.RedniBroj);
                    lista.Add(ekipaDTO);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return lista;
        }

        public static List<EkipaDTO> VratiSveEkipeSaClanovima()
        {
            List<EkipaDTO> ekipeDTO = new List<EkipaDTO>();
            try
            {
                ISession s = DataLayer.GetSession();

                var clanovi = s.Query<FizickoObezbedjenje>()
                               .Where(c => c.PripadaEkipi != null)
                               .ToList();
                var ekipe = s.Query<Ekipa>().ToList();

                ekipeDTO = ekipe.Select(e => new EkipaDTO
                {
                    RedniBroj = e.RedniBroj,
                    clanoviEkipe = clanovi
                                  .Where(c => c.PripadaEkipi.RedniBroj == e.RedniBroj)
                                  .Select(c => new FizickoObezbedjenjeDTO
                                  {
                                      MaticniBroj = c.MaticniBroj,
                                      Ime = c.Ime,
                                      Prezime = c.Prezime
                                  })
                                  .ToList(),
                    Vodja = e.Vodja != null
                        ? new FizickoObezbedjenjeDTO
                        {
                            MaticniBroj = e.Vodja.MaticniBroj,
                            Ime = e.Vodja.Ime,
                            Prezime = e.Vodja.Prezime
                        }
                        : null
                }).ToList();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dohvatu ekipa: " + ex.Message);
            }

            return ekipeDTO;
        }

        public static void DodajNovuEkipu(long[] maticniBrojeviClanova)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ITransaction tx = s.BeginTransaction();

                Ekipa novaEkipa = new Ekipa();
                s.Save(novaEkipa);
                s.Flush();

                foreach (long mb in maticniBrojeviClanova)
                {
                    FizickoObezbedjenje clan = s.Load<FizickoObezbedjenje>(mb);
                    clan.PripadaEkipi = novaEkipa;
                    s.Update(clan);
                }

                tx.Commit();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju nove ekipe: " + ex.Message);
            }
        }

        public static List<int> VratiEkipeBezVozila()
        {
            List<int> ekipeBezVozila = new List<int>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    ekipeBezVozila = s.Query<Ekipa>()
                                      .Where(e => e.DuziVozilo == null)
                                      .Select(e => e.RedniBroj)
                                      .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
            return ekipeBezVozila;
        }

        #endregion

        #region Odrzavanje

        public static void dodajOdrzavanje(OdrzavaDTO odrzavanje, AlarmniSistemDTO alarm, long maticni)
        {
            Odrzava o = new Odrzava();
            try
            {
                ISession s = DataLayer.GetSession();

                AlarmniSistem alarmniSistem = s.Load<AlarmniSistem>(alarm.Id);
                TehnickoLice tehnickoLice = s.Load<TehnickoLice>(maticni);

                o.AlarmniSistem = alarmniSistem;
                o.TehnickoLice = tehnickoLice;
                o.DatumOd = odrzavanje.DatumOd;
                o.DatumDo = odrzavanje.DatumDo;

                s.Save(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }
        }

        public static OdrzavaDTO vratiOdrzavanje(AlarmniSistemDTO alarm, TehnickoLiceDTO tl)
        {
            OdrzavaDTO o = new OdrzavaDTO();
            try
            {
                ISession s = DataLayer.GetSession();

                var odrzava = s.Query<Odrzava>()
                              .Where(x => x.TehnickoLice.MaticniBroj == tl.MaticniBroj && x.AlarmniSistem.Id == alarm.Id)
                              .SingleOrDefault();

                if (odrzava != null)
                {
                    o = new OdrzavaDTO
                    {
                        Id = odrzava.Id,
                        DatumOd = odrzava.DatumOd,
                        DatumDo = odrzava.DatumDo
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom vraćanja održavanja: " + ex.Message);
            }

            return o;
        }
        public static void PostaviVodju(int ekipaId, long maticniBrojVodje)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                    Ekipa ekipa = s.Get<Ekipa>(ekipaId);

                    FizickoObezbedjenje clan = s.Load<FizickoObezbedjenje>(maticniBrojVodje);

                    ekipa.Vodja = clan;
                    s.Update(ekipa);
                    s.Flush();
                    s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        public static EkipaDTO vratiEkipu(int id)
        {
            EkipaDTO ekipa = new EkipaDTO();
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Get<Ekipa>(id);

                if (e != null)
                {
                    ekipa.RedniBroj = e.RedniBroj;
                    ekipa.clanoviEkipe = s.Query<FizickoObezbedjenje>()
                                          .Where(c => c.PripadaEkipi.RedniBroj == e.RedniBroj)
                                          .Select(c => new FizickoObezbedjenjeDTO
                                          {
                                              MaticniBroj = c.MaticniBroj
                                          })
                                          .ToList();
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oh no\n{ex.Message}");
            }

            return ekipa;
        }

        public static void ObrisiEkipu(int ekipaId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction transaction = s.BeginTransaction())
                    {
                        Ekipa ekipa = s.Get<Ekipa>(ekipaId);

                        if (ekipa != null)
                        {
                            var clanovi = s.Query<FizickoObezbedjenje>()
                                           .Where(c => c.PripadaEkipi.RedniBroj == ekipa.RedniBroj)
                                           .ToList();

                            foreach (var clan in clanovi)
                            {
                                clan.PripadaEkipi = null;
                                s.Update(clan);
                            }
                            s.Delete(ekipa);
                            transaction.Commit();
                        }
                        else
                        {
                            MessageBox.Show("Ekipa sa datim ID-om ne postoji.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
        }
        #endregion

        #region Intervencija

        public static List<IntervencijaDTO> VratiIntervencijeEkipe(int ekipaId)
        {
            List<IntervencijaDTO> intervencijeDTO = new List<IntervencijaDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var intervencije = s.Query<Intervencija>()
                                         .Where(i => i.Ekipa.RedniBroj == ekipaId)
                                         .Select(i => new IntervencijaDTO
                                         {
                                             adresaObjekta = i.Objekat.Adresa,
                                             Datum = i.Datum,
                                             Vreme = i.Vreme,
                                             Tip = i.Tip
                                         })
                                         .ToList();

                    intervencijeDTO = intervencije;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message);
            }

            return intervencijeDTO;
        }

        #endregion
    }
}