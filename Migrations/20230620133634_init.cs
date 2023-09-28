using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetShop_WebApp4.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                    table.ForeignKey(
                        name: "FK_Animals_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalId = table.Column<int>(type: "int", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Mamal" },
                    { 2, "Reptile" },
                    { 3, "Aquatic" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "CategoryID", "Description", "ImagePath", "Name" },
                values: new object[,]
                {
                    { 1, 6, 1, "Parrots, also known as psittacines, are birds of the roughly 398 species in 92 genera comprising the order Psittaciformes, found mostly in tropical and subtropical regions.", "/Images/Parrot.jpg", "Parrot" },
                    { 2, 8, 1, "The tiger is the largest species among the Felidae and classified in the genus Panthera.", "/Images/Tiger.jpg", "Tiger" },
                    { 3, 10, 3, "Dolphins are marine mammals known for their intelligence and playful behavior.", "/Images/Dolphin.jpg", "Dolphin" },
                    { 4, 15, 1, "Elephants are the largest land animals and have a characteristic long trunk.", "/Images/Elephant.jpg", "Elephant" },
                    { 5, 12, 3, "Crocodiles are large reptiles that live in freshwater habitats.", "/Images/Crocodile.jpg", "Crocodile" },
                    { 6, 9, 1, "Giraffes are known for their long necks and towering height.", "/Images/Giraffe.jpg", "Giraffe" },
                    { 7, 4, 3, "Penguins are flightless birds that live in the Southern Hemisphere.", "/Images/Penguin.jpg", "Penguin" },
                    { 8, 7, 2, "Snakes are elongated, legless reptiles.", "/Images/Snake.jpg", "Snake" },
                    { 9, 6, 1, "Kangaroos are marsupials known for their powerful hind legs and pouch.", "/Images/Kangaroo.jpg", "Kangaroo" },
                    { 10, 20, 3, "Sharks are a group of elasmobranch fish known for their predatory behavior.", "/Images/Shark.jpg", "Shark" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "AnimalId", "CommentDate", "Text" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7526), "Beautiful colors" },
                    { 2, 1, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7566), "Lovely bird" },
                    { 3, 2, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7568), "Majestic tiger" },
                    { 4, 2, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7570), "Powerful creature" },
                    { 5, 3, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7571), "Adorable dolphins" },
                    { 6, 3, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7573), "So playful" },
                    { 7, 4, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7575), "Gentle giants" },
                    { 8, 4, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7577), "Impressive elephants" },
                    { 9, 5, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7578), "Fearsome crocodile" },
                    { 10, 5, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7580), "Stay away!" },
                    { 11, 6, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7581), "Elegant giraffes" },
                    { 12, 6, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7583), "Long necks!" },
                    { 13, 7, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7585), "Cute penguins" },
                    { 14, 7, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7586), "Happy feet" },
                    { 15, 8, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7588), "Slithery snakes" },
                    { 16, 8, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7590), "Watch out for them" },
                    { 17, 9, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7591), "Hopping kangaroos" },
                    { 18, 9, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7593), "Australian wonders" },
                    { 19, 10, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7595), "Dangerous sharks" },
                    { 20, 10, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7596), "Apex predators" },
                    { 21, 1, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7598), "Talkative parrots" },
                    { 22, 2, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7599), "Roaring tigers" },
                    { 23, 3, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7601), "Graceful dolphins" },
                    { 24, 4, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7603), "Giant elephants" },
                    { 25, 5, new DateTime(2023, 6, 20, 16, 36, 34, 876, DateTimeKind.Local).AddTicks(7604), "Scary crocodiles" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CategoryID",
                table: "Animals",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AnimalId",
                table: "Comments",
                column: "AnimalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
