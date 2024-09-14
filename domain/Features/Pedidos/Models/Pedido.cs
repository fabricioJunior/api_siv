using System;
namespace domain.Features.Pedidos
{
	public class Pedido
	{
        public Pedido(int id, string nomeDoCliente, double valorTotal, FormaDePagamento formaDePagamento, OperacaoFiscal operacaoFiscal, string naturezaDaOpercao)
        {
            Id = id;
            NomeDoCliente = nomeDoCliente;
            ValorTotal = valorTotal;
            FormaDePagamento = formaDePagamento;
            OperacaoFiscal = operacaoFiscal;
            NaturezaDaOpercao = naturezaDaOpercao;
        }

        public int Id { get; set; }
		public string NomeDoCliente { get; set; }
		public double ValorTotal { get; set; }
		public double Desconto { get; set; }
		public FormaDePagamento FormaDePagamento { get; set; }
		public OperacaoFiscal OperacaoFiscal { get; set; }
		public string NaturezaDaOpercao { get; set; }
		
	}
}

public enum FormaDePagamento
{

	Dinheiro = 0,
	Cartao = 1,
	Pix = 2,

}

public enum OperacaoFiscal
{

	entrada = 0,
	saida = 1,
}

