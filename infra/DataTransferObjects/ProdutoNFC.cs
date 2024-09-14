using System;
using domain.Features.Pedidos.Models;
using domain.Features.Produtos.Models;

namespace infra.DataTransferObjects
{
	public class ProdutoNFC
	{


        public string nome { get; set; }
        public string codigo { get; set; }
        public string ncm { get; set; }
        public int quantidade { get; set; }
        public string unidade { get; set; }
        public int origem { get; set; }
        public string subtotal { get; set; }
        public string total { get; set; }
        public string classe_imposto { get; set; }

        public ProdutoNFC(ProdutoDoPedido produto)
		{
            nome = produto.Descricao;
            codigo = produto.Refer;
            unidade = "UN";
            origem = 0;
            subtotal = produto.Valor.ToString();
            total = (produto.Valor * produto.Quantidade).ToString(); ///TODO: Verificar formação
            ncm = produto.Ncm;
            classe_imposto = "REF154608942";
 		}

	
	}
}

