using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeTrainingRegistration.DataService;

namespace SkillsLab_Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDAL _layer;

        public HomeController(IDAL layer)
        {
            _layer = layer;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Index()
        {
            ViewBag.Message = _layer.Connect();

            return RedirectToAction("Index", "Login");
        }
    }
}