namespace WindowsFormsApp1.Entiteti
{
    public class Objekat
    {
        public virtual int Id { get; protected set; }
        public virtual string Adresa { get; set; }
        public virtual string TipObjekta { get; set; }
        public virtual float? Povrsina { get; set; }
        public virtual IList<ObjektiTelefoni> KontaktTelefoni { get; set; }
        public virtual IList<Obuhvata> ObuhvataSmene { get; set; }
        public virtual IList<AlarmniSistem> AlarmniSistemi { get; set; }    
        public virtual IList<Intervencija> Intervencije { get; set; }
        public Objekat()
        {
            KontaktTelefoni = new List<ObjektiTelefoni>();
            ObuhvataSmene = new List<Obuhvata>();
            Intervencije = new List<Intervencija>();
            AlarmniSistemi = new List<AlarmniSistem>(); 
        }   
        
    }
}
