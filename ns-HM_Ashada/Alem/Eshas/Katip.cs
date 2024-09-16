using ns_HM_Ashada.Alem.Asar;
using ns_HM_Ashada.Alem.Emkine;
using ns_HM_Ashada.Alem.Eshas.Meziyet;

namespace ns_HM_Ashada.Alem.Eshas
{
    public class Katip : Yazi
    {
        //Katipin nerede çalışacağı bilgisi:
        public Oda Nerede {get; set; }

        public Katip(Oda Nerede)
        {
            //Bir katip sınıfından varlık varolunca hemen neresi için varolacağı netleştirilir:
            this.Nerede = Nerede;
        }

        public void Yazin()
        {
            //Raftaki sayfaların hazırlanması için var edilmesi:
            List<Sahife> Sahifeler = new List<Sahife>();
            
            //Raflardaki sayfaların hazırlanması:
            Nerede
                 .Kitapliklar[0]
                 .Raflar[0]
                 .Sahifeler  =   Sahifeler;
            
            //Sayfaların nerde olduğunun gösterilmesi:
            Sahifeler   = 
                 Nerede
                    .Kitapliklar[0]
                    .Raflar[0]
                    .Sahifeler;


            //Sayfaya gömülecek metnin hazırlanması:
            Metn Metn = new()
            {
                MetnID = new(),
                ElMetn =
                """

                <!DOCTYPE html>
                <html lang="tr">
                <head>
                    <meta charset="UTF-8">
                    <meta name="viewport" content="width=device-width, initial-scale=1.0">
                    <title>Açık Kitap Simülasyonu</title>
                    <style>
                        body {
                            display: flex;
                            justify-content: center;
                            align-items: center;
                            height: 100vh;
                            margin: 0;
                            background-color: #f0f0f0;
                            font-family: Arial, sans-serif;
                        }
                        .book {
                            display: flex;
                            width: 800px;
                            height: 500px;
                            background-color: #fff;
                            box-shadow: 0 0 20px rgba(0,0,0,0.2);
                        }
                        .page {
                            width: 50%;
                            padding: 20px;
                            box-sizing: border-box;
                            border: 1px solid #ddd;
                        }
                        .page-left {
                            border-right: none;
                            background-image: linear-gradient(to right, #fff, #f9f9f9);
                        }
                        .page-right {
                            border-left: none;
                            background-image: linear-gradient(to left, #fff, #f9f9f9);
                        }
                        h1 {
                            text-align: center;
                            color: #333;
                        }
                        p {
                            text-align: justify;
                            line-height: 1.6;
                            color: #444;
                        }
                    </style>
                </head>
                <body>
                    <div class="book">
                        <div class="page page-left">
                            <h1>Sayfa 1</h1>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                        </div>
                        <div class="page page-right">
                            <h1>Sayfa 2</h1>
                            <p>Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                        </div>
                    </div>
                </body>
                </html>

                """
            };

            //Metin yazılcak sahifenin oluşturulması:
            Sahife Sahife = new();
            Sahifeler.Add(Sahife);
            Sahife = Sahifeler[0]; 
 
            //Sayfaya basılması için metinlerin gömülmesi ve kaydedilmesi:
            Sahife.Add(Metn);
            Sahife.SaveChanges();
        }
    }
}
