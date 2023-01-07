using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Xml.Linq;

namespace InvoiceManager.Models.Domains
{
    public class InvoicePosition
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole Lp jest wymagane")]
        public int Lp { get; set; }

        public int InvoiceId { get; set; }

        [Required(ErrorMessage = "Pole Wartość jest wymagane")]
        [Display(Name = "Wartość")]
        public decimal Value { get; set; }

        [Required(ErrorMessage = "Pole Produkt jest wymagane")]
        [Display(Name = "Produkt")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Pole Ilość jest wymagane")]
        [Display(Name = "Ilość")]
        public int Quantity { get; set; }
       
        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
    }
}