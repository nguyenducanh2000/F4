﻿// <auto-generated />
using System;
using Framework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Framework.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201128101446_AddData1ToDb")]
    partial class AddData1ToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Framework.Models.Account", b =>
                {
                    b.Property<int>("ADMIN_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MARK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("PASSWD")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("USERNAME")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("ADMIN_ID");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            ADMIN_ID = 7,
                            MARK = 0,
                            PASSWD = "123",
                            USERNAME = "ducanhdeptraivodichvutru"
                        });
                });

            modelBuilder.Entity("Framework.Models.Category", b =>
                {
                    b.Property<int>("CATE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CATE_DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CATE_IMG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CATE_NAME")
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<int>("MARK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("CATE_ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CATE_ID = 1,
                            CATE_DESCRIPTION = "Gồm nhiều chất xơ và vitamin hỗ trợ giảm cân",
                            CATE_IMG = "https://ibb.co/XF73tQf",
                            CATE_NAME = "Món rau"
                        },
                        new
                        {
                            CATE_ID = 2,
                            CATE_DESCRIPTION = "Gồm nhiều vitamin và dưỡng chất",
                            CATE_IMG = "https://ibb.co/Gc11tnM",
                            CATE_NAME = "Trái cây"
                        });
                });

            modelBuilder.Entity("Framework.Models.Discount_Code", b =>
                {
                    b.Property<string>("CODE_ID")
                        .HasMaxLength(15)
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("CODE_NAME")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<int>("MARK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<int>("PERCENTS")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("CODE_ID");

                    b.ToTable("Discounts");

                    b.HasData(
                        new
                        {
                            CODE_ID = "BLACKFRIDAY",
                            CODE_NAME = "Thứ sáu đen tối",
                            MARK = 1,
                            PERCENTS = 50
                        });
                });

            modelBuilder.Entity("Framework.Models.Menu", b =>
                {
                    b.Property<int>("MENU_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("CALORIES")
                        .HasColumnType("real");

                    b.Property<int?>("CATE_ID")
                        .HasColumnType("int");

                    b.Property<int>("MARK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("MENU_DESCRIPTION")
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("MENU_IMG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MENU_NAME")
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<decimal>("MENU_PRICE")
                        .HasColumnType("money");

                    b.Property<int>("MENU_SIZE")
                        .HasColumnType("int");

                    b.HasKey("MENU_ID");

                    b.HasIndex("CATE_ID");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            MENU_ID = 1,
                            CALORIES = 50f,
                            CATE_ID = 4,
                            MENU_DESCRIPTION = "1 cây xà lách, 1/2 trái dưa leo, 2 trái cà chua",
                            MENU_IMG = "https://picsum.photos/200",
                            MENU_NAME = "Rau trộn",
                            MENU_PRICE = 20000m,
                            MENU_SIZE = 1
                        },
                        new
                        {
                            MENU_ID = 2,
                            CALORIES = 50f,
                            CATE_ID = 4,
                            MENU_DESCRIPTION = "2 cây xà lách, 1 trái dưa leo, 4 trái cà chua",
                            MENU_IMG = "https://picsum.photos/200",
                            MENU_NAME = "Rau trộn",
                            MENU_PRICE = 10000m,
                            MENU_SIZE = 2
                        },
                        new
                        {
                            MENU_ID = 3,
                            CALORIES = 50f,
                            CATE_ID = 4,
                            MENU_DESCRIPTION = "1/2 kg rau muống",
                            MENU_IMG = "https://picsum.photos/200",
                            MENU_NAME = "Rau luộc",
                            MENU_PRICE = 20000m,
                            MENU_SIZE = 1
                        },
                        new
                        {
                            MENU_ID = 4,
                            CALORIES = 50f,
                            CATE_ID = 4,
                            MENU_DESCRIPTION = "1 kg rau muống",
                            MENU_IMG = "https://picsum.photos/200",
                            MENU_NAME = "Rau luộc",
                            MENU_PRICE = 10000m,
                            MENU_SIZE = 2
                        },
                        new
                        {
                            MENU_ID = 5,
                            CALORIES = 50f,
                            CATE_ID = 5,
                            MENU_DESCRIPTION = "trái cây",
                            MENU_IMG = "https://picsum.photos/200",
                            MENU_NAME = "Trái cây tô",
                            MENU_PRICE = 30000m,
                            MENU_SIZE = 1
                        },
                        new
                        {
                            MENU_ID = 6,
                            CALORIES = 50f,
                            CATE_ID = 5,
                            MENU_DESCRIPTION = "trái cây",
                            MENU_IMG = "https://picsum.photos/200",
                            MENU_NAME = "Trái cây tô",
                            MENU_PRICE = 50000m,
                            MENU_SIZE = 2
                        },
                        new
                        {
                            MENU_ID = 7,
                            CALORIES = 50f,
                            CATE_ID = 5,
                            MENU_DESCRIPTION = "trái cây",
                            MENU_IMG = "https://picsum.photos/200",
                            MENU_NAME = "Trái cây tô",
                            MENU_PRICE = 79000m,
                            MENU_SIZE = 3
                        },
                        new
                        {
                            MENU_ID = 8,
                            CALORIES = 250f,
                            CATE_ID = 4,
                            MENU_DESCRIPTION = "1 bơ",
                            MENU_IMG = "https://picsum.photos/200",
                            MENU_NAME = "Sinh tố bơ",
                            MENU_PRICE = 25000m,
                            MENU_SIZE = 1
                        },
                        new
                        {
                            MENU_ID = 9,
                            CALORIES = 250f,
                            CATE_ID = 4,
                            MENU_DESCRIPTION = "2 bơ",
                            MENU_IMG = "https://picsum.photos/200",
                            MENU_NAME = "Sinh tố bơ",
                            MENU_PRICE = 30000m,
                            MENU_SIZE = 2
                        },
                        new
                        {
                            MENU_ID = 10,
                            CALORIES = 250f,
                            CATE_ID = 4,
                            MENU_DESCRIPTION = "3 bơ",
                            MENU_IMG = "https://picsum.photos/200",
                            MENU_NAME = "Sinh tố bơ",
                            MENU_PRICE = 35000m,
                            MENU_SIZE = 3
                        });
                });

            modelBuilder.Entity("Framework.Models.Order_Detail", b =>
                {
                    b.Property<int?>("ORDER_ID")
                        .HasColumnType("int");

                    b.Property<int?>("MENU_ID")
                        .HasColumnType("int");

                    b.Property<int>("AMOUNT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("CODE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("VARCHAR(15)")
                        .HasDefaultValue("null");

                    b.Property<int>("MARK")
                        .HasColumnType("int");

                    b.HasKey("ORDER_ID", "MENU_ID");

                    b.HasIndex("CODE_ID");

                    b.HasIndex("MENU_ID");

                    b.ToTable("Order_Details");
                });

            modelBuilder.Entity("Framework.Models.Orders", b =>
                {
                    b.Property<int>("ORDER_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ADDRESS")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<int>("DELIVERED")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<int>("ORDER_DATE")
                        .HasColumnType("int");

                    b.Property<int>("PAYMENT_TYPE")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("PHONE")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("VARCHAR(10)");

                    b.Property<int>("RECEIVED")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<decimal>("TOTAL_PRICE")
                        .HasColumnType("money");

                    b.HasKey("ORDER_ID");

                    b.ToTable("Oders");
                });

            modelBuilder.Entity("Framework.Models.Menu", b =>
                {
                    b.HasOne("Framework.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("CATE_ID");

                    b.Navigation("category");
                });

            modelBuilder.Entity("Framework.Models.Order_Detail", b =>
                {
                    b.HasOne("Framework.Models.Discount_Code", "Discount")
                        .WithMany()
                        .HasForeignKey("CODE_ID");

                    b.HasOne("Framework.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MENU_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Framework.Models.Orders", "Order")
                        .WithMany()
                        .HasForeignKey("ORDER_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discount");

                    b.Navigation("Menu");

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}