using domain.Features.Produtos.Models;
using domain.Features.Produtos.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ProdutosPedidoController : ControllerBase
{

    private readonly ProdutosService _produtosService;


    public ProdutosPedidoController(ProdutosService produtosService)
    {
        _produtosService = produtosService;
    }

    [HttpGet(Name = "GetProdutos")]
    public IEnumerable<ProdutoPedido> GetProdutos(DateTime inicio, DateTime final)
    {
        return _produtosService.GetProdutoPedidos(inicio, final);
    }



}