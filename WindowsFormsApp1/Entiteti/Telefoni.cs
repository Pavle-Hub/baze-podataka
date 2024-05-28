namespace WindowsFormsApp1.Entiteti
{
    public class Telefoni
    {
        public virtual int Id { get; set; }
        public virtual RegionalniCentar RegCentar { get; set; } 
        public virtual int Telefon {  get; set; }   

        public Telefoni()
        {

        }

        //public override bool Equals(object obj)
        //{
        //    if(Object.ReferenceEquals(this, obj)) return true;
        //    if (obj.GetType() != typeof(Telefoni)) return false;

        //    Telefoni recievedObject = (Telefoni)obj;

        //    if ((RegCentar.Id == recievedObject.RegCentar.Id) && (Telefon == recievedObject.Telefon)) return true;

        //    return false;
        //}

       // public override int GetHashCode()
       // {
       //     return base.GetHashCode();
       // }
    }
}
