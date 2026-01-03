using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdutoWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopularProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[]
                {
                    "Id",
                    "Nome",
                    "Descricao",
                    "Preco",
                    "ImagemUrl",
                    "Estoque",
                    "DataCadastro",
                    "CategoriaId"
                },
                values: new object[,]
                {
                    {
                        1,
                        "Notebook Gamer",
                        "Notebook gamer com placa de vídeo dedicada e alto desempenho.",
                        5999.90m,
                        "https://exemplo.com/imagens/notebook-gamer.png",
                        15f,
                        DateTime.Now,
                        1
                    },
                    {
                        2,
                        "Smartphone",
                        "Smartphone com câmera de alta resolução e ótimo desempenho.",
                        2999.00m,
                        "https://exemplo.com/imagens/smartphone.png",
                        30f,
                        DateTime.Now,
                        1
                     },
                    {
                        3,
                        "Perfume Importado",
                        "Perfume importado com fragrância marcante.",
                        450.00m,
                        "https://exemplo.com/imagens/perfume.png",
                        50f,
                        DateTime.Now,
                        2
                    },
                    {
                        4,
                        "Camiseta Básica",
                        "Camiseta de algodão confortável para uso diário.",
                        79.90m,
                        "https://exemplo.com/imagens/camiseta.png",
                        100f,
                        DateTime.Now,
                        4
                    }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Produtos");
        }
    }
}
