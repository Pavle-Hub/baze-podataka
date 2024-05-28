
namespace WindowsFormsApp1.Entiteti
{
    public class FizickoObezbedjenje
    {
        public virtual long MaticniBroj { get;  set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual char? Pol { get; set; }
        public virtual string BorilackaVestina { get; set;}
        public virtual Ekipa PripadaEkipi { get; set; }

        public FizickoObezbedjenje()
        {
        }   
    }
}
