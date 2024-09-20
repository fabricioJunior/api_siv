using System;
using Microsoft.Data.SqlClient;

namespace infra.Common
{
	public class SqlConnectionRepositoryBase<E>
	{
		public SqlConnectionRepositoryBase()
		{
		}

        private SqlConnection Connection()
        {
            return new SqlConnection("Data Source=PORONDEFLOR\\SQLEXPRESS;Database=siv;Integrated Security=false;User ID=sa;Password=44668822;Encrypt=false;TrustServerCertificate=True");
        }

        protected SqlCommand SqlCommand(string query)
        {

            return new SqlCommand(query, Connection());
        }

        
    }
}

