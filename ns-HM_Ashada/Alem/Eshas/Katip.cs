using ns_HM_Ashada.Alem.Asar;
using ns_HM_Ashada.Alem.Eshas.Meziyet;
using ns_HM_Ashada.Alem.Emkine.Rufuf;
using ns_HM_Ashada.Alem.Emkine.Alanlar;

namespace ns_HM_Ashada.Alem.Eshas
{
    public class Katip : Yazi
    {        
        public Katip(string Kelime, Bina Bina) 
        {
            Yazin(Kelime, Bina);
        }
        
        public void Yazin(string Kelime, Bina Bina)
        {
            var Sahife = new Sahife(Kelime);
            Bina.Rufuf = new Raf();
            Bina.Rufuf.Sahifeler.Add(Sahife);
        }
    }
}
