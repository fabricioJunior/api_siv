using System;
namespace domain.Features.ControleDePrecos.Models
{
	public class PrecoDaReferencia
	{
		public string IdentificadorReferencia { get; set; }
		public double Preco { get; set; }
		public int  IdTabela { get; set; }

		public PrecoDaReferencia(
			string identificaroDaReferencia,
			double preco,
			int idTabela
			)
		{

			IdentificadorReferencia = identificaroDaReferencia;
			Preco = preco;
			IdTabela = idTabela;
		}
	}
}

