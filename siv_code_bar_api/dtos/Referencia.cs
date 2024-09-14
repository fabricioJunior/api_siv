using System;
namespace siv_code_bar_api.models
{
	public class Referencia
	{
		public string Identificador { get; set; }
		public string Descricao { get; set; }

		public Referencia(string identificador, string descricao )
		{
			Identificador = identificador;
			Descricao = descricao;
		}
	}
}

