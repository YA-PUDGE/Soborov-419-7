using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace appollosxsxsxolsxlosl
{
    class DataLayer
    {
        private SqlConnection _connection;

        public DataLayer()
        {
            _connection = new SqlConnection(@"Data Source=ADCLG1;Initial Catalog = soborov_praktika_base;Integrated Security = True");
        }

        public SqlConnection GetConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
            return _connection;
        }

        public void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }



    }



}