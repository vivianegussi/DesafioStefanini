using DesafioStefanini.Models;

namespace DesafioStefanini.Service.Interface
{
    public interface IPedidoService
    {
        public List<Pedido> GetAll();

        public Pedido GetById(int id);
        public Pedido Create(Pedido pedido);
        public Pedido Update(Pedido pedido);
        public bool Delete(int id);
    }
}
