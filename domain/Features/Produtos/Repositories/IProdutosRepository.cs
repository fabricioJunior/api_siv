using System;
using domain.Features.Produtos.Models;

namespace domain.Features.Produtos.Repositories
{
    public interface IProdutosRepository
	{
		List<Produto> GetProdutos(string identificadoReferencia);

		List<Produto> GetProdutosPor(string busca);

		List<Produto> GetProdutos(DateTime ultimaAlteracao);

		List<Produto> GetProdutos();

	}
}

