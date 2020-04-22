using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleToDo.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItem_AspNetUsers_ApplicationUserId1",
                table: "TodoItem");

            migrationBuilder.DropIndex(
                name: "IX_TodoItem_ApplicationUserId1",
                table: "TodoItem");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "TodoItem");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "TodoItem",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3477ef5e-bf0e-49bf-87e4-ca56b97d93b3", "AQAAAAEAACcQAAAAEOIcS9r/ch4fBqrXMsbnbl9eg1yGveIcZoGmAgtiv0Uhyp+I7ePR8gimXdBkrJg2Kg==" });

            migrationBuilder.CreateIndex(
                name: "IX_TodoItem_ApplicationUserId",
                table: "TodoItem",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItem_AspNetUsers_ApplicationUserId",
                table: "TodoItem",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItem_AspNetUsers_ApplicationUserId",
                table: "TodoItem");

            migrationBuilder.DropIndex(
                name: "IX_TodoItem_ApplicationUserId",
                table: "TodoItem");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "TodoItem",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "TodoItem",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82b3937f-120c-4386-898d-70c581d1a92b", "AQAAAAEAACcQAAAAENJaz5gXLRJTSkaIcUGfHwTYdB42LDasjJUU7Q4ZbdE9DICUDi9KfZUlWbn/fCe5pQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_TodoItem_ApplicationUserId1",
                table: "TodoItem",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItem_AspNetUsers_ApplicationUserId1",
                table: "TodoItem",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
