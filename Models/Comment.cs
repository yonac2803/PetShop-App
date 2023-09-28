using System.ComponentModel.DataAnnotations;

namespace PetShop_WebApp4.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        [Required]
        public string Text { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public DateTime CommentDate { get; set; }

    }
}