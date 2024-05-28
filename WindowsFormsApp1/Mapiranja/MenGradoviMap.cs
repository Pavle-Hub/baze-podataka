namespace WindowsFormsApp1.Mapiranja
{
    public class MenGradoviMap : ClassMap<MenGradovi>
    {
        public MenGradoviMap() 
        {
            Table("GRADOVI_MENADZER");

            Id(x => x.Id, "ID_GRADA").GeneratedBy.TriggerIdentity();

            Map(x => x.Grad, "IME_GRADA");

            References(x => x.Menadzer).Column("MATICNI_BROJ_MENADZERA").LazyLoad();
        }
    }
}
