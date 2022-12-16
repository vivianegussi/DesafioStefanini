using System.ComponentModel.DataAnnotations;

namespace DesafioStefanini.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string? NomeProduto { get; set; }
        public decimal? Valor { get; set; }
    }
}
