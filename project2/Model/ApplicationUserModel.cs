using System.ComponentModel.DataAnnotations;

namespace project2.Model
{
    public class ApplicationUserModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FullName { get; set; }
        [Required]
        public string Eamil { get; set; }
        [Required]
        public string Password { get; set; } 

        
        
    }
}
