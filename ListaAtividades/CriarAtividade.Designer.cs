namespace ListaAtividades
{
    partial class CriarAtividade
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
            labelTitulo = new Label();
            buttonDescartar = new Button();
            buttonCriar = new Button();
            textBoxTitulo = new TextBox();
            labelErro = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(241, 97);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(37, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Titulo";
            // 
            // buttonDescartar
            // 
            buttonDescartar.Location = new Point(178, 144);
            buttonDescartar.Name = "buttonDescartar";
            buttonDescartar.Size = new Size(75, 23);
            buttonDescartar.TabIndex = 1;
            buttonDescartar.Text = "Descartar";
            buttonDescartar.UseVisualStyleBackColor = true;
            buttonDescartar.Click += buttonDescartar_Click;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(259, 144);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(75, 23);
            buttonCriar.TabIndex = 2;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(192, 115);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(135, 23);
            textBoxTitulo.TabIndex = 3;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(6, 417);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 4;
            labelErro.Text = "label2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelErro);
            groupBox1.Controls.Add(textBoxTitulo);
            groupBox1.Controls.Add(buttonCriar);
            groupBox1.Controls.Add(buttonDescartar);
            groupBox1.Controls.Add(labelTitulo);
            groupBox1.Location = new Point(15, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(488, 435);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // CriarAtividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 450);
            Controls.Add(groupBox1);
            Name = "CriarAtividade";
            Text = "CriarAtividade";
            Load += CriarAtividade_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitulo;
        private Button buttonDescartar;
        private Button buttonCriar;
        private TextBox textBoxTitulo;
        private Label labelErro;
        private GroupBox groupBox1;
    }
}