using System;
using domain.Features.Pedidos.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NFCsController : ControllerBase
    {
        private readonly NFCsServices _nfcsService;

        public NFCsController(
            NFCsServices nfcsService)

        {
            _nfcsService = nfcsService;
        }


        [HttpPost]
        public string novaNFC(int idPedido) {
            return _nfcsService.novaNFC(idPedido);
        }

    }
}

