using GestãoRH;
using MySql.Data.MySqlClient;
using System.Data;


namespace GestaoRH
{
    public partial class Interface_Inicial : Form
    {
        public Interface_Inicial()
        {

            InitializeComponent();
           

        }

        private void Interface_Inicial_Load(object sender, EventArgs e)
        {
            
            AtualizarDataGrid();
        }


        public void CarregarFuncionario()
        {

            var repositorio = new Repositorio();
            var dados = Repositorio.CarregarFuncionario();

            dataGridView1.DataSource = dados;

        }

        public void AtualizarDataGrid()
        {
            string conexaoString = "server = localhost; user = root; password =; database = GestaoRH; ";

            using (var conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();
                string query = "SELECT * FROM Funcionario";
                var comando = new MySqlCommand(query, conexao);
                var adaptador = new MySqlDataAdapter(comando);
                var tabela = new DataTable();
                adaptador.Fill(tabela);

                dataGridView1.DataSource = tabela;
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {


            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

            
        }

        

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                
                var funcionarioId = (int) dataGridView1.CurrentRow.Cells["Id"].Value;
               

                Form1 form1 = new Form1(funcionarioId);
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
