using System;
using domain.Features.ControleDePrecos.Models;
using domain.Features.ControleDePrecos.Repositories;

namespace domain.Features.ControleDePrecos.Services
{
	public class ControleDePrecosService
	{
		private readonly IPrecosDasReferenciasRepository _precosDasReferenciasRepository;
		private readonly ITabelaDePrecosRepository _tabelaDePrecosRepository;


        public ControleDePrecosService(
			ITabelaDePrecosRepository tabelaDePrecosRepository,
			IPrecosDasReferenciasRepository precosDasReferenciasRepository
			)
		{
			_precosDasReferenciasRepository = precosDasReferenciasRepository;
			_tabelaDePrecosRepository = tabelaDePrecosRepository;

		}

	    public List<TabelaDePreco> RecuperarTabelasDePrecosAtivas()
		{
			var tabelasDePrecos = _tabelaDePrecosRepository.GetTabelasDePrecos();

			return tabelasDePrecos.Where((tabela) => tabela.Ativa).ToList();
		}

		public List<PrecoDaReferencia> RecuperarPrecosDaTabela(int idTabela)
		{
			return _precosDasReferenciasRepository.GetPrecosDaReferencias(idTabela);
		}
	}
}

