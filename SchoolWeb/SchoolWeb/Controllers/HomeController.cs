using Microsoft.AspNetCore.Http;
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
            string key = "Loogin";
            var Cookie = Request.Cookies[key];
            if (Cookie == null)
            {
                return Redirect("/Home/Login");
            }
            else {

                ViewBag.Title = "Home";
                return View();
            }
        }

        public IActionResult Login()
        {
            ViewBag.Title = "Login";
            return View();
        }

        [HttpGet]
        public JsonResult Loginfn() {
            string key = "Loogin";
            string value = "UserLogin";

            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(1);

            Response.Cookies.Append(key, value, options);

            return Json(new {status = true , Link = "/Home/Index" });
        }
    }
}
