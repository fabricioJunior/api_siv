using System;
using domain.Features.Pedidos.Repositories;

namespace domain.Features.Pedidos.Services
{
	public class PedidosService
	{
		private readonly IPedidosRepository pedidosRepository;

		public PedidosService(
			IPedidosRepository pedidosRepository
			)
		{
			this.pedidosRepository = pedidosRepository;
		}
		 
	    public List<Pedido> GetPedidos(FormaDePagamento formaDePagamento, DateTime inicio, DateTime fim)
		{
			return pedidosRepository.GetPedidos(formaDePagamento,inicio, fim);
		}

	}
}

