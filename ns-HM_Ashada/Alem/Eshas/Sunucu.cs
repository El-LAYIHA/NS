using ns_HM_Ashada.Alem.Emkine.Alanlar;
using ns_HM_Ashada.Alem.Emkine.Rufuf;
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

            app.MapGet("/", () => Bina.Rufuf.Sahifeler[0].Metn);
            app.Run();
        }
    }
}
