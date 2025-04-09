
using domain.Features.Produtos.Models;
using infra.Common;

public class PedidoNFReposistory : SqlConnectionRepositoryBase<Pedido>, IPedidoNFRepository
{
    public Pedido GetPedido(int id)
    {
        var taxa = TaxaDeEntrega(id);
        var pagamentos = Pagamentos(id);
        var produtos = GetProdutoPedidos(id);
        var desconto = produtos.Sum(x => x.desconto);
        var total = pagamentos.Sum(x => x.valor);
        return new Pedido(id, total, desconto, taxa, produtos, pagamentos);
    }

    private List<ProdutoPedido> GetProdutoPedidos(int idPedido)
    {

        var comando = SqlCommand(@"SELECT * FROM View_Romaneio_Items WHERE  PEDIDO = @idPedido AND TIPO = 'V' AND CONFIRMADO =1 AND PAGO = 1");
        comando.Parameters.AddWithValue("@idPedido", idPedido);
        comando.Connection.Open();

        List<ProdutoPedido> resultado = new List<ProdutoPedido>();
        var reader = comando.ExecuteReader();
        while (reader.Read())
        {
#pragma warning disable CS8604 // Possível argumento de referência nula.

            var produto = new ProdutoPedido(
                pedido: int.Parse(reader["PEDIDO"].ToString()),
                desconto: double.Parse(reader["DESCONTO"].ToString()),
                descricao: reader["DESCRICAO"].ToString(),
                tamanho: reader["TAM"].ToString(),
                cor: reader["COR"].ToString(),
                valor: double.Parse(reader["PRECO"].ToString()),
                quantidade: int.Parse(reader["QTD"].ToString()),
                codigoDeBarras: reader["CODBAR"].ToString(),
                dsrefer: reader["DS_REFER"].ToString()
                );

            resultado.Add(produto);

#pragma warning disable CS8604 // Possível argumento de referência nula.

        }
        comando.Connection.Close();
        return resultado;
    }

    private List<Pagamento> Pagamentos(int idPedido)
    {
        var comando = SqlCommand(@"SELECT DISTINCT ROMANEIO, FORPAG, SUM(VALOR) as VALOR FROM PagamentoRomenio WHERE ROMANEIO = @idPedido GROUP BY ROMANEIO, FORPAG, VALOR ");
        comando.Parameters.AddWithValue("@idPedido", idPedido);
        comando.Connection.Open();
        var reader = comando.ExecuteReader();

        List<Pagamento> pagamentos = new List<Pagamento>();

        while (reader.Read())
        {
            var pagamento = new Pagamento(
                formaDePagamento: reader["FORPAG"].ToString(),
                valor: double.Parse(reader["VALOR"].ToString())
            );
            pagamentos.Add(pagamento);
        }
        comando.Connection.Close();
        return pagamentos;
    }

    private double? TaxaDeEntrega(int idPedido)
    {

        var comando = SqlCommand(@"SELECT * FROM LJPEDIDOS_ENTREGA where ROMANEIO = @idPedido");
        comando.Parameters.AddWithValue("@idPedido", idPedido);
        comando.Connection.Open();
        var reader = comando.ExecuteReader();

        double? taxa = null;

        while (reader.Read())
        {
            taxa = reader["TAXA"] == null ? null : double.Parse(reader["TAXA"].ToString());
        }
        comando.Connection.Close();
        return taxa;
    }

    public List<Pedido> GetPedidosDoDia()
    {

        // 
        var comando = SqlCommand(@"SELECT * FROM LJPEDIDOS where  TIPO = 'V' AND CONFIRMADO = 1 AND PAGO = 1 AND [DATA] >= DATEADD(DAY, 0, DATEDIFF(DAY, 0, CURRENT_TIMESTAMP)) AND [DATA] <  DATEADD(DAY, 1, DATEDIFF(DAY, 0, CURRENT_TIMESTAMP))");
        comando.Connection.Open();
        var reader = comando.ExecuteReader();

        List<int> idPedidosDoDia = new List<int>();


        while (reader.Read())
        {
            var idPedido = int.Parse(reader["ID"].ToString());
            idPedidosDoDia.Add(idPedido);
        }
        comando.Connection.Close();
        List<Pedido> pedidos = new List<Pedido>();
        foreach (var idPedido in idPedidosDoDia)
        {
            pedidos.Add(GetPedido(idPedido));
        }
        return pedidos;
    }
}