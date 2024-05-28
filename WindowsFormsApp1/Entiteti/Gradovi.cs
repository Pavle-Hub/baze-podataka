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

        //public override bool Equals(object obj)
        //{
        //    if (Object.ReferenceEquals(this, obj)) return true;
        //    if (obj.GetType() != typeof(Gradovi)) return false;

        //    Gradovi recievedObject = (Gradovi)obj;

        //    if ((RegCentar.Id == recievedObject.RegCentar.Id) && (Grad == recievedObject.Grad)) return true;

        //    return false;
        //}

        /*public override int GetHashCode()
        {
            return base.GetHashCode();
        }*/
    }
}
