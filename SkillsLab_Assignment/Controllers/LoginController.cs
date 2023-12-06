using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.ApplicationServices;
using System.Web.Mvc;
using BusinessLayer.Services;


namespace SkillsLab_Assignment.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loggingIn;

        public LoginController(ILoginService loggingIn)
        {
            _loggingIn = loggingIn;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIntoAccount(string emailAddress, string password)
        {
            if (_loggingIn.LoginResults(emailAddress, password))
            {
                // Return a JSON response indicating success
                return Json(new { Success = true, url = Url.Action("Success", "Login") });
            }
            else
            {
                // Return a JSON response indicating failure
                return Json(new { Success = false, ErrorMessage = "Invalid credentials!!" });
            }
        }
        public ActionResult Success()
        {
            return View();
        }

    }
}

