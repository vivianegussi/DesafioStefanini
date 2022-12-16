using DesafioStefanini.Context;
using DesafioStefanini.Models;
using DesafioStefanini.Repository.Interfaces;

namespace DesafioStefanini.Repository
{
    public class ItensPedidoRepository : IItensPedidoRepository
    {
        public readonly DataContext _context;
        public ItensPedidoRepository(DataContext context)
        {
            _context = context;
        }

        public ItensPedido Create(ItensPedido itensPedido)
        {
            _context.Add(itensPedido);
            _context.SaveChanges();

            return itensPedido;
        }

        public bool Delete(int id)
        {
            var itensPedido = _context.Pedido.FirstOrDefault(p => p.Id == id);

            if (itensPedido != null)
            {
                _context.Pedido.Remove(itensPedido);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<ItensPedido> GetAll()
        {
            throw new NotImplementedException();
        }

        public ItensPedido GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ItensPedido Update(ItensPedido itensPedido)
        {
            throw new NotImplementedException();
        }
    }
}
