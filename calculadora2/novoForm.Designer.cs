namespace calculadora2
{
    partial class novoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rSoma = new RadioButton();
            rSubtracao = new RadioButton();
            rMultiplicacao = new RadioButton();
            rDivisao = new RadioButton();
            textBox1 = new TextBox();
            labResultado = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textResul = new TextBox();
            groupBox1 = new GroupBox();
            CalcularCirculo = new Button();
            rVolume = new RadioButton();
            rArea = new RadioButton();
            rPerimetro = new RadioButton();
            rDiamentro = new RadioButton();
            label2 = new Label();
            lResultado = new TextBox();
            lRaio = new TextBox();
            label1 = new Label();
            labelErro = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rSoma
            // 
            rSoma.AutoSize = true;
            rSoma.Location = new Point(12, 67);
            rSoma.Name = "rSoma";
            rSoma.Size = new Size(33, 19);
            rSoma.TabIndex = 0;
            rSoma.TabStop = true;
            rSoma.Text = "+";
            rSoma.UseVisualStyleBackColor = true;
            rSoma.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rSubtracao
            // 
            rSubtracao.AutoSize = true;
            rSubtracao.Location = new Point(12, 92);
            rSubtracao.Name = "rSubtracao";
            rSubtracao.Size = new Size(30, 19);
            rSubtracao.TabIndex = 1;
            rSubtracao.TabStop = true;
            rSubtracao.Text = "-";
            rSubtracao.UseVisualStyleBackColor = true;
            rSubtracao.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rMultiplicacao
            // 
            rMultiplicacao.AutoSize = true;
            rMultiplicacao.Location = new Point(12, 117);
            rMultiplicacao.Name = "rMultiplicacao";
            rMultiplicacao.Size = new Size(30, 19);
            rMultiplicacao.TabIndex = 2;
            rMultiplicacao.TabStop = true;
            rMultiplicacao.Text = "*";
            rMultiplicacao.UseVisualStyleBackColor = true;
            rMultiplicacao.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rDivisao
            // 
            rDivisao.AutoSize = true;
            rDivisao.Location = new Point(12, 142);
            rDivisao.Name = "rDivisao";
            rDivisao.Size = new Size(30, 19);
            rDivisao.TabIndex = 3;
            rDivisao.TabStop = true;
            rDivisao.Text = "/";
            rDivisao.UseVisualStyleBackColor = true;
            rDivisao.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(67, 23);
            textBox1.TabIndex = 4;
            // 
            // labResultado
            // 
            labResultado.AutoSize = true;
            labResultado.BackColor = Color.Tomato;
            labResultado.Location = new Point(85, 12);
            labResultado.Name = "labResultado";
            labResultado.Size = new Size(10, 15);
            labResultado.TabIndex = 5;
            labResultado.Text = " ";
            // 
            // button1
            // 
            button1.Location = new Point(72, 92);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 7);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(67, 23);
            textBox2.TabIndex = 7;
            // 
            // textResul
            // 
            textResul.Location = new Point(43, 38);
            textResul.Name = "textResul";
            textResul.Size = new Size(69, 23);
            textResul.TabIndex = 8;
            textResul.TextChanged += textResul_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelErro);
            groupBox1.Controls.Add(CalcularCirculo);
            groupBox1.Controls.Add(rVolume);
            groupBox1.Controls.Add(rArea);
            groupBox1.Controls.Add(rPerimetro);
            groupBox1.Controls.Add(rDiamentro);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lResultado);
            groupBox1.Controls.Add(lRaio);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 171);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // CalcularCirculo
            // 
            CalcularCirculo.Location = new Point(206, 108);
            CalcularCirculo.Name = "CalcularCirculo";
            CalcularCirculo.Size = new Size(73, 25);
            CalcularCirculo.TabIndex = 8;
            CalcularCirculo.Text = "Calcular";
            CalcularCirculo.UseVisualStyleBackColor = true;
            CalcularCirculo.Click += CalcularCirculo_Click;
            // 
            // rVolume
            // 
            rVolume.AutoSize = true;
            rVolume.Location = new Point(151, 80);
            rVolume.Name = "rVolume";
            rVolume.Size = new Size(65, 19);
            rVolume.TabIndex = 7;
            rVolume.TabStop = true;
            rVolume.Text = "Volume";
            rVolume.UseVisualStyleBackColor = true;
            // 
            // rArea
            // 
            rArea.AutoSize = true;
            rArea.Location = new Point(151, 58);
            rArea.Name = "rArea";
            rArea.Size = new Size(49, 19);
            rArea.TabIndex = 6;
            rArea.TabStop = true;
            rArea.Text = "Area";
            rArea.UseVisualStyleBackColor = true;
            // 
            // rPerimetro
            // 
            rPerimetro.AutoSize = true;
            rPerimetro.Location = new Point(151, 36);
            rPerimetro.Name = "rPerimetro";
            rPerimetro.Size = new Size(77, 19);
            rPerimetro.TabIndex = 5;
            rPerimetro.TabStop = true;
            rPerimetro.Text = "Perimetro";
            rPerimetro.UseVisualStyleBackColor = true;
            // 
            // rDiamentro
            // 
            rDiamentro.AutoSize = true;
            rDiamentro.Location = new Point(151, 13);
            rDiamentro.Name = "rDiamentro";
            rDiamentro.Size = new Size(74, 19);
            rDiamentro.TabIndex = 4;
            rDiamentro.TabStop = true;
            rDiamentro.Text = "Diametro";
            rDiamentro.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 50);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Resultado:";
            // 
            // lResultado
            // 
            lResultado.Location = new Point(64, 47);
            lResultado.Name = "lResultado";
            lResultado.Size = new Size(71, 23);
            lResultado.TabIndex = 2;
            // 
            // lRaio
            // 
            lRaio.Location = new Point(64, 13);
            lRaio.Name = "lRaio";
            lRaio.Size = new Size(71, 23);
            lRaio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Raio:";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(36, 90);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 9;
            // 
            // novoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 505);
            Controls.Add(groupBox1);
            Controls.Add(textResul);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(labResultado);
            Controls.Add(textBox1);
            Controls.Add(rDivisao);
            Controls.Add(rMultiplicacao);
            Controls.Add(rSubtracao);
            Controls.Add(rSoma);
            Name = "novoForm";
            Text = "novoForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rSoma;
        private RadioButton rSubtracao;
        private RadioButton rMultiplicacao;
        private RadioButton rDivisao;
        private TextBox textBox1;
        private Label labResultado;
        private Button button1;
        private TextBox textBox2;
        private TextBox textResul;
        private GroupBox groupBox1;
        private Label label1;
        private Button CalcularCirculo;
        private RadioButton rVolume;
        private RadioButton rArea;
        private RadioButton rPerimetro;
        private RadioButton rDiamentro;
        private Label label2;
        private TextBox lResultado;
        private TextBox lRaio;
        private Label labelErro;
    }
}