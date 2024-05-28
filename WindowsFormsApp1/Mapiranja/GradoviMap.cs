namespace WindowsFormsApp1.Mapiranja
{
    public class GradoviMap : ClassMap<Gradovi>
    {
        public GradoviMap()
        {
            Table("IMENA_GRADOVA_REG_CNT");

            Id(x => x.Id, "ID_GRADA").GeneratedBy.TriggerIdentity(); // <-- Kako se zove kolona

            Map(x => x.Grad, "IME_GRADA");

            References(x => x.RegCentar).Column("ID_REG_CNT").LazyLoad();
        }
    }
}
