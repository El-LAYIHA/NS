using ns_HM_Ashada.Alem.Asar;
using ns_HM_Ashada.Alem.Eshas.Meziyet;
using ns_HM_Ashada.Alem.Emkine.Alanlar;
using System.Linq;

namespace ns_HM_Ashada.Alem.Eshas
{
    public class Katip : Yazi
    {        
        public Katip(String Metn, Bina Bina) 
        {
            Yazin(Metn, Bina);
        }

        public void Yazin(String Metn, Bina Bina)
        {
            //Oluşturulmuş kitağlığımız hazır:
            var IlkKitaplik = Bina.Kitaplik[0];
            var IlkRaf = IlkKitaplik.Raf;

            IlkRaf.Add(new Raf());

            //Kitaplığımızdaki raflara göz atıyoruz:
            var Liste = IlkRaf.OrderBy(x => x.Sahifeler).First();
            Console.WriteLine(Liste);
        }
    }
}
