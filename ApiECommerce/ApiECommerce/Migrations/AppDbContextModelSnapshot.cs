﻿// <auto-generated />
using System;
using ApiECommerce.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiECommerce.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiECommerce.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UrlImagem")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Lanches",
                            UrlImagem = "lanches1.png"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Combos",
                            UrlImagem = "combos1.png"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Naturais",
                            UrlImagem = "naturais1.png"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Bebidas",
                            UrlImagem = "refrigerantes1.png"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Sucos",
                            UrlImagem = "sucos1.png"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Sobremesas",
                            UrlImagem = "sobremesas1.png"
                        });
                });

            modelBuilder.Entity("ApiECommerce.Entities.DetalhePedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("DetalhesPedido");
                });

            modelBuilder.Entity("ApiECommerce.Entities.ItemCarrinhoCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecoUnitario")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItensCarrinhoCompra");
                });

            modelBuilder.Entity("ApiECommerce.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("ApiECommerce.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Detalhe")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<int>("EmEstoque")
                        .HasColumnType("int");

                    b.Property<bool>("MaisVendido")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Popular")
                        .HasColumnType("bit");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("UrlImagem")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Detalhe = "Pão fofinho, hambúrger de carne bovina temperada, cebola, mostarda e ketchup ",
                            Disponivel = true,
                            EmEstoque = 13,
                            MaisVendido = true,
                            Nome = "Hamburger padrão",
                            Popular = true,
                            Preco = 15m,
                            UrlImagem = "hamburger1.jpeg"
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 1,
                            Detalhe = "Pão fofinho, hambúrguer de carne bovina temperada e queijo por todos os lados.",
                            Disponivel = true,
                            EmEstoque = 10,
                            MaisVendido = false,
                            Nome = "CheeseBurger padrão",
                            Popular = true,
                            Preco = 18m,
                            UrlImagem = "hamburger3.jpeg"
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 1,
                            Detalhe = "Pão fofinho, hambúrger de carne bovina temperada, cebola,alface, mostarda e ketchup ",
                            Disponivel = true,
                            EmEstoque = 13,
                            MaisVendido = false,
                            Nome = "CheeseSalada padrão",
                            Popular = false,
                            Preco = 19m,
                            UrlImagem = "hamburger4.jpeg"
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 2,
                            Detalhe = "Pão fofinho, hambúrguer de carne bovina temperada e queijo, refrigerante e fritas",
                            Disponivel = false,
                            EmEstoque = 10,
                            MaisVendido = false,
                            Nome = "Hambúrger, batata fritas, refrigerante ",
                            Popular = true,
                            Preco = 25m,
                            UrlImagem = "combo1.jpeg"
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 2,
                            Detalhe = "Pão fofinho, hambúrguer de carne bovina ,refrigerante e fritas, cebola, maionese e ketchup",
                            Disponivel = true,
                            EmEstoque = 13,
                            MaisVendido = false,
                            Nome = "CheeseBurger, batata fritas , refrigerante",
                            Popular = false,
                            Preco = 27m,
                            UrlImagem = "combo2.jpeg"
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 2,
                            Detalhe = "Pão fofinho, hambúrguer de carne bovina ,refrigerante e fritas, cebola, maionese e ketchup",
                            Disponivel = true,
                            EmEstoque = 10,
                            MaisVendido = false,
                            Nome = "CheeseSalada, batata fritas, refrigerante",
                            Popular = true,
                            Preco = 28m,
                            UrlImagem = "combo3.jpeg"
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 3,
                            Detalhe = "Pão integral com folhas e tomate",
                            Disponivel = true,
                            EmEstoque = 13,
                            MaisVendido = false,
                            Nome = "Lanche Natural com folhas",
                            Popular = false,
                            Preco = 14m,
                            UrlImagem = "lanche_natural1.jpeg"
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = 3,
                            Detalhe = "Pão integral, folhas, tomate e queijo.",
                            Disponivel = true,
                            EmEstoque = 10,
                            MaisVendido = false,
                            Nome = "Lanche Natural e queijo",
                            Popular = true,
                            Preco = 15m,
                            UrlImagem = "lanche_natural2.jpeg"
                        },
                        new
                        {
                            Id = 9,
                            CategoriaId = 3,
                            Detalhe = "Lanche vegano com ingredientes saudáveis",
                            Disponivel = true,
                            EmEstoque = 18,
                            MaisVendido = false,
                            Nome = "Lanche Vegano",
                            Popular = false,
                            Preco = 25m,
                            UrlImagem = "lanche_vegano1.jpeg"
                        },
                        new
                        {
                            Id = 10,
                            CategoriaId = 4,
                            Detalhe = "Refrigerante Coca Cola",
                            Disponivel = true,
                            EmEstoque = 7,
                            MaisVendido = false,
                            Nome = "Coca-Cola",
                            Popular = true,
                            Preco = 21m,
                            UrlImagem = "coca_cola1.jpeg"
                        },
                        new
                        {
                            Id = 11,
                            CategoriaId = 4,
                            Detalhe = "Refrigerante de Guaraná",
                            Disponivel = true,
                            EmEstoque = 6,
                            MaisVendido = false,
                            Nome = "Guaraná",
                            Popular = false,
                            Preco = 25m,
                            UrlImagem = "guarana1.jpeg"
                        },
                        new
                        {
                            Id = 12,
                            CategoriaId = 4,
                            Detalhe = "Refrigerante Pepsi Cola",
                            Disponivel = true,
                            EmEstoque = 6,
                            MaisVendido = false,
                            Nome = "Pepsi",
                            Popular = false,
                            Preco = 21m,
                            UrlImagem = "pepsi1.jpeg"
                        },
                        new
                        {
                            Id = 13,
                            CategoriaId = 5,
                            Detalhe = "Suco de laranja saboroso e nutritivo",
                            Disponivel = true,
                            EmEstoque = 10,
                            MaisVendido = false,
                            Nome = "Suco de laranja",
                            Popular = false,
                            Preco = 11m,
                            UrlImagem = "suco_laranja.jpeg"
                        },
                        new
                        {
                            Id = 14,
                            CategoriaId = 5,
                            Detalhe = "Suco de morango fresquinhos",
                            Disponivel = true,
                            EmEstoque = 13,
                            MaisVendido = false,
                            Nome = "Suco de morango",
                            Popular = false,
                            Preco = 15m,
                            UrlImagem = "suco_morango1.jpeg"
                        },
                        new
                        {
                            Id = 15,
                            CategoriaId = 5,
                            Detalhe = "Suco de uva natural sem acúcar feito com a fruta",
                            Disponivel = true,
                            EmEstoque = 10,
                            MaisVendido = false,
                            Nome = "Suco de uva",
                            Popular = false,
                            Preco = 13m,
                            UrlImagem = "suco_uva1.jpeg"
                        },
                        new
                        {
                            Id = 16,
                            CategoriaId = 4,
                            Detalhe = "Água mineral natural fresquinha",
                            Disponivel = true,
                            EmEstoque = 10,
                            MaisVendido = false,
                            Nome = "Água",
                            Popular = false,
                            Preco = 5m,
                            UrlImagem = "agua_mineral1.jpeg"
                        },
                        new
                        {
                            Id = 17,
                            CategoriaId = 6,
                            Detalhe = "Cookies de Chocolate com pedaços de chocolate",
                            Disponivel = true,
                            EmEstoque = 10,
                            MaisVendido = false,
                            Nome = "Cookies de chocolate",
                            Popular = true,
                            Preco = 8m,
                            UrlImagem = "cookie1.jpeg"
                        },
                        new
                        {
                            Id = 18,
                            CategoriaId = 6,
                            Detalhe = "Cookies de baunilha saborosos e crocantes",
                            Disponivel = true,
                            EmEstoque = 13,
                            MaisVendido = true,
                            Nome = "Cookies de Baunilha",
                            Popular = false,
                            Preco = 8m,
                            UrlImagem = "cookie2.jpeg"
                        },
                        new
                        {
                            Id = 19,
                            CategoriaId = 6,
                            Detalhe = "Torta suíca com creme e camadas de doce de leite",
                            Disponivel = true,
                            EmEstoque = 10,
                            MaisVendido = false,
                            Nome = "Torta Suíca",
                            Popular = true,
                            Preco = 10m,
                            UrlImagem = "torta_suica1.jpeg"
                        });
                });

            modelBuilder.Entity("ApiECommerce.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("UrlImagem")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ApiECommerce.Entities.DetalhePedido", b =>
                {
                    b.HasOne("ApiECommerce.Entities.Pedido", "Pedido")
                        .WithMany("DetalhesPedido")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiECommerce.Entities.Produto", "Produto")
                        .WithMany("DetalhesPedido")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("ApiECommerce.Entities.ItemCarrinhoCompra", b =>
                {
                    b.HasOne("ApiECommerce.Entities.Produto", null)
                        .WithMany("ItensCarrinhoCompras")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiECommerce.Entities.Pedido", b =>
                {
                    b.HasOne("ApiECommerce.Entities.Usuario", null)
                        .WithMany("Pedidos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiECommerce.Entities.Produto", b =>
                {
                    b.HasOne("ApiECommerce.Entities.Categoria", null)
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiECommerce.Entities.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("ApiECommerce.Entities.Pedido", b =>
                {
                    b.Navigation("DetalhesPedido");
                });

            modelBuilder.Entity("ApiECommerce.Entities.Produto", b =>
                {
                    b.Navigation("DetalhesPedido");

                    b.Navigation("ItensCarrinhoCompras");
                });

            modelBuilder.Entity("ApiECommerce.Entities.Usuario", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
