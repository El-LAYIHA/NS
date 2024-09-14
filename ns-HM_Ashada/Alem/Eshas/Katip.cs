using ns_HM_Ashada.Alem.Eshas.Meziyet;
using ns_HM_Ashada.Alem.Emkine;
using ns_HM_Ashada.Alem.Asar;
using System.Linq;

namespace ns_HM_Ashada.Alem.Eshas
{
    public class Katip : Yazi
    {        
        public Katip(Bina Bina, String Metn) 
        {
            Yazin(Bina, Metn);
        }

        public void Yazin(Bina Bina, String ElMetn)
        {
            //Oluşturulmuş kitağlığımız hazır:
            Bina ElBina = Bina;

            Kitaplik Kitaplik = new Kitaplik();
            ElBina.Kitapliklar.Add(Kitaplik);

            Raf Raf = new Raf();
            Kitaplik.Raflar.Add(Raf);

            Sahife Sahife = new Sahife();
            Raf.Sahifeler.Add(Sahife);


            Sahife.Add(new Metn(ElMetn));
            Sahife.SaveChanges();

            var alan = Sahife.Metinler.OrderBy(b => b.MetnID).FirstOrDefault();
            Console.WriteLine(alan);
        }
    }
}
