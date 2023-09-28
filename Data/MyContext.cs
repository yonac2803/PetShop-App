using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Xml.Linq;
using PetShop_WebApp4.Models;

namespace PetShop_WebApp4.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasData(
                    new Animal
                    {
                        AnimalId = 1,
                        Name = "Parrot",
                        Age = 6,
                        ImagePath = "/Images/Parrot.jpg",
                        Description = "Parrots, also known as psittacines, are birds of the roughly 398 species in 92 genera comprising the order Psittaciformes, found mostly in tropical and subtropical regions.",
                        CategoryID = 1
                    },
                    new Animal
                    {
                        AnimalId = 2,
                        Name = "Tiger",
                        Age = 8,
                        ImagePath = "/Images/Tiger.jpg",
                        Description = "The tiger is the largest species among the Felidae and classified in the genus Panthera.",
                        CategoryID = 1
                    },
                    new Animal
                    {
                        AnimalId = 3,
                        Name = "Dolphin",
                        Age = 10,
                        ImagePath = "/Images/Dolphin.jpg",
                        Description = "Dolphins are marine mammals known for their intelligence and playful behavior.",
                        CategoryID = 3
                    },
                    new Animal
                    {
                        AnimalId = 4,
                        Name = "Elephant",
                        Age = 15,
                        ImagePath = "/Images/Elephant.jpg",
                        Description = "Elephants are the largest land animals and have a characteristic long trunk.",
                        CategoryID = 1
                    },
                    new Animal
                    {
                        AnimalId = 5,
                        Name = "Crocodile",
                        Age = 12,
                        ImagePath = "/Images/Crocodile.jpg",
                        Description = "Crocodiles are large reptiles that live in freshwater habitats.",
                        CategoryID = 3
                    },
                    new Animal
                    {
                        AnimalId = 6,
                        Name = "Giraffe",
                        Age = 9,
                        ImagePath = "/Images/Giraffe.jpg",
                        Description = "Giraffes are known for their long necks and towering height.",
                        CategoryID = 1
                    },
                    new Animal
                    {
                        AnimalId = 7,
                        Name = "Penguin",
                        Age = 4,
                        ImagePath = "/Images/Penguin.jpg",
                        Description = "Penguins are flightless birds that live in the Southern Hemisphere.",
                        CategoryID = 3
                    },
                    new Animal
                    {
                        AnimalId = 8,
                        Name = "Snake",
                        Age = 7,
                        ImagePath = "/Images/Snake.jpg",
                        Description = "Snakes are elongated, legless reptiles.",
                        CategoryID = 2
                    },
                    new Animal
                    {
                        AnimalId = 9,
                        Name = "Kangaroo",
                        Age = 6,
                        ImagePath = "/Images/Kangaroo.jpg",
                        Description = "Kangaroos are marsupials known for their powerful hind legs and pouch.",
                        CategoryID = 1
                    },
                    new Animal
                    {
                        AnimalId = 10,
                        Name = "Shark",
                        Age = 20,
                        ImagePath = "/Images/Shark.jpg",
                        Description = "Sharks are a group of elasmobranch fish known for their predatory behavior.",
                        CategoryID = 3
                    }
            );

            modelBuilder.Entity<Category>().HasData(
                      new Category { CategoryId = 1, CategoryName = "Mamal" },
                      new Category { CategoryId = 2, CategoryName = "Reptile" },
                      new Category { CategoryId = 3, CategoryName = "Aquatic" },
                      new Category { CategoryId = 4, CategoryName = "Cats"}
          );

            modelBuilder.Entity<Comment>().HasData(
                        new Comment { CommentDate = DateTime.Now, CommentId = 1, AnimalId = 1, Text = "Beautiful colors" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 2, AnimalId = 1, Text = "Lovely bird" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 3, AnimalId = 2, Text = "Majestic tiger" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 4, AnimalId = 2, Text = "Powerful creature" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 5, AnimalId = 3, Text = "Adorable dolphins" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 6, AnimalId = 3, Text = "So playful" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 7, AnimalId = 4, Text = "Gentle giants" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 8, AnimalId = 4, Text = "Impressive elephants" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 9, AnimalId = 5, Text = "Fearsome crocodile" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 10, AnimalId = 5, Text = "Stay away!" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 11, AnimalId = 6, Text = "Elegant giraffes" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 12, AnimalId = 6, Text = "Long necks!" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 13, AnimalId = 7, Text = "Cute penguins" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 14, AnimalId = 7, Text = "Happy feet" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 15, AnimalId = 8, Text = "Slithery snakes" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 16, AnimalId = 8, Text = "Watch out for them" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 17, AnimalId = 9, Text = "Hopping kangaroos" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 18, AnimalId = 9, Text = "Australian wonders" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 19, AnimalId = 10, Text = "Dangerous sharks" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 20, AnimalId = 10, Text = "Apex predators" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 21, AnimalId = 1, Text = "Talkative parrots" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 22, AnimalId = 2, Text = "Roaring tigers" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 23, AnimalId = 3, Text = "Graceful dolphins" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 24, AnimalId = 4, Text = "Giant elephants" },
                        new Comment { CommentDate = DateTime.Now, CommentId = 25, AnimalId = 5, Text = "Scary crocodiles" }
                );
        }
    }
}
