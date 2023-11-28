﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Storage.Contexts;

#nullable disable

namespace Storage.Migrations
{
    [DbContext(typeof(StorageContext))]
    [Migration("20231126124853_DataSeed")]
    partial class DataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Storage.Entities.Box", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Length")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("ManufacturingDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PalletId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PalletId");

                    b.ToTable("Boxes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("92421f6f-0b5e-4e4c-a4ce-34852c292eec"),
                            ExpirationDate = new DateOnly(2017, 9, 25),
                            Height = 5,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2017, 7, 3),
                            PalletId = new Guid("57841efa-1aad-47ba-b6cc-dd53ffc2fdd1"),
                            Weight = 8,
                            Width = 6
                        },
                        new
                        {
                            Id = new Guid("4d901244-b10d-4a38-adfe-b292d4473e3c"),
                            ExpirationDate = new DateOnly(2024, 1, 1),
                            Height = 1,
                            Length = 10,
                            ManufacturingDate = new DateOnly(2023, 9, 23),
                            PalletId = new Guid("57841efa-1aad-47ba-b6cc-dd53ffc2fdd1"),
                            Weight = 3,
                            Width = 8
                        },
                        new
                        {
                            Id = new Guid("d890a1fd-bebe-42bc-a1c3-d2027967e5cd"),
                            ExpirationDate = new DateOnly(2023, 7, 27),
                            Height = 5,
                            Length = 13,
                            ManufacturingDate = new DateOnly(2015, 7, 27),
                            PalletId = new Guid("e6ea05aa-5b19-47cb-b16a-5b8e1eff90cd"),
                            Weight = 1,
                            Width = 16
                        },
                        new
                        {
                            Id = new Guid("176794ef-6940-4b05-8227-738af74b06c6"),
                            ExpirationDate = new DateOnly(2023, 12, 28),
                            Height = 4,
                            Length = 14,
                            ManufacturingDate = new DateOnly(2023, 12, 22),
                            PalletId = new Guid("59d6f738-d9c1-460a-a7d2-e46bcbe93acb"),
                            Weight = 4,
                            Width = 5
                        },
                        new
                        {
                            Id = new Guid("795f01b0-4246-45d5-becb-004e70897631"),
                            ExpirationDate = new DateOnly(2018, 5, 14),
                            Height = 4,
                            Length = 22,
                            ManufacturingDate = new DateOnly(2017, 3, 7),
                            PalletId = new Guid("59d6f738-d9c1-460a-a7d2-e46bcbe93acb"),
                            Weight = 4,
                            Width = 4
                        },
                        new
                        {
                            Id = new Guid("3b26fd94-cbe3-4c30-ac22-3b0f1124517f"),
                            ExpirationDate = new DateOnly(2017, 12, 26),
                            Height = 3,
                            Length = 20,
                            ManufacturingDate = new DateOnly(2017, 9, 17),
                            PalletId = new Guid("36a61e6c-1a5f-40b4-9c93-2ded94424ae2"),
                            Weight = 8,
                            Width = 20
                        },
                        new
                        {
                            Id = new Guid("1eaac1f3-2ba4-402a-8fa3-09bb0496e57e"),
                            ExpirationDate = new DateOnly(2022, 11, 27),
                            Height = 1,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2016, 11, 23),
                            PalletId = new Guid("71a5a9fa-43ab-4a83-b0ae-72d35b506d81"),
                            Weight = 3,
                            Width = 1
                        },
                        new
                        {
                            Id = new Guid("8d998746-0676-42f6-8dbf-38595a462eb4"),
                            ExpirationDate = new DateOnly(2017, 4, 27),
                            Height = 5,
                            Length = 3,
                            ManufacturingDate = new DateOnly(2015, 4, 24),
                            PalletId = new Guid("71a5a9fa-43ab-4a83-b0ae-72d35b506d81"),
                            Weight = 4,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("0eabe552-7a54-4d4c-96c1-77e9c3413a0b"),
                            ExpirationDate = new DateOnly(2019, 4, 6),
                            Height = 6,
                            Length = 3,
                            ManufacturingDate = new DateOnly(2018, 12, 27),
                            PalletId = new Guid("71a5a9fa-43ab-4a83-b0ae-72d35b506d81"),
                            Weight = 5,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("6284f293-1805-441f-84c6-782b37fdd03e"),
                            ExpirationDate = new DateOnly(2021, 10, 28),
                            Height = 5,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2021, 6, 27),
                            PalletId = new Guid("71a5a9fa-43ab-4a83-b0ae-72d35b506d81"),
                            Weight = 3,
                            Width = 1
                        },
                        new
                        {
                            Id = new Guid("4f1902b6-eb26-4d3f-941e-627644c5bfe9"),
                            ExpirationDate = new DateOnly(2017, 11, 22),
                            Height = 2,
                            Length = 7,
                            ManufacturingDate = new DateOnly(2017, 8, 14),
                            PalletId = new Guid("ae6f807e-da42-4a7b-a588-f6c60f168578"),
                            Weight = 1,
                            Width = 3
                        },
                        new
                        {
                            Id = new Guid("3f7a1b46-a663-4739-b502-fccf29c0ac8b"),
                            ExpirationDate = new DateOnly(2018, 11, 12),
                            Height = 4,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2018, 8, 4),
                            PalletId = new Guid("ae6f807e-da42-4a7b-a588-f6c60f168578"),
                            Weight = 4,
                            Width = 8
                        },
                        new
                        {
                            Id = new Guid("1649d6a7-0073-4f3f-9cbe-c387b2480df3"),
                            ExpirationDate = new DateOnly(2023, 7, 11),
                            Height = 7,
                            Length = 5,
                            ManufacturingDate = new DateOnly(2023, 4, 2),
                            PalletId = new Guid("ae6f807e-da42-4a7b-a588-f6c60f168578"),
                            Weight = 7,
                            Width = 6
                        },
                        new
                        {
                            Id = new Guid("b9c7d989-5d8e-4ece-b559-7a63b81f5817"),
                            ExpirationDate = new DateOnly(2021, 10, 22),
                            Height = 8,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2017, 9, 14),
                            PalletId = new Guid("ae6f807e-da42-4a7b-a588-f6c60f168578"),
                            Weight = 2,
                            Width = 3
                        },
                        new
                        {
                            Id = new Guid("19e3fc45-c23d-4845-ad3f-54b5a16c5e23"),
                            ExpirationDate = new DateOnly(2021, 2, 20),
                            Height = 5,
                            Length = 5,
                            ManufacturingDate = new DateOnly(2020, 11, 12),
                            PalletId = new Guid("2b7bdc4f-cc5b-4bd6-bf72-fd45781e55bd"),
                            Weight = 6,
                            Width = 5
                        },
                        new
                        {
                            Id = new Guid("02bf493a-3a39-4954-98c8-c63e49e8fb59"),
                            ExpirationDate = new DateOnly(2019, 12, 25),
                            Height = 2,
                            Length = 11,
                            ManufacturingDate = new DateOnly(2016, 11, 21),
                            PalletId = new Guid("2b7bdc4f-cc5b-4bd6-bf72-fd45781e55bd"),
                            Weight = 4,
                            Width = 3
                        },
                        new
                        {
                            Id = new Guid("2b4e308c-c930-4174-b8ba-5f8118faa6c6"),
                            ExpirationDate = new DateOnly(2021, 11, 27),
                            Height = 6,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2020, 5, 26),
                            PalletId = new Guid("2b7bdc4f-cc5b-4bd6-bf72-fd45781e55bd"),
                            Weight = 3,
                            Width = 4
                        },
                        new
                        {
                            Id = new Guid("ea1b6ad1-d045-4654-9f25-45e0106bcff7"),
                            ExpirationDate = new DateOnly(2018, 1, 6),
                            Height = 8,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2017, 9, 28),
                            PalletId = new Guid("00469dc0-7c7b-4df7-8d6e-9b909f2310e5"),
                            Weight = 4,
                            Width = 11
                        },
                        new
                        {
                            Id = new Guid("af0912dd-6ee9-4d3a-acb9-165aee343f2b"),
                            ExpirationDate = new DateOnly(2020, 11, 16),
                            Height = 7,
                            Length = 7,
                            ManufacturingDate = new DateOnly(2017, 11, 14),
                            PalletId = new Guid("00469dc0-7c7b-4df7-8d6e-9b909f2310e5"),
                            Weight = 9,
                            Width = 7
                        },
                        new
                        {
                            Id = new Guid("762bf6b2-06e5-4352-a1a7-c6643815da9b"),
                            ExpirationDate = new DateOnly(2020, 5, 1),
                            Height = 3,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2020, 1, 22),
                            PalletId = new Guid("faa2745a-9984-4d70-b3e5-8f95a71de346"),
                            Weight = 5,
                            Width = 17
                        },
                        new
                        {
                            Id = new Guid("f507eaf5-c995-4d00-85e2-267c46fd2953"),
                            ExpirationDate = new DateOnly(2024, 3, 13),
                            Height = 7,
                            Length = 3,
                            ManufacturingDate = new DateOnly(2023, 12, 4),
                            PalletId = new Guid("b5902cfa-3d81-4c4f-9da3-65b8be711f2c"),
                            Weight = 6,
                            Width = 4
                        },
                        new
                        {
                            Id = new Guid("501d5965-bab4-47ff-8286-160546a54808"),
                            ExpirationDate = new DateOnly(2023, 11, 15),
                            Height = 3,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2021, 9, 10),
                            PalletId = new Guid("b5902cfa-3d81-4c4f-9da3-65b8be711f2c"),
                            Weight = 3,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("947613af-9feb-4f5c-ae3f-60c7cec68f30"),
                            ExpirationDate = new DateOnly(2019, 3, 28),
                            Height = 9,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2017, 3, 28),
                            PalletId = new Guid("b5902cfa-3d81-4c4f-9da3-65b8be711f2c"),
                            Weight = 1,
                            Width = 5
                        },
                        new
                        {
                            Id = new Guid("1b878d05-b63c-49a3-8d99-22ea8509d7ee"),
                            ExpirationDate = new DateOnly(2023, 12, 10),
                            Height = 3,
                            Length = 9,
                            ManufacturingDate = new DateOnly(2023, 9, 1),
                            PalletId = new Guid("be5c5bc5-8a50-4021-a6f0-0acb97cf6ea3"),
                            Weight = 8,
                            Width = 3
                        },
                        new
                        {
                            Id = new Guid("5d080fda-199c-40a7-bd04-3624694fc540"),
                            ExpirationDate = new DateOnly(2022, 8, 26),
                            Height = 2,
                            Length = 8,
                            ManufacturingDate = new DateOnly(2021, 2, 19),
                            PalletId = new Guid("be5c5bc5-8a50-4021-a6f0-0acb97cf6ea3"),
                            Weight = 6,
                            Width = 13
                        },
                        new
                        {
                            Id = new Guid("ac66daf0-fafe-469a-a424-20b748e25a5e"),
                            ExpirationDate = new DateOnly(2023, 9, 27),
                            Height = 8,
                            Length = 5,
                            ManufacturingDate = new DateOnly(2023, 1, 25),
                            PalletId = new Guid("b2d2aafa-4434-42f8-8036-45735971e067"),
                            Weight = 3,
                            Width = 3
                        },
                        new
                        {
                            Id = new Guid("559c5241-3b28-4f8c-aa51-b33512a65f3f"),
                            ExpirationDate = new DateOnly(2022, 5, 21),
                            Height = 9,
                            Length = 3,
                            ManufacturingDate = new DateOnly(2020, 5, 3),
                            PalletId = new Guid("b2d2aafa-4434-42f8-8036-45735971e067"),
                            Weight = 7,
                            Width = 3
                        },
                        new
                        {
                            Id = new Guid("6b72250a-8b47-449b-bd22-80507975ee51"),
                            ExpirationDate = new DateOnly(2022, 4, 15),
                            Height = 7,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2022, 1, 5),
                            PalletId = new Guid("b2d2aafa-4434-42f8-8036-45735971e067"),
                            Weight = 1,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("3c84495a-ae22-43e1-914e-d39855d63866"),
                            ExpirationDate = new DateOnly(2018, 10, 18),
                            Height = 9,
                            Length = 7,
                            ManufacturingDate = new DateOnly(2017, 9, 6),
                            PalletId = new Guid("b2d2aafa-4434-42f8-8036-45735971e067"),
                            Weight = 8,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("d5c29c9c-393b-4aa8-94bb-607e0367a154"),
                            ExpirationDate = new DateOnly(2017, 8, 26),
                            Height = 5,
                            Length = 21,
                            ManufacturingDate = new DateOnly(2017, 5, 18),
                            PalletId = new Guid("67b0a430-61dd-45a8-9946-9f68e3b248d0"),
                            Weight = 6,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("dc3202b2-7fc0-4d62-aece-93bb99d442b2"),
                            ExpirationDate = new DateOnly(2018, 2, 4),
                            Height = 8,
                            Length = 12,
                            ManufacturingDate = new DateOnly(2017, 10, 27),
                            PalletId = new Guid("67b0a430-61dd-45a8-9946-9f68e3b248d0"),
                            Weight = 5,
                            Width = 7
                        },
                        new
                        {
                            Id = new Guid("96ae9bd8-2650-4833-96e6-2351ec966908"),
                            ExpirationDate = new DateOnly(2021, 3, 23),
                            Height = 7,
                            Length = 5,
                            ManufacturingDate = new DateOnly(2020, 12, 13),
                            PalletId = new Guid("950ba077-c89a-4a83-87ef-6c670ce9ddb4"),
                            Weight = 5,
                            Width = 6
                        },
                        new
                        {
                            Id = new Guid("77a21835-8406-4efd-88da-fb4efe3f1868"),
                            ExpirationDate = new DateOnly(2021, 9, 21),
                            Height = 8,
                            Length = 6,
                            ManufacturingDate = new DateOnly(2018, 8, 7),
                            PalletId = new Guid("8ac04d38-a243-4362-85a3-b131ffdae39e"),
                            Weight = 7,
                            Width = 5
                        },
                        new
                        {
                            Id = new Guid("9a6b10fb-ddfa-44d4-80b1-2b0f9ab56c81"),
                            ExpirationDate = new DateOnly(2022, 11, 28),
                            Height = 5,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2022, 10, 28),
                            PalletId = new Guid("8ac04d38-a243-4362-85a3-b131ffdae39e"),
                            Weight = 9,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("12a97ffa-9a38-4f3b-bef1-39c384fb223f"),
                            ExpirationDate = new DateOnly(2023, 10, 28),
                            Height = 4,
                            Length = 8,
                            ManufacturingDate = new DateOnly(2023, 9, 9),
                            PalletId = new Guid("8ac04d38-a243-4362-85a3-b131ffdae39e"),
                            Weight = 4,
                            Width = 5
                        },
                        new
                        {
                            Id = new Guid("0dbf3edd-af1d-4746-ac0f-a496db199212"),
                            ExpirationDate = new DateOnly(2016, 11, 11),
                            Height = 7,
                            Length = 3,
                            ManufacturingDate = new DateOnly(2015, 8, 7),
                            PalletId = new Guid("16744f44-b7c2-43b4-98ea-a54122581f50"),
                            Weight = 9,
                            Width = 4
                        },
                        new
                        {
                            Id = new Guid("48f84ff6-561a-461c-a9b0-b36bed964007"),
                            ExpirationDate = new DateOnly(2023, 12, 24),
                            Height = 3,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2023, 7, 23),
                            PalletId = new Guid("f89e020e-d122-4060-969d-58b781b52e67"),
                            Weight = 8,
                            Width = 6
                        },
                        new
                        {
                            Id = new Guid("e6cf896b-11e6-4fa5-a08f-6ebf298343ec"),
                            ExpirationDate = new DateOnly(2020, 7, 25),
                            Height = 4,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2020, 4, 16),
                            PalletId = new Guid("f89e020e-d122-4060-969d-58b781b52e67"),
                            Weight = 6,
                            Width = 7
                        },
                        new
                        {
                            Id = new Guid("ec9e9c04-a299-4f53-9eb3-cd87b65a2944"),
                            ExpirationDate = new DateOnly(2019, 11, 28),
                            Height = 7,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2019, 11, 9),
                            PalletId = new Guid("f89e020e-d122-4060-969d-58b781b52e67"),
                            Weight = 5,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("5f1729a1-985d-4154-a831-59bbdd230611"),
                            ExpirationDate = new DateOnly(2023, 5, 24),
                            Height = 6,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2023, 2, 16),
                            PalletId = new Guid("f89e020e-d122-4060-969d-58b781b52e67"),
                            Weight = 7,
                            Width = 1
                        },
                        new
                        {
                            Id = new Guid("a3041b54-7299-474d-8584-061ba347566a"),
                            ExpirationDate = new DateOnly(2023, 2, 15),
                            Height = 7,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2022, 11, 7),
                            PalletId = new Guid("ec7d6071-6d64-40bc-bd46-0e49e5889063"),
                            Weight = 9,
                            Width = 5
                        },
                        new
                        {
                            Id = new Guid("9f67c304-8713-41d7-a020-5f4727ccb589"),
                            ExpirationDate = new DateOnly(2021, 1, 11),
                            Height = 2,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2020, 10, 3),
                            PalletId = new Guid("ec7d6071-6d64-40bc-bd46-0e49e5889063"),
                            Weight = 1,
                            Width = 7
                        },
                        new
                        {
                            Id = new Guid("4e845a07-e082-4396-a946-9f243f82f9ec"),
                            ExpirationDate = new DateOnly(2020, 10, 27),
                            Height = 2,
                            Length = 6,
                            ManufacturingDate = new DateOnly(2016, 1, 7),
                            PalletId = new Guid("ec7d6071-6d64-40bc-bd46-0e49e5889063"),
                            Weight = 6,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("ba18381a-a7ef-47ea-9588-489299af3918"),
                            ExpirationDate = new DateOnly(2023, 8, 9),
                            Height = 9,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2021, 6, 1),
                            PalletId = new Guid("ec7d6071-6d64-40bc-bd46-0e49e5889063"),
                            Weight = 2,
                            Width = 7
                        });
                });

            modelBuilder.Entity("Storage.Entities.Pallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Length")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Pallets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("57841efa-1aad-47ba-b6cc-dd53ffc2fdd1"),
                            Height = 18,
                            Length = 36,
                            Weight = 39,
                            Width = 25
                        },
                        new
                        {
                            Id = new Guid("e6ea05aa-5b19-47cb-b16a-5b8e1eff90cd"),
                            Height = 25,
                            Length = 26,
                            Weight = 32,
                            Width = 18
                        },
                        new
                        {
                            Id = new Guid("59d6f738-d9c1-460a-a7d2-e46bcbe93acb"),
                            Height = 18,
                            Length = 47,
                            Weight = 44,
                            Width = 40
                        },
                        new
                        {
                            Id = new Guid("36a61e6c-1a5f-40b4-9c93-2ded94424ae2"),
                            Height = 14,
                            Length = 32,
                            Weight = 49,
                            Width = 41
                        },
                        new
                        {
                            Id = new Guid("71a5a9fa-43ab-4a83-b0ae-72d35b506d81"),
                            Height = 37,
                            Length = 23,
                            Weight = 44,
                            Width = 14
                        },
                        new
                        {
                            Id = new Guid("ae6f807e-da42-4a7b-a588-f6c60f168578"),
                            Height = 35,
                            Length = 40,
                            Weight = 37,
                            Width = 39
                        },
                        new
                        {
                            Id = new Guid("2b7bdc4f-cc5b-4bd6-bf72-fd45781e55bd"),
                            Height = 18,
                            Length = 37,
                            Weight = 30,
                            Width = 18
                        },
                        new
                        {
                            Id = new Guid("00469dc0-7c7b-4df7-8d6e-9b909f2310e5"),
                            Height = 42,
                            Length = 27,
                            Weight = 30,
                            Width = 25
                        },
                        new
                        {
                            Id = new Guid("faa2745a-9984-4d70-b3e5-8f95a71de346"),
                            Height = 30,
                            Length = 22,
                            Weight = 45,
                            Width = 22
                        },
                        new
                        {
                            Id = new Guid("b5902cfa-3d81-4c4f-9da3-65b8be711f2c"),
                            Height = 40,
                            Length = 17,
                            Weight = 35,
                            Width = 21
                        },
                        new
                        {
                            Id = new Guid("be5c5bc5-8a50-4021-a6f0-0acb97cf6ea3"),
                            Height = 17,
                            Length = 23,
                            Weight = 32,
                            Width = 33
                        },
                        new
                        {
                            Id = new Guid("b2d2aafa-4434-42f8-8036-45735971e067"),
                            Height = 15,
                            Length = 34,
                            Weight = 42,
                            Width = 20
                        },
                        new
                        {
                            Id = new Guid("67b0a430-61dd-45a8-9946-9f68e3b248d0"),
                            Height = 24,
                            Length = 44,
                            Weight = 37,
                            Width = 20
                        },
                        new
                        {
                            Id = new Guid("950ba077-c89a-4a83-87ef-6c670ce9ddb4"),
                            Height = 23,
                            Length = 21,
                            Weight = 48,
                            Width = 13
                        },
                        new
                        {
                            Id = new Guid("8ac04d38-a243-4362-85a3-b131ffdae39e"),
                            Height = 28,
                            Length = 43,
                            Weight = 46,
                            Width = 39
                        },
                        new
                        {
                            Id = new Guid("16744f44-b7c2-43b4-98ea-a54122581f50"),
                            Height = 25,
                            Length = 23,
                            Weight = 42,
                            Width = 31
                        },
                        new
                        {
                            Id = new Guid("f89e020e-d122-4060-969d-58b781b52e67"),
                            Height = 28,
                            Length = 13,
                            Weight = 48,
                            Width = 36
                        },
                        new
                        {
                            Id = new Guid("ec7d6071-6d64-40bc-bd46-0e49e5889063"),
                            Height = 26,
                            Length = 40,
                            Weight = 43,
                            Width = 35
                        });
                });

            modelBuilder.Entity("Storage.Entities.Box", b =>
                {
                    b.HasOne("Storage.Entities.Pallet", null)
                        .WithMany("Boxes")
                        .HasForeignKey("PalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Storage.Entities.Pallet", b =>
                {
                    b.Navigation("Boxes");
                });
#pragma warning restore 612, 618
        }
    }
}
