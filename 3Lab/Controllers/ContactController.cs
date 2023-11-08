using Microsoft.AspNetCore.Mvc;


namespace _3Lab.Controllers
{
    public class ContactController : Controller
    {
        static readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        static int index = 1;
        private IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View("Update", _contacts[id]);
        }
        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contacts[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_contacts[id]);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contacts[id]);
        }
    }
}
