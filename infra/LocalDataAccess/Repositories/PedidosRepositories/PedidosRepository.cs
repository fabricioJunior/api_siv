using System;
using domain.Features.Pedidos;
using domain.Features.Pedidos.Repositories;
using domain.Features.Produtos.Models;
using infra.Common;

namespace infra.LocalDataAccess.Repositories.PedidosRepositories
{
    //TODO: Implementar busca no banco de dados.
	public class PedidosRepository: IPedidosRepository
	{
		public PedidosRepository()
		{
		}

        public Pedido GetPedido(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> GetPedidos(DateTime inicio, DateTime final)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> GetPedidos(FormaDePagamento formaDePagamento, DateTime inicio, DateTime final)
        {
            throw new NotImplementedException();
        }
    }
}

