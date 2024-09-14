using System;
using System.Collections.Generic;
using domain.Features.Produtos.Models;
using domain.Features.Produtos.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {

        private readonly ProdutosService _produtosService;


        public ProdutosController(ProdutosService produtosService)
        {
            _produtosService = produtosService;
        }
        
        [HttpGet(Name = "busca")]
       
        public IEnumerable<Produto> GetProdutos(string? busca, DateTime? dtUltimaAlteracao)
        {
            if (dtUltimaAlteracao != null)
            {
               return  _produtosService.buscarProdutos((DateTime)dtUltimaAlteracao);
            }
            if (busca != null)
            {
              return _produtosService.buscarProdutos(busca);

            }

            return _produtosService.buscarProdutos();
        }



    }
}

