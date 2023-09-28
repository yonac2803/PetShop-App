using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShop_WebApp4.Data;
using PetShop_WebApp4.Models;
using PetShop_WebApp4.Service;
using SixLabors.ImageSharp.Formats.Jpeg;
using static System.Net.Mime.MediaTypeNames;
using Image = SixLabors.ImageSharp.Image;

namespace PetShop_WebApp4.Controllers
{
    public class AdminController : Controller
    {
        private readonly IService _service;

        public AdminController(IService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetAnimals());
        }

        public IActionResult CreateAnimal()
        {
            List<Category> categories = _service.GetCategories();

            ViewBag.Cats = categories;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Animal model)
        {
            if (model.ImageFile != null && model.ImageFile.Length > 0)
            {
                using (var image = Image.Load(model.ImageFile.OpenReadStream()))
                {
                    string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                    string fileName = $"{model.Name}_{timeStamp}.jpg";

                    using (var imageStream = model.ImageFile.OpenReadStream())
                    {
                        var imageBytes = new byte[imageStream.Length];
                        imageStream.Read(imageBytes, 0, imageBytes.Length);

                        var imageFile = new FormFile(new MemoryStream(imageBytes), 0, imageBytes.Length, model.ImageFile.Name, fileName);

                        string imagePath = _service.SaveImageFileToDisk(imageFile);

                        model.ImagePath = imagePath;
                    }
                }
            }

            _service.AddAnimal(model);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var animal = _service.ShowAnimalById(id);
            if (animal == null)
            {
                return NotFound();
            }
            return View(animal);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.DeleteAnimal(id);
            return RedirectToAction("Index");
        }

        public IActionResult EditAnimal(int id)
        {
            List<Category> categories = _service.GetCategories();

            ViewBag.Cats = categories;
            var animal = _service.ShowAnimalById(id);
            if (animal == null)
            {
                return NotFound();
            }
            return View(animal);
        }

        [HttpPost]
        public IActionResult Update(Animal updatedAnimal)
        {
            var animal = new Animal
            {
                AnimalId = updatedAnimal.AnimalId,
                Name = updatedAnimal.Name,
                Age = updatedAnimal.Age,
                Description = updatedAnimal.Description,
                CategoryID = updatedAnimal.CategoryID,
                ImageFile = updatedAnimal.ImageFile
            };

            if (animal.ImageFile != null && animal.ImageFile.Length > 0)
            {
                string imagePath = _service.SaveImageFileToDisk(animal.ImageFile);
                animal.ImagePath = imagePath;
            }

            _service.UpdateAnimal(updatedAnimal.AnimalId, animal, updatedAnimal.CategoryID);

            return RedirectToAction("Index");
        }








    }

}