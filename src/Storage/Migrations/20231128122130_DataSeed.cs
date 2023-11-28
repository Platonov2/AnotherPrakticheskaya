using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Storage.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pallets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Length = table.Column<int>(type: "INTEGER", nullable: false),
                    Width = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pallets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boxes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PalletRecordId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Length = table.Column<int>(type: "INTEGER", nullable: false),
                    Width = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    ManufacturingDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    ExpirationDate = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boxes_Pallets_PalletRecordId",
                        column: x => x.PalletRecordId,
                        principalTable: "Pallets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("00e176b4-f9f8-48cb-bcf1-87b4a7ef4760"), 12, 12, 37, 48 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("32e75c0b-b570-45b3-8254-4221dc9ee36f"), 47, 46, 49, 36 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("3588cf03-fec1-4c2c-9f0b-277083a7fc6c"), 47, 36, 46, 34 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("3a628309-11e2-40a1-81c4-fe6e072060a9"), 17, 28, 39, 24 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("4e66b256-7fe4-438c-9b08-ca22fbab178c"), 35, 32, 39, 49 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("4f4c0181-78cf-4376-9557-5a63327a84ee"), 44, 37, 41, 39 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("50e3c085-d129-43c3-86a2-af5334d92d13"), 26, 11, 33, 10 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("6780444e-ae8e-4b7c-ac50-9ba2305ee03e"), 30, 31, 35, 17 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("70960421-4adf-4aa9-9eb4-cb9c2c87bdab"), 43, 41, 44, 30 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("8ab29685-5756-40b9-b076-268b34c2034d"), 25, 23, 36, 13 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("8cd20d80-fc2a-4332-8f13-71a5c69fe94d"), 14, 12, 31, 31 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("932dd1aa-352b-4c8c-a8c8-20dc77b55117"), 45, 18, 39, 45 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("94fc4a7d-a7bb-4560-b377-dc15be47e121"), 48, 41, 41, 29 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("dff59e9d-6bc9-4787-93bc-e82197975ed2"), 46, 12, 42, 40 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("e4f5d3ea-6858-4ee6-89d4-19b3b27f9919"), 13, 40, 32, 10 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("f5a52da6-560f-4c91-b616-327fd7e48e39"), 48, 10, 35, 31 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("f72628da-bb70-4129-a40f-aa2605bb6c44"), 36, 20, 33, 32 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("f72af983-abfd-4cea-beb9-5f66d4955dd8"), 24, 30, 44, 33 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("0131de17-de13-4126-a8ee-2aad46ee68fe"), new DateOnly(2023, 3, 24), 6, 1, new DateOnly(2022, 12, 14), new Guid("dff59e9d-6bc9-4787-93bc-e82197975ed2"), 6, 12 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("084d7117-e0d6-4202-858b-eba5a857aad8"), new DateOnly(2019, 8, 16), 5, 2, new DateOnly(2019, 5, 8), new Guid("e4f5d3ea-6858-4ee6-89d4-19b3b27f9919"), 3, 1 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("114bd55d-3aee-4508-a3ce-34f54f488e3a"), new DateOnly(2023, 6, 28), 7, 1, new DateOnly(2023, 4, 21), new Guid("70960421-4adf-4aa9-9eb4-cb9c2c87bdab"), 2, 3 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("15d3c542-0cd7-4335-950a-3c5606ef23ff"), new DateOnly(2015, 8, 16), 5, 8, new DateOnly(2015, 5, 8), new Guid("8ab29685-5756-40b9-b076-268b34c2034d"), 3, 10 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("16ff25a4-c88a-434b-861e-9dfdadfc1270"), new DateOnly(2023, 12, 12), 8, 4, new DateOnly(2019, 5, 10), new Guid("3a628309-11e2-40a1-81c4-fe6e072060a9"), 1, 3 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("1aeb2d12-db48-46b3-9450-7a27a6bf5041"), new DateOnly(2020, 10, 10), 7, 3, new DateOnly(2019, 9, 1), new Guid("f72628da-bb70-4129-a40f-aa2605bb6c44"), 9, 9 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("1ba7b62f-3b27-48b7-ad1a-f0e1556af2a2"), new DateOnly(2017, 12, 24), 4, 14, new DateOnly(2015, 7, 19), new Guid("4f4c0181-78cf-4376-9557-5a63327a84ee"), 5, 17 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("1e7b1df5-d396-4860-8859-9d97cf5a837c"), new DateOnly(2022, 6, 12), 1, 4, new DateOnly(2022, 3, 4), new Guid("32e75c0b-b570-45b3-8254-4221dc9ee36f"), 7, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("267fccc8-e58c-411a-9eb6-3f00491ebe57"), new DateOnly(2017, 12, 23), 9, 2, new DateOnly(2016, 6, 16), new Guid("4e66b256-7fe4-438c-9b08-ca22fbab178c"), 2, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("30463e33-77a6-4d7e-9e10-ebbfd70efd48"), new DateOnly(2016, 10, 25), 7, 2, new DateOnly(2016, 7, 17), new Guid("4e66b256-7fe4-438c-9b08-ca22fbab178c"), 8, 1 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("31bd3b3f-23eb-40fe-ae39-279cf912e253"), new DateOnly(2015, 10, 1), 6, 15, new DateOnly(2015, 6, 23), new Guid("3588cf03-fec1-4c2c-9f0b-277083a7fc6c"), 8, 15 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("3bfeccf6-1289-4a04-b70d-c0c9792140c9"), new DateOnly(2019, 9, 16), 6, 8, new DateOnly(2019, 6, 8), new Guid("32e75c0b-b570-45b3-8254-4221dc9ee36f"), 5, 6 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("49ff0a12-cdee-490a-90c0-41ab08f6ebc2"), new DateOnly(2019, 10, 25), 4, 5, new DateOnly(2016, 10, 17), new Guid("e4f5d3ea-6858-4ee6-89d4-19b3b27f9919"), 5, 1 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("4b871f5f-6bda-47d1-8b5c-c813df093f55"), new DateOnly(2023, 8, 29), 1, 4, new DateOnly(2023, 5, 21), new Guid("e4f5d3ea-6858-4ee6-89d4-19b3b27f9919"), 9, 1 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("4d4596d7-fc32-45d0-8cd4-d55bf022e18b"), new DateOnly(2021, 10, 20), 3, 8, new DateOnly(2021, 6, 10), new Guid("70960421-4adf-4aa9-9eb4-cb9c2c87bdab"), 5, 6 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("4e2a848a-d160-4807-a62d-9f01af816478"), new DateOnly(2023, 8, 12), 3, 5, new DateOnly(2021, 4, 1), new Guid("94fc4a7d-a7bb-4560-b377-dc15be47e121"), 9, 1 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("57b4e37b-5085-4007-97f9-ec843862025b"), new DateOnly(2022, 10, 19), 7, 9, new DateOnly(2022, 2, 8), new Guid("e4f5d3ea-6858-4ee6-89d4-19b3b27f9919"), 4, 1 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("583c3e19-218c-4334-8d1e-fd4e4ac2e63c"), new DateOnly(2015, 8, 12), 2, 1, new DateOnly(2015, 5, 4), new Guid("6780444e-ae8e-4b7c-ac50-9ba2305ee03e"), 3, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("6387746a-303a-47da-871f-19aefccd686c"), new DateOnly(2023, 6, 28), 8, 2, new DateOnly(2023, 3, 20), new Guid("94fc4a7d-a7bb-4560-b377-dc15be47e121"), 2, 5 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("6705d991-0b55-41c4-89ff-dd665ad49c2d"), new DateOnly(2022, 11, 16), 9, 3, new DateOnly(2021, 10, 10), new Guid("4e66b256-7fe4-438c-9b08-ca22fbab178c"), 4, 11 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("67300179-686a-4e8e-8ade-b134a35c8a52"), new DateOnly(2020, 8, 24), 5, 5, new DateOnly(2020, 5, 16), new Guid("f72af983-abfd-4cea-beb9-5f66d4955dd8"), 8, 1 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("6ce8256a-eecc-498e-bfc9-6bf8487bf925"), new DateOnly(2017, 1, 13), 9, 1, new DateOnly(2016, 10, 5), new Guid("f5a52da6-560f-4c91-b616-327fd7e48e39"), 6, 9 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("76a626cf-5aa1-4963-927d-55cf3e27739a"), new DateOnly(2016, 6, 15), 6, 3, new DateOnly(2016, 3, 7), new Guid("94fc4a7d-a7bb-4560-b377-dc15be47e121"), 4, 1 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("780e0e72-49d7-45c9-80f4-02f3a525b5da"), new DateOnly(2018, 11, 28), 5, 3, new DateOnly(2016, 10, 27), new Guid("3a628309-11e2-40a1-81c4-fe6e072060a9"), 7, 3 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("78bba43a-3152-4573-a1ea-fb7fb730e076"), new DateOnly(2023, 10, 18), 6, 4, new DateOnly(2020, 3, 7), new Guid("6780444e-ae8e-4b7c-ac50-9ba2305ee03e"), 3, 3 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("8d267eb2-ea8a-4503-b935-05edfc2ba947"), new DateOnly(2023, 2, 10), 2, 7, new DateOnly(2022, 11, 2), new Guid("8cd20d80-fc2a-4332-8f13-71a5c69fe94d"), 7, 13 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("8e8c2468-93b3-4577-8003-2fa21710981e"), new DateOnly(2017, 11, 30), 1, 4, new DateOnly(2017, 8, 22), new Guid("00e176b4-f9f8-48cb-bcf1-87b4a7ef4760"), 8, 41 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("8fe51ce6-73bc-4260-a5f6-b5b34213ff78"), new DateOnly(2015, 6, 14), 8, 1, new DateOnly(2015, 3, 6), new Guid("94fc4a7d-a7bb-4560-b377-dc15be47e121"), 4, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("909b9869-b82d-4b5b-9385-c006f665b410"), new DateOnly(2023, 10, 17), 9, 2, new DateOnly(2023, 9, 2), new Guid("932dd1aa-352b-4c8c-a8c8-20dc77b55117"), 3, 9 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("99a73194-3cfc-4221-b35b-05d92adcc6bd"), new DateOnly(2021, 11, 23), 4, 4, new DateOnly(2020, 11, 11), new Guid("3a628309-11e2-40a1-81c4-fe6e072060a9"), 9, 4 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("99aac401-c076-4028-a5c3-c4cd4f7cfb4c"), new DateOnly(2023, 5, 21), 3, 4, new DateOnly(2021, 3, 13), new Guid("f72af983-abfd-4cea-beb9-5f66d4955dd8"), 3, 5 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("9fe4210c-be7a-4386-8759-da581465a5a1"), new DateOnly(2015, 11, 18), 5, 5, new DateOnly(2015, 8, 10), new Guid("50e3c085-d129-43c3-86a2-af5334d92d13"), 8, 6 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("acb7b242-932c-43df-95e7-61a4293d1df4"), new DateOnly(2017, 11, 27), 7, 4, new DateOnly(2017, 8, 19), new Guid("3588cf03-fec1-4c2c-9f0b-277083a7fc6c"), 9, 10 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("b7506e22-0a20-429e-9778-535eead7519e"), new DateOnly(2017, 1, 31), 4, 3, new DateOnly(2016, 10, 23), new Guid("932dd1aa-352b-4c8c-a8c8-20dc77b55117"), 2, 19 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("b8f3ac0f-c263-4d13-a2e1-b5cd461376f0"), new DateOnly(2023, 12, 22), 1, 3, new DateOnly(2016, 12, 9), new Guid("dff59e9d-6bc9-4787-93bc-e82197975ed2"), 1, 11 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("bef8633b-aeaa-46d8-ac44-b394cbb2f676"), new DateOnly(2022, 5, 21), 9, 4, new DateOnly(2022, 2, 10), new Guid("70960421-4adf-4aa9-9eb4-cb9c2c87bdab"), 1, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("ca968e31-5ece-45e9-a1c1-2d71147456ef"), new DateOnly(2018, 11, 15), 6, 3, new DateOnly(2015, 8, 5), new Guid("32e75c0b-b570-45b3-8254-4221dc9ee36f"), 5, 8 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("cda311de-567d-453c-ada2-1b8f935a88e3"), new DateOnly(2018, 1, 4), 5, 1, new DateOnly(2017, 9, 26), new Guid("dff59e9d-6bc9-4787-93bc-e82197975ed2"), 4, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("cf21499f-50b7-42b7-9c59-624e2f278564"), new DateOnly(2019, 8, 24), 1, 5, new DateOnly(2019, 5, 16), new Guid("f72af983-abfd-4cea-beb9-5f66d4955dd8"), 9, 6 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("d33216ad-d047-43db-8528-40705543b4f1"), new DateOnly(2020, 12, 28), 6, 1, new DateOnly(2020, 2, 27), new Guid("f5a52da6-560f-4c91-b616-327fd7e48e39"), 3, 7 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("db7cca1b-c2a2-4830-8c3d-99af8b92d694"), new DateOnly(2019, 4, 20), 1, 1, new DateOnly(2019, 1, 10), new Guid("f5a52da6-560f-4c91-b616-327fd7e48e39"), 3, 9 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("e1c45e5c-bec4-413c-89fc-21338e00b339"), new DateOnly(2018, 12, 16), 3, 1, new DateOnly(2018, 9, 7), new Guid("4e66b256-7fe4-438c-9b08-ca22fbab178c"), 4, 8 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("e64fb897-474e-4efc-b87f-d0a2f0d2e2bf"), new DateOnly(2019, 9, 28), 4, 4, new DateOnly(2015, 9, 28), new Guid("f72af983-abfd-4cea-beb9-5f66d4955dd8"), 6, 7 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("f689495b-4246-46ad-8211-7a46c1105495"), new DateOnly(2023, 11, 27), 6, 4, new DateOnly(2022, 11, 27), new Guid("3a628309-11e2-40a1-81c4-fe6e072060a9"), 3, 1 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("f9e945c4-f6cf-438c-b745-b5050c002e48"), new DateOnly(2018, 12, 24), 8, 8, new DateOnly(2017, 12, 19), new Guid("4f4c0181-78cf-4376-9557-5a63327a84ee"), 2, 9 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("faf74c44-c951-4f10-9a86-88bcdf8cd343"), new DateOnly(2021, 12, 27), 5, 2, new DateOnly(2021, 10, 25), new Guid("32e75c0b-b570-45b3-8254-4221dc9ee36f"), 7, 3 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletRecordId", "Weight", "Width" },
                values: new object[] { new Guid("ffd02d78-da1f-46b7-88f6-3901edd0e381"), new DateOnly(2022, 12, 28), 6, 3, new DateOnly(2018, 12, 27), new Guid("f72628da-bb70-4129-a40f-aa2605bb6c44"), 5, 15 });

            migrationBuilder.CreateIndex(
                name: "IX_Boxes_Id",
                table: "Boxes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Boxes_PalletRecordId",
                table: "Boxes",
                column: "PalletRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Pallets_Id",
                table: "Pallets",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boxes");

            migrationBuilder.DropTable(
                name: "Pallets");
        }
    }
}
