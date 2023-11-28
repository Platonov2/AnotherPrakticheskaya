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
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("00469dc0-7c7b-4df7-8d6e-9b909f2310e5"), 42, 27, 30, 25 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("16744f44-b7c2-43b4-98ea-a54122581f50"), 25, 23, 42, 31 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("2b7bdc4f-cc5b-4bd6-bf72-fd45781e55bd"), 18, 37, 30, 18 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("36a61e6c-1a5f-40b4-9c93-2ded94424ae2"), 14, 32, 49, 41 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("57841efa-1aad-47ba-b6cc-dd53ffc2fdd1"), 18, 36, 39, 25 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("59d6f738-d9c1-460a-a7d2-e46bcbe93acb"), 18, 47, 44, 40 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("67b0a430-61dd-45a8-9946-9f68e3b248d0"), 24, 44, 37, 20 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("71a5a9fa-43ab-4a83-b0ae-72d35b506d81"), 37, 23, 44, 14 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("8ac04d38-a243-4362-85a3-b131ffdae39e"), 28, 43, 46, 39 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("950ba077-c89a-4a83-87ef-6c670ce9ddb4"), 23, 21, 48, 13 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("ae6f807e-da42-4a7b-a588-f6c60f168578"), 35, 40, 37, 39 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("b2d2aafa-4434-42f8-8036-45735971e067"), 15, 34, 42, 20 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("b5902cfa-3d81-4c4f-9da3-65b8be711f2c"), 40, 17, 35, 21 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("be5c5bc5-8a50-4021-a6f0-0acb97cf6ea3"), 17, 23, 32, 33 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("e6ea05aa-5b19-47cb-b16a-5b8e1eff90cd"), 25, 26, 32, 18 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("ec7d6071-6d64-40bc-bd46-0e49e5889063"), 26, 40, 43, 35 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("f89e020e-d122-4060-969d-58b781b52e67"), 28, 13, 48, 36 });

            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Height", "Length", "Weight", "Width" },
                values: new object[] { new Guid("faa2745a-9984-4d70-b3e5-8f95a71de346"), 30, 22, 45, 22 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("02bf493a-3a39-4954-98c8-c63e49e8fb59"), new DateOnly(2019, 12, 25), 2, 11, new DateOnly(2016, 11, 21), new Guid("2b7bdc4f-cc5b-4bd6-bf72-fd45781e55bd"), 4, 3 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("0dbf3edd-af1d-4746-ac0f-a496db199212"), new DateOnly(2016, 11, 11), 7, 3, new DateOnly(2015, 8, 7), new Guid("16744f44-b7c2-43b4-98ea-a54122581f50"), 9, 4 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("0eabe552-7a54-4d4c-96c1-77e9c3413a0b"), new DateOnly(2019, 4, 6), 6, 3, new DateOnly(2018, 12, 27), new Guid("71a5a9fa-43ab-4a83-b0ae-72d35b506d81"), 5, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("12a97ffa-9a38-4f3b-bef1-39c384fb223f"), new DateOnly(2023, 10, 28), 4, 8, new DateOnly(2023, 9, 9), new Guid("8ac04d38-a243-4362-85a3-b131ffdae39e"), 4, 5 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("1649d6a7-0073-4f3f-9cbe-c387b2480df3"), new DateOnly(2023, 7, 11), 7, 5, new DateOnly(2023, 4, 2), new Guid("ae6f807e-da42-4a7b-a588-f6c60f168578"), 7, 6 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("176794ef-6940-4b05-8227-738af74b06c6"), new DateOnly(2023, 12, 28), 4, 14, new DateOnly(2023, 12, 22), new Guid("59d6f738-d9c1-460a-a7d2-e46bcbe93acb"), 4, 5 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("19e3fc45-c23d-4845-ad3f-54b5a16c5e23"), new DateOnly(2021, 2, 20), 5, 5, new DateOnly(2020, 11, 12), new Guid("2b7bdc4f-cc5b-4bd6-bf72-fd45781e55bd"), 6, 5 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("1b878d05-b63c-49a3-8d99-22ea8509d7ee"), new DateOnly(2023, 12, 10), 3, 9, new DateOnly(2023, 9, 1), new Guid("be5c5bc5-8a50-4021-a6f0-0acb97cf6ea3"), 8, 3 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("1eaac1f3-2ba4-402a-8fa3-09bb0496e57e"), new DateOnly(2022, 11, 27), 1, 2, new DateOnly(2016, 11, 23), new Guid("71a5a9fa-43ab-4a83-b0ae-72d35b506d81"), 3, 1 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("2b4e308c-c930-4174-b8ba-5f8118faa6c6"), new DateOnly(2021, 11, 27), 6, 2, new DateOnly(2020, 5, 26), new Guid("2b7bdc4f-cc5b-4bd6-bf72-fd45781e55bd"), 3, 4 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("3b26fd94-cbe3-4c30-ac22-3b0f1124517f"), new DateOnly(2017, 12, 26), 3, 20, new DateOnly(2017, 9, 17), new Guid("36a61e6c-1a5f-40b4-9c93-2ded94424ae2"), 8, 20 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("3c84495a-ae22-43e1-914e-d39855d63866"), new DateOnly(2018, 10, 18), 9, 7, new DateOnly(2017, 9, 6), new Guid("b2d2aafa-4434-42f8-8036-45735971e067"), 8, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("3f7a1b46-a663-4739-b502-fccf29c0ac8b"), new DateOnly(2018, 11, 12), 4, 1, new DateOnly(2018, 8, 4), new Guid("ae6f807e-da42-4a7b-a588-f6c60f168578"), 4, 8 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("48f84ff6-561a-461c-a9b0-b36bed964007"), new DateOnly(2023, 12, 24), 3, 1, new DateOnly(2023, 7, 23), new Guid("f89e020e-d122-4060-969d-58b781b52e67"), 8, 6 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("4d901244-b10d-4a38-adfe-b292d4473e3c"), new DateOnly(2024, 1, 1), 1, 10, new DateOnly(2023, 9, 23), new Guid("57841efa-1aad-47ba-b6cc-dd53ffc2fdd1"), 3, 8 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("4e845a07-e082-4396-a946-9f243f82f9ec"), new DateOnly(2020, 10, 27), 2, 6, new DateOnly(2016, 1, 7), new Guid("ec7d6071-6d64-40bc-bd46-0e49e5889063"), 6, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("4f1902b6-eb26-4d3f-941e-627644c5bfe9"), new DateOnly(2017, 11, 22), 2, 7, new DateOnly(2017, 8, 14), new Guid("ae6f807e-da42-4a7b-a588-f6c60f168578"), 1, 3 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("501d5965-bab4-47ff-8286-160546a54808"), new DateOnly(2023, 11, 15), 3, 4, new DateOnly(2021, 9, 10), new Guid("b5902cfa-3d81-4c4f-9da3-65b8be711f2c"), 3, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("559c5241-3b28-4f8c-aa51-b33512a65f3f"), new DateOnly(2022, 5, 21), 9, 3, new DateOnly(2020, 5, 3), new Guid("b2d2aafa-4434-42f8-8036-45735971e067"), 7, 3 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("5d080fda-199c-40a7-bd04-3624694fc540"), new DateOnly(2022, 8, 26), 2, 8, new DateOnly(2021, 2, 19), new Guid("be5c5bc5-8a50-4021-a6f0-0acb97cf6ea3"), 6, 13 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("5f1729a1-985d-4154-a831-59bbdd230611"), new DateOnly(2023, 5, 24), 6, 1, new DateOnly(2023, 2, 16), new Guid("f89e020e-d122-4060-969d-58b781b52e67"), 7, 1 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("6284f293-1805-441f-84c6-782b37fdd03e"), new DateOnly(2021, 10, 28), 5, 2, new DateOnly(2021, 6, 27), new Guid("71a5a9fa-43ab-4a83-b0ae-72d35b506d81"), 3, 1 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("6b72250a-8b47-449b-bd22-80507975ee51"), new DateOnly(2022, 4, 15), 7, 2, new DateOnly(2022, 1, 5), new Guid("b2d2aafa-4434-42f8-8036-45735971e067"), 1, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("762bf6b2-06e5-4352-a1a7-c6643815da9b"), new DateOnly(2020, 5, 1), 3, 1, new DateOnly(2020, 1, 22), new Guid("faa2745a-9984-4d70-b3e5-8f95a71de346"), 5, 17 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("77a21835-8406-4efd-88da-fb4efe3f1868"), new DateOnly(2021, 9, 21), 8, 6, new DateOnly(2018, 8, 7), new Guid("8ac04d38-a243-4362-85a3-b131ffdae39e"), 7, 5 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("795f01b0-4246-45d5-becb-004e70897631"), new DateOnly(2018, 5, 14), 4, 22, new DateOnly(2017, 3, 7), new Guid("59d6f738-d9c1-460a-a7d2-e46bcbe93acb"), 4, 4 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("8d998746-0676-42f6-8dbf-38595a462eb4"), new DateOnly(2017, 4, 27), 5, 3, new DateOnly(2015, 4, 24), new Guid("71a5a9fa-43ab-4a83-b0ae-72d35b506d81"), 4, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("92421f6f-0b5e-4e4c-a4ce-34852c292eec"), new DateOnly(2017, 9, 25), 5, 2, new DateOnly(2017, 7, 3), new Guid("57841efa-1aad-47ba-b6cc-dd53ffc2fdd1"), 8, 6 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("947613af-9feb-4f5c-ae3f-60c7cec68f30"), new DateOnly(2019, 3, 28), 9, 1, new DateOnly(2017, 3, 28), new Guid("b5902cfa-3d81-4c4f-9da3-65b8be711f2c"), 1, 5 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("96ae9bd8-2650-4833-96e6-2351ec966908"), new DateOnly(2021, 3, 23), 7, 5, new DateOnly(2020, 12, 13), new Guid("950ba077-c89a-4a83-87ef-6c670ce9ddb4"), 5, 6 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("9a6b10fb-ddfa-44d4-80b1-2b0f9ab56c81"), new DateOnly(2022, 11, 28), 5, 4, new DateOnly(2022, 10, 28), new Guid("8ac04d38-a243-4362-85a3-b131ffdae39e"), 9, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("9f67c304-8713-41d7-a020-5f4727ccb589"), new DateOnly(2021, 1, 11), 2, 1, new DateOnly(2020, 10, 3), new Guid("ec7d6071-6d64-40bc-bd46-0e49e5889063"), 1, 7 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("a3041b54-7299-474d-8584-061ba347566a"), new DateOnly(2023, 2, 15), 7, 4, new DateOnly(2022, 11, 7), new Guid("ec7d6071-6d64-40bc-bd46-0e49e5889063"), 9, 5 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("ac66daf0-fafe-469a-a424-20b748e25a5e"), new DateOnly(2023, 9, 27), 8, 5, new DateOnly(2023, 1, 25), new Guid("b2d2aafa-4434-42f8-8036-45735971e067"), 3, 3 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("af0912dd-6ee9-4d3a-acb9-165aee343f2b"), new DateOnly(2020, 11, 16), 7, 7, new DateOnly(2017, 11, 14), new Guid("00469dc0-7c7b-4df7-8d6e-9b909f2310e5"), 9, 7 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("b9c7d989-5d8e-4ece-b559-7a63b81f5817"), new DateOnly(2021, 10, 22), 8, 1, new DateOnly(2017, 9, 14), new Guid("ae6f807e-da42-4a7b-a588-f6c60f168578"), 2, 3 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("ba18381a-a7ef-47ea-9588-489299af3918"), new DateOnly(2023, 8, 9), 9, 2, new DateOnly(2021, 6, 1), new Guid("ec7d6071-6d64-40bc-bd46-0e49e5889063"), 2, 7 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("d5c29c9c-393b-4aa8-94bb-607e0367a154"), new DateOnly(2017, 8, 26), 5, 21, new DateOnly(2017, 5, 18), new Guid("67b0a430-61dd-45a8-9946-9f68e3b248d0"), 6, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("d890a1fd-bebe-42bc-a1c3-d2027967e5cd"), new DateOnly(2023, 7, 27), 5, 13, new DateOnly(2015, 7, 27), new Guid("e6ea05aa-5b19-47cb-b16a-5b8e1eff90cd"), 1, 16 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("dc3202b2-7fc0-4d62-aece-93bb99d442b2"), new DateOnly(2018, 2, 4), 8, 12, new DateOnly(2017, 10, 27), new Guid("67b0a430-61dd-45a8-9946-9f68e3b248d0"), 5, 7 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("e6cf896b-11e6-4fa5-a08f-6ebf298343ec"), new DateOnly(2020, 7, 25), 4, 2, new DateOnly(2020, 4, 16), new Guid("f89e020e-d122-4060-969d-58b781b52e67"), 6, 7 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("ea1b6ad1-d045-4654-9f25-45e0106bcff7"), new DateOnly(2018, 1, 6), 8, 4, new DateOnly(2017, 9, 28), new Guid("00469dc0-7c7b-4df7-8d6e-9b909f2310e5"), 4, 11 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("ec9e9c04-a299-4f53-9eb3-cd87b65a2944"), new DateOnly(2019, 11, 28), 7, 2, new DateOnly(2019, 11, 9), new Guid("f89e020e-d122-4060-969d-58b781b52e67"), 5, 2 });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "ExpirationDate", "Height", "Length", "ManufacturingDate", "PalletId", "Weight", "Width" },
                values: new object[] { new Guid("f507eaf5-c995-4d00-85e2-267c46fd2953"), new DateOnly(2024, 3, 13), 7, 3, new DateOnly(2023, 12, 4), new Guid("b5902cfa-3d81-4c4f-9da3-65b8be711f2c"), 6, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("02bf493a-3a39-4954-98c8-c63e49e8fb59"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("0dbf3edd-af1d-4746-ac0f-a496db199212"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("0eabe552-7a54-4d4c-96c1-77e9c3413a0b"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("12a97ffa-9a38-4f3b-bef1-39c384fb223f"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("1649d6a7-0073-4f3f-9cbe-c387b2480df3"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("176794ef-6940-4b05-8227-738af74b06c6"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("19e3fc45-c23d-4845-ad3f-54b5a16c5e23"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("1b878d05-b63c-49a3-8d99-22ea8509d7ee"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("1eaac1f3-2ba4-402a-8fa3-09bb0496e57e"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("2b4e308c-c930-4174-b8ba-5f8118faa6c6"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("3b26fd94-cbe3-4c30-ac22-3b0f1124517f"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("3c84495a-ae22-43e1-914e-d39855d63866"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("3f7a1b46-a663-4739-b502-fccf29c0ac8b"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("48f84ff6-561a-461c-a9b0-b36bed964007"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("4d901244-b10d-4a38-adfe-b292d4473e3c"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("4e845a07-e082-4396-a946-9f243f82f9ec"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("4f1902b6-eb26-4d3f-941e-627644c5bfe9"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("501d5965-bab4-47ff-8286-160546a54808"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("559c5241-3b28-4f8c-aa51-b33512a65f3f"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("5d080fda-199c-40a7-bd04-3624694fc540"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("5f1729a1-985d-4154-a831-59bbdd230611"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("6284f293-1805-441f-84c6-782b37fdd03e"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("6b72250a-8b47-449b-bd22-80507975ee51"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("762bf6b2-06e5-4352-a1a7-c6643815da9b"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("77a21835-8406-4efd-88da-fb4efe3f1868"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("795f01b0-4246-45d5-becb-004e70897631"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("8d998746-0676-42f6-8dbf-38595a462eb4"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("92421f6f-0b5e-4e4c-a4ce-34852c292eec"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("947613af-9feb-4f5c-ae3f-60c7cec68f30"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("96ae9bd8-2650-4833-96e6-2351ec966908"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("9a6b10fb-ddfa-44d4-80b1-2b0f9ab56c81"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("9f67c304-8713-41d7-a020-5f4727ccb589"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("a3041b54-7299-474d-8584-061ba347566a"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("ac66daf0-fafe-469a-a424-20b748e25a5e"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("af0912dd-6ee9-4d3a-acb9-165aee343f2b"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("b9c7d989-5d8e-4ece-b559-7a63b81f5817"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("ba18381a-a7ef-47ea-9588-489299af3918"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("d5c29c9c-393b-4aa8-94bb-607e0367a154"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("d890a1fd-bebe-42bc-a1c3-d2027967e5cd"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("dc3202b2-7fc0-4d62-aece-93bb99d442b2"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("e6cf896b-11e6-4fa5-a08f-6ebf298343ec"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("ea1b6ad1-d045-4654-9f25-45e0106bcff7"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("ec9e9c04-a299-4f53-9eb3-cd87b65a2944"));

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: new Guid("f507eaf5-c995-4d00-85e2-267c46fd2953"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("00469dc0-7c7b-4df7-8d6e-9b909f2310e5"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("16744f44-b7c2-43b4-98ea-a54122581f50"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("2b7bdc4f-cc5b-4bd6-bf72-fd45781e55bd"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("36a61e6c-1a5f-40b4-9c93-2ded94424ae2"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("57841efa-1aad-47ba-b6cc-dd53ffc2fdd1"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("59d6f738-d9c1-460a-a7d2-e46bcbe93acb"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("67b0a430-61dd-45a8-9946-9f68e3b248d0"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("71a5a9fa-43ab-4a83-b0ae-72d35b506d81"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("8ac04d38-a243-4362-85a3-b131ffdae39e"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("950ba077-c89a-4a83-87ef-6c670ce9ddb4"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("ae6f807e-da42-4a7b-a588-f6c60f168578"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("b2d2aafa-4434-42f8-8036-45735971e067"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("b5902cfa-3d81-4c4f-9da3-65b8be711f2c"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("be5c5bc5-8a50-4021-a6f0-0acb97cf6ea3"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("e6ea05aa-5b19-47cb-b16a-5b8e1eff90cd"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("ec7d6071-6d64-40bc-bd46-0e49e5889063"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("f89e020e-d122-4060-969d-58b781b52e67"));

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: new Guid("faa2745a-9984-4d70-b3e5-8f95a71de346"));

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
