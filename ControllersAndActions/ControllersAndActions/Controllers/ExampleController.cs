using Microsoft.AspNetCore.Mvc;
using System;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        //public ContentResult Index() => Content("[\"Alice\",\"Bob\",\"Joe\"]", "application/json");

        public ObjectResult Index() => Ok(new string[] { "Alice", "Bob", "Joe" });
    }
}
