using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Storage.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pallets_Id",
                table: "Pallets");

            migrationBuilder.DropIndex(
                name: "IX_Boxes_Id",
                table: "Boxes");

            migrationBuilder.InsertData(
                table: "Pallets",
                column: "Id",
                value: new Guid("5f8d3137-f994-426b-9868-3e3051ee10b4"));

            migrationBuilder.InsertData(
                table: "Pallets",
                column: "Id",
                value: new Guid("7cd4bde8-f707-45ec-bb68-d79bc592db26"));

            migrationBuilder.InsertData(
                table: "Pallets",
                column: "Id",
                value: new Guid("c341ac75-e415-4087-945f-f6c4f44d790f"));

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "PalletId" },
                values: new object[] { new Guid("6ff2088d-9e5c-4043-9965-c1db84a19551"), new Guid("c341ac75-e415-4087-945f-f6c4f44d790f") });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "PalletId" },
                values: new object[] { new Guid("b1316bf2-e907-4192-bbd5-af2cab3e9bb3"), new Guid("5f8d3137-f994-426b-9868-3e3051ee10b4") });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "PalletId" },
                values: new object[] { new Guid("b5d201cf-a110-4cee-b318-4dcb7894d143"), new Guid("c341ac75-e415-4087-945f-f6c4f44d790f") });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "PalletId" },
                values: new object[] { new Guid("d595ce95-08ca-4a97-9e38-34a4717e99df"), new Guid("7cd4bde8-f707-45ec-bb68-d79bc592db26") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("6ff2088d-9e5c-4043-9965-c1db84a19551"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("b1316bf2-e907-4192-bbd5-af2cab3e9bb3"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("b5d201cf-a110-4cee-b318-4dcb7894d143"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("d595ce95-08ca-4a97-9e38-34a4717e99df"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("5f8d3137-f994-426b-9868-3e3051ee10b4"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("7cd4bde8-f707-45ec-bb68-d79bc592db26"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("c341ac75-e415-4087-945f-f6c4f44d790f"));

            migrationBuilder.CreateIndex(
                name: "IX_Pallets_Id",
                table: "Pallets",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Boxes_Id",
                table: "Boxes",
                column: "Id",
                unique: true);
        }
    }
}
