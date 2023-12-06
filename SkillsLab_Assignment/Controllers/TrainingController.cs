using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.ApplicationServices;
using System.Web.Mvc;
using BusinessLayer.Services;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;

namespace SkillsLab_Assignment.Controllers
{
    public class TrainingController : Controller
    {
        private readonly ITrainingService _training;

        public TrainingController(ITrainingService training)
        {
            _training = training;
        }

        // GET: Training
        public ActionResult Index()
        {
            var trainingData = _training.GetTrainingData();
            return View(trainingData); // Return the training data to the view
        }
    }

}