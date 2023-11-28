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
    [Migration("20231128122130_DataSeed")]
    partial class DataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Storage.Entities.BoxRecord", b =>
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

                    b.Property<Guid>("PalletRecordId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PalletRecordId");

                    b.ToTable("Boxes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("15d3c542-0cd7-4335-950a-3c5606ef23ff"),
                            ExpirationDate = new DateOnly(2015, 8, 16),
                            Height = 5,
                            Length = 8,
                            ManufacturingDate = new DateOnly(2015, 5, 8),
                            PalletRecordId = new Guid("8ab29685-5756-40b9-b076-268b34c2034d"),
                            Weight = 3,
                            Width = 10
                        },
                        new
                        {
                            Id = new Guid("8e8c2468-93b3-4577-8003-2fa21710981e"),
                            ExpirationDate = new DateOnly(2017, 11, 30),
                            Height = 1,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2017, 8, 22),
                            PalletRecordId = new Guid("00e176b4-f9f8-48cb-bcf1-87b4a7ef4760"),
                            Weight = 8,
                            Width = 41
                        },
                        new
                        {
                            Id = new Guid("e64fb897-474e-4efc-b87f-d0a2f0d2e2bf"),
                            ExpirationDate = new DateOnly(2019, 9, 28),
                            Height = 4,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2015, 9, 28),
                            PalletRecordId = new Guid("f72af983-abfd-4cea-beb9-5f66d4955dd8"),
                            Weight = 6,
                            Width = 7
                        },
                        new
                        {
                            Id = new Guid("cf21499f-50b7-42b7-9c59-624e2f278564"),
                            ExpirationDate = new DateOnly(2019, 8, 24),
                            Height = 1,
                            Length = 5,
                            ManufacturingDate = new DateOnly(2019, 5, 16),
                            PalletRecordId = new Guid("f72af983-abfd-4cea-beb9-5f66d4955dd8"),
                            Weight = 9,
                            Width = 6
                        },
                        new
                        {
                            Id = new Guid("99aac401-c076-4028-a5c3-c4cd4f7cfb4c"),
                            ExpirationDate = new DateOnly(2023, 5, 21),
                            Height = 3,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2021, 3, 13),
                            PalletRecordId = new Guid("f72af983-abfd-4cea-beb9-5f66d4955dd8"),
                            Weight = 3,
                            Width = 5
                        },
                        new
                        {
                            Id = new Guid("67300179-686a-4e8e-8ade-b134a35c8a52"),
                            ExpirationDate = new DateOnly(2020, 8, 24),
                            Height = 5,
                            Length = 5,
                            ManufacturingDate = new DateOnly(2020, 5, 16),
                            PalletRecordId = new Guid("f72af983-abfd-4cea-beb9-5f66d4955dd8"),
                            Weight = 8,
                            Width = 1
                        },
                        new
                        {
                            Id = new Guid("b8f3ac0f-c263-4d13-a2e1-b5cd461376f0"),
                            ExpirationDate = new DateOnly(2023, 12, 22),
                            Height = 1,
                            Length = 3,
                            ManufacturingDate = new DateOnly(2016, 12, 9),
                            PalletRecordId = new Guid("dff59e9d-6bc9-4787-93bc-e82197975ed2"),
                            Weight = 1,
                            Width = 11
                        },
                        new
                        {
                            Id = new Guid("cda311de-567d-453c-ada2-1b8f935a88e3"),
                            ExpirationDate = new DateOnly(2018, 1, 4),
                            Height = 5,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2017, 9, 26),
                            PalletRecordId = new Guid("dff59e9d-6bc9-4787-93bc-e82197975ed2"),
                            Weight = 4,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("0131de17-de13-4126-a8ee-2aad46ee68fe"),
                            ExpirationDate = new DateOnly(2023, 3, 24),
                            Height = 6,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2022, 12, 14),
                            PalletRecordId = new Guid("dff59e9d-6bc9-4787-93bc-e82197975ed2"),
                            Weight = 6,
                            Width = 12
                        },
                        new
                        {
                            Id = new Guid("49ff0a12-cdee-490a-90c0-41ab08f6ebc2"),
                            ExpirationDate = new DateOnly(2019, 10, 25),
                            Height = 4,
                            Length = 5,
                            ManufacturingDate = new DateOnly(2016, 10, 17),
                            PalletRecordId = new Guid("e4f5d3ea-6858-4ee6-89d4-19b3b27f9919"),
                            Weight = 5,
                            Width = 1
                        },
                        new
                        {
                            Id = new Guid("57b4e37b-5085-4007-97f9-ec843862025b"),
                            ExpirationDate = new DateOnly(2022, 10, 19),
                            Height = 7,
                            Length = 9,
                            ManufacturingDate = new DateOnly(2022, 2, 8),
                            PalletRecordId = new Guid("e4f5d3ea-6858-4ee6-89d4-19b3b27f9919"),
                            Weight = 4,
                            Width = 1
                        },
                        new
                        {
                            Id = new Guid("4b871f5f-6bda-47d1-8b5c-c813df093f55"),
                            ExpirationDate = new DateOnly(2023, 8, 29),
                            Height = 1,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2023, 5, 21),
                            PalletRecordId = new Guid("e4f5d3ea-6858-4ee6-89d4-19b3b27f9919"),
                            Weight = 9,
                            Width = 1
                        },
                        new
                        {
                            Id = new Guid("084d7117-e0d6-4202-858b-eba5a857aad8"),
                            ExpirationDate = new DateOnly(2019, 8, 16),
                            Height = 5,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2019, 5, 8),
                            PalletRecordId = new Guid("e4f5d3ea-6858-4ee6-89d4-19b3b27f9919"),
                            Weight = 3,
                            Width = 1
                        },
                        new
                        {
                            Id = new Guid("6ce8256a-eecc-498e-bfc9-6bf8487bf925"),
                            ExpirationDate = new DateOnly(2017, 1, 13),
                            Height = 9,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2016, 10, 5),
                            PalletRecordId = new Guid("f5a52da6-560f-4c91-b616-327fd7e48e39"),
                            Weight = 6,
                            Width = 9
                        },
                        new
                        {
                            Id = new Guid("d33216ad-d047-43db-8528-40705543b4f1"),
                            ExpirationDate = new DateOnly(2020, 12, 28),
                            Height = 6,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2020, 2, 27),
                            PalletRecordId = new Guid("f5a52da6-560f-4c91-b616-327fd7e48e39"),
                            Weight = 3,
                            Width = 7
                        },
                        new
                        {
                            Id = new Guid("db7cca1b-c2a2-4830-8c3d-99af8b92d694"),
                            ExpirationDate = new DateOnly(2019, 4, 20),
                            Height = 1,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2019, 1, 10),
                            PalletRecordId = new Guid("f5a52da6-560f-4c91-b616-327fd7e48e39"),
                            Weight = 3,
                            Width = 9
                        },
                        new
                        {
                            Id = new Guid("4d4596d7-fc32-45d0-8cd4-d55bf022e18b"),
                            ExpirationDate = new DateOnly(2021, 10, 20),
                            Height = 3,
                            Length = 8,
                            ManufacturingDate = new DateOnly(2021, 6, 10),
                            PalletRecordId = new Guid("70960421-4adf-4aa9-9eb4-cb9c2c87bdab"),
                            Weight = 5,
                            Width = 6
                        },
                        new
                        {
                            Id = new Guid("114bd55d-3aee-4508-a3ce-34f54f488e3a"),
                            ExpirationDate = new DateOnly(2023, 6, 28),
                            Height = 7,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2023, 4, 21),
                            PalletRecordId = new Guid("70960421-4adf-4aa9-9eb4-cb9c2c87bdab"),
                            Weight = 2,
                            Width = 3
                        },
                        new
                        {
                            Id = new Guid("bef8633b-aeaa-46d8-ac44-b394cbb2f676"),
                            ExpirationDate = new DateOnly(2022, 5, 21),
                            Height = 9,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2022, 2, 10),
                            PalletRecordId = new Guid("70960421-4adf-4aa9-9eb4-cb9c2c87bdab"),
                            Weight = 1,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("6387746a-303a-47da-871f-19aefccd686c"),
                            ExpirationDate = new DateOnly(2023, 6, 28),
                            Height = 8,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2023, 3, 20),
                            PalletRecordId = new Guid("94fc4a7d-a7bb-4560-b377-dc15be47e121"),
                            Weight = 2,
                            Width = 5
                        },
                        new
                        {
                            Id = new Guid("4e2a848a-d160-4807-a62d-9f01af816478"),
                            ExpirationDate = new DateOnly(2023, 8, 12),
                            Height = 3,
                            Length = 5,
                            ManufacturingDate = new DateOnly(2021, 4, 1),
                            PalletRecordId = new Guid("94fc4a7d-a7bb-4560-b377-dc15be47e121"),
                            Weight = 9,
                            Width = 1
                        },
                        new
                        {
                            Id = new Guid("8fe51ce6-73bc-4260-a5f6-b5b34213ff78"),
                            ExpirationDate = new DateOnly(2015, 6, 14),
                            Height = 8,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2015, 3, 6),
                            PalletRecordId = new Guid("94fc4a7d-a7bb-4560-b377-dc15be47e121"),
                            Weight = 4,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("76a626cf-5aa1-4963-927d-55cf3e27739a"),
                            ExpirationDate = new DateOnly(2016, 6, 15),
                            Height = 6,
                            Length = 3,
                            ManufacturingDate = new DateOnly(2016, 3, 7),
                            PalletRecordId = new Guid("94fc4a7d-a7bb-4560-b377-dc15be47e121"),
                            Weight = 4,
                            Width = 1
                        },
                        new
                        {
                            Id = new Guid("1ba7b62f-3b27-48b7-ad1a-f0e1556af2a2"),
                            ExpirationDate = new DateOnly(2017, 12, 24),
                            Height = 4,
                            Length = 14,
                            ManufacturingDate = new DateOnly(2015, 7, 19),
                            PalletRecordId = new Guid("4f4c0181-78cf-4376-9557-5a63327a84ee"),
                            Weight = 5,
                            Width = 17
                        },
                        new
                        {
                            Id = new Guid("f9e945c4-f6cf-438c-b745-b5050c002e48"),
                            ExpirationDate = new DateOnly(2018, 12, 24),
                            Height = 8,
                            Length = 8,
                            ManufacturingDate = new DateOnly(2017, 12, 19),
                            PalletRecordId = new Guid("4f4c0181-78cf-4376-9557-5a63327a84ee"),
                            Weight = 2,
                            Width = 9
                        },
                        new
                        {
                            Id = new Guid("ca968e31-5ece-45e9-a1c1-2d71147456ef"),
                            ExpirationDate = new DateOnly(2018, 11, 15),
                            Height = 6,
                            Length = 3,
                            ManufacturingDate = new DateOnly(2015, 8, 5),
                            PalletRecordId = new Guid("32e75c0b-b570-45b3-8254-4221dc9ee36f"),
                            Weight = 5,
                            Width = 8
                        },
                        new
                        {
                            Id = new Guid("faf74c44-c951-4f10-9a86-88bcdf8cd343"),
                            ExpirationDate = new DateOnly(2021, 12, 27),
                            Height = 5,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2021, 10, 25),
                            PalletRecordId = new Guid("32e75c0b-b570-45b3-8254-4221dc9ee36f"),
                            Weight = 7,
                            Width = 3
                        },
                        new
                        {
                            Id = new Guid("3bfeccf6-1289-4a04-b70d-c0c9792140c9"),
                            ExpirationDate = new DateOnly(2019, 9, 16),
                            Height = 6,
                            Length = 8,
                            ManufacturingDate = new DateOnly(2019, 6, 8),
                            PalletRecordId = new Guid("32e75c0b-b570-45b3-8254-4221dc9ee36f"),
                            Weight = 5,
                            Width = 6
                        },
                        new
                        {
                            Id = new Guid("1e7b1df5-d396-4860-8859-9d97cf5a837c"),
                            ExpirationDate = new DateOnly(2022, 6, 12),
                            Height = 1,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2022, 3, 4),
                            PalletRecordId = new Guid("32e75c0b-b570-45b3-8254-4221dc9ee36f"),
                            Weight = 7,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("30463e33-77a6-4d7e-9e10-ebbfd70efd48"),
                            ExpirationDate = new DateOnly(2016, 10, 25),
                            Height = 7,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2016, 7, 17),
                            PalletRecordId = new Guid("4e66b256-7fe4-438c-9b08-ca22fbab178c"),
                            Weight = 8,
                            Width = 1
                        },
                        new
                        {
                            Id = new Guid("e1c45e5c-bec4-413c-89fc-21338e00b339"),
                            ExpirationDate = new DateOnly(2018, 12, 16),
                            Height = 3,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2018, 9, 7),
                            PalletRecordId = new Guid("4e66b256-7fe4-438c-9b08-ca22fbab178c"),
                            Weight = 4,
                            Width = 8
                        },
                        new
                        {
                            Id = new Guid("6705d991-0b55-41c4-89ff-dd665ad49c2d"),
                            ExpirationDate = new DateOnly(2022, 11, 16),
                            Height = 9,
                            Length = 3,
                            ManufacturingDate = new DateOnly(2021, 10, 10),
                            PalletRecordId = new Guid("4e66b256-7fe4-438c-9b08-ca22fbab178c"),
                            Weight = 4,
                            Width = 11
                        },
                        new
                        {
                            Id = new Guid("267fccc8-e58c-411a-9eb6-3f00491ebe57"),
                            ExpirationDate = new DateOnly(2017, 12, 23),
                            Height = 9,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2016, 6, 16),
                            PalletRecordId = new Guid("4e66b256-7fe4-438c-9b08-ca22fbab178c"),
                            Weight = 2,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("16ff25a4-c88a-434b-861e-9dfdadfc1270"),
                            ExpirationDate = new DateOnly(2023, 12, 12),
                            Height = 8,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2019, 5, 10),
                            PalletRecordId = new Guid("3a628309-11e2-40a1-81c4-fe6e072060a9"),
                            Weight = 1,
                            Width = 3
                        },
                        new
                        {
                            Id = new Guid("780e0e72-49d7-45c9-80f4-02f3a525b5da"),
                            ExpirationDate = new DateOnly(2018, 11, 28),
                            Height = 5,
                            Length = 3,
                            ManufacturingDate = new DateOnly(2016, 10, 27),
                            PalletRecordId = new Guid("3a628309-11e2-40a1-81c4-fe6e072060a9"),
                            Weight = 7,
                            Width = 3
                        },
                        new
                        {
                            Id = new Guid("99a73194-3cfc-4221-b35b-05d92adcc6bd"),
                            ExpirationDate = new DateOnly(2021, 11, 23),
                            Height = 4,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2020, 11, 11),
                            PalletRecordId = new Guid("3a628309-11e2-40a1-81c4-fe6e072060a9"),
                            Weight = 9,
                            Width = 4
                        },
                        new
                        {
                            Id = new Guid("f689495b-4246-46ad-8211-7a46c1105495"),
                            ExpirationDate = new DateOnly(2023, 11, 27),
                            Height = 6,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2022, 11, 27),
                            PalletRecordId = new Guid("3a628309-11e2-40a1-81c4-fe6e072060a9"),
                            Weight = 3,
                            Width = 1
                        },
                        new
                        {
                            Id = new Guid("b7506e22-0a20-429e-9778-535eead7519e"),
                            ExpirationDate = new DateOnly(2017, 1, 31),
                            Height = 4,
                            Length = 3,
                            ManufacturingDate = new DateOnly(2016, 10, 23),
                            PalletRecordId = new Guid("932dd1aa-352b-4c8c-a8c8-20dc77b55117"),
                            Weight = 2,
                            Width = 19
                        },
                        new
                        {
                            Id = new Guid("909b9869-b82d-4b5b-9385-c006f665b410"),
                            ExpirationDate = new DateOnly(2023, 10, 17),
                            Height = 9,
                            Length = 2,
                            ManufacturingDate = new DateOnly(2023, 9, 2),
                            PalletRecordId = new Guid("932dd1aa-352b-4c8c-a8c8-20dc77b55117"),
                            Weight = 3,
                            Width = 9
                        },
                        new
                        {
                            Id = new Guid("31bd3b3f-23eb-40fe-ae39-279cf912e253"),
                            ExpirationDate = new DateOnly(2015, 10, 1),
                            Height = 6,
                            Length = 15,
                            ManufacturingDate = new DateOnly(2015, 6, 23),
                            PalletRecordId = new Guid("3588cf03-fec1-4c2c-9f0b-277083a7fc6c"),
                            Weight = 8,
                            Width = 15
                        },
                        new
                        {
                            Id = new Guid("acb7b242-932c-43df-95e7-61a4293d1df4"),
                            ExpirationDate = new DateOnly(2017, 11, 27),
                            Height = 7,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2017, 8, 19),
                            PalletRecordId = new Guid("3588cf03-fec1-4c2c-9f0b-277083a7fc6c"),
                            Weight = 9,
                            Width = 10
                        },
                        new
                        {
                            Id = new Guid("78bba43a-3152-4573-a1ea-fb7fb730e076"),
                            ExpirationDate = new DateOnly(2023, 10, 18),
                            Height = 6,
                            Length = 4,
                            ManufacturingDate = new DateOnly(2020, 3, 7),
                            PalletRecordId = new Guid("6780444e-ae8e-4b7c-ac50-9ba2305ee03e"),
                            Weight = 3,
                            Width = 3
                        },
                        new
                        {
                            Id = new Guid("583c3e19-218c-4334-8d1e-fd4e4ac2e63c"),
                            ExpirationDate = new DateOnly(2015, 8, 12),
                            Height = 2,
                            Length = 1,
                            ManufacturingDate = new DateOnly(2015, 5, 4),
                            PalletRecordId = new Guid("6780444e-ae8e-4b7c-ac50-9ba2305ee03e"),
                            Weight = 3,
                            Width = 2
                        },
                        new
                        {
                            Id = new Guid("9fe4210c-be7a-4386-8759-da581465a5a1"),
                            ExpirationDate = new DateOnly(2015, 11, 18),
                            Height = 5,
                            Length = 5,
                            ManufacturingDate = new DateOnly(2015, 8, 10),
                            PalletRecordId = new Guid("50e3c085-d129-43c3-86a2-af5334d92d13"),
                            Weight = 8,
                            Width = 6
                        },
                        new
                        {
                            Id = new Guid("1aeb2d12-db48-46b3-9450-7a27a6bf5041"),
                            ExpirationDate = new DateOnly(2020, 10, 10),
                            Height = 7,
                            Length = 3,
                            ManufacturingDate = new DateOnly(2019, 9, 1),
                            PalletRecordId = new Guid("f72628da-bb70-4129-a40f-aa2605bb6c44"),
                            Weight = 9,
                            Width = 9
                        },
                        new
                        {
                            Id = new Guid("ffd02d78-da1f-46b7-88f6-3901edd0e381"),
                            ExpirationDate = new DateOnly(2022, 12, 28),
                            Height = 6,
                            Length = 3,
                            ManufacturingDate = new DateOnly(2018, 12, 27),
                            PalletRecordId = new Guid("f72628da-bb70-4129-a40f-aa2605bb6c44"),
                            Weight = 5,
                            Width = 15
                        },
                        new
                        {
                            Id = new Guid("8d267eb2-ea8a-4503-b935-05edfc2ba947"),
                            ExpirationDate = new DateOnly(2023, 2, 10),
                            Height = 2,
                            Length = 7,
                            ManufacturingDate = new DateOnly(2022, 11, 2),
                            PalletRecordId = new Guid("8cd20d80-fc2a-4332-8f13-71a5c69fe94d"),
                            Weight = 7,
                            Width = 13
                        });
                });

            modelBuilder.Entity("Storage.Entities.PalletRecord", b =>
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

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Pallets", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8ab29685-5756-40b9-b076-268b34c2034d"),
                            Height = 25,
                            Length = 23,
                            Weight = 36,
                            Width = 13
                        },
                        new
                        {
                            Id = new Guid("00e176b4-f9f8-48cb-bcf1-87b4a7ef4760"),
                            Height = 12,
                            Length = 12,
                            Weight = 37,
                            Width = 48
                        },
                        new
                        {
                            Id = new Guid("f72af983-abfd-4cea-beb9-5f66d4955dd8"),
                            Height = 24,
                            Length = 30,
                            Weight = 44,
                            Width = 33
                        },
                        new
                        {
                            Id = new Guid("dff59e9d-6bc9-4787-93bc-e82197975ed2"),
                            Height = 46,
                            Length = 12,
                            Weight = 42,
                            Width = 40
                        },
                        new
                        {
                            Id = new Guid("e4f5d3ea-6858-4ee6-89d4-19b3b27f9919"),
                            Height = 13,
                            Length = 40,
                            Weight = 32,
                            Width = 10
                        },
                        new
                        {
                            Id = new Guid("f5a52da6-560f-4c91-b616-327fd7e48e39"),
                            Height = 48,
                            Length = 10,
                            Weight = 35,
                            Width = 31
                        },
                        new
                        {
                            Id = new Guid("70960421-4adf-4aa9-9eb4-cb9c2c87bdab"),
                            Height = 43,
                            Length = 41,
                            Weight = 44,
                            Width = 30
                        },
                        new
                        {
                            Id = new Guid("94fc4a7d-a7bb-4560-b377-dc15be47e121"),
                            Height = 48,
                            Length = 41,
                            Weight = 41,
                            Width = 29
                        },
                        new
                        {
                            Id = new Guid("4f4c0181-78cf-4376-9557-5a63327a84ee"),
                            Height = 44,
                            Length = 37,
                            Weight = 41,
                            Width = 39
                        },
                        new
                        {
                            Id = new Guid("32e75c0b-b570-45b3-8254-4221dc9ee36f"),
                            Height = 47,
                            Length = 46,
                            Weight = 49,
                            Width = 36
                        },
                        new
                        {
                            Id = new Guid("4e66b256-7fe4-438c-9b08-ca22fbab178c"),
                            Height = 35,
                            Length = 32,
                            Weight = 39,
                            Width = 49
                        },
                        new
                        {
                            Id = new Guid("3a628309-11e2-40a1-81c4-fe6e072060a9"),
                            Height = 17,
                            Length = 28,
                            Weight = 39,
                            Width = 24
                        },
                        new
                        {
                            Id = new Guid("932dd1aa-352b-4c8c-a8c8-20dc77b55117"),
                            Height = 45,
                            Length = 18,
                            Weight = 39,
                            Width = 45
                        },
                        new
                        {
                            Id = new Guid("3588cf03-fec1-4c2c-9f0b-277083a7fc6c"),
                            Height = 47,
                            Length = 36,
                            Weight = 46,
                            Width = 34
                        },
                        new
                        {
                            Id = new Guid("6780444e-ae8e-4b7c-ac50-9ba2305ee03e"),
                            Height = 30,
                            Length = 31,
                            Weight = 35,
                            Width = 17
                        },
                        new
                        {
                            Id = new Guid("50e3c085-d129-43c3-86a2-af5334d92d13"),
                            Height = 26,
                            Length = 11,
                            Weight = 33,
                            Width = 10
                        },
                        new
                        {
                            Id = new Guid("f72628da-bb70-4129-a40f-aa2605bb6c44"),
                            Height = 36,
                            Length = 20,
                            Weight = 33,
                            Width = 32
                        },
                        new
                        {
                            Id = new Guid("8cd20d80-fc2a-4332-8f13-71a5c69fe94d"),
                            Height = 14,
                            Length = 12,
                            Weight = 31,
                            Width = 31
                        });
                });

            modelBuilder.Entity("Storage.Entities.BoxRecord", b =>
                {
                    b.HasOne("Storage.Entities.PalletRecord", null)
                        .WithMany("Boxes")
                        .HasForeignKey("PalletRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Storage.Entities.PalletRecord", b =>
                {
                    b.Navigation("Boxes");
                });
#pragma warning restore 612, 618
        }
    }
}