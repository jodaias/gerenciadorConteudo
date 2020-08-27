using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pagina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }

        public List<Pagina> Lista()
        {

            var listaPagina = new List<Pagina>();
            var paginaDB = new Database.Pagina();
            foreach (DataRow row in paginaDB.Lista().Rows)
            {
                var pagina = new Pagina();
                pagina.Id = Convert.ToInt32(row["id"]);
                pagina.Nome = row["nome"].ToString();
                pagina.Conteudo = row["conteudo"].ToString();
                pagina.Data = Convert.ToDateTime(row["data"]);
                
                listaPagina.Add(pagina);
            }
            return listaPagina;
        }

        public void Save()
        {
            new Database.Pagina().Salvar(this.Id, this.Nome, this.Conteudo, this.Data);
        }

        public static Pagina BuscarPorId(int id)
        {
            var pagina = new Pagina();
            var paginaDB = new Database.Pagina();
            foreach (DataRow row in paginaDB.BuscarPorId(id).Rows)
            {
                pagina.Id = Convert.ToInt32(row["id"]);
                pagina.Nome = row["nome"].ToString();
                pagina.Conteudo = row["conteudo"].ToString();
                pagina.Data = Convert.ToDateTime(row["data"]);
            }
            return pagina;
        }
    }
}
