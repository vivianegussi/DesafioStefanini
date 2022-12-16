using DesafioStefanini.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding;
using System.Reflection.PortableExecutable;

namespace DesafioStefanini.Context
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .HasMany(p => p.ItensPedido);
            
            modelBuilder.Entity<ItensPedido>()
                .HasOne(p => p.Produto);
        }

        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ItensPedido> ItensPedido { get; set; }
    }
}
