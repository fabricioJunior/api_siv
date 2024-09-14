using System;
using domain.Features.Pedidos.Models;

namespace domain.Features.Pedidos.Repositories
{
	public interface IProdutosPedidoRepository
	{
		public List<ProdutoDoPedido> GetProdutoDoPedidos(int idPedido);
	}
}

