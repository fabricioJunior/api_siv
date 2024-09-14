using System;
using domain.Features.ControleDePrecos.Models;
using domain.Features.ControleDePrecos.Repositories;

namespace infra.LocalDataAccess.Repositories.ControleDePrecosRepositories
{
	public class TabelasDePrecosRepository: ITabelaDePrecosRepository
	{
		public TabelasDePrecosRepository()
		{
		}

        List<TabelaDePreco> ITabelaDePrecosRepository.GetTabelasDePrecos()
        {
            throw new NotImplementedException();
        }
    }
}

