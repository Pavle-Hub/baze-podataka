namespace WindowsFormsApp1.Mapiranja
{
    public class ObuhvataMap : ClassMap<Obuhvata>
    {
        public ObuhvataMap()
        {
            Table("OBUHVATANJE");

            Id(x => x.Id).GeneratedBy.Sequence("PRODUCT_ID_SEQ").Column("ID");



            References(x => x.Objekat).Column("ID_OBJEKTA").LazyLoad();
            References(x => x.Smena).Column("ID_SMENE").LazyLoad();
        }
    }
}
