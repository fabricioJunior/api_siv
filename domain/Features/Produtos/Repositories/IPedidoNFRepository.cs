using System.Collections.Generic;

public interface IPedidoNFRepository
{
   List<Pedido> GetPedidosDoDia();

   Pedido GetPedido(int id, bool produtosDoPagamento = false);
}