using BuyTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuyTickets.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel data)
        {
            if(data != null)
            {
                if(data.UserName=="" && data.Password=="")
                {
                    return RedirectToAction("Login");
                }
                else
                    return RedirectToAction("Login");
            }
            return RedirectToAction("Login");
        }
    }
}