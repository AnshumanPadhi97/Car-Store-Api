﻿// <auto-generated />
using CARS_Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CARS_Api.Migrations
{
    [DbContext(typeof(CarsDataContext))]
    partial class CarsDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CARS_Api.Data.CarsModel", b =>
                {
                    b.Property<int>("car_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("car_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("car_model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("car_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("car_price")
                        .HasColumnType("int");

                    b.HasKey("car_id");

                    b.ToTable("CarsTable");
                });
#pragma warning restore 612, 618
        }
    }
}
