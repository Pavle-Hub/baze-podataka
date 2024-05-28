namespace WindowsFormsApp1.Mapiranja
{
    public class MenadzerMap : ClassMap<Menadzer>
    {
        public MenadzerMap() 
        {
            Table("MENADZER");

            Id(x => x.MaticniBroj, "MATICNI_BROJ").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.Pol, "POL");

            HasMany(x => x.RegionalniCentri).KeyColumn("MATICNI_BROJ_MENADZERA").Cascade.All().Inverse().LazyLoad();// 1:N MENADZER-REGIONALNI_CENTAR
            HasMany(x => x.MenGradovi).KeyColumn("MATICNI_BROJ_MENADZERA").Cascade.All().Inverse().LazyLoad();

        }
    }
}
