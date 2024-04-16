﻿// <auto-generated />
using System;
using BleebosBistro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BleebosBistro.Migrations
{
    [DbContext(typeof(BleebosBistroDbContext))]
    [Migration("20240403133536_JCS-Payment")]
    partial class JCSPayment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BleebosBistro.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTULR06hbIXK3efBfwg0eJon8_z9CcU7srRmQqL-gRglQ&s",
                            Name = "Shrugbo",
                            Price = 100m
                        },
                        new
                        {
                            Id = 102,
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSrh1BIMheVzZsb7AUHvPlGo9QTSKdSvLPLFw&s",
                            Name = "Trenboodoo",
                            Price = 150m
                        },
                        new
                        {
                            Id = 103,
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8iROIB-DTfaO0Tzke6ErgcaBR6V10C3xfEw&s",
                            Name = "Salad",
                            Price = 50m
                        });
                });

            modelBuilder.Entity("BleebosBistro.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isClosed")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Subtotal")
                        .HasColumnType("integer");

                    b.Property<int>("Tip")
                        .HasColumnType("integer");

                    b.Property<int>("Total")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            Date = new DateTime(2024, 4, 3, 8, 35, 36, 536, DateTimeKind.Local).AddTicks(9341),
                            Email = "gertyherdy@example.com",
                            FirstName = "Darbin",
                            Image = "https://i.ibb.co/kqvY0KX/Bleebos-Bistro-Order2.png",
                            isClosed = true,
                            LastName = "Glowbone",
                            PaymentType = "Credit",
                            Subtotal = 2000,
                            Tip = 300,
                            Total = 2300
                        },
                        new
                        {
                            Id = 1002,
                            Date = new DateTime(2024, 4, 2, 8, 35, 36, 536, DateTimeKind.Local).AddTicks(9380),
                            Email = "goober@example.com",
                            FirstName = "Phil",
                            Image = "https://i.ibb.co/kqvY0KX/Bleebos-Bistro-Order2.png",
                            isClosed = false,
                            LastName = "Doctor",
                            PaymentType = "Cash",
                            Subtotal = 1500,
                            Tip = 200,
                            Total = 1700
                        });
                });

            modelBuilder.Entity("BleebosBistro.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IsColleague")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Username")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "https://avatarfiles.alphacoders.com/113/113469.jpg",
                            IsColleague = "Yes",
                            Uid = "WFKkg9zIyfT36VTlUrxbLXhknJV2",
                            Username = 200201
                        },
                        new
                        {
                            Id = 2,
                            Image = "https://imagedelivery.net/9sCnq8t6WEGNay0RAQNdvQ/UUID-cl9g4rv6p4471q8nfruthlmio/public",
                            IsColleague = "No",
                            Uid = "WFKkg9zIyfT36VTlUrxbLXhknJV3",
                            Username = 200202
                        });
                });

            modelBuilder.Entity("ItemOrder", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("integer");

                    b.Property<int>("OrdersId")
                        .HasColumnType("integer");

                    b.HasKey("ItemsId", "OrdersId");

                    b.HasIndex("OrdersId");

                    b.ToTable("ItemOrder");
                });

            modelBuilder.Entity("ItemOrder", b =>
                {
                    b.HasOne("BleebosBistro.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BleebosBistro.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
