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

            bool usuarioEncontrado = false;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (novoUsuario == listaUsuarios[i])
                {
                    usuarioEncontrado = true;
                }
            }

            if (usuarioEncontrado)
            {
                listaUsuarios.Add (novoUsuario);
                listaSenha.Add(novoUsuario);
                labelNovoUsuario.Text = "Usuario cadastrado com sucesso"; 
            }

            else
            {
                labelNovoUsuario.Text = "Já existe um usuario cadastrado";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
