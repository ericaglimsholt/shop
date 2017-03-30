﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_commerce.Models;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace E_commerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        [HttpGet]
        public ActionResult Index()
        {
            List<ProductsViewModel> product;
            using (var connection = new SqlConnection(this.connectionString))
            {
                product = connection.Query<ProductsViewModel>("select * from Products").ToList();
            }

            return View(product);
        }

        public ActionResult Cart()
        {
            return View();
        }

     }
}