using GestaoRH;
using GestaoRH.BancoDados.Dominio;
using System;
using System.Text.RegularExpressions;


namespace GestãoRH
{
    public partial class Form1 : Form
    {
        private int? funcionarioId;
        public Form1()
        {
            InitializeComponent();

            textBoxID.Enabled = false;
            textBoxID.ReadOnly = true;

            button1.Text = "Criar";
        }

        public Form1(int funcionarioId)
        {
            InitializeComponent();
            this.funcionarioId = funcionarioId;

            textBoxID.Enabled = false;
            textBoxID.ReadOnly = true;
            textBoxID.Text = funcionarioId.ToString();

            button1.Text = "Alterar";
        }

        private bool ValidaçoesDadosPessoais()
        {
            // Painel 1

            var nome = textNome.Text;
            // Validação Nome
            if (string.IsNullOrEmpty(textNome.Text) || Regex.IsMatch(textNome.Text, @"[^a-zA-Z0-9\s]") || nome.Split(' ').Length < 2)
            {
                MessageBox.Show("Insira um Nome Valído");
                return true;
            }

            // validação Cpf
            string CPF = new string(MBCpf.Text.Where(char.IsDigit).ToArray());

            if (string.IsNullOrWhiteSpace(CPF) || CPF.Length != 11)
            {
                MessageBox.Show("Numero do CPF Invalido");
                return true;
            }
            // validar RG

            string RG = new string(MBRG.Text.Where(char.IsDigit).ToArray());


            if (string.IsNullOrWhiteSpace(RG) || RG.Length != 9)
            {
                MessageBox.Show("Numero do RG Invalido");
                return true;
            }
            // validar Data de Nascimento

            var DataNascimento = MBDataNascimento.Text;

            if (!DateTime.TryParse(MBDataNascimento.Text, out var dataNascimento))
            {
                MessageBox.Show("Insira uma data valida");
                return true;

            }

            // validar genero 

            if (CBGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Informe Seu Genêro");
                return true;
            }

            // validar Estado Civil

            if (CBEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Informe Seu Estado Civil");
                return true;
            }



















            return false;
        }
        private bool ValidarDependentes()
        {
            // Nome Dependente
            var nomeDependentes = txtNome2.Text;
            if (string.IsNullOrEmpty(txtNome2.Text) || Regex.IsMatch(textNome.Text, @"[^a-zA-Z0-9\s]") || nomeDependentes.Split(' ').Length < 2)
            {
                MessageBox.Show("Insira um Nome Valído");
                return true;
            }

            // Cpf Dependente
            string CPFDependente = new string(MBCPFDependente.Text.Where(char.IsDigit).ToArray());

            string cpfDigitado = MBCpf.Text.Trim();



            if (string.IsNullOrWhiteSpace(CPFDependente) || CPFDependente.Length != 11)
            {
                MessageBox.Show("Numero do CPF Invalido");
                return true;
            }

            //  RG Dependente

            string RGDependente = new string(MBRgDependente.Text.Where(char.IsDigit).ToArray());


            if (string.IsNullOrWhiteSpace(RGDependente) || RGDependente.Length != 9)
            {
                MessageBox.Show("Numero do RG Invalido");
                return true;
            }

            //Data Dependente
            if (!DateTime.TryParse(MBDataDependente.Text, out var dataNascimento))
            {
                MessageBox.Show("Insira uma data valida");
                return true;

            }


            // Genero Dependente

            if (CBGeneroDependente.SelectedIndex == -1)
            {
                MessageBox.Show("Informe o Genêro do Dependente");
                return true;
            }

            // Parentesco Validação

            if (CBParentesco.SelectedIndex == -1)
            {
                MessageBox.Show("Informe o Parentesco do Dependente");
                return true;
            }



            return false;
        }
        private bool ValidarEndereco()
        {
            if (string.IsNullOrEmpty(MBCEP.Text))
            {
                MessageBox.Show("Informe O Cep");
                return true;
            }
            if (string.IsNullOrEmpty(TXTLogradouro.Text))
            {
                MessageBox.Show("Informe O Logradoro");
                return true;
            }
            if (string.IsNullOrEmpty(TXTNumero.Text))
            {
                MessageBox.Show("Informe O Numero");
                return true;
            }
            if (string.IsNullOrEmpty(TXTComplemento.Text))
            {
                MessageBox.Show("Informe O Complemento");
                return true;
            }
            if (string.IsNullOrEmpty(TXTBairro.Text))
            {
                MessageBox.Show("Informe O Bairro");
                return true;
            }
            if (string.IsNullOrEmpty(TXTCidade.Text))
            {
                MessageBox.Show("Informe O Cidade");
                return true;
            }

            if (CBEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Informe O Estado");
                return true;
            }



            return false;
        }
        private bool ValidarFuncao()
        {
            if (string.IsNullOrEmpty(TXTCargo.Text))
            {
                MessageBox.Show("Campo Cargo Obrigatorio");
                TXTCargo.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(TXTDepartamento.Text))
            {
                MessageBox.Show("Campo Departamento Obrigatorio");
                TXTCargo.Focus();
                return true;
            }

            var DataAdmissao = MBDataAdimissao.Text;

            if (!DateTime.TryParse(MBDataAdimissao.Text, out var DataAdimissao))
            {
                MessageBox.Show("Insira a Data de Admissão");
                return true;

            }

            if (string.IsNullOrEmpty(MBSalario.Text))
            {
                MessageBox.Show("Insira o Salario do Funcionario");
                MBSalario.Focus();
                return true;
            }


            return false;
        }
        private void InserirSql()
        {
            DateTime DataNascimento;

            if (DateTime.TryParse(MBDataNascimento.Text, out DataNascimento))
            {

            }

            var funcionario = new Funcionario
            {
                NomeCompleto = textNome.Text,
                CPF = MBCpf.Text,
                RG = MBRG.Text,
                DataNascimento = DataNascimento,
                Genero = CBGenero.Text,
                EstadoCivil = CBEstadoCivil.Text,



            };

            DateTime DataDependente;
            if (DateTime.TryParse(MBDataDependente.Text, out DataDependente))
            {

            }



            var dependente = new Dependente
            {
                NomeCompleto = txtNome2.Text,
                CPF = MBCPFDependente.Text,
                RG = MBRG.Text,
                DataNascimentoDependente = DataDependente,
                GeneroDependente = CBGeneroDependente.Text,
                Parentesco = CBParentesco.Text,

            };








            var endereco = new Endereco
            {
                CEP = MBCEP.Text,
                Logradouro = TXTLogradouro.Text,
                Numero = TXTNumero.Text,
                Complemento = TXTComplemento.Text,
                Bairro = TXTBairro.Text,
                Cidade = TXTCidade.Text,
                Estado = CBEstado.Text,

            };

            DateTime DataAdimissao;
            if (DateTime.TryParse(MBDataAdimissao.Text, out DataAdimissao))
            {

            }

            var funcao = new Funcao
            {
                Cargo = TXTCargo.Text,
                Departamento = TXTDepartamento.Text,
                DataAdmissao = DataAdimissao,
                Salario = decimal.Parse(MBSalario.Text.Replace("R$", ""))



            };




            try
            {
                var idFuncionario = Repositorio.InserirFuncionario(funcionario);
                Repositorio.InserirDependente(dependente, idFuncionario);
                Repositorio.InserirEndereco(endereco, idFuncionario);
                Repositorio.InserirFuncao(funcao, idFuncionario);




                MessageBox.Show("Usuário salvo com sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar: ");
            }




        }

        private void MBCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MBCpf.Mask = "000.000.000-00";

        }

        private void button1_Click(object sender, EventArgs e)
        {





        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ValidaçoesDadosPessoais() || ValidarDependentes() || ValidarEndereco() || ValidarFuncao()) { return; }
            InserirSql();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interface_Inicial fomr2 = new Interface_Inicial();
            fomr2.Show();
            this.Close();
        }
    }
}
