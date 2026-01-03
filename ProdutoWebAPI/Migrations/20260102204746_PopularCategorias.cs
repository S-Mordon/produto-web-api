using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdutoWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                    table: "Categorias",
                    columns: new[] { "Id", "Nome", "ImagemUrl" },
                    values: new object[,]
                    {
                        { 1, "Eletrônicos", "https://exemplo.com/imagens/eletronicos.png" },
                        { 2, "Cosméticos", "https://exemplo.com/imagens/cosmeticos.png" },
                        { 3, "Alimentos", "https://exemplo.com/imagens/alimentos.png" },
                        { 4, "Roupas", "https://exemplo.com/imagens/roupas.png" }
                    }
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categorias");
        }
    }
}
