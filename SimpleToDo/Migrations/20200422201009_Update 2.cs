using Microsoft.EntityFrameworkCore.Migrations;



namespace SimpleToDo.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a2509c7-95ee-4836-9eca-a66922c2dc48", "AQAAAAEAACcQAAAAEM7agNJzm8ZU5bmGGiJFxf0UkHKAUIs/xAycMOFJgpl65vwb4sBql8bN6TtbskccwA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3477ef5e-bf0e-49bf-87e4-ca56b97d93b3", "AQAAAAEAACcQAAAAEOIcS9r/ch4fBqrXMsbnbl9eg1yGveIcZoGmAgtiv0Uhyp+I7ePR8gimXdBkrJg2Kg==" });
        }
    }
}
