using System.ComponentModel.DataAnnotations;

namespace DesafioStefanini.Models.Request
{
    public class PedidoRequest
    {
        [Key]
        public int Id { get; set; }
        public string? NomeCliente { get; set; }
        public string? EmailCliente { get; set; }
        public byte Pago { get; set; }
        public virtual ICollection<ProdutoRequest>? Produtos { get; set; }
    }
}
