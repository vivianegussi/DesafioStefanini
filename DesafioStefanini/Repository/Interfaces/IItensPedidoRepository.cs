using DesafioStefanini.Models;

namespace DesafioStefanini.Repository.Interfaces
{
    public interface IItensPedidoRepository
    {

        public List<ItensPedido> GetAll();

        public ItensPedido GetById(int id);
        public ItensPedido Create(ItensPedido itensPedido);
        public ItensPedido Update(ItensPedido itensPedido);
        public bool Delete(int id);

    }
}
