using System;
using domain.Features.ControleDePrecos.Models;
using domain.Features.Produtos.Models;
using domain.Features.Produtos.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : ControllerBase
    {

        private readonly PessoasService _pessoasService;

		public PessoasController(PessoasService pessoasService)
		{
            _pessoasService = pessoasService;
		}

        [HttpGet]
        public IEnumerable<Pessoa> GetPessoas()
        {
            return _pessoasService.recuperaPessoas();
        }

        [HttpPost(Name = "Post")]
        public void PostPessoa(Pessoa pessoa)
        {
            _pessoasService.SalvarPessoa(pessoa);
        }

    }
}

