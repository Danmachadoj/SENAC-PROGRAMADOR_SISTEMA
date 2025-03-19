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

namespace CadastroCliente
{



    public partial class Form2 : Form
    {
        private readonly List<Cliente> Clientes = [];
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
            Cliente vitor = new Cliente() { Id = 2, Nome = "Fabio Saraiva", DataNascimento = "15 / 09/ 1997", etnia = Etnia.BRANCO, Tipo = TipoCliente.PF };
            Clientes.Add(vitor);
        }

        private void tbnome_TextChanged(object sender, EventArgs e)
        {
          

            string nome = tbnome.Text;
            string telefone = mtbtelefone.Text;
            string cep = mtbcep.Text;
            string datanascimento = mtbdata.Text;
            string nomesocial = tbtnomesocial.Text;
            string genero = cbgenero.Text;
            string email = tbemail.Text;
            string longradouro = tblogradouro.Text;
            string complemento = tbcomplemento.Text;
            string bairro = tbbairro.Text;
            string numero = tbnumero.Text;
            string municipio = tbmunicio.Text;
            string estado = cbestado.Text;
            bool PF = rbpf.Checked;
            bool PJ = rbpj.Checked;
            bool estrangeiro = cbestrangeiro.Checked;

            return;
        }
    }
}
