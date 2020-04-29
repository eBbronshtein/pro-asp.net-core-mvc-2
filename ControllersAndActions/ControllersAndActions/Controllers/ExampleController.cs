using Microsoft.AspNetCore.Mvc;
namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            return View("/Views/Admin/Index");
        }
    }
}
