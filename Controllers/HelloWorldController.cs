using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{       
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string index()
        {

            return "This is my Defalut action";
        }
    }
}
