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

        public void Salvar(int id, string nome, string conteudo, DateTime data)
        {
            using (SqlConnection connection = new SqlConnection(
                sqlConnection()))
            {
                string queryString = "insert into paginas(nome, conteudo, data) values (@nome,@conteudo,TRY_CONVERT(datetime,@data, 121))";
                
                if (id != 0)
                {
                    queryString = "update paginas set nome=@nome, conteudo=@conteudo, data= TRY_CONVERT(datetime,@data, 121) where id =@id";
                }

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd HH:mm:ss"));
                command.Parameters.AddWithValue("@conteudo", conteudo);
                command.CommandText = queryString;
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable BuscarPorId(int id)
        {

            using (SqlConnection connection = new SqlConnection(
                sqlConnection()))
            {
                string queryString = "Select * from paginas where id="+id;
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
