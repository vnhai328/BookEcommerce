using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class fixfielduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "Name");
        }
    }
}
