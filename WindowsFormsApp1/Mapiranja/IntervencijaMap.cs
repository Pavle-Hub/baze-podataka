﻿namespace WindowsFormsApp1.Mapiranja
{
    public class IntervencijaMap : ClassMap<Intervencija>
    {
        public IntervencijaMap()
        {
            Table("INTERVENCIJA");

            Id(x => x.Id).GeneratedBy.Sequence("PRODUCT_ID_SEQ").Column("ID");

            Map(x => x.Vreme, "VREME");
            Map(x => x.Datum, "DATUM");
            Map(x => x.Tip, "TIP_INTERVENCIJE");

            References(x => x.Objekat).Column("ID_OBJEKTA").LazyLoad();

            References(x => x.Ekipa).Column("ID_EKIPE").LazyLoad();
        }
    }
}
