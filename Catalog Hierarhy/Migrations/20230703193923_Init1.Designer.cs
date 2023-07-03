﻿// <auto-generated />
using System;
using Catalog_Hierarhy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Catalog_Hierarhy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230703193923_Init1")]
    partial class Init1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("Catalog_Hierarhy.Models.Catalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ParentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Catalogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Creating Digital Images"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Resources",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Evidence",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Graphic Products",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Primary Sources",
                            ParentId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Secondary Sources",
                            ParentId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Process",
                            ParentId = 4
                        },
                        new
                        {
                            Id = 8,
                            Name = "Final Product",
                            ParentId = 4
                        });
                });

            modelBuilder.Entity("Catalog_Hierarhy.Models.Catalog", b =>
                {
                    b.HasOne("Catalog_Hierarhy.Models.Catalog", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Catalog_Hierarhy.Models.Catalog", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}