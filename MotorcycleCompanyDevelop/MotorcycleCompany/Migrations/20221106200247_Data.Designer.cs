﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace MotorcycleCompany.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20221106200247_Data")]
    partial class Data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Entities.Models.Agency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AgencyId");

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Poblation")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Agencias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Direction = "Calle del recuerdo",
                            Name = "Kevin",
                            Poblation = "Santa Barbara"
                        },
                        new
                        {
                            Id = 2,
                            Direction = "Calle de la soledad",
                            Name = "Jose",
                            Poblation = "Santa Ana"
                        });
                });

            modelBuilder.Entity("Entities.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Ciudad");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kevin",
                            Population = 1000,
                            Province = "Kennedy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Jose",
                            Population = 10000,
                            Province = "Guateque"
                        });
                });

            modelBuilder.Entity("Entities.Models.Client", b =>
                {
                    b.Property<string>("DNI")
                        .HasMaxLength(9)
                        .HasColumnType("varchar(9)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("SecondSurname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("DNI");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            DNI = "1049794204",
                            City = "Bogota",
                            Direction = "cr 82 #42 f 56 sur",
                            Name = "Kevin",
                            Phone = "3219250893",
                            SecondSurname = "Ramirez",
                            Surname = "Moreno"
                        },
                        new
                        {
                            DNI = "23622563",
                            City = "Guateque",
                            Direction = "calle 13 #4-37",
                            Name = "Luz",
                            Phone = "3145463634",
                            SecondSurname = "Sayns",
                            Surname = "Banish"
                        });
                });

            modelBuilder.Entity("Entities.Models.Garage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdCity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Num")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("IdCity");

                    b.ToTable("Garaje");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdCity = 1,
                            Name = "Kevin",
                            Num = 123,
                            Street = "cr 82 #42 f 56 sur"
                        },
                        new
                        {
                            Id = 2,
                            IdCity = 2,
                            Name = "Jose",
                            Num = 456,
                            Street = "cr 82 #42 f 56 sur"
                        });
                });

            modelBuilder.Entity("Entities.Models.Motorcycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdAgency")
                        .HasColumnType("int");

                    b.Property<int>("IdGarage")
                        .HasColumnType("int");

                    b.Property<int>("Num")
                        .HasColumnType("int");

                    b.Property<string>("NumBast")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("IdAgency");

                    b.HasIndex("IdGarage");

                    b.ToTable("Motocicleta");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Ferrari",
                            Color = "Blue",
                            Date = new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            IdAgency = 1,
                            IdGarage = 1,
                            Num = 123,
                            NumBast = "White",
                            Street = "Griislong",
                            model = "C-666"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Supra",
                            Color = "Red",
                            Date = new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            IdAgency = 2,
                            IdGarage = 2,
                            Num = 345,
                            NumBast = "Dark",
                            Street = "Smile",
                            model = "Z-333"
                        });
                });

            modelBuilder.Entity("Entities.Models.Phones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdAgency")
                        .HasColumnType("int");

                    b.Property<string>("phone")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("IdAgency");

                    b.ToTable("Celular");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdAgency = 1,
                            phone = "3219250893"
                        },
                        new
                        {
                            Id = 2,
                            IdAgency = 2,
                            phone = "3514567895"
                        });
                });

            modelBuilder.Entity("Entities.Models.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DNIClient")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar(9)");

                    b.Property<int>("IdAgency")
                        .HasColumnType("int");

                    b.Property<int>("IdMotorcycle")
                        .HasColumnType("int");

                    b.Property<string>("Paidout")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateF")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("dateI")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("dateR")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DNIClient");

                    b.HasIndex("IdAgency");

                    b.HasIndex("IdMotorcycle");

                    b.ToTable("Renta");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DNIClient = "1049794204",
                            IdAgency = 1,
                            IdMotorcycle = 1,
                            Paidout = "Yes",
                            Price = 1000,
                            dateF = new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            dateI = new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            dateR = new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            DNIClient = "23622563",
                            IdAgency = 2,
                            IdMotorcycle = 2,
                            Paidout = "No",
                            Price = 2000,
                            dateF = new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            dateI = new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            dateR = new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("Entities.Models.Garage", b =>
                {
                    b.HasOne("Entities.Models.City", "Garaje")
                        .WithMany("Garage_City")
                        .HasForeignKey("IdCity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Garaje");
                });

            modelBuilder.Entity("Entities.Models.Motorcycle", b =>
                {
                    b.HasOne("Entities.Models.Agency", "Agencia")
                        .WithMany("Motorcycle_Agency")
                        .HasForeignKey("IdAgency")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Garage", "Garaje")
                        .WithMany("Motorcycle_Garage")
                        .HasForeignKey("IdGarage")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agencia");

                    b.Navigation("Garaje");
                });

            modelBuilder.Entity("Entities.Models.Phones", b =>
                {
                    b.HasOne("Entities.Models.Agency", "Agencia")
                        .WithMany("Phones_Agency")
                        .HasForeignKey("IdAgency")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agencia");
                });

            modelBuilder.Entity("Entities.Models.Rent", b =>
                {
                    b.HasOne("Entities.Models.Client", "Cliente")
                        .WithMany("Rents_Client")
                        .HasForeignKey("DNIClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Agency", "Agencia")
                        .WithMany("Rents_Agency")
                        .HasForeignKey("IdAgency")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Motorcycle", "motocicleta")
                        .WithMany("Rents_Motorcycle")
                        .HasForeignKey("IdMotorcycle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agencia");

                    b.Navigation("Cliente");

                    b.Navigation("motocicleta");
                });

            modelBuilder.Entity("Entities.Models.Agency", b =>
                {
                    b.Navigation("Motorcycle_Agency");

                    b.Navigation("Phones_Agency");

                    b.Navigation("Rents_Agency");
                });

            modelBuilder.Entity("Entities.Models.City", b =>
                {
                    b.Navigation("Garage_City");
                });

            modelBuilder.Entity("Entities.Models.Client", b =>
                {
                    b.Navigation("Rents_Client");
                });

            modelBuilder.Entity("Entities.Models.Garage", b =>
                {
                    b.Navigation("Motorcycle_Garage");
                });

            modelBuilder.Entity("Entities.Models.Motorcycle", b =>
                {
                    b.Navigation("Rents_Motorcycle");
                });
#pragma warning restore 612, 618
        }
    }
}
