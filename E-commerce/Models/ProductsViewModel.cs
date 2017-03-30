using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Models
{
    public class ProductsViewModel
    {
        public string VideoId { set; get; }
        public string VideoTitle { set; get; }
        public int VideoPrice { set; get; }
        public string ImgPath { set; get; }
    }
}