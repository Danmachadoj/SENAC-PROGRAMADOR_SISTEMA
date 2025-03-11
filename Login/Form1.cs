using System.ComponentModel.DataAnnotations;

namespace Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
      
        Usuario joe = new Usuario() { Email = "joe.jonas@email.com", Senha = "brothers" };
        Usuario chris = new Usuario() { Email = "chris.brown@email.com", Senha = "residuals" };
        Usuario elisa = new Usuario() { Email = "elisa.jesus@email.com", Senha = "nenem" };


        private void button1_Click(object sender, EventArgs e)
        {

            string usuarioBuscado = BoxAcesso.Text;
            string senha = BoxSenha.Text;


            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                LabelResultado.Text = "Usuario é obrigatório!!";
                LabelResultado.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                LabelResultado.Text = "Senha é obrigatório!!";
                LabelResultado.ForeColor = Color.Red;
                return;
            }

            int posicaoUsuarioEncontrado = listaUsuarios.IndexOf(usuarioBuscado);
                          

            if (posicaoUsuarioEncontrado ==  -1 || senha !=  listaSenha[posicaoUsuarioEncontrado])
            {
                LabelResultado.Text = "Usuario ou Senha incorretos...";
                LabelResultado.ForeColor = Color.Red;
                return;
            }

            LabelResultado.Text = "Autenticado com sucesso";
            LabelResultado.ForeColor = Color.Green;
            BoxAcesso.Clear();
            BoxSenha.Clear();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string novoUsuario = textBoxNome.Text;
            string criarSenha = textBoxCriarS.Text;


            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                labelNovoUsuario.Text = "Usuario eh obrigatorio!!!";
                return;
            }

            if (string.IsNullOrWhiteSpace(criarSenha))
            {
                labelNovoUsuario.Text = "Senha eh obrigatoria!!!";
                return;
            }

            if (criarSenha.Length < 8)
            {
                labelNovoUsuario.Text = "A senha deve ter pelo menos 8 caracteres";
                return;
            }

            if (!criarSenha.Any(char.IsUpper))
            {
                labelNovoUsuario.Text = "A senha deve ter pelo menos uma letra maiuscula";
                return;
            }

            if (!criarSenha.Any(char.IsLower))
            {
                labelNovoUsuario.Text = "A senha deve ter pelo menos uma letra minuscula";
                return;
            }

            if (!criarSenha.Any(char.IsNumber))
            {
                labelNovoUsuario.Text = "A senha deve ter pelo menos um numero";
                return;
            }

            if (!criarSenha.Any(char.IsPunctuation) && !criarSenha.Any(char.IsSymbol) && !criarSenha.Contains('@'))
            {
                labelNovoUsuario.Text = "A senha deve ter pelo menos um caracter especial";
                return;
            }

            if (criarSenha.Any(char.IsWhiteSpace))
            {
                labelNovoUsuario.Text = "A senha nao deve ter espacos em branco";
                return;
            }

            if (listaUsuarios.Contains(novoUsuario))
            {
                labelNovoUsuario.Text = "Já existe um usuário cadastrado";
                return;
            }

            listaUsuarios.Add(novoUsuario);
            listaSenha.Add(criarSenha);
            labelNovoUsuario.Text = "Usuário cadastrado com sucesso!";
            textBoxNome.Clear();
            textBoxCriarS.Clear();
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
