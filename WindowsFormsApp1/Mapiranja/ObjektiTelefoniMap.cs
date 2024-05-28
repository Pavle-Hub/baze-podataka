using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entiteti;

namespace WindowsFormsApp1.Mapiranja
{
    public class ObjektiTelefoniMap : ClassMap<ObjektiTelefoni>
    {
        public ObjektiTelefoniMap()
        {
            Table("BROJEVI_TELEFONA_OBJ");

            Id(x => x.Id, "ID_TELEFON").GeneratedBy.TriggerIdentity();

            Map(x => x.Telefon, "KONTAKT_TELEFON");

            References(x => x.Objekat).Column("ID_OBJEKTA").LazyLoad();

        }
    }
}
