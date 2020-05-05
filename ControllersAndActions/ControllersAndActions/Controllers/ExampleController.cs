using Microsoft.AspNetCore.Mvc;
using System;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public JsonResult Index() => Json(new[] { "Alice", "Bob", "Joe" });
    }
}
