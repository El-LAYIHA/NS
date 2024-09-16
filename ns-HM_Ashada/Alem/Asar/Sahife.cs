using Microsoft.EntityFrameworkCore;

namespace ns_HM_Ashada.Alem.Asar
{
    public class Sahife : DbContext
    {
        public DbSet<Metn> Metinler { get; set; }

        public Sahife()
        {
            //Kitaplik varolmakla inşa planı da deruhdesinde bulunur.
            //Kitaplığın inşa edileceği yer yol ile tam adresini sağladığımız kod bloku:
            var Yer = Environment.SpecialFolder.LocalApplicationData;
            var Yol = Environment.GetFolderPath(Yer);
            Adres = Path.Join(Yol, "blogging.db");
        }

        //Adres:
        public string Adres;

        //İlgili adrese kitaplığın inşasını sağlayan kod bloku:
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={Adres}");
    }
}
