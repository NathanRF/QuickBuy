using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repository.Migrations
{
    public partial class PaymentOptionsLoad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PaymentOptions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Payment Slip Payment Option", "Payment Slip" });

            migrationBuilder.InsertData(
                table: "PaymentOptions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Credit Card Payment Option", "Credit Card" });

            migrationBuilder.InsertData(
                table: "PaymentOptions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Bank Deposit Payment Option", "Deposit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
