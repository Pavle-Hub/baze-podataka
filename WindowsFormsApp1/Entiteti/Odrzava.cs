namespace WindowsFormsApp1.Entiteti
{
    public class Odrzava
    {
        public virtual int Id { get; protected set; } 
        public virtual AlarmniSistem AlarmniSistem { get; set; }
        public virtual TehnickoLice TehnickoLice { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        public Odrzava()
        {
            
        }
    }
}
