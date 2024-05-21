﻿// <auto-generated />
using System;
using Impressao.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Impressao.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230403112906_PedidoItemUpload3Migration")]
    partial class PedidoItemUpload3Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Impressao.Models.Celula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Celula");
                });

            modelBuilder.Entity("Impressao.Models.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("Impressao.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CidadeId")
                        .HasColumnType("integer");

                    b.Property<int>("ClienteGrupoId")
                        .HasColumnType("integer");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<char>("FisicaJuridica")
                        .HasColumnType("character(1)");

                    b.Property<string>("InscricaoEstadual")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("text");

                    b.Property<int?>("Numero")
                        .HasColumnType("integer");

                    b.Property<string>("Observacoes")
                        .HasColumnType("text");

                    b.Property<int?>("Pais")
                        .HasColumnType("integer");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefone2")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("ClienteGrupoId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Impressao.Models.ClienteGrupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ClienteGrupo");
                });

            modelBuilder.Entity("Impressao.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("integer");

                    b.Property<string>("Contrato")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DataFinalizado")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Observacoes")
                        .HasColumnType("text");

                    b.Property<DateTime?>("PrevisaoEntrega")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Impressao.Models.PedidoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Copias")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DataAprovacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DataImposicao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PedidoId")
                        .HasColumnType("integer");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("PedidoItem");
                });

            modelBuilder.Entity("Impressao.Models.PedidoItemApontamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CelulaId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DataInicio")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DataTermino")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PedidoItemId")
                        .HasColumnType("integer");

                    b.Property<int>("Sequencia")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CelulaId");

                    b.HasIndex("PedidoItemId");

                    b.ToTable("PedidoItemApontamento");
                });

            modelBuilder.Entity("Impressao.Models.PedidoItemArquivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataUpload")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("NomeArquivo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PedidoItemArquivoAlbumId")
                        .HasColumnType("integer");

                    b.Property<int>("PedidoItemId")
                        .HasColumnType("integer");

                    b.Property<float>("Sequencia")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("PedidoItemArquivoAlbumId");

                    b.HasIndex("PedidoItemId");

                    b.ToTable("PedidoItemArquivo");
                });

            modelBuilder.Entity("Impressao.Models.PedidoItemArquivoAlbum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DataProcessamento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("NomeArquivo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PedidoItemId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PedidoItemId");

                    b.ToTable("PedidoItemArquivoAlbum");
                });

            modelBuilder.Entity("Impressao.Models.PedidoItemUpload", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Altura")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataCadstro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Largura")
                        .HasColumnType("integer");

                    b.Property<string>("NomeArquivo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Panoramica")
                        .HasColumnType("boolean");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PedidoItemId")
                        .HasColumnType("integer");

                    b.Property<bool>("Rotacionar")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("PedidoItemId");

                    b.ToTable("PedidoItemUpload");
                });

            modelBuilder.Entity("Impressao.Models.PedidoReimpressao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DataImposicionamento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PedidoItemId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PedidoItemId");

                    b.ToTable("PedidoReimpressao");
                });

            modelBuilder.Entity("Impressao.Models.PedidoReimpressaoArquivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("ApontamentoFrente")
                        .HasColumnType("boolean");

                    b.Property<int>("ArquivoFrenteId")
                        .HasColumnType("integer");

                    b.Property<int?>("ArquivoVersoId")
                        .HasColumnType("integer");

                    b.Property<int>("PedidoReimpressaoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ArquivoFrenteId");

                    b.HasIndex("ArquivoVersoId");

                    b.HasIndex("PedidoReimpressaoId");

                    b.ToTable("PedidoReimpressaoArquivo");
                });

            modelBuilder.Entity("Impressao.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Altura")
                        .HasColumnType("integer");

                    b.Property<int>("AlturaMidia")
                        .HasColumnType("integer");

                    b.Property<bool>("ArquivosJPEG")
                        .HasColumnType("boolean");

                    b.Property<bool>("ArquivosPDF")
                        .HasColumnType("boolean");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<int?>("DeslocamentoFrenteX")
                        .HasColumnType("integer");

                    b.Property<int?>("DeslocamentoFrenteY")
                        .HasColumnType("integer");

                    b.Property<int?>("DeslocamentoVersoX")
                        .HasColumnType("integer");

                    b.Property<int?>("DeslocamentoVersoY")
                        .HasColumnType("integer");

                    b.Property<char>("DisposicaoImagem")
                        .HasColumnType("character(1)");

                    b.Property<char>("DisposicaoImpressao")
                        .HasColumnType("character(1)");

                    b.Property<int>("Largura")
                        .HasColumnType("integer");

                    b.Property<int>("LarguraMidia")
                        .HasColumnType("integer");

                    b.Property<int>("Orientacao")
                        .HasColumnType("integer");

                    b.Property<int?>("ProdutoGrupoId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("ProdutoHotFolderId")
                        .HasColumnType("integer");

                    b.Property<int?>("ProdutoSubstratoId")
                        .HasColumnType("integer");

                    b.Property<int>("QuantidadeArquivosProduto")
                        .HasColumnType("integer");

                    b.Property<bool>("RenomearArquivo")
                        .HasColumnType("boolean");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoGrupoId");

                    b.HasIndex("ProdutoHotFolderId");

                    b.HasIndex("ProdutoSubstratoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Impressao.Models.ProdutoGrupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProdutoGrupo");
                });

            modelBuilder.Entity("Impressao.Models.ProdutoHotFolder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProdutoHotFolder");
                });

            modelBuilder.Entity("Impressao.Models.ProdutoInformacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Orientacao")
                        .HasColumnType("integer");

                    b.Property<int>("Pagina")
                        .HasColumnType("integer");

                    b.Property<int>("PosX")
                        .HasColumnType("integer");

                    b.Property<int>("PosY")
                        .HasColumnType("integer");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("integer");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ProdutoInformacao");
                });

            modelBuilder.Entity("Impressao.Models.ProdutoSubstrato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProdutoSubstrato");
                });

            modelBuilder.Entity("Impressao.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Impressao.Models.Cliente", b =>
                {
                    b.HasOne("Impressao.Models.Cidade", "Cidade")
                        .WithMany("Clientes")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Impressao.Models.ClienteGrupo", "ClienteGrupo")
                        .WithMany("Clientes")
                        .HasForeignKey("ClienteGrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("ClienteGrupo");
                });

            modelBuilder.Entity("Impressao.Models.Pedido", b =>
                {
                    b.HasOne("Impressao.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Impressao.Models.PedidoItem", b =>
                {
                    b.HasOne("Impressao.Models.Pedido", "Pedido")
                        .WithMany("PedidoItens")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Impressao.Models.Produto", "Produto")
                        .WithMany("PedidoItens")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Impressao.Models.PedidoItemApontamento", b =>
                {
                    b.HasOne("Impressao.Models.Celula", "Celula")
                        .WithMany("PedidoItemApontamentos")
                        .HasForeignKey("CelulaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Impressao.Models.PedidoItem", "PedidoItem")
                        .WithMany("PedidoItemApontamentos")
                        .HasForeignKey("PedidoItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Celula");

                    b.Navigation("PedidoItem");
                });

            modelBuilder.Entity("Impressao.Models.PedidoItemArquivo", b =>
                {
                    b.HasOne("Impressao.Models.PedidoItemArquivoAlbum", "PedidoItemArquivoAlbum")
                        .WithMany("PedidoItemArquivos")
                        .HasForeignKey("PedidoItemArquivoAlbumId");

                    b.HasOne("Impressao.Models.PedidoItem", "PedidoItem")
                        .WithMany("PedidoItemArquivos")
                        .HasForeignKey("PedidoItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PedidoItem");

                    b.Navigation("PedidoItemArquivoAlbum");
                });

            modelBuilder.Entity("Impressao.Models.PedidoItemArquivoAlbum", b =>
                {
                    b.HasOne("Impressao.Models.PedidoItem", "PedidoItem")
                        .WithMany("PedidoItemArquivoAlbuns")
                        .HasForeignKey("PedidoItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PedidoItem");
                });

            modelBuilder.Entity("Impressao.Models.PedidoItemUpload", b =>
                {
                    b.HasOne("Impressao.Models.PedidoItem", "PedidoItem")
                        .WithMany("PedidoItemUploads")
                        .HasForeignKey("PedidoItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PedidoItem");
                });

            modelBuilder.Entity("Impressao.Models.PedidoReimpressao", b =>
                {
                    b.HasOne("Impressao.Models.PedidoItem", "PedidoItem")
                        .WithMany("PedidoReimpressoes")
                        .HasForeignKey("PedidoItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PedidoItem");
                });

            modelBuilder.Entity("Impressao.Models.PedidoReimpressaoArquivo", b =>
                {
                    b.HasOne("Impressao.Models.PedidoItemArquivo", "ArquivoFrente")
                        .WithMany("PedidoReimpressaoArquivosFrente")
                        .HasForeignKey("ArquivoFrenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Impressao.Models.PedidoItemArquivo", "ArquivoVerso")
                        .WithMany("PedidoReimpressaoArquivosVerso")
                        .HasForeignKey("ArquivoVersoId");

                    b.HasOne("Impressao.Models.PedidoReimpressao", "PedidoReimpressao")
                        .WithMany("Arquivos")
                        .HasForeignKey("PedidoReimpressaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArquivoFrente");

                    b.Navigation("ArquivoVerso");

                    b.Navigation("PedidoReimpressao");
                });

            modelBuilder.Entity("Impressao.Models.Produto", b =>
                {
                    b.HasOne("Impressao.Models.ProdutoGrupo", "ProdutoGrupo")
                        .WithMany("Produtos")
                        .HasForeignKey("ProdutoGrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Impressao.Models.ProdutoHotFolder", "ProdutoHotFolder")
                        .WithMany("Produtos")
                        .HasForeignKey("ProdutoHotFolderId");

                    b.HasOne("Impressao.Models.ProdutoSubstrato", "ProdutoSubstrato")
                        .WithMany("Produtos")
                        .HasForeignKey("ProdutoSubstratoId");

                    b.Navigation("ProdutoGrupo");

                    b.Navigation("ProdutoHotFolder");

                    b.Navigation("ProdutoSubstrato");
                });

            modelBuilder.Entity("Impressao.Models.ProdutoInformacao", b =>
                {
                    b.HasOne("Impressao.Models.Produto", "Produto")
                        .WithMany("Informacoes")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Impressao.Models.Celula", b =>
                {
                    b.Navigation("PedidoItemApontamentos");
                });

            modelBuilder.Entity("Impressao.Models.Cidade", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("Impressao.Models.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Impressao.Models.ClienteGrupo", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("Impressao.Models.Pedido", b =>
                {
                    b.Navigation("PedidoItens");
                });

            modelBuilder.Entity("Impressao.Models.PedidoItem", b =>
                {
                    b.Navigation("PedidoItemApontamentos");

                    b.Navigation("PedidoItemArquivoAlbuns");

                    b.Navigation("PedidoItemArquivos");

                    b.Navigation("PedidoItemUploads");

                    b.Navigation("PedidoReimpressoes");
                });

            modelBuilder.Entity("Impressao.Models.PedidoItemArquivo", b =>
                {
                    b.Navigation("PedidoReimpressaoArquivosFrente");

                    b.Navigation("PedidoReimpressaoArquivosVerso");
                });

            modelBuilder.Entity("Impressao.Models.PedidoItemArquivoAlbum", b =>
                {
                    b.Navigation("PedidoItemArquivos");
                });

            modelBuilder.Entity("Impressao.Models.PedidoReimpressao", b =>
                {
                    b.Navigation("Arquivos");
                });

            modelBuilder.Entity("Impressao.Models.Produto", b =>
                {
                    b.Navigation("Informacoes");

                    b.Navigation("PedidoItens");
                });

            modelBuilder.Entity("Impressao.Models.ProdutoGrupo", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Impressao.Models.ProdutoHotFolder", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Impressao.Models.ProdutoSubstrato", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
