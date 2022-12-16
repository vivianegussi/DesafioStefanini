using DesafioStefanini.Context;
using DesafioStefanini.Models;
using DesafioStefanini.Repository.Interfaces;

namespace DesafioStefanini.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        public readonly DataContext _context;
        public PedidoRepository(DataContext context)
        {
            _context = context;
        }
        public Pedido Create(Pedido pedido)
        {
            _context.Add(pedido);
            _context.SaveChanges();

            return pedido;
        }

        public bool Delete(int id)
        {
            var pedido = _context.Pedido.FirstOrDefault(p => p.Id == id);

            if(pedido != null)
            {
                _context.Pedido.Remove(pedido);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<Pedido> GetAll()
        {
            return _context.Pedido.ToList();
        }

        public Pedido GetById(int id)
        {
            return _context.Pedido.FirstOrDefault(p => p.Id == id);
        }

        public Pedido Update(Pedido pedido)
        {
            var pedidoBanco = _context.Pedido.FirstOrDefault(p => p.Id == pedido.Id);

            if (pedidoBanco != null)
            {
                _context.Entry(pedidoBanco).CurrentValues.SetValues(pedido);
                _context.SaveChanges();
            }
            return pedidoBanco;
        }
    }
}
