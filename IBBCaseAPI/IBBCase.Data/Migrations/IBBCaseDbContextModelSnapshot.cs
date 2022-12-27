﻿// <auto-generated />
using IBBCase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IBBCase.Data.Migrations
{
    [DbContext(typeof(IBBCaseDbContext))]
    partial class IBBCaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IBBCase.Entities.CarPark", b =>
                {
                    b.Property<int>("CarParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarParkId"), 1L, 1);

                    b.Property<int>("CAPACITY_OF_PARK")
                        .HasColumnType("int");

                    b.Property<string>("COUNTY_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LATITUDE")
                        .HasColumnType("float");

                    b.Property<string>("LOCATION_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LONGITUDE")
                        .HasColumnType("float");

                    b.Property<string>("PARK_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PARK_TYPE_DESC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PARK_TYPE_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WORKING_TIME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("_id")
                        .HasColumnType("int");

                    b.HasKey("CarParkId");

                    b.ToTable("CarParks");

                    b.HasData(
                        new
                        {
                            CarParkId = 1,
                            CAPACITY_OF_PARK = 30,
                            COUNTY_NAME = "ŞİŞLİ",
                            LATITUDE = 41.048823356915499,
                            LOCATION_NAME = "Şişli Vali Konağı Caddes",
                            LONGITUDE = 28.987974944131899,
                            PARK_NAME = "Vali Konağı Caddesi 1",
                            PARK_TYPE_DESC = "YOL ÜSTÜ",
                            PARK_TYPE_ID = "YOL ÜSTÜ",
                            WORKING_TIME = "08:00-19:00",
                            _id = 1
                        },
                        new
                        {
                            CarParkId = 2,
                            CAPACITY_OF_PARK = 50,
                            COUNTY_NAME = "ŞİŞLİ",
                            LATITUDE = 41.049523298771703,
                            LOCATION_NAME = "Şişli Şakayık Soka",
                            LONGITUDE = 28.995565605244401,
                            PARK_NAME = "Şakayık Sokak 1",
                            PARK_TYPE_DESC = "YOL ÜSTÜ",
                            PARK_TYPE_ID = "YOL ÜSTÜ",
                            WORKING_TIME = "08:00-19:00",
                            _id = 2
                        },
                        new
                        {
                            CarParkId = 3,
                            CAPACITY_OF_PARK = 50,
                            COUNTY_NAME = "ŞİŞLİ",
                            LATITUDE = 41.048389540642198,
                            LOCATION_NAME = "Şişli Hüsrev Gerede Caddes",
                            LONGITUDE = 28.994975578169999,
                            PARK_NAME = "Hüsrev Gerede Sokak 1",
                            PARK_TYPE_DESC = "YOL ÜSTÜ",
                            PARK_TYPE_ID = "YOL ÜSTÜ",
                            WORKING_TIME = "08:00-19:00",
                            _id = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
