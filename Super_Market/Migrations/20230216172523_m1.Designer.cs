﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Super_Market;

#nullable disable

namespace Super_Market.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230216172523_m1")]
    partial class m1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Super_Market.Categorys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StorId");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("Super_Market.Proudect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategorysId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PurchasingPrice")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ReciptId")
                        .HasColumnType("int");

                    b.Property<double>("SellingPrice")
                        .HasColumnType("float");

                    b.Property<int>("Sellinvoceid")
                        .HasColumnType("int");

                    b.Property<int>("Suppliersid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategorysId");

                    b.HasIndex("ReciptId");

                    b.HasIndex("Sellinvoceid");

                    b.HasIndex("Suppliersid");

                    b.ToTable("proudcts");
                });

            modelBuilder.Entity("Super_Market.Recipt", b =>
                {
                    b.Property<int>("bon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bon"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SuppliersId")
                        .HasColumnType("int");

                    b.HasKey("bon");

                    b.HasIndex("SuppliersId");

                    b.ToTable("recipts");
                });

            modelBuilder.Entity("Super_Market.Sellinvoce", b =>
                {
                    b.Property<int>("BonNumberr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BonNumberr"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("PaidMoney")
                        .HasColumnType("float");

                    b.Property<double>("RemainingMoney")
                        .HasColumnType("float");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.Property<string>("casherUserNameUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BonNumberr");

                    b.HasIndex("casherUserNameUserName");

                    b.ToTable("sellinvoces");
                });

            modelBuilder.Entity("Super_Market.Stor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stors");
                });

            modelBuilder.Entity("Super_Market.Suppliers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("suppliers");
                });

            modelBuilder.Entity("Super_Market.Users", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Password")
                        .HasColumnType("int");

                    b.Property<int>("Pos")
                        .HasColumnType("int");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.HasKey("UserName");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Super_Market.Categorys", b =>
                {
                    b.HasOne("Super_Market.Stor", "objstor")
                        .WithMany("Categories")
                        .HasForeignKey("StorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("objstor");
                });

            modelBuilder.Entity("Super_Market.Proudect", b =>
                {
                    b.HasOne("Super_Market.Categorys", "category")
                        .WithMany("Products")
                        .HasForeignKey("CategorysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Super_Market.Recipt", "recipt")
                        .WithMany("products")
                        .HasForeignKey("ReciptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Super_Market.Sellinvoce", "sellinvoce")
                        .WithMany("Products")
                        .HasForeignKey("Sellinvoceid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Super_Market.Suppliers", "supplier")
                        .WithMany("products")
                        .HasForeignKey("Suppliersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("recipt");

                    b.Navigation("sellinvoce");

                    b.Navigation("supplier");
                });

            modelBuilder.Entity("Super_Market.Recipt", b =>
                {
                    b.HasOne("Super_Market.Suppliers", "supplier")
                        .WithMany("recipts")
                        .HasForeignKey("SuppliersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("supplier");
                });

            modelBuilder.Entity("Super_Market.Sellinvoce", b =>
                {
                    b.HasOne("Super_Market.Users", "casherUserName")
                        .WithMany("Sellinvos")
                        .HasForeignKey("casherUserNameUserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("casherUserName");
                });

            modelBuilder.Entity("Super_Market.Categorys", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Super_Market.Recipt", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("Super_Market.Sellinvoce", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Super_Market.Stor", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Super_Market.Suppliers", b =>
                {
                    b.Navigation("products");

                    b.Navigation("recipts");
                });

            modelBuilder.Entity("Super_Market.Users", b =>
                {
                    b.Navigation("Sellinvos");
                });
#pragma warning restore 612, 618
        }
    }
}
