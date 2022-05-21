﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.DataAccess;

namespace WebAPI.Migrations
{
    [DbContext(typeof(KinderGartenContext))]
    [Migration("20220110090500_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Data.Child", b =>
                {
                    b.Property<int>("Age")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasMaxLength(6);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Age");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("Data.Toy", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<int?>("ChildOwnerOfToyAge")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.Property<string>("Condition")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.HasIndex("ChildOwnerOfToyAge");

                    b.ToTable("Toys");
                });

            modelBuilder.Entity("Data.Toy", b =>
                {
                    b.HasOne("Data.Child", "ChildOwnerOfToy")
                        .WithMany()
                        .HasForeignKey("ChildOwnerOfToyAge");
                });
#pragma warning restore 612, 618
        }
    }
}