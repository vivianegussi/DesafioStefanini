using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioStefanini.Models
{
    public class ItensPedido
    {
        [Key]
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        [ForeignKey("ProdutoId")]
        public virtual Produto? Produto { get; set; }
    }
}
