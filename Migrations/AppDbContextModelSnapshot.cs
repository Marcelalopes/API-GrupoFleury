﻿// <auto-generated />
using System;
using API_GrupoFleury.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_GrupoFleury.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("API_GrupoFleury.models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.HasKey("Id")
                        .HasName("Pk_AddressId");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("API_GrupoFleury.models.Client", b =>
                {
                    b.Property<string>("Cpf")
                        .HasColumnType("varchar(255)");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(11)");

                    b.Property<bool>("isDesable")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Cpf")
                        .HasName("Pk_ClientCpf");

                    b.HasIndex("AddressId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("API_GrupoFleury.models.Exam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<double>("Price")
                        .HasPrecision(4, 2)
                        .HasColumnType("double");

                    b.HasKey("Id")
                        .HasName("Pk_ExamId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("API_GrupoFleury.models.Scheduling", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ClientCpf")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("ExamIds")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("HorarioF")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("HorarioI")
                        .HasColumnType("datetime");

                    b.Property<double>("ValueTotal")
                        .HasPrecision(4, 2)
                        .HasColumnType("double");

                    b.HasKey("Id")
                        .HasName("Pk_SchedulingId");

                    b.HasIndex("ClientCpf");

                    b.ToTable("Schedulings");
                });

            modelBuilder.Entity("ExamScheduling", b =>
                {
                    b.Property<Guid>("ExamsId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("SchedulingsId")
                        .HasColumnType("char(36)");

                    b.HasKey("ExamsId", "SchedulingsId");

                    b.HasIndex("SchedulingsId");

                    b.ToTable("ExamScheduling");
                });

            modelBuilder.Entity("API_GrupoFleury.models.Client", b =>
                {
                    b.HasOne("API_GrupoFleury.models.Address", "Address")
                        .WithMany("Clients")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("API_GrupoFleury.models.Scheduling", b =>
                {
                    b.HasOne("API_GrupoFleury.models.Client", "Client")
                        .WithMany("Schedulings")
                        .HasForeignKey("ClientCpf")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("ExamScheduling", b =>
                {
                    b.HasOne("API_GrupoFleury.models.Exam", null)
                        .WithMany()
                        .HasForeignKey("ExamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_GrupoFleury.models.Scheduling", null)
                        .WithMany()
                        .HasForeignKey("SchedulingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API_GrupoFleury.models.Address", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("API_GrupoFleury.models.Client", b =>
                {
                    b.Navigation("Schedulings");
                });
#pragma warning restore 612, 618
        }
    }
}
