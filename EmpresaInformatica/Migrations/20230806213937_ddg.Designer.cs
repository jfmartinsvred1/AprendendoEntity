﻿// <auto-generated />
using System;
using EmpresaInformatica;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmpresaInformatica.Migrations
{
    [DbContext(typeof(InformaticaContext))]
    [Migration("20230806213937_ddg")]
    partial class ddg
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmpresaInformatica.GerarNotasServicos", b =>
                {
                    b.Property<int>("ServicoID")
                        .HasColumnType("int");

                    b.Property<int>("NotaId")
                        .HasColumnType("int");

                    b.HasKey("ServicoID", "NotaId");

                    b.HasIndex("NotaId");

                    b.ToTable("GerarNotasServicos");
                });

            modelBuilder.Entity("Program.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Program.GerarNota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataGerada")
                        .HasColumnType("datetime2");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("Program.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDeEntrega")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("EmpresaInformatica.GerarNotasServicos", b =>
                {
                    b.HasOne("Program.GerarNota", "Nota")
                        .WithMany("Servico")
                        .HasForeignKey("NotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Program.Servico", "Servico")
                        .WithMany("Notas")
                        .HasForeignKey("ServicoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nota");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("Program.GerarNota", b =>
                {
                    b.HasOne("Program.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Program.GerarNota", b =>
                {
                    b.Navigation("Servico");
                });

            modelBuilder.Entity("Program.Servico", b =>
                {
                    b.Navigation("Notas");
                });
#pragma warning restore 612, 618
        }
    }
}
