﻿// <auto-generated />
using System;
using ClothesShop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClothesShop.Infrastructure.Migrations
{
    [DbContext(typeof(ClothesShopDbContext))]
    [Migration("20241124122308_ChangePriceToIntTest")]
    partial class ChangePriceToIntTest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClothesShop.Domain.Entities.ClothesShop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EncodedBrand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClothesShop");
                });

            modelBuilder.Entity("ClothesShop.Domain.Entities.ClothesShop", b =>
                {
                    b.OwnsOne("ClothesShop.Domain.Entities.ClothesShopItemDetails", "ItemDetails", b1 =>
                        {
                            b1.Property<int>("ClothesShopId")
                                .HasColumnType("int");

                            b1.Property<string>("Colour")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Price")
                                .HasColumnType("int");

                            b1.Property<string>("Size")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ClothesShopId");

                            b1.ToTable("ClothesShop");

                            b1.WithOwner()
                                .HasForeignKey("ClothesShopId");
                        });

                    b.Navigation("ItemDetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
