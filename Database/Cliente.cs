using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Cliente
    {
        public string Nome { get; set; }
        public List<Cliente> Clientes(string cliente)
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Nome = "Jodaías" });

            return clientes;
        }
    }
}
