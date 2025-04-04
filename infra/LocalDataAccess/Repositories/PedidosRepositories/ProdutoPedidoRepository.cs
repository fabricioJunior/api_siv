using System;
using domain.Features.Produtos.Models;
using domain.Features.Produtos.Repositories;
using infra.Common;

namespace infra.LocalDataAccess.Repositories.PedidosRepositories
{
	public class ProdutoPedidoRepository : SqlConnectionRepositoryBase<ProdutoPedido>, IProdutoPedidoRespository
	{
		public ProdutoPedidoRepository()
		{
		}

        public List<ProdutoPedido> GetProdutoPedido(int idPedido)
        {
                throw new NotImplementedException();

        }

        public List<ProdutoPedido> GetProdutoPedidos(DateTime inicial, DateTime final)
        {

            var comando = SqlCommand("SELECT PEDIDO, CODBAR, DESCRICAO,TAM, COR, PRECO,DESCONTO,FORPAG,QTD,DATA FROM PagamentoRomenio as itens RIGHT  join View_Romaneio_Items as p on p.PEDIDO = itens.ROMANEIO where   CONFIRMADO = 1 AND [DATA] >= DATEADD(DAY, 0, DATEDIFF(DAY, 0, CURRENT_TIMESTAMP)) AND [DATA] <  DATEADD(DAY, 1, DATEDIFF(DAY, 0, CURRENT_TIMESTAMP))  GROUP by PEDIDO,CODBAR, DESCRICAO,TAM, COR, PRECO,DESCONTO,FORPAG,QTD,DATA");
            comando.Parameters.AddWithValue("@inicio", inicial);
            comando.Parameters.AddWithValue("@fim", final);
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
                    preco: double.Parse(reader["PRECO"].ToString()),
                    formaDePagamento : reader["FORPAG"].ToString(),
                    quantidade: int.Parse(reader["QTD"].ToString()),
                    codigoDeBarras: reader["CODBAR"].ToString()
                    );

                resultado.Add(produto);

#pragma warning disable CS8604 // Possível argumento de referência nula.

            }
            return resultado;
        }
    }
}

