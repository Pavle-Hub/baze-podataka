using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Mapiranja
{
    public class FizickoObezbedjenjeMap : ClassMap<FizickoObezbedjenje>
    {
        public FizickoObezbedjenjeMap()
        {
            Table("FIZICKO_OBEZBEDJENJE");

            Id(x => x.MaticniBroj, "MATICNI_BROJ").GeneratedBy.Assigned();
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.Pol, "POL");
            Map(x => x.BorilackaVestina, "BORILACKA_VESTINA");

            References(x => x.PripadaEkipi).Column("REDNI_BROJ_EKIPE").LazyLoad();
        }
    }
}
