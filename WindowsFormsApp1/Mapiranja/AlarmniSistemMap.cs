namespace WindowsFormsApp1.Mapiranja
{
    public class AlarmniSistemMap : ClassMap<AlarmniSistem>
    {
        public AlarmniSistemMap()
        {
            Table("ALARMNI_SISTEM");

            Id(x => x.Id, "ID_ALARMA").GeneratedBy.TriggerIdentity();

            Map(x => x.Proizvodjac).Column("PROIZVODJAC");
            Map(x => x.GodinaProizvodnje).Column("GODINA_PROIZVODNJE");
            Map(x => x.UltrazvucniSenzor).Column("P_ULTRAZVUK");
            Map(x => x.MinFrekvencija).Column("MIN_FREKVENCIJA");
            Map(x => x.MaxFrekvencija).Column("MAX_FREKVENCIJA");
            Map(x => x.DetektorPokreta).Column("P_DETEKTOR_POKRETA");
            Map(x => x.Osetljivost).Column("OSETLJIVOST");
            Map(x => x.DetektorToplotnogOdraza).Column("P_TOPLOTNI_ODRAZ");
            Map(x => x.HorRezolucija).Column("HORIZONTALNA_REZ");
            Map(x => x.VerRezolucija).Column("VERTIKALNA_REZ");
            Map(x => x.DatumInstalacije).Column("DATUM_INSTALACIJE");

            References(x => x.Objekat).Column("ID_OBJEKTA").LazyLoad();

            HasMany(x => x.Odrzava)
                .KeyColumn("ID_ALARMA") // <- ovde treba samo proveriti kako se zove ova kolona
                .LazyLoad()
                .Inverse()
                .Cascade.All();
        }
    }
}
