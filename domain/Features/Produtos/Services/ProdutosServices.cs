using System;
using domain.Features.Produtos.Models;
using domain.Features.Produtos.Repositories;

namespace domain.Features.Produtos.Services
{
	public class ProdutosService
	{

		private readonly IProdutosRepository _produtosRepository;

		public ProdutosService(IProdutosRepository produtosRepository)
		{
			_produtosRepository = produtosRepository;
		}

		public List<Produto> recuperarProdutosPelaReferencia( string referencia) {
			return _produtosRepository.GetProdutos(referencia);
		}

		public List<Produto> buscarProdutos(string busca) {

			var palavrasDaBusca = busca.Split(' ');

			var resultado = new List<Produto>();

			foreach (var palavra in  palavrasDaBusca)
			{
				var resultadoDaBuscaPorPalavra = _produtosRepository.GetProdutosPor(palavra);
				resultado.AddRange(resultadoDaBuscaPorPalavra);
			}

			return resultado;
		}



		public List<Produto> buscarProdutos(DateTime ultimaAlteracaoApos) {
			return _produtosRepository.GetProdutos(ultimaAlteracaoApos);
		}

        public List<Produto> buscarProdutos()
        {
            return _produtosRepository.GetProdutos();
        }


    }
}

