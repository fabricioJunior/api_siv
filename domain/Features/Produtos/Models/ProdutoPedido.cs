using System;
namespace domain.Features.Produtos.Models
{
	public class ProdutoPedido
	{

		public int idPedido { get; set; }
		public double desconto { get; set; }
		public string descricao { get; set; }
		public string tamanho { get; set; }
		public string cor { get; set; }
		public double valor { get; set; }
		public int quantidade { get; set; }

		public string codigoDeBarras { get; set; }

		public string dsrefer { get; set; }

		public ProdutoPedido(
			int pedido,
			double desconto,
			string descricao,
			string tamanho,
			string cor,
			double valor,
			int quantidade,
			string codigoDeBarras,
			string dsrefer
			)
		{
			this.idPedido = pedido;
			this.desconto = desconto;
			this.descricao = descricao;
			this.tamanho = tamanho;
			this.cor = cor;
			this.valor = valor;
			this.quantidade = quantidade;
			this.codigoDeBarras = codigoDeBarras;
			this.dsrefer = dsrefer;
		}


	}
}

