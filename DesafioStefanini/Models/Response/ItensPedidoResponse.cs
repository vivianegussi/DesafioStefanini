namespace DesafioStefanini.Models.Response
{
    public class ItensPedidoResponse
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; } = string.Empty;
        public decimal? ValorUnitario { get; set; }
        public int Quantidade { get; set; }
    }
}
