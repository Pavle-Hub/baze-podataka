namespace WindowsFormsApp1.Entiteti
{
    public class MenGradovi
    {
        public virtual int Id { get; protected set; }
        public virtual Menadzer Menadzer { get; set; }
        public virtual string Grad { get; set; }
        public MenGradovi()
        {

        }

        //public override bool Equals(object obj)
        //{
        //    if (Object.ReferenceEquals(this, obj)) return true;
        //    if (obj.GetType() != typeof(MenGradovi)) return false;

        //    MenGradovi recievedObject = (MenGradovi)obj;

        //    if ((Menadzer.MaticniBroj == recievedObject.Menadzer.MaticniBroj) && (Grad == recievedObject.Grad)) return true;

        //    return false;
        //}

       /* public override int GetHashCode()
        {
            return base.GetHashCode();
        }*/
    }
}
