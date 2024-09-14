using domain.Features.Pedidos;
using domain.Features.Pedidos.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController: ControllerBase
    {
        private readonly PedidosService pedidosService; 
      
        public PedidosController(PedidosService pedidosService)
		{
            this.pedidosService = pedidosService;
		}

        [HttpGet]
        public List<Pedido> GetPedidos(int formaDePagamento, DateTime inicio, DateTime fim) {
            return pedidosService.GetPedidos((FormaDePagamento) formaDePagamento, inicio, fim);
        }
	}
}

