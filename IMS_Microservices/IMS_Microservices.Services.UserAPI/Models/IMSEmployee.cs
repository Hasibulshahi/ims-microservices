using System.ComponentModel.DataAnnotations;

namespace IMS_Microservices.Services.UserAPI.Models
{
    public class IMSEmployee
    {
        [Key]
        public int employeeID { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public string password { get; set; }
    }
}
