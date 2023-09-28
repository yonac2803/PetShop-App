using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using PetShop_WebApp4.Service;

namespace PetShop_WebApp4.Controllers
{
    public class HomeController : Controller
    {
        private IService _service;

        public HomeController(IService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View(_service.GetTopAnimals().OrderByDescending(x => x.Comments.Count()));
        }
    }
}