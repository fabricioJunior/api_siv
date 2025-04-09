using System;
using domain.Features.Pedidos;
using domain.Features.Pedidos.Models;
using domain.Features.Pedidos.Repositories;
using domain.Features.Produtos.Models;
using infra.DataTransferObjects;
using infra.RemoteDataAccess;

namespace infra.LocalDataAccess.Repositories.PedidosRepositories
{
    public class NFCRepository : INFCRepository
    {

        private readonly int ambiente = 2;
        private readonly NFCWebManiaRemoteDataSource nFCWebManiaRemoteDataSource;

        public NFCRepository(
            NFCWebManiaRemoteDataSource nFCWebManiaRemoteDataSource
            )
        {
            this.nFCWebManiaRemoteDataSource = nFCWebManiaRemoteDataSource;

        }

        public string NovaNFC(Pedido pedido, List<ProdutoDoPedido> produtos)
        {
            var produtosNFC = ProdutoNFCs(produtos);
            var pedidoNFC = new PedidoNFC(pedido);
            var novaNFC = new NFC(pedido.id, null, 1, "Venda de produção do estabelecimento", 2, 1, ambiente, null, produtosNFC, pedidoNFC);

            return nFCWebManiaRemoteDataSource.PostNFC(novaNFC);
        }

        public string NovasNFCs(List<Pedido> pedidos)
        {
            throw new NotImplementedException();
        }

        private List<ProdutoNFC> ProdutoNFCs(List<ProdutoDoPedido> produtos)
        {
            var nfcs = produtos.Select(x => new ProdutoNFC(x));
            return nfcs.ToList();
        }

        private PedidoNFC PedidoNFC(Pedido pedido) => new PedidoNFC(pedido);

        public string NovaNFC(domain.Features.Pedidos.Pedido pedido, List<ProdutoDoPedido> produtos)
        {
            throw new NotImplementedException();
        }

        public string NovasNFCs(List<domain.Features.Pedidos.Pedido> pedidos)
        {
            throw new NotImplementedException();
        }
    }
}

