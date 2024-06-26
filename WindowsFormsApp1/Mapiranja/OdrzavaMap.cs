﻿namespace WindowsFormsApp1.Mapiranja
{
    public class OdrzavaMap : ClassMap<Odrzava>
    {
        public OdrzavaMap()
        {
            Table("ODRZAVANJE");

            Id(x => x.Id).GeneratedBy.Sequence("ODRZAVANJE_ID_SEQ").Column("ID");
            Map(x => x.DatumOd, "DATUM_OD");
            Map(x => x.DatumDo, "DATUM_DO");
     
            References(x => x.TehnickoLice).Column("MATICNI_BROJ_TEHN_LICA").LazyLoad();
            References(x => x.AlarmniSistem).Column("ID_ALARMA").LazyLoad();
        }
    }
}
