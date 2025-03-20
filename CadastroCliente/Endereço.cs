using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    internal class Endereço
    {
        internal bool tipoCliente;
        internal object id;

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Municipio { get; set; }

        public string Estado { get; set; }

        public string CEP { get; set; }
        public string Nome { get; internal set; }
        public string Telefone { get; internal set; }
        public string DataNascimento { get; internal set; }
        public string NomeSocial { get; internal set; }
        public string Genero { get; internal set; }
        public string Email { get; internal set; }
        public bool Estrangeiro { get; internal set; }
        public bool TipoCliente { get; internal set; }
        public string Longradouro { get; internal set; }
    }
}
