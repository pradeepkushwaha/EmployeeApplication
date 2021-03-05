﻿// <auto-generated />
using System;
using EmployeeApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeApp.API.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("employment_end_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("employment_start_date")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1L,
                            DateOfBirth = new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "IT",
                            Email = "uncle.bob@gmail.com",
                            First_name = "Uncle",
                            Gender = "male",
                            Job_title = "Solution architect",
                            Last_name = "Bob",
                            Phone_number = "999-888-7777",
                            employment_end_date = new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            employment_start_date = new DateTime(2017, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 2L,
                            DateOfBirth = new DateTime(1981, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "IT",
                            Email = "jan.kirsten@gmail.com",
                            First_name = "Jan",
                            Gender = "male",
                            Job_title = "Solution architect",
                            Last_name = "Kirsten",
                            Phone_number = "111-888-7777",
                            employment_end_date = new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            employment_start_date = new DateTime(2016, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 3L,
                            DateOfBirth = new DateTime(1982, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "IT",
                            Email = "James.Smith@gmail.com",
                            First_name = "James",
                            Gender = "male",
                            Job_title = "Technical architect",
                            Last_name = "Smith",
                            Phone_number = "111-555-7777",
                            employment_end_date = new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            employment_start_date = new DateTime(2018, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 4L,
                            DateOfBirth = new DateTime(1986, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "IT",
                            Email = "Selina.Chun@gmail.com",
                            First_name = "Selina",
                            Gender = "female",
                            Job_title = "Business Analyst",
                            Last_name = "Chun",
                            Phone_number = "111-555-5555",
                            employment_end_date = new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            employment_start_date = new DateTime(2018, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 5L,
                            DateOfBirth = new DateTime(1985, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "IT",
                            Email = "Tracie.Chun@gmail.com",
                            First_name = "Tracie",
                            Gender = "female",
                            Job_title = "Business Analyst",
                            Last_name = "Chun",
                            Phone_number = "2222-888-5555",
                            employment_end_date = new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            employment_start_date = new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
