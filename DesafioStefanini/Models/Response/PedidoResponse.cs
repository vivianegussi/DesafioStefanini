using System.ComponentModel.DataAnnotations;

namespace DesafioStefanini.Models.Response
{
    public class PedidoResponse
    {
        public int Id { get; set; }
        public string? NomeCliente { get; set; }
        public string? EmailCliente { get; set; }
        public decimal? ValorTotal { get; set; }
        public byte Pago { get; set; }
        public virtual ICollection<ItensPedidoResponse>? ItensPedido { get; set; }
    }
}
