using Microsoft.EntityFrameworkCore;

namespace ns_HM_Ashada.Alem.Asar
{
    public class Metn
    {
        public int MetnID { get; set; }
        public string ElMetn { get; set; }

        public Metn(string ElMetn) 
        {
            this.ElMetn = ElMetn;
            this.MetnID = 4;
        }
    }
}
