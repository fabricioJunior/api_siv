using System;
using domain.Features.ControleDePrecos.Models;
using domain.Features.Pedidos;

namespace infra.DataTransferObjects
{
    public class PedidoNFC
    {

        public int pagamento { get; private set; }
        public int presenca { get; private set; }
        public int modalidade_frete { get; set; }
        public string frete { get; set; }
        public string desconto { get; set; }
        public string total { get; set; }
        public string forma_pagamento { get; set; }
        public string valor_pagamento { get; set; }

        public PedidoNFC(int pagamento, int presenca, int modalidade_frete, string frete, string desconto, string total, string formaPagamento, string valorPagamento)
        {
            this.pagamento = pagamento;
            this.presenca = presenca;
            this.modalidade_frete = modalidade_frete;
            this.frete = frete;
            this.desconto = desconto;
            this.total = total;
            this.forma_pagamento = formaPagamento;
            this.valor_pagamento = valorPagamento;
        }

        public PedidoNFC(Pedido pedido)
        {
            presenca = 1;
            modalidade_frete = 9;
            frete = "0";
            // desconto = pedido.Desconto.ToString(); //TODO: Verificar formatação
            // total = pedido.ValorTotal.ToString(); // TODO: Verificar formatação
            // forma_pagamento = pedido.FormaDePagamento.ToString(); //TODO: Verificar dado
            // valor_pagamento = pedido.ValorTotal.ToString(); //TODO: Verificar formatação
        }

    }
}

