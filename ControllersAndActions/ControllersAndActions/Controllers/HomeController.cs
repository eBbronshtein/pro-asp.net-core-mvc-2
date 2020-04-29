using Microsoft.AspNetCore.Mvc;
using System.Text;
using ControllersAndActions.Infrastructure;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("SimpleForm");

        public IActionResult ReceiveForm(string name, string city) => new CustomHtmlResult
        {
            Content = $"{name} lives in {city}"
        };
    }
}
