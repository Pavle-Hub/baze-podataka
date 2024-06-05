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

            Id(x => x.Id).GeneratedBy.Sequence("PRODUCT_ID_SEQ").Column("ID_TELEFON");

            Map(x => x.Telefon, "KONTAKT_TELEFON");

            References(x => x.Objekat).Column("ID_OBJEKTA").LazyLoad();

        }
    }
}
