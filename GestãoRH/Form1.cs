using System.Text.RegularExpressions;

namespace GestãoRH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxID.Enabled = false;
            textBoxID.ReadOnly = true;


        }

        private bool ValidaçoesDadosPessoais()
        {
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

            

                                                   

            











            return false;
        }
        










        private void button1_Click(object sender, EventArgs e)
        {
            ValidaçoesDadosPessoais();
        }

        private void MBCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MBCpf.Mask = "000.000.000-00";

        }
    }










}
