using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Pagina
    {
        private string sqlConnection()
        {
            return ConfigurationManager.AppSettings["SqlConnection"];
        }

        public DataTable Lista()
        {
            using (SqlConnection connection = new SqlConnection(
                sqlConnection()))
            {
                //string queryString = "Select * from clientes c inner join pedidos p on c.idCliente = p.idCliente where p.idCliente =" + id;
                string queryString = "Select * from paginas";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
