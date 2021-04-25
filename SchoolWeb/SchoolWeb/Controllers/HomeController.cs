using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult Login()
        {
            ViewBag.Title = "Login";
            return View();
        }
    }
}
