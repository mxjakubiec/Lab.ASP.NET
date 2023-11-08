using Microsoft.AspNetCore.Mvc;

namespace _2lab.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result(Birth model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
    }
}
