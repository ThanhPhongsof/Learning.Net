using FluentValidation.Models;
using FluentValidation.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FluentValidation.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserModel model)
        {
            if (ModelState.IsValid)
            {
                // Logic code
            }
            return View(model);
        }
    }
}