using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop_WebApp4.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an age"), Range(0, 75)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter a Image Path")]
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        [NotMapped]
        [DisplayName("Image File")]
        public IFormFile ImageFile { get; set; }

    }
}