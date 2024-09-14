using System;using domain.Features.Produtos.Models;using domain.Features.Produtos.Repositories;using infra.Common;namespace infra.LocalDataAccess.Repositories.ProdutosRepositories{	public class ProdutosRepository: SqlConnectionRepositoryBase<Produto>, IProdutosRepository	{		public ProdutosRepository()		{		}        public List<Produto> GetProdutos(string identificadoReferencia)        {            throw new NotImplementedException();        }

        public List<Produto> GetProdutos(DateTime ultimaAlteracao)
        {

            var comando = SqlCommand("select  P.CODBAR, P.CD_PRODUTO, p.TAM, P.COR, P.REFER, p.EST_FISICO,P.DESCRICAO,PRECO.[PRECO], H.[Data] from LJEST_HISTORICO as h inner join  Produtos as p  on p.CODBAR = h.CODBAR INNER JOIN LJTPREI as preco on preco.REFER = p.REFER\nWHERE h.Data >= @dataAlteraca OR preco.DTALTERA >=  @dataAlteraca ORDER by [Data] desc");            comando.Parameters.AddWithValue("@dataAlteraca", ultimaAlteracao);            comando.Connection.Open();            List<Produto> resultado = new List<Produto>();            var reader = comando.ExecuteReader();            while (reader.Read())            {

#pragma warning disable CS8604 // Possível argumento de referência nula.
                var produto = new Produto(
                    reader["CODBAR"].ToString(),
                    reader["CD_PRODUTO"].ToString(),
                    reader["TAM"].ToString(),
                    cor: reader["COR"].ToString(),
                    estoque: int.Parse(reader["EST_FISICO"].ToString()),
                    descricao: reader["DESCRICAO"].ToString(),
                    preco: double.Parse(reader["preco"].ToString()),
                    refer: reader["REFER"].ToString()
                    );
#pragma warning restore CS8604 // Possível argumento de referência nula.
                resultado.Add(produto                    );            }            return resultado;
        }

        public List<Produto> GetProdutos()
        {
            var comando = SqlCommand(" select  P.CODBAR, P.CD_PRODUTO, p.TAM, P.COR, P.REFER, p.EST_FISICO,P.DESCRICAO,PRECO.[PRECO], H.[Data] from LJEST_HISTORICO as h inner join  Produtos as p  on p.CODBAR = h.CODBAR INNER JOIN LJTPREI as preco on preco.REFER = p.REFER\nWHERE p.EST_FISICO > 0");            comando.Connection.Open();            List<Produto> resultado = new List<Produto>();            var reader = comando.ExecuteReader();            while (reader.Read())            {

#pragma warning disable CS8604 // Possível argumento de referência nula.
                var produto = new Produto(
                    reader["CODBAR"].ToString(),
                    reader["CD_PRODUTO"].ToString(),
                    reader["TAM"].ToString(),
                    cor: reader["COR"].ToString(),
                    estoque: int.Parse(reader["EST_FISICO"].ToString()),
                    descricao: reader["DESCRICAO"].ToString(),
                    preco: double.Parse(reader["preco"].ToString()),
                    refer: reader["REFER"].ToString()
                    );
#pragma warning restore CS8604 // Possível argumento de referência nula.
                resultado.Add(produto                    );            }            return resultado;
        }

        public List<Produto> GetProdutosPor(string busca)        {                      var comando = SqlCommand("SELECT * FROM(\n\nselect *  from PRODUTOS where (DESCRICAO like '%'+@Filter+'%' or DS_REFER like '%'+@Filter+'%') \n\n) AS SOURCE order by EST_FISICO desc");            comando.Parameters.AddWithValue("@Filter", busca);            comando.Connection.Open();            List<Produto> resultado = new List<Produto>();            var reader = comando.ExecuteReader();            while (reader.Read())            {

#pragma warning disable CS8604 // Possível argumento de referência nula.
                var produto = new Produto(
                    reader["CODBAR"].ToString(),
                    reader["CD_PRODUTO"].ToString(),
                    reader["TAM"].ToString(),
                    cor: reader["COR"].ToString(),
                    estoque: int.Parse( reader["EST_FISICO"].ToString()),
                    descricao: reader["DESCRICAO"].ToString(),
                    preco: 00
                    ,refer: reader["REFER"].ToString()
                    );
#pragma warning restore CS8604 // Possível argumento de referência nula.
                resultado.Add(produto                    );            }            return resultado;        }
           }}