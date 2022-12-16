using DesafioStefanini.Models;
using DesafioStefanini.Models.Request;
using DesafioStefanini.Models.Response;

namespace DesafioStefanini.Service.Interface
{
    public interface IPedidoService
    {
        public List<PedidoResponse> GetAll();

        public PedidoResponse GetById(int id);
        public PedidoResponse Create(PedidoRequest pedido);
        public Pedido Update(Pedido pedido);
        public bool Delete(int id);
    }
}
