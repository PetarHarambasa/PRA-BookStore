using System;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRA_Knjizara.Migrations
{
    public partial class seedRoles : Migration
    {

        private string UserRoleId = Guid.NewGuid().ToString();
        private string AdminRoleId = Guid.NewGuid().ToString();
        private string User1Id = Guid.NewGuid().ToString();

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            SeedUserRoles(migrationBuilder);
            SeedAdmin(migrationBuilder);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: true),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });
        }

        private void SeedAdmin(MigrationBuilder migrationBuilder)
        {
            //Test admin ne radi, doda ga ali password je hash na neki drugi nacin
            migrationBuilder.Sql(
                @$"INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [ImagePath], [UserName], 
                [Email], [NormalizedUserName], [NormalizedEmail], [Adress], [ZipCode], [Password], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [AccessFailedCount], [EmailConfirmed],
                [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnabled]) 
                VALUES 
                (N'{User1Id}', N'Test', N'Lastname',N'Default' ,N'test@test.ca', N'test@test.ca', N'TEST@TEST.CA', N'TEST@TEST.CA' , N'ulica, grad', N'10000',
                N'842476835',
                N'AQAAAAEAACcQAAAAEHLyb4BYCp7pqfx4j7RxMiMurYDOgRBGJdKposknO8VMptI9zTDJ0rR0RxJmUGQu/Q==', N'VRLCICETY527VCFRMRTPSVANCT5QPTL3',
                N'5fb9cfdf-a312-48ae-9e0b-ab283ba96647', N'098892543',
                0, 0, 1, 0, 0)");

            migrationBuilder.Sql(@$"
                INSERT INTO [dbo].[AspNetUserRoles]
                   ([UserId]
                   ,[RoleId])
                VALUES
                   ('{User1Id}', '{AdminRoleId}');
                INSERT INTO [dbo].[AspNetUserRoles]
                   ([UserId]
                   ,[RoleId])
                VALUES
                   ('{User1Id}', '{UserRoleId}');");
        }

        private void SeedUserRoles(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetRoles] ([Id],[Description],[Name],[NormalizedName],[ConcurrencyStamp])
            VALUES ('{AdminRoleId}', 'administrator, zaposelnik', 'Administrator', 'ADMINISTRATOR', null);");
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetRoles] ([Id],[Description],[Name],[NormalizedName],[ConcurrencyStamp])
            VALUES ('{UserRoleId}', 'korisnik', 'User', 'USER', null);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
