using Microsoft.Identity.Client;
using ns_HM_Ashada.Alem.Emkine;
using ns_HM_Ashada.Alem.Eshas.Meziyet;
using System.Dynamic;

namespace ns_HM_Ashada.Alem.Eshas
{
    public class Usta : Yapi
    {
        public Usta(Arsa Nereye) 
        {
            Yapim(Nereye);
        }

        public void Yapim(Arsa Nereye)
        {
            //Arsada binaların yer alacağı parselin belirlenmesi:
            Bina Bina = new Bina();
            List<Bina> Binalar = new List<Bina>();
            Nereye.Binalar = Binalar;
            Nereye.Binalar.Add(Bina);
            Binalar = Nereye.Binalar;

            //Parsele ilk binanın eklenmesi:
            Bina = Binalar[0];

            //İnsa edilen ilk binaya bir kat atılması:
            Kat Kat = new Kat();
            List<Kat> Katlar = new List<Kat>();
            Bina.Katlar = Katlar;
            Bina.Katlar.Add(Kat);
            Kat = Bina.Katlar[0];

            //Kata bir oda inşası:
            Oda Oda = new Oda();
            List<Oda> Odalar = new List<Oda>();
            Kat.Odalar = Odalar;
            Kat.Odalar.Add(Oda);
            Oda = Kat.Odalar[0];

            //Odaya raf atanıyor:
            Kitaplik Kitaplik = new Kitaplik();
            List<Kitaplik> Kitapliklar = new List<Kitaplik>();
            Oda.Kitapliklar = Kitapliklar;
            Oda.Kitapliklar.Add(Kitaplik);
            Kitaplik = Oda.Kitapliklar[0];

            Raf Raf = new Raf();
            List<Raf> Raflar = new List<Raf>();
            Kitaplik.Raflar = Raflar;
            Kitaplik.Raflar.Add(Raf);


            //Arsa üzerine bir bina ona bir kat ona bir oda
            //ve ona da bir kitaplik hazır edildi artık sıra
            //Yazıncı memurlar ve diğer memurlarda
        }
    }
}
