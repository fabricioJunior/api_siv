using System;
using domain.Features.ControleDePrecos.Models;

namespace domain.Features.Produtos.Repositories
{
	public interface IPessoaRepository
	{

		public void Salvar(Pessoa pessoa);

		public List<Pessoa> recuperarPessoas();

        public List<Pessoa> recuperarPessoas(string busca);
    }
}

