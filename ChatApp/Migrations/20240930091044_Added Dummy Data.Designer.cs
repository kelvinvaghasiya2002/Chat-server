﻿// <auto-generated />
using ChatApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChatApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240930091044_Added Dummy Data")]
    partial class AddedDummyData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChatApp.Models.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "a@a.a",
                            Name = "Kelvin",
                            salary = 20000m
                        },
                        new
                        {
                            Id = 2,
                            Email = "b@b.b",
                            Name = "Surya",
                            salary = 30000m
                        },
                        new
                        {
                            Id = 3,
                            Email = "c@c.c",
                            Name = "Xyz",
                            salary = 40000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
