
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
using System.Text.RegularExpressions;
using CadastroCliente.dominio;

namespace CadastroCliente
{



    public partial class Form2 : Form
    {
        private readonly List<Cliente> Clientes = [];
        private readonly BindingSource bindingSource = [];
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
            Cliente vitor = new Cliente() { Id = 3, Nome = "Vitor Lima", DataNascimento = "15 / 09/ 1997", etnia = Etnia.BRANCO, Tipo = TipoCliente.PF };
            Clientes.Add(vitor);

            bindingSource.DataSource = Clientes;
            dataGridView1.DataSource = bindingSource;

        }




        public bool PF { get; private set; }
        public bool PJ { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tbnome.Text;
            string telefone = mtbtelefone.Text;
            string cep = mtbcep.Text;
            string datanascimento = mtbdata.Text;
            string nomesocial = tbtnomesocial.Text;
            string genero = cbgenero.Text;
            string etnia = cbetnia.Text;
            string email = tbemail.Text;
            string logradouro = tblogradouro.Text;
            string complemento = tbcomplemento.Text;
            string bairro = tbbairro.Text;
            string numero = tbnumero.Text;
            string municipio = tbmunicio.Text;
            string estado = cbestado.Text;
            bool PF = rbpf.Checked;
            bool PJ = rbpj.Checked;
            bool estrangeiro = cbestrangeiro.Checked;

            if (!ValidarFormulario(nome, telefone, cep, datanascimento, nomesocial, genero, etnia, email, logradouro, complemento, bairro, numero, municipio, estado, PF, PJ, estrangeiro))
            {
                return;
            }

            Endereço endereco_Novo = new Endereço()
            {
                Logradouro = logradouro,
                Complemento = complemento,
                Bairro = bairro,
                Numero = numero,
                Municipio = municipio,
                Estado = estado

            };


            Cliente novoCliente = new Cliente()
            {
                Id = Clientes.Max(clientes => clientes.Id) + 1,
                Nome = nome,
                Telefone = telefone,
                DataNascimento = datanascimento,
                NomeSocial = nomesocial,
                etnia = (Etnia)cbetnia.SelectedIndex,
                Genero = (Genero)cbgenero.SelectedIndex,
                Email = email,
                Endereço = endereco_Novo,
                Tipo = PF ? TipoCliente.PF : TipoCliente.PJ,
                Estrangeiro = estrangeiro
            };

            Clientes.Add(novoCliente);
            bindingSource.ResetBindings(false);

            MessageBox.Show("Formulário enviado com sucesso!");
        }


        private bool ValidarFormulario(string nome, string telefone, string cep, string datanascimento, string nomesocial, string genero, string etnia, string email, string longradouro, string complemento, string bairro, string numero, string municipio, string estado, bool PF, bool PJ, bool estrangeiro)
        {
            bool valido = true;
            string mensagemErro = "";


            if (string.IsNullOrEmpty(tbnome.Text))
            {
                valido = false;
                mensagemErro += "Nome não pode ser vazio.\n";
            }


            if (string.IsNullOrEmpty(mtbtelefone.Text))
            {
                valido = false;
                mensagemErro += "Telefone inválido. Formato esperado: (XX) XXXXX-XXXX.\n";
            }
            else if (Clientes.Any(c => c.Telefone == mtbtelefone.Text))
            {
                valido = false;
                mensagemErro += "Telefone já cadastrado.\n";
            }


            if (string.IsNullOrEmpty(mtbcep.Text) || !Regex.IsMatch(mtbcep.Text, @"^\d{5}-\d{3}$"))
            {
                valido = false;
                mensagemErro += "CEP inválido. Formato esperado: 12345-678.\n";
            }


            if (string.IsNullOrEmpty(mtbdata.Text) || !DateTime.TryParse(mtbdata.Text, out _))
            {
                valido = false;
                mensagemErro += "Data de nascimento inválida.\n";
            }



            Genero generoEnum;
            if (!Enum.TryParse(genero, true, out generoEnum))
            {
                MessageBox.Show("Gênero inválido.");

            }


            if (string.IsNullOrEmpty(tbemail.Text) || !Regex.IsMatch(tbemail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                valido = false;
                mensagemErro += "Email inválido.\n";
            }


            if (string.IsNullOrEmpty(tblogradouro.Text))
            {
                valido = false;
                mensagemErro += "Logradouro não pode ser vazio.\n";
            }


            if (string.IsNullOrEmpty(tbbairro.Text))
            {
                valido = false;
                mensagemErro += "Bairro não pode ser vazio.\n";
            }
            else if (Clientes.Any(c => c.Email == tbemail.Text))
            {
                valido = false;
                mensagemErro += "Email já cadastrado.\n";


                if (string.IsNullOrEmpty(tbnumero.Text) || !int.TryParse(tbnumero.Text, out _))
                {
                    valido = false;
                    mensagemErro += "Número deve ser um valor numérico.\n";
                }


                if (string.IsNullOrEmpty(tbmunicio.Text))
                {
                    valido = false;
                    mensagemErro += "Município não pode ser vazio.\n";
                }


                if (string.IsNullOrEmpty(cbestado.Text))
                {
                    valido = false;
                    mensagemErro += "Estado deve ser selecionado.\n";
                }


                if (!PF && !PJ)
                {
                    valido = false;
                    mensagemErro += "Deve ser selecionado se é Pessoa Física (PF) ou Pessoa Jurídica (PJ).\n";
                }



            }
            if (!valido)
            {
                MessageBox.Show(mensagemErro, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        private void tbnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}