using System;
namespace domain.Features.ControleDePrecos.Models
{
	public class TabelaDePreco
	{

		public int ID { get; set; }
		public string Nome { get; set; }
		public bool Ativa { get; set; }
		 
		public TabelaDePreco(
			int id,
			string nome,
			bool ativa
			)
		{
			ID = id;
			Nome = nome;
			Ativa = ativa;
		}
	}
}

