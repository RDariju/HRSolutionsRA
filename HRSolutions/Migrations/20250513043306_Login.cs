using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSolutions.Migrations
{
    /// <inheritdoc />
    public partial class Login : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfileImagePath",
                table: "Employee",
                newName: "JobRole");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employee",
                newName: "empId");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfileImage",
                table: "Employee",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Announcement",
                columns: table => new
                {
                    announcementId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    announcementTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcement", x => x.announcementId);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "Notice",
                columns: table => new
                {
                    NoticeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Auther = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notice", x => x.NoticeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcement");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Notice");

            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "JobRole",
                table: "Employee",
                newName: "ProfileImagePath");

            migrationBuilder.RenameColumn(
                name: "empId",
                table: "Employee",
                newName: "Id");
        }
    }
}
