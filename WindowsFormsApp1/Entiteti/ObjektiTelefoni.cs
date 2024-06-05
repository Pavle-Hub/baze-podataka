namespace WindowsFormsApp1.Entiteti
{
    public class ObjektiTelefoni
    {
        public virtual int Id { get; protected set; }
        public virtual Objekat Objekat { get; set; }
        public virtual long Telefon { get; set; }
        public ObjektiTelefoni()
        {

        }
    }
}
