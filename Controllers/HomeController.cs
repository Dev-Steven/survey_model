using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using surveyModel.Models;

namespace surveyModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("survey")]
        public IActionResult Submission(Survey survey)
        {
            return View("Result", survey);
        }

    }
}
