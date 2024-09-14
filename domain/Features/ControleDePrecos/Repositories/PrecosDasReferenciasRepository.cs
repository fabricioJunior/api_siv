using System;
using domain.Features.ControleDePrecos.Models;

namespace domain.Features.ControleDePrecos.Repositories
{
	public interface IPrecosDasReferenciasRepository
	{

		List<PrecoDaReferencia> GetPrecosDaReferencias(int idTabela);


	}
}

