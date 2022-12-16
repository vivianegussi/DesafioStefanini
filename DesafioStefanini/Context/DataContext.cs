using DesafioStefanini.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;

namespace DesafioStefanini.Context
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ItensPedido> ItensPedido { get; set; }
    }
}
