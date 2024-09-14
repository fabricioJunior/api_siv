using System;
using domain.Features.ControleDePrecos.Models;
using domain.Features.Produtos.Repositories;
using infra.Common;
using Microsoft.Data.SqlClient;

namespace infra.LocalDataAccess.Repositories
{
	public class PessoaRepository:SqlConnectionRepositoryBase<Pessoa>, IPessoaRepository

	{
		public PessoaRepository()
		{
		}

        public List<Pessoa> recuperarPessoas()
        {
           
            var command = SqlCommand("select * from LJCLI");
            var con = command.Connection;
            con.Open();
            var dr = command.ExecuteReader();

            List<Pessoa> _values  = ConstruirPessoasDoReader(dr);

            con.Close();
            con.Dispose();
            return _values;
        }

        public List<Pessoa> recuperarPessoas(string busca)
        {
            var command = SqlCommand("select * from LJCLI");
            var con = command.Connection;
            con.Open();
            var dr = command.ExecuteReader();

            List<Pessoa> _values = ConstruirPessoasDoReader(dr);

            con.Close();
            con.Dispose();
            return _values;
        }

        public void Salvar(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        private List<Pessoa> ConstruirPessoasDoReader(SqlDataReader dr)
        {
            List<Pessoa> _values = new List<Pessoa>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
#pragma warning disable CS8601 // Possível atribuição de referência nula.
                    var item = new Pessoa
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        CIDADE = Convert.ToInt32(dr["CIDADE"]),
                        BAIRRO = dr["BAIRRO"].ToString(),
                        LOGRADOURO = dr["LOGRADOURO"].ToString().Trim(),
                        ENDERECO = dr["LOGRADOURO"].ToString().Trim(),
                        NUMERO = dr["NUMERO"].ToString().Trim(),
                        CEP = dr["CEP"].ToString().Trim(),
                        COMPLEMENTO = dr["COMPLEMENTO"].ToString().Trim(),
                        NOME = dr["NOME"].ToString().Trim(),
                        CPF = dr["CPF"].ToString().Trim(),
                        RG = dr["RG"].ToString().Trim(),
                        SEXO = dr["SEXO"].ToString().Trim(),
                        DDD = dr["DDD"].ToString().Trim(),
                        FONE = dr["FONE"].ToString().Trim(),
                        WHATSAPP = dr["WHATSAPP"].ToString().Trim(),
                        EMAIL = dr["EMAIL"].ToString().Trim(),
                        DataCadastro = Convert.ToDateTime(dr["DataCadastro"]),
                        NASCIMENTO = dr["NASCIMENTO"] == DBNull.Value ? new DateTime() : Convert.ToDateTime(dr["NASCIMENTO"]),
                        VENDEDOR_PADRAO = Convert.IsDBNull(dr["VENDEDOR_PADRAO"]) ? 0 : Convert.ToInt32(dr["VENDEDOR_PADRAO"]),
                    };
#pragma warning restore CS8601 // Possível atribuição de referência nula.

                    _values.Add(item);
                }
            }
            return _values;

        }
    }
}

