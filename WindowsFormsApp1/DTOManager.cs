using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            catch(Exception ex)
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

        #endregion
    }
}
