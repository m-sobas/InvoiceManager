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

        public int Lp { get; set; }

        public int InvoiceId { get; set; }

        [Display(Name = "Wartość")]
        public decimal Value { get; set; }

        [Display(Name = "Produkt")]
        public int ProductId { get; set; }

        [Display(Name = "Ilość")]
        public int Quantity { get; set; }
       
        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
    }
}