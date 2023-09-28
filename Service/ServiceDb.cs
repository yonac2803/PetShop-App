using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using PetShop_WebApp4.Data;
using PetShop_WebApp4.Models;

namespace PetShop_WebApp4.Service
{
    public class ServiceDb : IService
    {
        private readonly MyContext _context;

        public ServiceDb(MyContext context)
        {
            _context = context;
        }
        public List<Animal> GetAnimals()
        {
            return _context.Animals
                .Include(animal => animal.Comments)
                .Include(animal => animal.Category)
                .ToList();
        }
        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
        public void AddAnimal(Animal model)
        {
            _context.Animals!.Add(model);
            _context.SaveChanges();
        }
        public void UpdateAnimal(int id, Animal animal, int categoryID)
        {
            var animalInDb = _context.Animals.SingleOrDefault(m => m.AnimalId == id);

            if (animalInDb != null)
            {
                if (categoryID != animalInDb.CategoryID)
                    animalInDb.CategoryID = categoryID;

                animalInDb.Name = animal.Name;
                animalInDb.Age = animal.Age;
                animalInDb.Description = animal.Description;

                if (!string.IsNullOrEmpty(animal.ImagePath))
                    animalInDb.ImagePath = animal.ImagePath;

                _context.SaveChanges();
            }
        }

        public void DeleteAnimal(int id)
        {
            var animal = _context.Animals.SingleOrDefault(animal => animal.AnimalId == id);
            if (animal != null)
            {
                _context.Animals.Remove(animal);
                _context.SaveChanges();
            }
        }
        public List<Animal> GetTopAnimals()
        {
            var topAnimalIds = _context.Animals
                .OrderByDescending(a => a.Comments.Count)
                .Select(a => a.AnimalId)
                .Take(2)
                .ToList();

            var topAnimals = _context.Animals
                .Include(a => a.Comments)
                .Where(a => topAnimalIds.Contains(a.AnimalId))
                .ToList();

            return topAnimals;
        }
        public Animal AddComment(int animalId, string text)
        {
            var animal = _context.Animals
                .Include(a => a.Category)
                .Include(a => a.Comments)
                .FirstOrDefault(a => a.AnimalId == animalId);
            if (animal != null)
            {
                
                var newComment = new Comment
                {
                    Animal = animal,
                    AnimalId = animalId,
                    Text = text,
                    CommentDate = DateTime.Now
                };

                _context.Comments.Add(newComment);
                _context.SaveChanges();
            }

            return animal;
        }
        public List<Animal> GetByCategory(int categoryId)
        {
            return _context.Animals
                 .Include(animal => animal.Comments)
                .Include(animal => animal.Category)
                .Where(animal => animal.CategoryID == categoryId)
                .ToList();
        }
        public Animal ShowAnimalById(int animalId)
        {
            return _context.Animals
                .Include(animal => animal.Comments)
                .Include(animal => animal.Category)
                .FirstOrDefault(animal => animal.AnimalId == animalId);
        }

        public string SaveImageFileToDisk(IFormFile imageFile)
        {
            string uniqueFileName = null;

            if (imageFile != null && imageFile.Length > 0)
            {
                string uploadsDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images");

                if (!Directory.Exists(uploadsDir))
                {
                    Directory.CreateDirectory(uploadsDir);
                }

                uniqueFileName = Path.GetFileName(imageFile.FileName);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(uniqueFileName);
                string extension = Path.GetExtension(uniqueFileName);

                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                uniqueFileName = $"{fileNameWithoutExtension}_{timestamp}{extension}";

                string filePath = Path.Combine(uploadsDir, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.CopyTo(fileStream);
                }
            }

            return $"/Images/{uniqueFileName}";
        }


        public int GetLastAnimalId()
        {
            var lastAnimal = _context.Animals.OrderByDescending(a => a.AnimalId).FirstOrDefault();
            return lastAnimal?.AnimalId ?? 0;
        }
    }
}
