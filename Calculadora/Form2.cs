namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor1 = textBox1.Text;
            string valor2 = textBox2.Text;


            if (!valor2.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 1 de ser um numero";
                return;

            }

            double doubleValor1 = Convert.ToDouble(valor1);
            double doubleValor2 = Convert.ToDouble(valor2);

            double resultado = doubleValor1 + doubleValor2;




            labelResultado.Text = resultado.ToString();

        }

        private void bSubtracao_Click(object sender, EventArgs e)
        {

            string valor1 = textBox1.Text;
            string valor2 = textBox2.Text;


            if (!valor2.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 1 de ser um numero";
                return;

            }

            double doubleValor1 = Convert.ToDouble(valor1);
            double doubleValor2 = Convert.ToDouble(valor2);
            double resultado = doubleValor1 - doubleValor2;

            labelResultado.Text = resultado.ToString();
        }

        private void bDivisao_Click(object sender, EventArgs e)
        {
            string valor1 = textBox1.Text;
            string valor2 = textBox2.Text;


            if (!valor2.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 1 de ser um numero";
                return;

            }

            double doubleValor1 = Convert.ToDouble(valor1);
            double doubleValor2 = Convert.ToDouble(valor2);
            double resultado = doubleValor1 / doubleValor2;

            labelResultado.Text = resultado.ToString();
        }

        private void bMultiplicacao_Click(object sender, EventArgs e)
        {
            string valor1 = textBox1.Text;
            string valor2 = textBox2.Text;


            if (!valor2.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 1 de ser um numero";
                return;

            }

            double doubleValor1 = Convert.ToDouble(valor1);
            double doubleValor2 = Convert.ToDouble(valor2);
            double resultado = doubleValor1 * doubleValor2;

            labelResultado.Text = resultado.ToString();
        }

        private void bnovoforms_Click(object sender, EventArgs e)
        {
            Form1 form2 = new form2 ();
            form2.Show();
           
        }
    }
}
