using ns_HM_Ashada.Alem.Eshas.Meziyet;
using ns_HM_Ashada.Alem.Emkine;
using ns_HM_Ashada.Alem.Asar;
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
            var IlkRaf = IlkKitaplik.Raf.Add(new Raf { Sahifeler = new Sahife() });

            var Ornek = IlkKitaplik.Raf.OrderBy(x => x).ToList().First();

            //Kitaplığımızdaki raflara göz atıyoruz:
            Console.WriteLine(Ornek);
        }
    }
}
