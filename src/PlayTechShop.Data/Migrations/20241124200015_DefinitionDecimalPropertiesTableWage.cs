using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayTechShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class DefinitionDecimalPropertiesTableWage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "NetSalary",
                table: "Wage",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "GrossSalary",
                table: "Wage",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Wage",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "NetSalary",
                table: "Wage",
                type: "float",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "GrossSalary",
                table: "Wage",
                type: "float",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Discount",
                table: "Wage",
                type: "float",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
