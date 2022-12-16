using DesafioStefanini.Models;
using DesafioStefanini.Models.Request;
using DesafioStefanini.Models.Response;
using DesafioStefanini.Repository;
using DesafioStefanini.Repository.Interfaces;
using DesafioStefanini.Service.Interface;
using Microsoft.AspNetCore.Http.Connections;

namespace DesafioStefanini.Service
{
    public class PedidoService : IPedidoService
    {

        private readonly IPedidoRepository _pedidoRepository;
        private readonly IItensPedidoRepository _itensPedidoRepository;
        public PedidoService(IPedidoRepository pedidoRepository, IItensPedidoRepository itensPedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
            _itensPedidoRepository = itensPedidoRepository;
        }
        
        
        public PedidoResponse Create(PedidoRequest pedido)
        {
            var novoPedido = new Pedido
            {
                NomeCliente = pedido.NomeCliente,
                EmailCliente = pedido.EmailCliente,
                DataCriacao = DateTime.Now,
                Pago = pedido.Pago
            };

            novoPedido = _pedidoRepository.Create(novoPedido);

            pedido.Produtos.ToList().ForEach(pr =>
            {
                var itensPedido = new ItensPedido
                {
                    PedidoId = novoPedido.Id,
                    ProdutoId = pr.Id,
                    Quantidade = pr.Quantidade
                };

                _itensPedidoRepository.Create(itensPedido);
            });
            
            return GetById(novoPedido.Id);
        }

        public bool Delete(int id)
        {
            return _pedidoRepository.Delete(id);
        }

        public List<PedidoResponse> GetAll()
        {
            var pedidos = _pedidoRepository.GetAll();

            var response = new List<PedidoResponse>();


            pedidos.ForEach(p =>
            {
                var itens = new List<ItensPedidoResponse>();

                p.ItensPedido?.ToList().ForEach(ip =>
                {
                    itens.Add(new ItensPedidoResponse
                    {
                        Id = ip.Id,
                        ProdutoId = ip.Produto.Id,
                        NomeProduto = ip.Produto.NomeProduto,
                        ValorUnitario = ip.Produto.Valor,
                        Quantidade = ip.Quantidade
                    });
                });

                response.Add(new PedidoResponse
                {
                    Id = p.Id,
                    NomeCliente = p.NomeCliente,
                    EmailCliente = p.EmailCliente,
                    Pago = p.Pago,
                    ValorTotal = itens.Select(i => i.ValorUnitario * i.Quantidade).Sum(),
                    ItensPedido = itens
                });

            });

            return response;
        }

        public PedidoResponse GetById(int id)
        {
            var pedido = _pedidoRepository.GetById(id);

            var itens = new List<ItensPedidoResponse>();

            pedido.ItensPedido?.ToList().ForEach(ip =>
            {
                itens.Add(new ItensPedidoResponse
                {
                    Id = ip.Id,
                    ProdutoId = ip.Produto.Id,
                    NomeProduto = ip.Produto.NomeProduto,
                    ValorUnitario = ip.Produto.Valor,
                    Quantidade = ip.Quantidade
                });
            });

            return new PedidoResponse
            {
                Id = pedido.Id,
                NomeCliente = pedido.NomeCliente,
                EmailCliente = pedido.EmailCliente,
                Pago = pedido.Pago,
                ValorTotal = itens.Select(i => i.ValorUnitario * i.Quantidade).Sum(),
                ItensPedido = itens
            };
        }

        public Pedido Update(Pedido pedido)
        {
            return _pedidoRepository.Update(pedido);
        }
    }
}
