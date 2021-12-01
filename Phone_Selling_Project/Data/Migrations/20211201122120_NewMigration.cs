using Microsoft.EntityFrameworkCore.Migrations;

namespace Phone_Selling_Project.Data.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Payments_PaymentID",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "HouseNumber",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "HouseName",
                table: "Addresses",
                newName: "HouseNameNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentID",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Payments_PaymentID",
                table: "Persons",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Payments_PaymentID",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "HouseNameNumber",
                table: "Addresses",
                newName: "HouseName");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentID",
                table: "Persons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "HouseNumber",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Payments_PaymentID",
                table: "Persons",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
