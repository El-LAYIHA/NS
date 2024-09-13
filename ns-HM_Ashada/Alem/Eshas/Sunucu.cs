using ns_HM_Ashada.Alem.Asar;
using ns_HM_Ashada.Alem.Emkine;
using ns_HM_Ashada.Alem.Eshas.Meziyet;

namespace ns_HM_Ashada.Alem.Eshas
{
    public class Sunucu : Sunu
    {
        public Sunucu(Bina Bina)
        {
            Sunum(Bina);
        }

        public void Sunum(Bina Bina)
        {
            var builder = WebApplication.CreateBuilder();
            var app = builder.Build();
            var ElMetn = Bina.Kitapliklar[0].Raflar[0].Sahifeler[0].Metinler.OrderBy(Metinler => Metinler.ElMetn).FirstOrDefault();

            app.MapGet("/", async Metn =>
            {
                Metn.Response.ContentType = "text/html; charset=utf-8";
                await Metn.Response.WriteAsync(ElMetn.ElMetn);
            });

            app.Run();
        }
    }
}
