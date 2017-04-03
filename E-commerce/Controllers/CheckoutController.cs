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
    public class CheckoutController : Controller
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        // GET: Checkout
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveOrder(string firstName, string lastName, string email, int phone, string street, string postalCode, string city)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                var insert = "INSERT INTO Information (firstName, lastName, email, phone, street, postalCode, city) VALUES (@firstName, @lastName, @email, @phone, @street, @postalCode, @city)";

                var parameters = new { firstName = firstName, lastName = lastName, email = email, phone = phone, street = street, postalCode = postalCode, city = city };

                connection.Execute(insert, parameters);
            }

            return RedirectToAction("index", "Order");
        }
    }
}