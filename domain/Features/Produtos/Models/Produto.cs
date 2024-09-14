using System;
namespace domain.Features.Produtos.Models
{
	public class Produto
	{
        public string CodigoDeBarras { get; set; }
        public string CodigoReduzido { get; set; }
        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public int Estoque { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string Referencia { get; set; }

        public Produto(
           string codigoDeBarras,
           string codigoReduzido,
           string tamanho,
           string cor,
           int estoque,
           string descricao,
           double preco,
           string refer
           )
        {

            CodigoDeBarras = codigoDeBarras;
            CodigoReduzido = codigoReduzido;
            Tamanho = tamanho;
            Cor = cor;
            Estoque = estoque;
            Descricao = descricao;
            Preco = preco;
            Referencia = refer;
        }
    }
}

