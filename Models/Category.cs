using System.ComponentModel.DataAnnotations;

namespace PetShop_WebApp4.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }
        public IEnumerable<Animal>? Animals { get; set; }
    }
}