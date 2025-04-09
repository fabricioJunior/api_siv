public interface IPedidoNFRepository { 
   List<Pedido> GetPedidosDoDia(); 

   Pedido GetPedido(int id);
}