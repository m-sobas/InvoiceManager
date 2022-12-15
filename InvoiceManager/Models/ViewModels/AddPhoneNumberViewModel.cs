using System.ComponentModel.DataAnnotations;

namespace InvoiceManager.Models
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Numer telefonu")]
        public string Number { get; set; }
    }
}