using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domain.Features.ControleDePrecos.Models;
using domain.Features.ControleDePrecos.Services;
using domain.Features.Produtos.Models;
using domain.Features.Produtos.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PrecosController : ControllerBase
    {
        private readonly ControleDePrecosService _controleDePrecosService;

        public PrecosController(ControleDePrecosService controleDePrecosService)
        {
            _controleDePrecosService = controleDePrecosService;
        }
   

        [HttpGet(Name = "tabelasDePrecos")]
        public IEnumerable<TabelaDePreco> GetTabelaDePrecos()
        {
            return _controleDePrecosService.RecuperarTabelasDePrecosAtivas();
        }

        //[HttpGet(Name = "precos")]
        //[Route("api/[controller]/[action]")]
        //public IEnumerable<PrecoDaReferencia> GetPrecoDaReferencias(int idTabela)
        //{
        //    return _controleDePrecosService.RecuperarPrecosDaTabela(idTabela);
        //} 
    }
}

