namespace WindowsFormsApp1.Entiteti
{
    public class AlarmniSistem
    { 
        public virtual int Id { get; protected set; }
        public virtual string Proizvodjac { get; set; }
        public virtual int? GodinaProizvodnje { get; set; }
        public virtual char UltrazvucniSenzor { get; set; } = 'N';
        public virtual int? MinFrekvencija { get; set; }
        public virtual int? MaxFrekvencija { get; set; }
        public virtual char DetektorPokreta { get; set; } = 'N';
        public virtual int? Osetljivost { get; set; }
        public virtual char DetektorToplotnogOdraza { get; set; } = 'N';
        public virtual int? HorRezolucija { get; set; }
        public virtual int? VerRezolucija { get; set; }
        public virtual DateTime DatumInstalacije { get; set; }
        public virtual Objekat Objekat { get; set; }
        public virtual IList<Odrzava> Odrzava { get; set; }
        public AlarmniSistem()
        {
            Objekat = new Objekat();
            Odrzava = new List<Odrzava>();
        }
    }
}
