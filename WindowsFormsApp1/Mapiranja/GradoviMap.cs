namespace WindowsFormsApp1.Mapiranja
{
    public class GradoviMap : ClassMap<Gradovi>
    {
        public GradoviMap()
        {
            Table("IMENA_GRADOVA_REG_CNT");

            Id(x => x.Id).GeneratedBy.Sequence("PRODUCT_ID_SEQ").Column("ID_GRADA");

            Map(x => x.Grad, "IME_GRADA");

            References(x => x.RegCentar).Column("ID_REG_CNT").LazyLoad();
        }
    }
}
