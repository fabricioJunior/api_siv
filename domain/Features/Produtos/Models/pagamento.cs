public class Pagamento
{
    public Pagamento(string formaDePagamento, double valor)
    {
        this.FormaDePagamento = formaDePagamento;
        this.valor = valor;
    }

    public string FormaDePagamento { get; set; }
    public double valor { get; set; }

}