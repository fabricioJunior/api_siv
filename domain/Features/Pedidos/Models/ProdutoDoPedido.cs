using System;
namespace domain.Features.Pedidos.Models
{
	public class ProdutoDoPedido
	{
        public ProdutoDoPedido(string refer, int quantidade,string descricao, double valor, string ncm)
        {
            Refer = refer;
            Quantidade = quantidade;
            Valor = valor;
            Ncm = ncm;
            Descricao = descricao;
        }

        public required string Refer { get; set; }
		public int Quantidade { get; set; }
        public string Descricao { get; set; }
		public double Valor { get; set; }
		public string Ncm { get; set; }
	
	
	}
}

