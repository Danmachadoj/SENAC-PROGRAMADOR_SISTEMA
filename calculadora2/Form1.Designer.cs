namespace calculadora2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bSoma = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelResultado = new Label();
            novoForm = new Button();
            bsubtraçao = new Button();
            bdividir = new Button();
            bmultiplicar = new Button();
            SuspendLayout();
            // 
            // bSoma
            // 
            bSoma.Location = new Point(32, 92);
            bSoma.Name = "bSoma";
            bSoma.Size = new Size(62, 24);
            bSoma.TabIndex = 0;
            bSoma.Text = "+";
            bSoma.UseVisualStyleBackColor = true;
            bSoma.Click += bCalcule_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(52, 62);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(144, 15);
            labelResultado.TabIndex = 3;
            labelResultado.Text = "Insira o valor para calcular";
            // 
            // novoForm
            // 
            novoForm.Location = new Point(171, 175);
            novoForm.Name = "novoForm";
            novoForm.Size = new Size(87, 22);
            novoForm.TabIndex = 4;
            novoForm.Text = "Novo forms";
            novoForm.UseVisualStyleBackColor = true;
            novoForm.Click += novoForm_Click;
            // 
            // bsubtraçao
            // 
            bsubtraçao.Location = new Point(119, 92);
            bsubtraçao.Name = "bsubtraçao";
            bsubtraçao.Size = new Size(62, 24);
            bsubtraçao.TabIndex = 5;
            bsubtraçao.Text = "-";
            bsubtraçao.UseVisualStyleBackColor = true;
            bsubtraçao.Click += bsubtraçao_Click;
            // 
            // bdividir
            // 
            bdividir.Location = new Point(32, 131);
            bdividir.Name = "bdividir";
            bdividir.Size = new Size(62, 24);
            bdividir.TabIndex = 6;
            bdividir.Text = "/";
            bdividir.UseVisualStyleBackColor = true;
            bdividir.Click += bdividir_Click;
            // 
            // bmultiplicar
            // 
            bmultiplicar.Location = new Point(119, 131);
            bmultiplicar.Name = "bmultiplicar";
            bmultiplicar.Size = new Size(62, 24);
            bmultiplicar.TabIndex = 7;
            bmultiplicar.Text = "*";
            bmultiplicar.UseVisualStyleBackColor = true;
            bmultiplicar.Click += bmultiplicar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 270);
            Controls.Add(bmultiplicar);
            Controls.Add(bdividir);
            Controls.Add(bsubtraçao);
            Controls.Add(novoForm);
            Controls.Add(labelResultado);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(bSoma);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSoma;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelResultado;
        private Button novoForm;
        private Button bsubtraçao;
        private Button bdividir;
        private Button bmultiplicar;
    }
}
