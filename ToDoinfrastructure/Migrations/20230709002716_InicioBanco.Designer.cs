﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ToDoInfrastructure.Context;

#nullable disable

namespace ToDoInfrastructure.Migrations
{
    [DbContext(typeof(TarefaContext))]
    [Migration("20230709002716_InicioBanco")]
    partial class InicioBanco
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ToDoInfrastructure.Models.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativa")
                        .HasColumnType("boolean")
                        .HasColumnName("Ativa");

                    b.Property<DateTime>("DataEstimada")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DataEstimada");

                    b.Property<DateTime>("DataFinalizacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DataFinalizacao");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DataInicio");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("Descricao");

                    b.Property<string>("Titulo")
                        .HasColumnType("text")
                        .HasColumnName("Titulo");

                    b.HasKey("Id");

                    b.ToTable("tarefa");
                });
#pragma warning restore 612, 618
        }
    }
}
