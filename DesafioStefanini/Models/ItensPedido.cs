using System.ComponentModel.DataAnnotations;

namespace DesafioStefanini.Models
{
    public class ItensPedido
    {
        [Key]
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
    }
}
