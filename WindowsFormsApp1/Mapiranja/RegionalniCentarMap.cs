using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Mapiranja
{
    public class RegionalniCentarMap : ClassMap<RegionalniCentar>
    {
        public RegionalniCentarMap()
        {
            Table("REGIONALNI_CENTAR");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity(); // mapiranje primarnog kljuca

            Map(x => x.Adresa, "ADRESA"); // mapiranje svojstva

            References(x => x.AngazovanMenadzer).Column("MATICNI_BROJ_MENADZERA").LazyLoad(); // veza angazovan_na N:1 REGIONALNI_CENTAR - MENADZER

            HasMany(x => x.Vozila).KeyColumn("ID_REGIONALNOG_CENTRA").Cascade.All().Inverse().LazyLoad(); // veza registrovano_na 1:N REGIONALNI_CENTAR - VOZILO

            HasMany(x => x.BrojeviTelefona).KeyColumn("ID_REG_CNT").LazyLoad().Cascade.All().Inverse(); // mapiranje liste telefona

            HasMany(x => x.ImenaGradova).KeyColumn("ID_REG_CNT").LazyLoad().Cascade.All().Inverse(); // mapiranje liste gradova
        }
    }
}
