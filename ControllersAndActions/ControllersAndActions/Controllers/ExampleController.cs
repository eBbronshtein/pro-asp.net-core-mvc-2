using Microsoft.AspNetCore.Mvc;
using System;

// CH 3

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index() => View(DateTime.Now);
        public ViewResult Result() => View((object)"Hello World");
    }
}
