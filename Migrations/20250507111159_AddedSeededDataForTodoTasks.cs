using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskX.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeededDataForTodoTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoTasks",
                columns: new[] { "Id", "Bookmarked", "CreatedAt", "Description", "Title" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description 1", "Task 1" },
                    { 2, true, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description 2", "Task 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
