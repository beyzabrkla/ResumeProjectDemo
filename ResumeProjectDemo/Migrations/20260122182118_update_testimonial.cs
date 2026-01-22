using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeProjectDemo.Migrations
{
    /// <inheritdoc />
    public partial class update_testimonial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirm",
                table: "Testimonials");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirm",
                table: "Testimonials",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
