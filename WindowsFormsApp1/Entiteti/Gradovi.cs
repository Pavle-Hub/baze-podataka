namespace WindowsFormsApp1.Entiteti
{
    public class Gradovi
    {
        public virtual int Id { get; protected set; }
        public virtual RegionalniCentar RegCentar { get; set; }
        public virtual string Grad {  get; set; }   
        public Gradovi()
        {

        }

        
    }
}
