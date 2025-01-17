using System.ComponentModel.DataAnnotations;

namespace IMS_Microservices.Services.MenuAPI.Models.Dto
{
    public class IMSMenuDto
    {
        public int menuID { get; set; }
        public string manuName { get; set; }
        public string category { get; set; }
        public double price { get; set; }
    }
}
