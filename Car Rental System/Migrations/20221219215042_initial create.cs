using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Rental_System.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataModels",
                columns: table => new
                {
                    StdId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false),
                    LastName = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false),
                    FName = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false),
                    Age = table.Column<string>(type: "varchar(150)", nullable: false),
                    E_Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ctcno = table.Column<string>(type: "varchar(250)", nullable: false),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataModels", x => x.StdId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataModels");
        }
    }
}
