using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.Username=="a@a"&&model.Password=="123")
            {
                return RedirectToAction("index", "home");
            }
            return RedirectToAction("login");
        }

    }
}
