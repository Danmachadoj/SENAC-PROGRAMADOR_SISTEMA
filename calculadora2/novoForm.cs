using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora2
{
    public partial class novoForm : Form
    {
        public novoForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labResultado.Text = "+";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labResultado.Text = "-";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            labResultado.Text = "*";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            labResultado.Text = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double doubleValor1 = Convert.ToDouble(textBox1.Text);
            double doubleValor2 = Convert.ToDouble(textBox2.Text);
            double resultado;
            string resultadoFinal = textResul.Text;

            switch (labResultado.Text)
            {
                case "+":
                    resultado = doubleValor1 + doubleValor2;
                    break;

                case "-":
                    resultado = doubleValor1 - doubleValor2;
                    break;

                case "*":
                    resultado = doubleValor1 * doubleValor2;
                    break;

                case "/":
                    resultado = doubleValor1 / doubleValor2;
                    break;


                default:
                    resultado = doubleValor1 + doubleValor2;
                    break;

            }
            textResul.Text = $"resultado {textResul.Text}";
        }

        private void textResul_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcularCirculo_Click(object sender, EventArgs e)
        {
            string raio = textResul.Text;

            if (string.IsNullOrWhiteSpace(raio) || raio.All(char.IsNumber))
            {
                labelErro.Text = "Inserir um raio de um numero valido";
                return;
            }
        } 

    }
}    
