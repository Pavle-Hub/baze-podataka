namespace WindowsFormsApp1.Entiteti
{
    public class Vozilo
    {
        public virtual string RegistarskaOznaka { get; protected set; }
        public virtual string Boja { get; set; }
        public virtual string? Tip { get; set; }
        public virtual string? Model { get; set; }
        public virtual string? Proizvodjac { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        public virtual RegionalniCentar RegistrovanNaRegCentar { get; set; }
        public virtual Ekipa EkipaKojaGaDuzi {  get; set; }
        public Vozilo()
        {

        }
    }
}
