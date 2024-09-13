namespace ns_HM_Ashada.Alem.Emkine
{
    public class Bina
    {
        public List<Kitaplik> Kitaplik;

        public Bina()
        {
            //Bu türden her binada en aşağı bir kitaplık bulunur;
            Kitaplik = new List<Kitaplik>();
            Kitaplik.Add(new Kitaplik());
        }
    }
}
