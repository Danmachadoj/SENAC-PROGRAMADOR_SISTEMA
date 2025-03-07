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
        List<string> alfabetoMaiusculo = new List<string>() { "A", "B", "C", "D", "E" };
        List<string> alfabetoMinusculo = new List<string>() { "a", "b", "c", "d", "e" };
        List<char> numeros = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        List<char> especiais = new List<char>() { '!', '@', '#', '$', '%', '&', '*' };
        List<string> listaUsuarios = new List<string>() { "joe.jonas", "chris.brown", "elisa.jesus" };
        List<string> listaSenha = new List<string>() { "brothers", "residuals", "nenem" };
       


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

            if (senha == null || senha == "")
            {
                LabelResultado.Text = "Senha é obrigatório!!";
                LabelResultado.ForeColor = Color.Red;
                return;
            }
            int posicaoUsuarioEncontrado = -1;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuarioBuscado == listaUsuarios[i])
                {
                    posicaoUsuarioEncontrado = i;
                }

            }

            if (posicaoUsuarioEncontrado > -1 && senha == listaSenha[posicaoUsuarioEncontrado])
            {
                LabelResultado.Text = "Autenticado com sucesso!";
                LabelResultado.ForeColor = Color.Green;
            }

            else
            {
                LabelResultado.Text = "Usuario ou Senha incorretos...";
                LabelResultado.ForeColor = Color.Red;
            }


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
            string CriarSenha = textBoxCriarS.Text;


            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                labelNovoUsuario.Text = "Usuario é obrigatorio!!!";
                return;
            }

            if (string.IsNullOrWhiteSpace(CriarSenha))
            {
                labelNovoUsuario.Text = "Senha é obrigatoria!!!";
                return;
            }

            if (CriarSenha.Length < 8)
            {
                labelNovoUsuario.Text = "A senha deve ter pelo menos 8 caracteres";
                return;
            }

            if (!CriarSenha.Any(char.IsUpper))
            {
                labelNovoUsuario.Text = "A senha deve ter pelo menos uma letra maiuscula";
                return;
            }

            if (!CriarSenha.Any(char.IsLower))
            {
                labelNovoUsuario.Text = "A senha deve ter pelo menos uma letra minuscula";
                return;
            }

            if (!CriarSenha.Any(char.IsDigit))
            {
                labelNovoUsuario.Text = "A senha deve ter pelo menos um numero";
                return;
            }

            if (!CriarSenha.Any(char.IsPunctuation))
            {
                labelNovoUsuario.Text = "A senha deve ter pelo menos um caracter especial";
                return;
            }

            if (CriarSenha.Contains(' '))
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
            listaSenha.Add(CriarSenha);
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
