using ns_HM_Ashada.Alem.Eshas.Meziyet;
using ns_HM_Ashada.Alem.Eshas;
using ns_HM_Ashada.Alem.Asar;
using System.Security.Cryptography.X509Certificates;
using ns_HM_Ashada.Alem.Emkine;

namespace ns_HM_Ashada.Alem.Eshas
{
    public class Amir : İdare
    {
        public Amir()
        {             
            //Amir'in idarede olduğu mekanın netleştirillmesi
            var Metn = "Fermandır.";
            var Bina = new Bina();

            Yayin(Metn, Bina);
        }

        //Amir'in ne yapacağını gösteren eylemlerdir. Bunlar iç içe eylemler oluyor.
        //Amir yayin emri ile gelmiş.
        public void Yayin(string Metn, Bina Bina)
        {
            //Yayin emri için gerekli olan iki alt emir gösterilmiş. Biri yazdir, akabinde de yazılanları sunmak için sundur emri gelmiş.
            Yazdir(Metn, Bina);
            Sundur(Bina);
        }

        //Yazdirma eylemi için önce bir Katip davet ediliyor(yaratılıyor(?)) sonra da onun yazi faaliyeti emre konu oluyor.
        public void Yazdir(string Metn, Bina Bina)
        {
            Katip VefikBey = new Katip(Metn, Bina);
        }

        //Sundurma eylemi için önce bir Sunucu davet ediliyor(yaratılıyor(?)) sonra da onun sunu faaliyeti emre konu oluyor.
        public void Sundur(Bina Bina)
        {
            Sunucu NamikBey = new Sunucu(Bina);
        }
    }
}
