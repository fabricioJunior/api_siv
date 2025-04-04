using System;
namespace domain.Features.Produtos.Models
{
	public class ProdutoPedido
	{

		public int pedido { get; set; }
		public double desconto { get; set; }
		public string descricao { get; set; }
		public string tamanho { get; set; }
		public string cor { get; set; }
		public double preco { get; set; }
		public string formaDePagamento { get; set; }
		public int quantidade { get; set; } 

		public string codigoDeBarras{ get;set;}

		public ProdutoPedido(
			int pedido,
			double desconto,
			string descricao,
			string tamanho,
			string cor,
			double preco,
			string formaDePagamento,
			int quantidade,
			string  codigoDeBarras
			)
		{
			this.pedido = pedido;
			this.desconto = desconto;
			this.descricao = descricao;
			this.tamanho = tamanho;
			this.cor = cor;
			this.preco = preco;
			this.formaDePagamento = formaDePagamento;
			this.quantidade = quantidade;
			this.codigoDeBarras = codigoDeBarras;
		}

    
    }
}

