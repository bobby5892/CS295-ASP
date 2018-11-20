using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace community.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ToID = table.Column<int>(nullable: true),
                    FromID = table.Column<int>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    Msge = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    IsPriority = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Messages_Users_FromID",
                        column: x => x.FromID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Users_ToID",
                        column: x => x.ToID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromID",
                table: "Messages",
                column: "FromID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToID",
                table: "Messages",
                column: "ToID");
            // Add Seed Data
            //User
            migrationBuilder.InsertData(
            table: "Users",
            columns: new[] { "ID", "Name", "EmailAddress" },
            values: new object[] { 1, "Bob", "bob@example.com" });

            migrationBuilder.InsertData(
            table: "Users",
            columns: new[] { "ID", "Name", "EmailAddress" },
            values: new object[] { 2, "ted", "ted@example.com" });
            //Location
            migrationBuilder.InsertData(
            table: "Locations",
            columns: new[] { "ID", "Name", "Link" },
            values: new object[] { 1, "Google", "google.com" });

            migrationBuilder.InsertData(
            table: "Locations",
            columns: new[] { "ID", "Name", "Link" },
            values: new object[] { 2, "Example", "example.com" });
            // Messages
           
            migrationBuilder.InsertData(
            table: "Messages",
            columns: new[] { "ID", "ToID", "FromID", "TimeStamp", "Msge", "Subject", "isPriority" },
            values: new object[] { 1, 1, 2, DateTime.Now, "Hey Bob this is ted", "welcome", false });

            migrationBuilder.InsertData(
            table: "Messages",
            columns: new[] { "ID", "ToID", "FromID", "TimeStamp", "Msge", "Subject", "isPriority" },
            values: new object[] { 2, 2, 1, DateTime.Now, "Hey Ted this is bob", "welcome", false });
            // Person and Links
            migrationBuilder.InsertData(
            table: "Persons",
            columns: new[] { "ID", "Name", "Link" },
            values: new object[] { 1, "Robert Moore", "eugeneprogramming.com" });

            migrationBuilder.InsertData(
            table: "Persons",
            columns: new[] { "ID", "Name", "Link" },
            values: new object[] { 2, "Brian Bird", "birdsbits.blog" });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
