﻿// <auto-generated />
using IMS_Microservices.Services.UserAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IMS_Microservices.Services.UserAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("IMS_Microservices.Services.UserAPI.Models.IMSEmployee", b =>
                {
                    b.Property<int>("employeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("employeeID"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("employeeID");

                    b.ToTable("IMSEmployees");

                    b.HasData(
                        new
                        {
                            employeeID = 1,
                            email = "abc@xyz.com",
                            firstName = "Hasibul",
                            lastName = "Hassan",
                            password = "123456",
                            phone = "0123456789"
                        },
                        new
                        {
                            employeeID = 2,
                            email = "def@xyz.com",
                            firstName = "Sharmin",
                            lastName = "Akter",
                            password = "147852",
                            phone = "01122334455"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
