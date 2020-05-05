using Microsoft.AspNetCore.Mvc;
using System;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public VirtualFileResult Index() => File(@"~/twitter-bootstrap/css/bootstrap.min.css", "text/css");
    }
}
