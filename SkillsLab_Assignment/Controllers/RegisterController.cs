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
        //public ActionResult Verify(Employee employee)
        //{
        //    List<ValidationResult> validationResults = _register.RegisterResults(employee);

        //    if (validationResults.Count == 0)
        //    {
        //        return View("Success");
        //    }
        //    else
        //    {
        //        validationResults.Add(new ValidationResult("Unable to register user!"));
        //    }

        //    return View("Error", validationResults);

        //}
        public ActionResult Verify(Employee employee)
        {
            if(_register.RegisterResults(employee))
                return RedirectToAction("Index", "Login");
           
            return RedirectToAction("Index", "Register");
        }


        //// GET: Register/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Register/Create
        //public ActionResult Success()
        //{
        //    return View();
        //}

        //// POST: Register/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Register/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Register/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Register/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Register/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
