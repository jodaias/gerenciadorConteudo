using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Cliente
    {
        public string Nome { get; set; }
        public List<Cliente> Clientes()
        {
            //new Database.Cliente().Clientes();
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Nome = "Jodaías" });

            return clientes;
        }
    }
}
