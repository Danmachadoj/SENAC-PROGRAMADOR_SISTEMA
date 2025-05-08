namespace visualPI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Tela = new Panel();
            txtUsuario = new TextBox();
            lErro = new Label();
            lSenha = new Label();
            lUsuario = new Label();
            txtSenha = new TextBox();
            btesquecisenha = new Label();
            label1 = new Label();
            Logo = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnEntrar = new Button();
            Mensagem = new Label();
            Background = new Panel();
            Tela.SuspendLayout();
            Background.SuspendLayout();
            SuspendLayout();
            // 
            // Tela
            // 
            Tela.BackColor = Color.Transparent;
            Tela.BackgroundImage = (Image)resources.GetObject("Tela.BackgroundImage");
            Tela.BackgroundImageLayout = ImageLayout.Stretch;
            Tela.Controls.Add(txtUsuario);
            Tela.Controls.Add(lErro);
            Tela.Controls.Add(lSenha);
            Tela.Controls.Add(lUsuario);
            Tela.Controls.Add(txtSenha);
            Tela.Controls.Add(btesquecisenha);
            Tela.Controls.Add(label1);
            Tela.Controls.Add(Logo);
            Tela.Controls.Add(panel3);
            Tela.Controls.Add(panel4);
            Tela.Controls.Add(btnEntrar);
            Tela.Controls.Add(Mensagem);
            Tela.Location = new Point(92, 147);
            Tela.Margin = new Padding(3, 4, 3, 4);
            Tela.Name = "Tela";
            Tela.Size = new Size(557, 523);
            Tela.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(129, 269);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(318, 23);
            txtUsuario.TabIndex = 15;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lErro
            // 
            lErro.AutoSize = true;
            lErro.Location = new Point(224, 365);
            lErro.Name = "lErro";
            lErro.Size = new Size(0, 15);
            lErro.TabIndex = 14;
            // 
            // lSenha
            // 
            lSenha.AutoSize = true;
            lSenha.Location = new Point(145, 363);
            lSenha.Name = "lSenha";
            lSenha.Size = new Size(0, 15);
            lSenha.TabIndex = 13;
            // 
            // lUsuario
            // 
            lUsuario.AutoSize = true;
            lUsuario.Location = new Point(129, 310);
            lUsuario.Name = "lUsuario";
            lUsuario.Size = new Size(0, 15);
            lUsuario.TabIndex = 12;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(129, 333);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(318, 23);
            txtSenha.TabIndex = 11;
            txtSenha.TextChanged += txtSenha_TextChanged_1;
            // 
            // btesquecisenha
            // 
            btesquecisenha.AutoSize = true;
            btesquecisenha.Cursor = Cursors.Hand;
            btesquecisenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btesquecisenha.Location = new Point(63, 409);
            btesquecisenha.Name = "btesquecisenha";
            btesquecisenha.Size = new Size(0, 21);
            btesquecisenha.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 229);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 7;
            label1.Text = "Login:";
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.Location = new Point(3, 4);
            Logo.Margin = new Padding(3, 4, 3, 4);
            Logo.Name = "Logo";
            Logo.Size = new Size(549, 161);
            Logo.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(88, 324);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(35, 36);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(88, 256);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(35, 36);
            panel4.TabIndex = 6;
            // 
            // btnEntrar
            // 
            btnEntrar.AutoEllipsis = true;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(224, 384);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(130, 36);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // Mensagem
            // 
            Mensagem.AutoSize = true;
            Mensagem.BackColor = Color.Transparent;
            Mensagem.Font = new Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mensagem.Location = new Point(167, 172);
            Mensagem.Name = "Mensagem";
            Mensagem.Size = new Size(213, 48);
            Mensagem.TabIndex = 1;
            Mensagem.Text = "Bem vindo!";
            // 
            // Background
            // 
            Background.BackColor = Color.Transparent;
            Background.BackgroundImage = (Image)resources.GetObject("Background.BackgroundImage");
            Background.Controls.Add(Tela);
            Background.Location = new Point(-4, -7);
            Background.Margin = new Padding(3, 4, 3, 4);
            Background.Name = "Background";
            Background.Size = new Size(799, 821);
            Background.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 766);
            Controls.Add(Background);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Recursos Humanos";
            Tela.ResumeLayout(false);
            Tela.PerformLayout();
            Background.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Tela;
        private Button btnEntrar;
        private Label Mensagem;
        private Panel Logo;
        private Panel Background;
        private Panel panel3;
        private Panel panel4;
        private Label lblWorkBridge;
        private Label label1;
        private Label btesquecisenha;
        private TextBox txtSenha;
        private Label lUsuario;
        private Label lSenha;
        private Label lErro;
        private TextBox txtUsuario;
    }
}
