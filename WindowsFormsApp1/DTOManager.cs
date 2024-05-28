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

                foreach(FizickoObezbedjenje a in lica)
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
            catch(Exception ex)
            {
                MessageBox.Show("Oh no\n" + ex.Message);
            }

            return lista;
         
        }

        #endregion
    }
}
