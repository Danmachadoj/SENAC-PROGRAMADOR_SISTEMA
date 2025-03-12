namespace calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalcule_Click(object sender, EventArgs e)
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


        private void bsubtraçao_Click(object sender, EventArgs e)
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

        private void bdividir_Click(object sender, EventArgs e)
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

        private void bmultiplicar_Click(object sender, EventArgs e)
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

        private void novoForm_Click(object sender, EventArgs e)
        {
            Form newForm = new novoForm();
            this.Hide();
            newForm.Show();

        }
    }

}
