using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        [HttpGet]
        public ActionResult Index()
        {
            var user = new RegisterModel();
            return View(user);
        }

        public ActionResult InfoSaved()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InfoSaved(RegisterModel user)
        { 
            return View(user);
        }
    }
}