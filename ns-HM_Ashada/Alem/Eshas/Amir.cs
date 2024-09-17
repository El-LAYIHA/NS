using ns_HM_Ashada.Alem.Eshas.Meziyet;
using ns_HM_Ashada.Alem.Emkine;

namespace ns_HM_Ashada.Alem.Eshas
{
    public class Amir : Idare
    {
        public Arsa?     Arsa        { get; }
        public Usta?     KerimUsta   { get; }

        public Katip?    SirriBey    { get; }
        public Sunucu?   YakupBey    { get; }

        public Amir()
        {
            //İstihdam faaliyeti
            Arsa        = new Arsa      ()                                      ;

            KerimUsta   = new Usta      (Arsa)                                  ;

            SirriBey    = new Katip     (Arsa.Binalar[0].Katlar[0].Odalar[0])   ;
            YakupBey    = new Sunucu    (Arsa.Binalar[0].Katlar[0].Odalar[0])   ;

            Idare();
        }

        public void Idare()
        {   
            Yayin();
        }

        //Amir'in ne yapacağını gösteren eylemlerdir. Bunlar iç içe eylemler oluyor.
        //Amir yayin emri ile gelmiş.
        public void Yayin()
        { 
            //Yayin emri için gerekli olan iki alt emir gösterilmiş. Biri yazdir, akabinde de yazılanları sunmak için sundur emri gelmiş.
            Yazdir(SirriBey);
            Sundur(YakupBey);
        }

        //Yazdirma eylemi için önce bir Katip davet ediliyor(yaratılıyor(?)) sonra da onun yazi faaliyeti emre konu oluyor.
        public void Yazdir(Katip Kim)
        {
            Kim.Yazin();
        }

        //Sundurma eylemi için önce bir Sunucu davet ediliyor(yaratılıyor(?)) sonra da onun sunu faaliyeti emre konu oluyor.
        public void Sundur(Sunucu Kim)
        {
            Kim.Sunum();
        }
    }
}
