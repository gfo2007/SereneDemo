﻿using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SereneDemo.Northwind.Pages
{
    [PageAuthorize(typeof(Entities.OrderDetailRow))]
    public class OrderDetailController : Controller
    {
        [Route("Northwind/OrderDetail")]
        public ActionResult Index()
        {
            return View(MVC.Views.Northwind.OrderDetail.OrderDetailIndex);
        }
    }
}
