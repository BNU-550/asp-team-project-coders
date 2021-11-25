using Microsoft.EntityFrameworkCore.Migrations;

namespace Phone_Selling_Project.Data.Migrations
{
    public partial class AddPaytoPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Persons_PersonID",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_PersonID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Payments");

            migrationBuilder.AddColumn<int>(
                name: "PaymentID",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PaymentID",
                table: "Persons",
                column: "PaymentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Payments_PaymentID",
                table: "Persons",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Payments_PaymentID",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PaymentID",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PaymentID",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PersonID",
                table: "Payments",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Persons_PersonID",
                table: "Payments",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
