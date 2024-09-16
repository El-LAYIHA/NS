using Microsoft.EntityFrameworkCore;

namespace ns_HM_Ashada.Alem.Asar
{
    public class Metn
    {
        //Her bir metnin bir kimlik numarası bir de içeriği olur:
        public required int MetnID { get; set; }
        public required string ElMetn { get; set; }
    }
}
