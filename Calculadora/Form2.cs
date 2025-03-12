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

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelResultado = new Label();
            calcule = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(40, 142);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(194, 15);
            labelResultado.TabIndex = 2;
            labelResultado.Text = "Para realizar o calculo, insira o valor";
            // 
            // calcule
            // 
            calcule.Location = new Point(103, 89);
            calcule.Name = "calcule";
            calcule.Size = new Size(91, 29);
            calcule.TabIndex = 3;
            calcule.Text = "Calcular";
            calcule.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(calcule);
            Controls.Add(labelResultado);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void bnovoforms_Click(object sender, EventArgs e)
        {
            Form1 form2 = new form2();
            form2.Show();

        }

        private TextBox textBox1;
        private Label labelResultado;
        private Button calcule;
        private TextBox textBox2;
    }
}
