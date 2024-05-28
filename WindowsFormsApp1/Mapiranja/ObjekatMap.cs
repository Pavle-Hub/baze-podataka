namespace WindowsFormsApp1.Mapiranja
{
    public class ObjekatMap : ClassMap<Objekat>
    {
        public ObjekatMap()
        {
            Table("OBJEKAT");

            Id(x => x.Id, "ID_OBJEKTA").GeneratedBy.TriggerIdentity();

            Map(x => x.Adresa, "ADRESA");
            Map(x => x.TipObjekta, "TIP_OBJEKTA");
            Map(x => x.Povrsina, "POVRSINA");

            HasMany(x => x.KontaktTelefoni).KeyColumn("ID_OBJEKTA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.ObuhvataSmene).KeyColumn("ID_OBJEKTA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.AlarmniSistemi).KeyColumn("ID_OBJEKTA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Intervencije).KeyColumn("ID_OBJEKTA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
