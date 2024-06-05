using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Mapiranja
{
    public class TelefoniMap: ClassMap<Telefoni>
    { 
        public TelefoniMap()
        {
            Table("BROJEVI_TELEFONA_REG_CNT");

            Id(x => x.Id).GeneratedBy.Sequence("PRODUCT_ID_SEQ").Column("ID_TELEFON");

            Map(x => x.Telefon, "BROJ_TELEFONA");

            References(x => x.RegCentar).Column("ID_REG_CNT").LazyLoad();
        }
    }
}
