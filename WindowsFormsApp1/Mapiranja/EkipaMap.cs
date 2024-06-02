namespace WindowsFormsApp1.Mapiranje
{
    public class EkipaMap : ClassMap<Ekipa>
    {
        public EkipaMap()
        {

            Table("EKIPA");

            Id(x => x.RedniBroj).GeneratedBy.Sequence("PRODUCT_ID_SEQ").Column("REDNI_BROJ"); // primarni kljuc

            References(x => x.Vodja).Column("MATICNI_BROJ_VODJE").LazyLoad(); // 1:1 veza JE_VODJA

            HasMany(x => x.Clanovi).KeyColumn("REDNI_BROJ_EKIPE").LazyLoad().Cascade.All().Inverse(); // 1:N EKIPA - FIZICKO_OBEZBEDJENJE

            HasMany(x => x.Smene).KeyColumn("REDNI_BROJ_EKIPE").Cascade.All().LazyLoad().Inverse(); // 1:N EKIPA - SMENA

            HasMany(x => x.Intervencija).KeyColumn("ID_EKIPE").LazyLoad().Cascade.All().Inverse(); // M:N veza Intervencija

           // References(x => x.DuziVozilo).Column("REDNI_BROJ_EKIPE").LazyLoad(); // 1:1 EKIPA - VOZILO











        }
    }
}
