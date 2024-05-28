namespace WindowsFormsApp1.Mapiranja
{
    public class TehnickoLiceMap : ClassMap<TehnickoLice>
    {
        public TehnickoLiceMap() 
        {
            Table("TEHNICKO_LICE");

            Id(x => x.MaticniBroj, "MATICNI_BROJ").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.Pol, "POL");
            Map(x => x.StrucnaSprema, "STRUCNA_SPREMA");
            Map(x => x.Oblast, "OBLAST_TEHNIKE");
                                             
            HasMany(x => x.OdrzavaAS).KeyColumn("MATICNI_BROJ_TEHN_LICA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
