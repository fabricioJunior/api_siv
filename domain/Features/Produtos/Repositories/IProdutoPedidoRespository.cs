using System;
using domain.Features.Produtos.Models;

namespace domain.Features.Produtos.Repositories
{
	public interface IProdutoPedidoRespository
	{

		List<ProdutoPedido> GetProdutoPedidos(DateTime inicial, DateTime final);

		List<ProdutoPedido> GetProdutoPedido(int idPedido);
	}
}

