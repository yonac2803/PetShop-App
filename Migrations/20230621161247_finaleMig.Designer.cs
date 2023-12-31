﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShop_WebApp4.Data;

#nullable disable

namespace PetShop_WebApp4.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20230621161247_finaleMig")]
    partial class finaleMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetShop_WebApp4.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimalId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnimalId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 6,
                            CategoryID = 1,
                            Description = "Parrots, also known as psittacines, are birds of the roughly 398 species in 92 genera comprising the order Psittaciformes, found mostly in tropical and subtropical regions.",
                            ImagePath = "/Images/Parrot.jpg",
                            Name = "Parrot"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 8,
                            CategoryID = 1,
                            Description = "The tiger is the largest species among the Felidae and classified in the genus Panthera.",
                            ImagePath = "/Images/Tiger.jpg",
                            Name = "Tiger"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 10,
                            CategoryID = 3,
                            Description = "Dolphins are marine mammals known for their intelligence and playful behavior.",
                            ImagePath = "/Images/Dolphin.jpg",
                            Name = "Dolphin"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 15,
                            CategoryID = 1,
                            Description = "Elephants are the largest land animals and have a characteristic long trunk.",
                            ImagePath = "/Images/Elephant.jpg",
                            Name = "Elephant"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 12,
                            CategoryID = 3,
                            Description = "Crocodiles are large reptiles that live in freshwater habitats.",
                            ImagePath = "/Images/Crocodile.jpg",
                            Name = "Crocodile"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 9,
                            CategoryID = 1,
                            Description = "Giraffes are known for their long necks and towering height.",
                            ImagePath = "/Images/Giraffe.jpg",
                            Name = "Giraffe"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 4,
                            CategoryID = 3,
                            Description = "Penguins are flightless birds that live in the Southern Hemisphere.",
                            ImagePath = "/Images/Penguin.jpg",
                            Name = "Penguin"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 7,
                            CategoryID = 2,
                            Description = "Snakes are elongated, legless reptiles.",
                            ImagePath = "/Images/Snake.jpg",
                            Name = "Snake"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 6,
                            CategoryID = 1,
                            Description = "Kangaroos are marsupials known for their powerful hind legs and pouch.",
                            ImagePath = "/Images/Kangaroo.jpg",
                            Name = "Kangaroo"
                        },
                        new
                        {
                            AnimalId = 10,
                            Age = 20,
                            CategoryID = 3,
                            Description = "Sharks are a group of elasmobranch fish known for their predatory behavior.",
                            ImagePath = "/Images/Shark.jpg",
                            Name = "Shark"
                        });
                });

            modelBuilder.Entity("PetShop_WebApp4.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Mamal"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Reptile"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Aquatic"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Cats"
                        });
                });

            modelBuilder.Entity("PetShop_WebApp4.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.HasIndex("AnimalId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            AnimalId = 1,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9746),
                            Text = "Beautiful colors"
                        },
                        new
                        {
                            CommentId = 2,
                            AnimalId = 1,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9794),
                            Text = "Lovely bird"
                        },
                        new
                        {
                            CommentId = 3,
                            AnimalId = 2,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9796),
                            Text = "Majestic tiger"
                        },
                        new
                        {
                            CommentId = 4,
                            AnimalId = 2,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9798),
                            Text = "Powerful creature"
                        },
                        new
                        {
                            CommentId = 5,
                            AnimalId = 3,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9799),
                            Text = "Adorable dolphins"
                        },
                        new
                        {
                            CommentId = 6,
                            AnimalId = 3,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9801),
                            Text = "So playful"
                        },
                        new
                        {
                            CommentId = 7,
                            AnimalId = 4,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9803),
                            Text = "Gentle giants"
                        },
                        new
                        {
                            CommentId = 8,
                            AnimalId = 4,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9804),
                            Text = "Impressive elephants"
                        },
                        new
                        {
                            CommentId = 9,
                            AnimalId = 5,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9806),
                            Text = "Fearsome crocodile"
                        },
                        new
                        {
                            CommentId = 10,
                            AnimalId = 5,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9808),
                            Text = "Stay away!"
                        },
                        new
                        {
                            CommentId = 11,
                            AnimalId = 6,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9833),
                            Text = "Elegant giraffes"
                        },
                        new
                        {
                            CommentId = 12,
                            AnimalId = 6,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9835),
                            Text = "Long necks!"
                        },
                        new
                        {
                            CommentId = 13,
                            AnimalId = 7,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9836),
                            Text = "Cute penguins"
                        },
                        new
                        {
                            CommentId = 14,
                            AnimalId = 7,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9838),
                            Text = "Happy feet"
                        },
                        new
                        {
                            CommentId = 15,
                            AnimalId = 8,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9839),
                            Text = "Slithery snakes"
                        },
                        new
                        {
                            CommentId = 16,
                            AnimalId = 8,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9841),
                            Text = "Watch out for them"
                        },
                        new
                        {
                            CommentId = 17,
                            AnimalId = 9,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9843),
                            Text = "Hopping kangaroos"
                        },
                        new
                        {
                            CommentId = 18,
                            AnimalId = 9,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9844),
                            Text = "Australian wonders"
                        },
                        new
                        {
                            CommentId = 19,
                            AnimalId = 10,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9846),
                            Text = "Dangerous sharks"
                        },
                        new
                        {
                            CommentId = 20,
                            AnimalId = 10,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9848),
                            Text = "Apex predators"
                        },
                        new
                        {
                            CommentId = 21,
                            AnimalId = 1,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9849),
                            Text = "Talkative parrots"
                        },
                        new
                        {
                            CommentId = 22,
                            AnimalId = 2,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9851),
                            Text = "Roaring tigers"
                        },
                        new
                        {
                            CommentId = 23,
                            AnimalId = 3,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9852),
                            Text = "Graceful dolphins"
                        },
                        new
                        {
                            CommentId = 24,
                            AnimalId = 4,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9854),
                            Text = "Giant elephants"
                        },
                        new
                        {
                            CommentId = 25,
                            AnimalId = 5,
                            CommentDate = new DateTime(2023, 6, 21, 19, 12, 47, 111, DateTimeKind.Local).AddTicks(9855),
                            Text = "Scary crocodiles"
                        });
                });

            modelBuilder.Entity("PetShop_WebApp4.Models.Animal", b =>
                {
                    b.HasOne("PetShop_WebApp4.Models.Category", "Category")
                        .WithMany("Animals")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PetShop_WebApp4.Models.Comment", b =>
                {
                    b.HasOne("PetShop_WebApp4.Models.Animal", "Animal")
                        .WithMany("Comments")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("PetShop_WebApp4.Models.Animal", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("PetShop_WebApp4.Models.Category", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
