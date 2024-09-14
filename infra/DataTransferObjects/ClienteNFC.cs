using System;
namespace infra.DataTransferObjects
{
	public class ClienteNFC
	{

        public string cpf { get; set; }
        public string nome_completo { get; set; }
        public string endereco { get; set; }
        public string complemento { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }

        public ClienteNFC(string cpf, string nome_completo, string endereco, string complemento, int numero, string bairro, string cidade, string uf, string cep, string telefone, string email)
        {
            this.cpf = cpf;
            this.nome_completo = nome_completo;
            this.endereco = endereco;
            this.complemento = complemento;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.cep = cep;
            this.telefone = telefone;
            this.email = email;
        }
    }
}

