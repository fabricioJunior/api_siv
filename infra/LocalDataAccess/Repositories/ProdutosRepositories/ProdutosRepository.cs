﻿using System;

        public List<Produto> GetProdutos(DateTime ultimaAlteracao)
        {

            var comando = SqlCommand("select  P.CODBAR, P.CD_PRODUTO, p.TAM, P.COR, P.REFER, p.EST_FISICO,P.DESCRICAO,PRECO.[PRECO], H.[Data] from LJEST_HISTORICO as h inner join  Produtos as p  on p.CODBAR = h.CODBAR INNER JOIN LJTPREI as preco on preco.REFER = p.REFER\nWHERE h.Data >= @dataAlteraca OR preco.DTALTERA >=  @dataAlteraca ORDER by [Data] desc");

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
                resultado.Add(produto
        }

        public List<Produto> GetProdutos()
        {
            var comando = SqlCommand(" select  P.CODBAR, P.CD_PRODUTO, p.TAM, P.COR, P.REFER, p.EST_FISICO,P.DESCRICAO,PRECO.[PRECO], H.[Data] from LJEST_HISTORICO as h inner join  Produtos as p  on p.CODBAR = h.CODBAR INNER JOIN LJTPREI as preco on preco.REFER = p.REFER\nWHERE p.EST_FISICO > 0");

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
                resultado.Add(produto
        }

        public List<Produto> GetProdutosPor(string busca)

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
                resultado.Add(produto
       