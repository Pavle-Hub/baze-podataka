using FluentNHibernate.Conventions.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Mapiranja
{
    public class VoziloMap : ClassMap<Vozilo>
    {
        public VoziloMap()
        {
            Table("VOZILO");

            Id(x => x.RegistarskaOznaka, "REGISTARSKA_OZNAKA").GeneratedBy.TriggerIdentity();

            Map(x => x.Boja, "BOJA");
            Map(x => x.Tip, "TIP");
            Map(x => x.Model, "MODEL");
            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.DatumOd, "DATUM_OD");
            Map(x => x.DatumDo, "DATUM_DO");
     
            References(x => x.RegistrovanNaRegCentar).Column("ID_REGIONALNOG_CENTRA").LazyLoad();

            References(x => x.EkipaKojaGaDuzi).Column("REDNI_BROJ_EKIPE").LazyLoad();
        }
    }
}
