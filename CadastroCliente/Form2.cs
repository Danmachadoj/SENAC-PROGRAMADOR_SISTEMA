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

        private void button1_Click(object sender, EventArgs e)
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

            if (ValidarDados(nome, telefone, cep, datanascimento, genero, email, longradouro, bairro, numero, municipio, estado))
            {
                Cliente novoCliente = new Cliente(); Endereço newEndereço = new Endereço

                {
                    id = contadorId++,
                    Nome = tbnome.Text,
                    Telefone = mtbtelefone.Text,
                    CEP = mtbcep.Text,
                    DataNascimento = mtbdata.Text,
                    Genero = cbgenero.Text,
                    Email = tbemail.Text,
                    Longradouro = tblogradouro.Text,
                    Bairro = tbbairro.Text,
                    Numero = tbnumero.Text,
                    Municipio = tbmunicio.Text,
                    Estado = cbestado.Text,
                    TipoCliente = rbpf.Checked,
                    tipoCliente = rbpj.Checked,
                    
                };


                Clientes.Add(novoCliente);

                MessageBox.Show("Cliente adicionado com sucesso!");
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
            }
        }

        private bool ValidarDados(string nome, string telefone, string cep, string datanascimento, string genero, string email, string longradouro, string bairro, string numero, string municipio, string estado)
        {
            throw new NotImplementedException();
        }

        private void LimparFormulario()
        {
            throw new NotImplementedException();
        }

        public bool ValidarDados(string nome, string telefone, string cep, string datanascimento, string genero, string email, string logradouro, string complemento, string bairro, string numero, string municipio, string estado)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(cep) ||
            string.IsNullOrWhiteSpace(datanascimento) || string.IsNullOrWhiteSpace(genero) ||
            string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(logradouro) || string.IsNullOrWhiteSpace(bairro) ||
            string.IsNullOrWhiteSpace(numero) || string.IsNullOrWhiteSpace(municipio) || string.IsNullOrWhiteSpace(estado))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos.");
                return false;
            }
            if (!nome.Contains(" "))
            {
                MessageBox.Show("Nome Completo por favor!");
                return false;
            }

            if (Clientes.Any(c => c.Telefone == telefone))
            {
                MessageBox.Show("Telefone já cadastrado. Por favor, insira um telefone novo.");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(cep, @"^\d{5}-\d{3}$"))
            {
                MessageBox.Show("CEP inválido. Por favor, insira um CEP no formato XXXXX-XXX.");
                return false;
            }
            if (!DateTime.TryParse(datanascimento, out DateTime dataNascimento))
            {
                MessageBox.Show("Data de nascimento inválida. Por favor, insira uma data válida.");
                return false;
            }
            if (dataNascimento > DateTime.Now)
            {
                MessageBox.Show("Data de nascimento não pode ser uma data futura.");
                return false;
            }
            if (Clientes.Any(c => c.Email == email))
            {
                MessageBox.Show("Email já cadastrado. Por favor, insira um email único.");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email inválido. Por favor, insira um email no formato correto.");
                return false;
            }
 


            void LimparFormulario()
            {
                tbnome.Clear();
                mtbtelefone.Clear();
                mtbcep.Clear();
                mtbdata.Clear();
                tbtnomesocial.Clear();
                cbgenero.SelectedIndex = -1;
                tbemail.Clear();
                tblogradouro.Clear();
                tbcomplemento.Clear();
                tbbairro.Clear();
                tbnumero.Clear();
                tbmunicio.Clear();
                cbestado.SelectedIndex = -1;
                rbpf.Checked = false;
                rbpj.Checked = false;
                cbestrangeiro.Checked = false;
            }
            return true;
        }
    }
}