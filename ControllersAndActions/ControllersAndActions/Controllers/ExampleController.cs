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

        public RedirectToRouteResult Redirect() => RedirectToRoute(new {controller = "Example", action = "Index", ID = "MyID"});
    }
}
