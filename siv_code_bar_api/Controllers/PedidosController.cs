using domain.Features.Produtos.Models;
using domain.Features.Produtos.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PedidosController : ControllerBase
{

    private readonly IPedidoNFRepository _pedidosNFRepository;


    public PedidosController(IPedidoNFRepository pedidosNFRepository)
    {
        this._pedidosNFRepository = pedidosNFRepository;
    }

    [HttpGet(Name = "GetPedidosDoDia")]
    public List<Pedido> GetProdutos()
    {
        return _pedidosNFRepository.GetPedidosDoDia();
    }



}