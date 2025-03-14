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
            SuspendLayout();
            // 
            // rSoma
            // 
            rSoma.AutoSize = true;
            rSoma.Location = new Point(139, 88);
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
            rSubtracao.Location = new Point(139, 113);
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
            rMultiplicacao.Location = new Point(139, 138);
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
            rDivisao.Location = new Point(139, 163);
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
            textBox1.Location = new Point(67, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 4;
            // 
            // labResultado
            // 
            labResultado.AutoSize = true;
            labResultado.BackColor = Color.Tomato;
            labResultado.Location = new Point(148, 15);
            labResultado.Name = "labResultado";
            labResultado.Size = new Size(10, 15);
            labResultado.TabIndex = 5;
            labResultado.Text = " ";
            // 
            // button1
            // 
            button1.Location = new Point(231, 245);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(67, 23);
            textBox2.TabIndex = 7;
            // 
            // textResul
            // 
            textResul.Location = new Point(119, 41);
            textResul.Name = "textResul";
            textResul.Size = new Size(69, 23);
            textResul.TabIndex = 8;
            textResul.TextChanged += textResul_TextChanged;
            // 
            // novoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 305);
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
    }
}