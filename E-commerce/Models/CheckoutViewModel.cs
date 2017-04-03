using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Models
{
    public class CheckoutViewModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string street { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
    }
}