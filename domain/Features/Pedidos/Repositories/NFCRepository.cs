using System;
using domain.Features.Pedidos.Models;
using domain.Features.Produtos.Models;

namespace domain.Features.Pedidos.Repositories
{
	public interface INFCRepository
	{
		public string NovaNFC(Pedido pedido, List<ProdutoDoPedido> produtos);

		public string NovasNFCs(List<Pedido> pedidos);
	}
}

