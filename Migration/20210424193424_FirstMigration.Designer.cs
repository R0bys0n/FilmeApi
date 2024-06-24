﻿// <auto-generated />
using System;
using FilmesAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmesAPI.Migration
{
    [DbContext(typeof(Filme))]
    [Migration("20210424193424_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("FilmesAPI.Models.Filme", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<string>("Diretor")
                    .HasMaxLength(100)
                    .HasColumnType("varchar(100)");

                b.Property<int>("Duracao")
                    .HasColumnType("int");

                b.Property<string>("Genero")
                    .HasColumnType("text");

                b.Property<DateTime>("Lancamento")
                    .HasColumnType("datetime");

                b.Property<string>("Titulo")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.ToTable("Filmes");
            });
#pragma warning restore 612, 618
        }
    }
}