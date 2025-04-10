using MySql.Data.MySqlClient;

namespace Login
{
    public partial class FormLogin : Form
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac;";
        private readonly MySqlConnection Connection = new MySqlConnection(ConnectionString);

        private string novaSenha = string.Empty;    

        public FormLogin()
        {
            InitializeComponent();
        }

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

            bool autenticado = false;

            try
            {
                Connection.Open();

                string query = $"SELECT senha FROM usuario WHERE email = '{usuarioBuscado}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                autenticado = reader.Read() && reader.GetString(0) == senha;
            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }


            if (!autenticado)
            {

                LabelResultado.Text = "Usuario ou Senha incorretos...";
                LabelResultado.ForeColor = Color.Red;
                return;
            }

            LabelResultado.Text = "Autenticado com sucesso!";
            LabelResultado.ForeColor = Color.Green;
            BoxAcesso.Clear();
            BoxSenha.Clear();

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

            bool encontrado = false;

            try
            {
                Connection.Open();

                string query = $"SELECT email FROM usuario WHERE email = '{novoUsuario}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                encontrado = reader.Read();
            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }


            if (encontrado)
            {
                LabelResultado.Text = "Já existe um usuário cadastrado";
                return;
            }


            try
            {
                Connection.Open();

                string query = $"INSERT INTO usuario (email, senha) VALUES ('{novoUsuario}', '{novaSenha}');";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                mySqlCommand.ExecuteNonQuery();

                LabelResultado.Text = "Usuário cadastrado com sucesso!";
                textBoxNome.Clear();
                textBoxCriarS.Clear();
            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
