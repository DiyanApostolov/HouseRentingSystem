using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class ChangeHouseImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "990e281e-5dc5-41d3-992e-6cddadb71f00", "AQAAAAEAACcQAAAAEJX0LCuk8czGNlKBrnOIfR+xcDbIFkxQl9rJXbmLx6ktRRdEApMJPGQ/GhbZ111bQA==", "a94c58f9-e3e5-4777-8ba7-5ce8acd28483" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf20817f-6164-4121-be5a-ba4e04c5d962", "AQAAAAEAACcQAAAAEN3ubbVqEVzDn+ZH7LMRkV9nNjIc9rozkiihA+m31keAqj+7VbBZONvt8vnxIwCUzg==", "516a2b48-51eb-4014-a31d-1845114a1ef0" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd54996a-52e5-4274-bf69-b974d1293895", "AQAAAAEAACcQAAAAEEbvjDheFyB9erTBD/0y/op5ihPAZnmHHIEGbnlXEl2dt+38Ay2vnQ8QRW1S7SGcxA==", "18f81773-1326-4392-a49a-2e3eaeb78498" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32e7c03c-d6c9-49d5-b8d6-22e407fcd13f", "AQAAAAEAACcQAAAAEJiQxtcfBYxUB3oc4iCXrpV9t6uxy0DTR7XcNtMC6G59WAa++BvoF1C+m7RN3MvRLA==", "5aa3cb7a-9946-43f6-b8aa-b619a321e835" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://static.dezeen.com/uploads/2017/08/ocotea-street-in-situ-studio-architecture_dezeen_hero-1.jpgs");
        }
    }
}
