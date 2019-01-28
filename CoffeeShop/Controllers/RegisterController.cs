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
            if(ModelState.IsValid)
            { 
                return View(user);
            }
            return View();
        }

        public ActionResult Wecome()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Welcome(RegisterModel user)
        {
                return View(user);
        }
    }
}