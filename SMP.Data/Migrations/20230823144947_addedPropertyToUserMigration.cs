using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMP.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedPropertyToUserMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Users",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Posts",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Messages",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Likes",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Follows",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Comments",
                newName: "UpdatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Users",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Posts",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Messages",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Likes",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Follows",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Comments",
                newName: "UpdateddAt");
        }
    }
}
