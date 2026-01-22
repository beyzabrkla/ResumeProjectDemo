using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeProjectDemo.Migrations
{
    /// <inheritdoc />
    public partial class update_statusForTestimonial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Testimonials",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Testimonials");
        }
    }
}
