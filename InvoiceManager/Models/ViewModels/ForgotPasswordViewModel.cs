using System.ComponentModel.DataAnnotations;

namespace InvoiceManager.Models
{

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }
    }
}
