﻿// <auto-generated />
using System;
using MVC_EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230201042017_sqlARERrLp")]
    partial class sqlARERrLp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCore.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("TipoSociosTipoSocioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoSociosTipoSocioId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("EFCore.Models.TipoSocios", b =>
                {
                    b.Property<int>("TipoSocioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoSocioId"));

                    b.Property<int>("DuracaoMeses")
                        .HasColumnType("int");

                    b.Property<int>("TaxaDesconto")
                        .HasColumnType("int");

                    b.HasKey("TipoSocioId");

                    b.ToTable("TipoSocioL");
                });

            modelBuilder.Entity("EFCore.Models.Aluno", b =>
                {
                    b.HasOne("EFCore.Models.TipoSocios", "TipoSocios")
                        .WithMany()
                        .HasForeignKey("TipoSociosTipoSocioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoSocios");
                });
#pragma warning restore 612, 618
        }
    }
}
