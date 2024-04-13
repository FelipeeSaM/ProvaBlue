﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProvaBlue.Db;

#nullable disable

namespace ProvaBlue.Migrations
{
    [DbContext(typeof(Prova_db_context))]
    [Migration("20240412233210_creating_db_seed")]
    partial class creating_db_seed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProvaBlue.Models.ContatoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contatos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "claudia_moen@hotmail.com",
                            Nome = "Laverne Kunde",
                            Numero = "81-9-3368-7044"
                        },
                        new
                        {
                            Id = 2,
                            Email = "kayla78@gmail.com",
                            Nome = "Elsie Schaden",
                            Numero = "81-9-4878-9128"
                        },
                        new
                        {
                            Id = 3,
                            Email = "shelia_von@hotmail.com",
                            Nome = "Ian Tremblay",
                            Numero = "81-9-0053-9813"
                        },
                        new
                        {
                            Id = 4,
                            Email = "courtney.johnston61@hotmail.com",
                            Nome = "Lance Sanford",
                            Numero = "81-9-4376-0926"
                        },
                        new
                        {
                            Id = 5,
                            Email = "kate22@hotmail.com",
                            Nome = "Julian Macejkovic",
                            Numero = "81-9-6161-4110"
                        },
                        new
                        {
                            Id = 6,
                            Email = "angie.shanahan85@hotmail.com",
                            Nome = "Jeffery King",
                            Numero = "81-9-8943-3726"
                        },
                        new
                        {
                            Id = 7,
                            Email = "owen.rice@yahoo.com",
                            Nome = "Lynda Legros",
                            Numero = "81-9-2861-5559"
                        },
                        new
                        {
                            Id = 8,
                            Email = "stella.rohan@gmail.com",
                            Nome = "Lonnie Hartmann",
                            Numero = "81-9-2222-2888"
                        },
                        new
                        {
                            Id = 9,
                            Email = "monica_mcdermott79@hotmail.com",
                            Nome = "Josefina McGlynn",
                            Numero = "81-9-9713-0989"
                        },
                        new
                        {
                            Id = 10,
                            Email = "albert_runolfsson17@yahoo.com",
                            Nome = "Andy Greenholt",
                            Numero = "81-9-4474-8383"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
