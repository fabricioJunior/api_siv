using System.Collections.Generic;
using domain.Features.Produtos.Models;

public class Pedido
{
  public Pedido(
    int id,
    double total,
    double desconto,
    double? taxaDeEntrega,
    List<ProdutoPedido> produtos,
    List<Pagamento> pagamentos
  )
  {
    this.id = id;
    this.total = total;
    this.taxaDeEntrega = taxaDeEntrega;
    this.produtos = produtos;
    this.pagamentos = pagamentos;
    this.desconto = desconto;
  }

  public int id { get; set; }

  public double total { get; set; }

  public double desconto { get; set; }

  public double? taxaDeEntrega { get; set; }

  public List<ProdutoPedido> produtos { get; set; }

  public List<Pagamento> pagamentos { get; set; }
}