using System;
using domain.Features.Pedidos.Repositories;

namespace domain.Features.Pedidos.Services
{
	public class NFCsServices
	{

		private readonly INFCRepository nFCRepository;
		private readonly IPedidosRepository pedidosRepository;
		private readonly IProdutosPedidoRepository produtosPedidoRepository;

        public NFCsServices(
			INFCRepository nFCRepository,
			IPedidosRepository pedidosRepository,
            IProdutosPedidoRepository produtosPedidoRepository
            )
		{
			this.pedidosRepository = pedidosRepository;
			this.nFCRepository = nFCRepository;
			this.produtosPedidoRepository = produtosPedidoRepository;
		}


		public string novaNFC(int idPedido) {

			var pedido = pedidosRepository.GetPedido(idPedido);

            var produtosDoPedido = produtosPedidoRepository.GetProdutoDoPedidos(idPedido);

			return nFCRepository.NovaNFC(pedido, produtosDoPedido);
		}
	}
}

