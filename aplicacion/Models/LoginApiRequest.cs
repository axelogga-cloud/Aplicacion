using System.ComponentModel.DataAnnotations;
namespace aplicacion.Models
{
    public class LoginApiRequest
    {
        [Required]
        [EmailAddress]
        public string Usuario { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
