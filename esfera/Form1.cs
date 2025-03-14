namespace esfera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double raio = double.Parse(textBox1.Text);
            double circunferencia = 2 * Math.PI * raio;
            lbxR.Text = $"Circunferência: {circunferencia:F2}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double raio = double.Parse(textBox1.Text);
            double perimetro = Math.PI * 2 * raio;
            lbxR.Text = $"Perímetro: {perimetro:F2}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double raio = double.Parse(textBox1.Text);
            double diametro = 2 * raio;
            lbxR.Text = $"Diâmetro: {diametro:F2}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double raio = double.Parse(textBox1.Text);
            double area = 4 * Math.PI * Math.Pow(raio, 2);
            lbxR.Text = $"Área: {area:F2}";
        }
    }
}
