using System.ComponentModel.DataAnnotations;

namespace InvoiceManager.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }
    }
}
