using System.ComponentModel.DataAnnotations;

namespace DesafioStefanini.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public string? NomeCliente { get; set; }
        public string? EmailCliente { get; set; }
        public DateTime DataCriacao { get; set; }
        public byte Pago { get; set; }
    }
}
