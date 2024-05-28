namespace WindowsFormsApp1.Entiteti
{
    public class Obuhvata
    {
        public virtual int Id { get; protected set; }
        public virtual Objekat Objekat { get; set; }
        public virtual Smena Smena { get; set; }

        public Obuhvata()
        {

        }
    }
}
