using System.ComponentModel.DataAnnotations;

namespace IMS_Microservices.Services.MenuAPI.Models
{
    public class IMSMenu
    {
        [Key]
        public int menuID { get; set; }
        [Required]
        public string manuName { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public double price { get; set; }
    }
}
