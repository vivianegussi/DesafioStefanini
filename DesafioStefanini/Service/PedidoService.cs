using DesafioStefanini.Models;
using DesafioStefanini.Repository.Interfaces;
using DesafioStefanini.Service.Interface;

namespace DesafioStefanini.Service
{
    public class PedidoService : IPedidoService
    {

        private readonly IPedidoRepository _pedidoRepository;
        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public Pedido Create(Pedido pedido)
        {
            return _pedidoRepository.Create(pedido);
        }

        public bool Delete(int id)
        {
            return _pedidoRepository.Delete(id);
        }

        public List<Pedido> GetAll()
        {
            return _pedidoRepository.GetAll();
        }

        public Pedido GetById(int id)
        {
            return _pedidoRepository.GetById(id);
        }

        public Pedido Update(Pedido pedido)
        {
            return _pedidoRepository.Update(pedido);
        }
    }
}
