using System.ComponentModel.DataAnnotations;

namespace InvoiceManager.Models
{
    public class VerifyPhoneNumberViewModel
    {
        [Required]
        [Display(Name = "Kod")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Numer telefonu")]
        public string PhoneNumber { get; set; }
    }
}