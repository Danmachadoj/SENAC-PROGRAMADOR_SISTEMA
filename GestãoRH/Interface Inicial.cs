using GestãoRH;
using GestaoRH.BancoDados.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoRH
{
    public partial class Interface_Inicial : Form
    {
        public Interface_Inicial()
        {

            InitializeComponent();
            dataGridView1.Visible = false;


        }

        private void Interface_Inicial_Load(object sender, EventArgs e)
        {
        }


        public void CarregarFuncionario()
        {

            var repositorio = new Repositorio();
            var dados = Repositorio.CarregarFuncionario();

            dataGridView1.DataSource = dados;

        }



        private void button1_Click(object sender, EventArgs e)
        {
             

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = !dataGridView1.Visible;
           
            dataGridView1.DataSource = Banco.BuscarSql("SELECT \r\n    f.NomeCompleto,\r\n    f.Cpf,\r\n    e.Cep,\r\n    e.Logradouro,\r\n    e.Numero,\r\n    e.Complemento,\r\n    e.Bairro,\r\n    e.Cidade,\r\n    e.Estado\r\nFROM\r\n    funcionario f\r\n        INNER JOIN\r\n    endereco e ON f.Id = e.FuncionarioId");



        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = !dataGridView1.Visible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = !dataGridView1.Visible;
        }

       
    }
}
