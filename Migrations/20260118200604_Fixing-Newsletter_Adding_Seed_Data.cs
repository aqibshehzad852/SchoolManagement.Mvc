using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagement.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class FixingNewsletter_Adding_Seed_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsletterSubscriptions",
                table: "NewsletterSubscriptions");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "NewsletterSubscriptions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK__Newsletter__3214EC07C2266ABB",
                table: "NewsletterSubscriptions",
                column: "Id");

            migrationBuilder.InsertData(
                table: "NewsletterSubscriptions",
                columns: new[] { "Id", "Email" },
                values: new object[,]
                {
                    { 1, "user1@example.com" },
                    { 2, "user2@example.com" },
                    { 3, "user3@example.com" },
                    { 4, "user4@example.com" },
                    { 5, "user5@example.com" },
                    { 6, "user6@example.com" },
                    { 7, "user7@example.com" },
                    { 8, "user8@example.com" },
                    { 9, "user9@example.com" },
                    { 10, "user10@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__Newsletter__3214EC07C2266ABB",
                table: "NewsletterSubscriptions");

            migrationBuilder.DeleteData(
                table: "NewsletterSubscriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NewsletterSubscriptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NewsletterSubscriptions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NewsletterSubscriptions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NewsletterSubscriptions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NewsletterSubscriptions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NewsletterSubscriptions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NewsletterSubscriptions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NewsletterSubscriptions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NewsletterSubscriptions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "NewsletterSubscriptions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsletterSubscriptions",
                table: "NewsletterSubscriptions",
                column: "Id");
        }
    }
}
