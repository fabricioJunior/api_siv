using System;

namespace domain.Features.Pedidos.Repositories
{
	public interface IPedidosRepository
	{
		public List<Pedido> GetPedidos(DateTime inicio, DateTime final);

		public Pedido GetPedido(int id);

		public List<Pedido> GetPedidos(FormaDePagamento formaDePagamento, DateTime inicio, DateTime final);

	}
}

