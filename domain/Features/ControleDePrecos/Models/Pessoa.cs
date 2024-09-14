using System;
namespace domain.Features.ControleDePrecos.Models
{
	public class Pessoa
	{

        public int ID { get; set; }
        public required string NOME { get; set; }
        public required string CPF { get; set; }
        public required string RG { get; set; }
        public string CEP { get; set; }
        public string LOGRADOURO { get; set; }
        public string ENDERECO { get; set; }
        public string NUMERO { get; set; }
        public string BAIRRO { get; set; }
        public int CIDADE { get; set; }
        public string COMPLEMENTO { get; set; }
        public string EMAIL { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime NASCIMENTO { get; set; }
        public string FONE { get; set; }
        public string DDD { get; set; }
        public string WHATSAPP { get; set; }
        public int VENDEDOR_PADRAO { get; set; }
        public string SEXO { get; set; }


        public Pessoa()
        {

        }
        public Pessoa(
           string nome,
           string cpf,
           string rg,
           string cep,
           string logradouro,
           string endereco,
           string numero,
           string bairro,
           int cidade,
           string complemento,
           string email,
           DateTime dataNascimento,
           string fone,
           string ddd,
           string whatsapp,
           int vendedorPadrao,
           string sexo
            ) {

            NOME = nome;
            CPF = cpf;
            RG = rg;
            CEP = cep;
            LOGRADOURO = logradouro;
            ENDERECO = endereco;
            NUMERO = numero;
            BAIRRO = bairro;
            CIDADE = cidade;
            COMPLEMENTO = complemento;
            EMAIL = email;
            NASCIMENTO = dataNascimento;
            FONE = fone;
            DDD = ddd;
            WHATSAPP = whatsapp;
            VENDEDOR_PADRAO = vendedorPadrao;
            SEXO = sexo;
        }

    }
}

