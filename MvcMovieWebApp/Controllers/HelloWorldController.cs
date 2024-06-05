using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovieWebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int nums = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["Number"] = nums;
            return View();
        }
    }
}
