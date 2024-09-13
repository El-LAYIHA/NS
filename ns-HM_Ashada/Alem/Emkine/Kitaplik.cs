using Microsoft.EntityFrameworkCore;

namespace ns_HM_Ashada.Alem.Emkine
{
    public class Kitaplik : DbContext
    {
        public DbSet<Raf> Raf;

        public Kitaplik()
        {
            //Kitaplik varolmakla inşa planı da deruhdesinde bulunur.
            //Kitaplığın inşa edileceği yer yol ile tam adresini sağladığımız kod bloku:
            var Yer = Environment.SpecialFolder.LocalApplicationData;
            var Yol = Environment.GetFolderPath(Yer);
            Adres = Path.Join(Yol, "blogging.db");
        }

        //Adres
        public string Adres;

        //İlgili adrese kitaplığın inşasını sağlayan kod bloku:
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={Adres}");
    }
}

