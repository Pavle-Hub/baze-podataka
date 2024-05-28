namespace WindowsFormsApp1.Mapiranja
{
    public class SmenaMap : ClassMap<Smena>
    {
        public SmenaMap()
        {
            Table("SMENA");

            Id(x => x.Id, "ID_SMENE").GeneratedBy.TriggerIdentity();

            Map(x => x.VremePocetka, "VREME_POCETKA");
            Map(x => x.VremeKraja, "VREME_KRAJA");

            References(x => x.EkipaZaSmenu).Column("REDNI_BROJ_EKIPE").LazyLoad();

            HasMany(x => x.ObjektiZaSmenu).KeyColumn("ID_SMENE").LazyLoad().Cascade.All().Inverse(); ;
        }
    }
}
