namespace WindowsFormsApp1.Entiteti
{
    public class TehnickoLice
    {
        public virtual int MaticniBroj { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; } 
        public virtual char? Pol { get; set; }  
        public virtual string? StrucnaSprema { get; set; }
        public virtual string? Oblast { get; set; }
        public virtual IList<Odrzava> OdrzavaAS { get; set; }
        public TehnickoLice()
        {
            OdrzavaAS = new List<Odrzava>();
        }   

    }
}
