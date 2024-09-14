using System;
using domain.Features.Produtos.Models;

namespace infra.DataTransferObjects
{
	public class NFC
	{

        public int? ID { get; set; }
        public string? url_notificacao { get; set; }
        public int operacao { get; set; }
        public string natureza_operacao { get; set; }
        public int modelo { get; set; }
        public int finalidade { get; set; }
        public int ambiente { get; set; }
        public ClienteNFC? cliente { get; set; }
        public List<ProdutoNFC> produtos { get; set; }
        public PedidoNFC? pedido { get; set; }

        public NFC(
            int? id,
            string? url_notificacao,
            int operacao,
            string naturezaOpercao,
            int modelo,
            int finalidade,
            int ambiente,
            ClienteNFC? clienteNFC,
            List<ProdutoNFC> produtoNFCs,
            PedidoNFC? pedido
            )
		{
            ID = id;
            this.url_notificacao = url_notificacao;
            this.operacao = operacao;
            natureza_operacao = naturezaOpercao;
            this.modelo = modelo;
            this.finalidade = finalidade;
            this.ambiente = ambiente;
            cliente = clienteNFC;
            produtos = produtoNFCs;
            this.pedido = pedido;
		}
	}
}

