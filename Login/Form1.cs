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

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = BoxAcesso.Text;
            string senha = BoxSenha.Text;


            if (string.IsNullOrWhiteSpace(usuario))
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

            if (usuario == "daniela.machado" && senha == "12345")
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
    }
}
