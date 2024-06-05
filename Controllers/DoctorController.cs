using Assignment_01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment_01.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult CheckFever()
        {

            double? Temperature = double.TryParse(Request.Query["Temperature"], out var temperatureValue)
                ? temperatureValue
                : (double?)null;

            ViewBag.FeverMessage = FeverChecker.EvaluateFever(Temperature);
            ViewBag.HypothermiaMessage = FeverChecker.EvaluateHypothermia(Temperature);
            return View(Temperature);
        }

    }
}