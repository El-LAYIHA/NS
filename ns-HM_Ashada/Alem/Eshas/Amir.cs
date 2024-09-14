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
            var Metn =
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
                
                """;
            var Bina = new Bina();

            Yayin(Bina, Metn);
        }

        //Amir'in ne yapacağını gösteren eylemlerdir. Bunlar iç içe eylemler oluyor.
        //Amir yayin emri ile gelmiş.
        public void Yayin(Bina Bina, string Metn)
        {
            //Yayin emri için gerekli olan iki alt emir gösterilmiş. Biri yazdir, akabinde de yazılanları sunmak için sundur emri gelmiş.
            Yazdir(Bina, Metn);
            Sundur(Bina);
        }

        //Yazdirma eylemi için önce bir Katip davet ediliyor(yaratılıyor(?)) sonra da onun yazi faaliyeti emre konu oluyor.
        public void Yazdir(Bina Bina, string Metn)
        {
            Katip VefikBey = new Katip(Bina, Metn);
        }

        //Sundurma eylemi için önce bir Sunucu davet ediliyor(yaratılıyor(?)) sonra da onun sunu faaliyeti emre konu oluyor.
        public void Sundur(Bina Bina)
        {
            Sunucu NamikBey = new Sunucu(Bina);
        }
    }
}
