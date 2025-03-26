using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace CadastroCliente
{



    public partial class Form2 : Form
    {
        private readonly List<Cliente> Clientes = [];
        private int contadorId;

        public Form2()
        {
            InitializeComponent();
            Endereço endereçoDaniela = new Endereço() { Logradouro = "endereçoDaniela", Numero = "554" };
            Cliente daniela = new Cliente() { Id = 1, Nome = "Daniela Machado", DataNascimento = "23 / 11 / 1995", etnia = Etnia.NEGRO, Tipo = TipoCliente.PF };
            Clientes.Add(daniela);

            Endereço endereçoFabio = new Endereço() { Logradouro = "endereçoFabio", Numero = "345" };
            Cliente fabio = new Cliente() { Id = 2, Nome = "Fabio Saraiva", DataNascimento = "30 / 08 / 2013", etnia = Etnia.BRANCO, Tipo = TipoCliente.PF };
            Clientes.Add(fabio);

            Endereço endereçoVitor = new Endereço() { Logradouro = "endereçoVitor", Numero = "304" };
            Cliente vitor = new Cliente() { Id = 3, Nome = "Fabio Saraiva", DataNascimento = "15 / 09/ 1997", etnia = Etnia.BRANCO, Tipo = TipoCliente.PF };
            Clientes.Add(vitor);
        }
        
       

    }
}