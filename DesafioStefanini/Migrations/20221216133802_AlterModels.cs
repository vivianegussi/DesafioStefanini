using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioStefanini.Migrations
{
    public partial class AlterModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "ItensPedido",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "ItensPedido",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItensPedido_PedidoId",
                table: "ItensPedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensPedido_ProdutoId",
                table: "ItensPedido",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensPedido_Pedido_PedidoId",
                table: "ItensPedido",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensPedido_Produto_ProdutoId",
                table: "ItensPedido",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensPedido_Pedido_PedidoId",
                table: "ItensPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensPedido_Produto_ProdutoId",
                table: "ItensPedido");

            migrationBuilder.DropIndex(
                name: "IX_ItensPedido_PedidoId",
                table: "ItensPedido");

            migrationBuilder.DropIndex(
                name: "IX_ItensPedido_ProdutoId",
                table: "ItensPedido");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "ItensPedido");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "ItensPedido");
        }
    }
}
