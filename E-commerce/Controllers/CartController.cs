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
            return View();
        }
    }
}