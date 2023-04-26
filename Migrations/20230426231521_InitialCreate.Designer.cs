﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RESTful_API.Context;

#nullable disable

namespace RESTful_API.Migrations
{
    [DbContext(typeof(LabSchoolContext))]
    [Migration("20230426231521_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("RESTful_API.Models.AlunoModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Código")
                        .HasColumnOrder(1);

                    b.Property<int>("AtendimentosPedagogicos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0)
                        .HasColumnName("Qtd Atendimentos")
                        .HasColumnOrder(8);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Cpf")
                        .HasColumnOrder(5);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT")
                        .HasColumnName("Data de nascimento")
                        .HasColumnOrder(4);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Nome")
                        .HasColumnOrder(2);

                    b.Property<float>("NotaSeletivo")
                        .HasColumnType("REAL")
                        .HasColumnName("Nota")
                        .HasColumnOrder(7);

                    b.Property<string>("SituacaoMatricula")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Situação da Matrícula")
                        .HasColumnOrder(6);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Telefone")
                        .HasColumnOrder(3);

                    b.HasKey("Codigo");

                    b.ToTable("ALUNOS", (string)null);

                    b.HasData(
                        new
                        {
                            Codigo = 1,
                            AtendimentosPedagogicos = 0,
                            Cpf = "11839750073",
                            DataNascimento = new DateTime(2014, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Bart Simpson",
                            NotaSeletivo = 3.5f,
                            SituacaoMatricula = "IRREGULAR",
                            Telefone = "11-11111-1212"
                        },
                        new
                        {
                            Codigo = 2,
                            AtendimentosPedagogicos = 0,
                            Cpf = "17158947076",
                            DataNascimento = new DateTime(2012, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Lisa Simpson",
                            NotaSeletivo = 10f,
                            SituacaoMatricula = "ATIVO",
                            Telefone = "11-22222-2222"
                        },
                        new
                        {
                            Codigo = 3,
                            AtendimentosPedagogicos = 0,
                            Cpf = "63701210020",
                            DataNascimento = new DateTime(2019, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Meggie Simpson",
                            NotaSeletivo = 9f,
                            SituacaoMatricula = "ATIVO",
                            Telefone = "12-20002-2200"
                        },
                        new
                        {
                            Codigo = 4,
                            AtendimentosPedagogicos = 0,
                            Cpf = "30119137062",
                            DataNascimento = new DateTime(2014, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Milhouse Van Houten",
                            NotaSeletivo = 8f,
                            SituacaoMatricula = "ATIVO",
                            Telefone = "11-33333-2222"
                        },
                        new
                        {
                            Codigo = 5,
                            AtendimentosPedagogicos = 0,
                            Cpf = "95704094015",
                            DataNascimento = new DateTime(2007, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Nelson Muntz",
                            NotaSeletivo = 2f,
                            SituacaoMatricula = "INATIVO",
                            Telefone = "11-44333-4444"
                        });
                });

            modelBuilder.Entity("RESTful_API.Models.PedagogoModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Código")
                        .HasColumnOrder(1);

                    b.Property<int>("AtendimentosPedagogicos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0)
                        .HasColumnName("Qtd Atendimentos")
                        .HasColumnOrder(6);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Cpf")
                        .HasColumnOrder(5);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT")
                        .HasColumnName("Data de nascimento")
                        .HasColumnOrder(4);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Nome")
                        .HasColumnOrder(2);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Telefone")
                        .HasColumnOrder(3);

                    b.HasKey("Codigo");

                    b.ToTable("PEDAGOGOS", (string)null);

                    b.HasData(
                        new
                        {
                            Codigo = 1,
                            AtendimentosPedagogicos = 0,
                            Cpf = "62316840086",
                            DataNascimento = new DateTime(2000, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "John Snow",
                            Telefone = "11-67333-4454"
                        },
                        new
                        {
                            Codigo = 2,
                            AtendimentosPedagogicos = 0,
                            Cpf = "49850253053",
                            DataNascimento = new DateTime(2004, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sansa Stark",
                            Telefone = "22-22333-4454"
                        },
                        new
                        {
                            Codigo = 3,
                            AtendimentosPedagogicos = 0,
                            Cpf = "39125106015",
                            DataNascimento = new DateTime(1990, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Tyrion Lannister",
                            Telefone = "33-77333-4454"
                        },
                        new
                        {
                            Codigo = 4,
                            AtendimentosPedagogicos = 0,
                            Cpf = "89089606009",
                            DataNascimento = new DateTime(1995, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sandor Clegane",
                            Telefone = "11-33333-2222"
                        });
                });

            modelBuilder.Entity("RESTful_API.Models.ProfessorModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Código")
                        .HasColumnOrder(1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Cpf")
                        .HasColumnOrder(5);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT")
                        .HasColumnName("Data de nascimento")
                        .HasColumnOrder(4);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Estado")
                        .HasColumnOrder(6);

                    b.Property<string>("ExperienciaDesenvolvimento")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Experiência")
                        .HasColumnOrder(7);

                    b.Property<string>("FormacaoAcademica")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Formação Acadêmica")
                        .HasColumnOrder(8);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Nome")
                        .HasColumnOrder(2);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Telefone")
                        .HasColumnOrder(3);

                    b.HasKey("Codigo");

                    b.ToTable("PROFESSORES", (string)null);

                    b.HasData(
                        new
                        {
                            Codigo = 1,
                            Cpf = "40539019011",
                            DataNascimento = new DateTime(1982, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "ATIVO",
                            ExperienciaDesenvolvimento = "FULL_STACK",
                            FormacaoAcademica = "MESTRADO",
                            Nome = "Walter White",
                            Telefone = "14-22998-1882"
                        },
                        new
                        {
                            Codigo = 2,
                            Cpf = "96107295097",
                            DataNascimento = new DateTime(1997, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "ATIVO",
                            ExperienciaDesenvolvimento = "BACK_END",
                            FormacaoAcademica = "GRADUACAO_INCOMPLETA",
                            Nome = "Jesse Pinkman",
                            Telefone = "44-11111-1992"
                        },
                        new
                        {
                            Codigo = 3,
                            Cpf = "70685977005",
                            DataNascimento = new DateTime(1984, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "ATIVO",
                            ExperienciaDesenvolvimento = "FULL_STACK",
                            FormacaoAcademica = "MESTRADO",
                            Nome = "Hank Schrader",
                            Telefone = "44-11111-1002"
                        },
                        new
                        {
                            Codigo = 4,
                            Cpf = "57408927085",
                            DataNascimento = new DateTime(1977, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "INATIVO",
                            ExperienciaDesenvolvimento = "FRONT_END",
                            FormacaoAcademica = "GRADUACAO_INCOMPLETA",
                            Nome = "Gustavo Fring",
                            Telefone = "44-11001-1002"
                        },
                        new
                        {
                            Codigo = 5,
                            Cpf = "86940162062",
                            DataNascimento = new DateTime(1980, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "ATIVO",
                            ExperienciaDesenvolvimento = "FULL_STACK",
                            FormacaoAcademica = "MESTRADO",
                            Nome = "Saul Goodman",
                            Telefone = "44-11998-1882"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
