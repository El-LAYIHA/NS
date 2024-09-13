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

            app.MapGet("/", async Metn =>
            {
                Metn.Response.ContentType = "text/html; charset=utf-8";
                //await Metn.Response.WriteAsync(Bina.Kitaplik.Sahifeler[0].Metn);
            });

            app.Run();
        }
    }
}
