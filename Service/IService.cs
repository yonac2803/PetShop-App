using PetShop_WebApp4.Data;
using PetShop_WebApp4.Models;

namespace PetShop_WebApp4.Service
{
    public interface IService
    {
        public List<Animal> GetAnimals();
        public List<Category> GetCategories();
        public void AddAnimal(Animal model);
        void UpdateAnimal(int id, Animal animal, int categoryID);
        void DeleteAnimal(int id);
        List<Animal> GetTopAnimals();
        public Animal AddComment(int animalId, string comment);
        List<Animal> GetByCategory(int categoryId);
        public Animal ShowAnimalById(int animalId);
        public string SaveImageFileToDisk(IFormFile imageFile);
        public int GetLastAnimalId();
    }
}
