﻿using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SereneDemo.Northwind.Pages
{
    [PageAuthorize(typeof(Entities.CustomerRow))]
    public class CustomerController : Controller
    {
        [Route("Northwind/Customer")]
        public ActionResult Index()
        {
            return View(MVC.Views.Northwind.Customer.CustomerIndex);
        }
    }
}
