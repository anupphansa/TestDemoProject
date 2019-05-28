using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVCwithGitHub.Models;

namespace TestMVCwithGitHub.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee emp )
        {
            if (ModelState.IsValid == true)
            {

                return RedirectToAction("success", "Home");
            }

            return View(emp);
        }

        public ActionResult success()
        {
            return View();
        }
    }
}
