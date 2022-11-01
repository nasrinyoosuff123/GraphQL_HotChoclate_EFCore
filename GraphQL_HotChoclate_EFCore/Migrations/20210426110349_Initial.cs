using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQL_HotChoclate_EFCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
            
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Designation", "Name" },
                values: new object[,]
                {
                    { 1, "Full Stack Developer", "Nasrin Yoosuff" },
                    { 2, "SSE", "DQ" },
                    { 3, "Software Engineer", "Eliza" },
                    { 4, "Database Developer", "Sheriff" },
                    { 5, "Cloud Engineer", "Reddy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
