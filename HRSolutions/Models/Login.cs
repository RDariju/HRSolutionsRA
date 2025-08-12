using System.ComponentModel.DataAnnotations;

namespace HRSolutions.Models
{
    public class Login
    {
        [Key]
        public string UserId { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string email { get; set; }
    }
}
