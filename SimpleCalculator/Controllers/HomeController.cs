using Microsoft.AspNetCore.Mvc;
using SimpleCalculator.Models;
using System.Diagnostics;

namespace SimpleCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Result = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator model, string operation)
        {

            if (ModelState.IsValid)
            {
                decimal result = model.Calculate(operation); 
                ViewBag.Result = result.ToString("C");
            }
            else
            {
                @ViewBag.ErrorMessage = "There is a problem in your calculation";
                ViewBag.Result = 0;
            }

            return View(model);
        }


    }
}
