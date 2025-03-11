﻿// <auto-generated />
using System;
using InfrastructureLayer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InfrastructureLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250311004450_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DomainLayer.Models.Attendance.AttendanceModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint");

                    b.Property<TimeOnly>("TimeIn")
                        .HasColumnType("time");

                    b.Property<TimeOnly?>("TimeOut")
                        .HasColumnType("time");

                    b.Property<byte>("TotalHours")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeModelId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("DomainLayer.Models.Department.DepartmentModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DomainLayer.Models.Employee.EmployeeModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("BasicDailyRate")
                        .HasColumnType("money");

                    b.Property<DateOnly>("BirthDay")
                        .HasColumnType("date");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("EmploymentDate")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte>("LeaveCredits")
                        .HasColumnType("tinyint");

                    b.Property<string>("MiddleInitial")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DomainLayer.Models.Leave.LeaveModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("DateOfAbsence")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DateOfFiling")
                        .HasColumnType("date");

                    b.Property<short>("Duration")
                        .HasColumnType("smallint");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeModelId");

                    b.ToTable("Leaves");
                });

            modelBuilder.Entity("DomainLayer.Models.NewUserRequest.NewUserRequestModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("DateOfRequest")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("binary(32)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("binary(32)");

                    b.Property<TimeOnly>("TimeOfRequest")
                        .HasColumnType("time");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("NewUserRequests");
                });

            modelBuilder.Entity("DomainLayer.Models.Role.RoleModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DomainLayer.Models.Salary.SalaryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("Days")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("DaysAmount")
                        .HasColumnType("money");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("Nights")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("NightsAmount")
                        .HasColumnType("money");

                    b.Property<byte>("NightsOT")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("NightsOTAmount")
                        .HasColumnType("money");

                    b.Property<DateOnly>("PayDay")
                        .HasColumnType("date");

                    b.Property<byte>("RegularOT")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("RegularOTAmount")
                        .HasColumnType("money");

                    b.Property<decimal>("TotalBasic")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeModelId");

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("DomainLayer.Models.User.UserModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("binary(32)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("binary(32)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DomainLayer.Models.Attendance.AttendanceModel", b =>
                {
                    b.HasOne("DomainLayer.Models.Employee.EmployeeModel", null)
                        .WithMany("Attendances")
                        .HasForeignKey("EmployeeModelId");
                });

            modelBuilder.Entity("DomainLayer.Models.Employee.EmployeeModel", b =>
                {
                    b.HasOne("DomainLayer.Models.Department.DepartmentModel", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DomainLayer.Models.Leave.LeaveModel", b =>
                {
                    b.HasOne("DomainLayer.Models.Employee.EmployeeModel", null)
                        .WithMany("Leaves")
                        .HasForeignKey("EmployeeModelId");
                });

            modelBuilder.Entity("DomainLayer.Models.Salary.SalaryModel", b =>
                {
                    b.HasOne("DomainLayer.Models.Employee.EmployeeModel", null)
                        .WithMany("Salaries")
                        .HasForeignKey("EmployeeModelId");
                });

            modelBuilder.Entity("DomainLayer.Models.User.UserModel", b =>
                {
                    b.HasOne("DomainLayer.Models.Role.RoleModel", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DomainLayer.Models.Department.DepartmentModel", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DomainLayer.Models.Employee.EmployeeModel", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Leaves");

                    b.Navigation("Salaries");
                });

            modelBuilder.Entity("DomainLayer.Models.Role.RoleModel", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
