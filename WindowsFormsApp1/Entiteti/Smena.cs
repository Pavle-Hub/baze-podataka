namespace WindowsFormsApp1.Entiteti
{
    public class Smena
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime VremePocetka { get; set; }
        public virtual DateTime VremeKraja { get; set; }
        public virtual Ekipa EkipaZaSmenu { get; set; }
        public virtual IList<Obuhvata> ObjektiZaSmenu { get; set; }
        public Smena()
        {
            ObjektiZaSmenu = new List<Obuhvata>();
        }
    }
}
