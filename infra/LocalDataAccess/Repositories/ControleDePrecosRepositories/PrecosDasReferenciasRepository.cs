using System;
using domain.Features.ControleDePrecos.Models;
using domain.Features.ControleDePrecos.Repositories;

namespace infra.LocalDataAccess.Repositories.ControleDePrecosRepositories
{
	public class PrecosDasReferenciasRepository: IPrecosDasReferenciasRepository
	{
		public PrecosDasReferenciasRepository()
		{
		}

        List<PrecoDaReferencia> IPrecosDasReferenciasRepository.GetPrecosDaReferencias(int idTabela)
        {
            throw new NotImplementedException();
        }
    }
}

