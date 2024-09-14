using System;
using domain.Features.ControleDePrecos.Models;
using domain.Features.Produtos.Repositories;

namespace domain.Features.Produtos.Services
{
	public class PessoasService
	{

		private readonly IPessoaRepository _pessoaRepository;

		public PessoasService(IPessoaRepository pessoaRepository)
		{
			_pessoaRepository = pessoaRepository;

		}

		public void SalvarPessoa(Pessoa pessoa) {
			_pessoaRepository.Salvar(pessoa);
		}

		public List<Pessoa> recuperaPessoas() {
			return _pessoaRepository.recuperarPessoas();
		}
	}
}

