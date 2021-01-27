﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PesquisaWebCrawler.DataLayer;

namespace PesquisaWebCrawler.Migrations
{
    [DbContext(typeof(RefeicaoDBContext))]
    [Migration("20210127143916_pesquisawebmigration")]
    partial class pesquisawebmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PesquisaWebCrawler.Models.Refeição", b =>
                {
                    b.Property<string>("codigoProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PROCODIGO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("descricaoProduto")
                        .HasColumnName("PRODESCRICAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imagemProduto")
                        .HasColumnName("PROIMAGEM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("linkProduto")
                        .HasColumnName("PROLINK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeProduto")
                        .HasColumnName("PRONOME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codigoProduto");

                    b.ToTable("Refeicao");
                });
#pragma warning restore 612, 618
        }
    }
}