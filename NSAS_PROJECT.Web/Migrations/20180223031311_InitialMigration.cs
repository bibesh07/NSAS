using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace NSAS_PROJECT.Web.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dateregistered = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 64, nullable: true),
                    Fullname = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Phonenumber = table.Column<int>(nullable: false),
                    Address_AddressLine2 = table.Column<string>(maxLength: 64, nullable: true),
                    Address_Addressline1 = table.Column<string>(maxLength: 64, nullable: true),
                    Address_City = table.Column<string>(maxLength: 64, nullable: true),
                    Address_State = table.Column<string>(maxLength: 2, nullable: true),
                    Address_ZipCode = table.Column<int>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
