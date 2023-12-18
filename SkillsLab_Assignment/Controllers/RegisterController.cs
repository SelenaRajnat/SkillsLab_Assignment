using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Services;
using DataAccessLayer.Models;

namespace SkillsLab_Assignment.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register

        private readonly IRegisterService _register;
        public RegisterController(IRegisterService employee)
        {
            _register = employee;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Verify(Employee employee)
        {
            if(_register.RegisterResults(employee))
                return RedirectToAction("Index", "Login");
           
            return RedirectToAction("Index", "Register");
        }
    }
}
