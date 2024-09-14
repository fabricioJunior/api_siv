using System;
using domain.Features.ControleDePrecos.Models;

namespace domain.Features.ControleDePrecos.Repositories
{
	public interface ITabelaDePrecosRepository
	{
		List<TabelaDePreco> GetTabelasDePrecos();
	}
}

