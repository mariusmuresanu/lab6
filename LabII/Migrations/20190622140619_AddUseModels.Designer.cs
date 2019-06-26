﻿// <auto-generated />
using System;
using LabII.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LabII.Migrations
{
    [DbContext(typeof(ExpensesDbContext))]
    [Migration("20190622140619_AddUseModels")]
    partial class AddUseModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LabII.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ExpenseId");

                    b.Property<bool>("Important");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("ExpenseId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("LabII.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Currency");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Location");

                    b.Property<double>("Sum");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("LabII.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LabII.Models.Comment", b =>
                {
                    b.HasOne("LabII.Models.Expense")
                        .WithMany("Comments")
                        .HasForeignKey("ExpenseId");
                });
#pragma warning restore 612, 618
        }
    }
}
