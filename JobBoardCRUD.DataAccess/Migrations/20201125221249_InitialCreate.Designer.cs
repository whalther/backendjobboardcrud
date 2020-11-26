﻿// <auto-generated />
using System;
using JobBoardCRUD.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JobBoardCRUD.DataAccess.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20201125221249_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("JobBoardCRUD.DataAccess.Models.Tables.Pruebatl", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<DateTime?>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("renderOption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tieneImagen")
                        .HasColumnType("int");

                    b.Property<int?>("tieneTextoAnalisis")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Pruebatl");
                });
#pragma warning restore 612, 618
        }
    }
}
