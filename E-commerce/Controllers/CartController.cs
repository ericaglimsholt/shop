using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_commerce.Models;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;

namespace E_commerce.Controllers
{
    public class CartController : Controller
    {

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        // GET: /Cart/
        public ActionResult Index()
        {
            List<CartViewModel> product;
            using (var connection = new SqlConnection(this.connectionString))
            {
                product = connection.Query<CartViewModel>("select * from Cart").ToList();
            }

            return View(product);
        }

        public ActionResult AddToCart(int CartId, int ProductId, string ProductTitle, int ProductPrice)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                var insert = "INSERT INTO Cart (CartId, ProductId, ProductTitle, ProductPrice) VALUES (@CartId, @ProductId, @ProductTitle, @ProductPrice)";

                var parameters = new { CartId = CartId, ProductId = ProductId, ProductTitle = ProductTitle, ProductPrice = ProductPrice };

                connection.Execute(insert, parameters);

            }

            return RedirectToAction("index", "cart");
        }
    }
}