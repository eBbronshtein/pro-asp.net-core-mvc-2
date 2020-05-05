using Microsoft.AspNetCore.Mvc;
using System;

// CH 3

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = "Hello";
            ViewBag.Date = DateTime.Now;
            return View();
        }

        public ViewResult Result() => View((object)"Hello World");

        public RedirectToActionResult Redirect() => RedirectToAction(nameof(Index));

        // public RedirectToActionResult Redirect() => RedirectToAction(nameof(HomeController), nameof(HomeController.Index));
    }
}
