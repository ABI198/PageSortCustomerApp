using Microsoft.EntityFrameworkCore.Migrations;

namespace PageFilterSortApp.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalOrderCount = table.Column<int>(type: "int", nullable: false),
                    MarriageStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "Firstname", "Gender", "Lastname", "MarriageStatus", "TotalOrderCount" },
                values: new object[,]
                {
                    { 1, 26, "Semih", "Male", "Ilgaz", "Single", 28 },
                    { 2, 19, "Kerem", "Male", "Erdogdu", "Single", 58 },
                    { 3, 43, "Ali", "Male", "Cakir", "Married", 12 },
                    { 4, 23, "Ebru", "Female", "Deniz", "Single", 8 },
                    { 5, 34, "Sinem", "Female", "Yılmaz", "Married", 41 },
                    { 6, 28, "Ceyhan", "Female", "Korkmaz", "Single", 6 },
                    { 7, 47, "Berkcan", "Male", "Hasanoglu", "Single", 126 },
                    { 8, 19, "Onur", "Male", "Aslan", "Single", 17 },
                    { 9, 35, "Suleyman", "Male", "Demir", "Single", 32 },
                    { 10, 28, "Kaan", "Male", "Avci", "Married", 205 },
                    { 11, 58, "Engin", "Male", "Yurtgezer", "Single", 41 },
                    { 12, 25, "Selin", "Female", "Uzuner", "Single", 16 },
                    { 13, 32, "Seyma", "Female", "Sezengil", "Married", 83 },
                    { 14, 33, "Orhan", "Male", "Sabuncu", "Single", 41 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
