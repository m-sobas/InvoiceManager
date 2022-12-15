using System.ComponentModel.DataAnnotations;

namespace InvoiceManager.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Adres e-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Display(Name = "Zapamiętać Cię?")]
        public bool RememberMe { get; set; }
    }
}
