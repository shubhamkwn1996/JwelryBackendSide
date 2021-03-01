using Microsoft.EntityFrameworkCore.Migrations;

namespace JwelryBackendSide.Migrations
{
    public partial class jewelry_03_03_2021_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "UserLogin",
                columns: new[] { "UserId", "Password", "UserName", "UserType" },
                values: new object[] { 1L, "Shubham", "shubham", "normal" });

            migrationBuilder.InsertData(
                table: "UserLogin",
                columns: new[] { "UserId", "Password", "UserName", "UserType" },
                values: new object[] { 2L, "Sridhar", "sridhar", "privileged" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogin");
        }
    }
}
