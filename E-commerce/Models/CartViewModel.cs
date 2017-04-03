using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Models
{
    public class CartViewModel
    {
        public int CartId { set; get; }
        public int ProductId { set; get; }
        public string ProductTitle { set; get; }
        public int ProductPrice { set; get; }

    }

}