using Microsoft.AspNetCore.Mvc;
using PetShop_WebApp4.Models;
using PetShop_WebApp4.Service;

namespace PetShop_WebApp4.Controllers
{
    [Route("Catalog")]
    public class CatalogController : Controller
    {
        private IService _service;

        public CatalogController(IService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            List<Category> categories = _service.GetCategories();

            ViewBag.Cats = categories;
            return View(_service.GetAnimals());
        }

        [HttpPost]
        [Route("Catalog/Filter")]
        public IActionResult Filter(int selectedCategoryId)
        {
            List<Category> categories = _service.GetCategories();

            ViewBag.Cats = categories;
            if (selectedCategoryId != 0)
            {
                List<Animal> animals = _service.GetByCategory(selectedCategoryId);
                return View("Index", animals);
            }

            return RedirectToAction("Index");
        }

        [HttpGet("Details/{animalId}")]
        public IActionResult Details(int animalId)
        {
            var animal = _service.ShowAnimalById(animalId);
            return View("AnimalDetails", animal);
        }

        [HttpPost("AddComment/{animalId}")]
        public IActionResult AddComment(int animalId, string comment)
        {
            if (string.IsNullOrEmpty(comment))
            {
                Animal awc = _service.ShowAnimalById(animalId);
                return View("AnimalDetails", awc);
            }
            var animal = _service.AddComment(animalId, comment);
            return View("AnimalDetails", animal);
        }


    }
}