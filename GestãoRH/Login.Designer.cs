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
            Background = new Panel();
            Tela = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            txtUsuario = new TextBox();
            lErro = new Label();
            lSenha = new Label();
            lUsuario = new Label();
            txtSenha = new TextBox();
            btesquecisenha = new Label();
            label1 = new Label();
            Logo = new Panel();
            btnEntrar = new Button();
            Mensagem = new Label();
            Background.SuspendLayout();
            Tela.SuspendLayout();
            SuspendLayout();
            // 
            // Background
            // 
            Background.BackColor = Color.Transparent;
            Background.BackgroundImage = (Image)resources.GetObject("Background.BackgroundImage");
            Background.Controls.Add(Tela);
            Background.Controls.Add(Mensagem);
            Background.Location = new Point(-4, -7);
            Background.Margin = new Padding(3, 4, 3, 4);
            Background.Name = "Background";
            Background.Size = new Size(1603, 821);
            Background.TabIndex = 4;
            // 
            // Tela
            // 
            Tela.BackColor = Color.Transparent;
            Tela.BackgroundImage = (Image)resources.GetObject("Tela.BackgroundImage");
            Tela.BackgroundImageLayout = ImageLayout.Stretch;
            Tela.Controls.Add(panel3);
            Tela.Controls.Add(panel4);
            Tela.Controls.Add(txtUsuario);
            Tela.Controls.Add(lErro);
            Tela.Controls.Add(lSenha);
            Tela.Controls.Add(lUsuario);
            Tela.Controls.Add(txtSenha);
            Tela.Controls.Add(btesquecisenha);
            Tela.Controls.Add(label1);
            Tela.Controls.Add(Logo);
            Tela.Controls.Add(btnEntrar);
            Tela.Location = new Point(686, 20);
            Tela.Margin = new Padding(3, 4, 3, 4);
            Tela.Name = "Tela";
            Tela.Size = new Size(889, 747);
            Tela.TabIndex = 5;
            Tela.Paint += Tela_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = GestaoRH.Properties.Resources.ChatGPT_Image_9_de_mai__de_2025__03_11_49;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(219, 442);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(82, 52);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(219, 362);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(82, 52);
            panel4.TabIndex = 6;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(265, 365);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(358, 49);
            txtUsuario.TabIndex = 15;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lErro
            // 
            lErro.AutoSize = true;
            lErro.Location = new Point(388, 481);
            lErro.Name = "lErro";
            lErro.Size = new Size(0, 15);
            lErro.TabIndex = 14;
            // 
            // lSenha
            // 
            lSenha.AutoSize = true;
            lSenha.Location = new Point(388, 479);
            lSenha.Name = "lSenha";
            lSenha.Size = new Size(0, 15);
            lSenha.TabIndex = 13;
            // 
            // lUsuario
            // 
            lUsuario.AutoSize = true;
            lUsuario.Location = new Point(388, 426);
            lUsuario.Name = "lUsuario";
            lUsuario.Size = new Size(0, 15);
            lUsuario.TabIndex = 12;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtSenha.ForeColor = Color.Black;
            txtSenha.Location = new Point(265, 445);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(358, 49);
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
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(342, 291);
            label1.Name = "label1";
            label1.Size = new Size(204, 40);
            label1.TabIndex = 7;
            label1.Text = "Faça Login";
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.Location = new Point(0, 4);
            Logo.Margin = new Padding(3, 4, 3, 4);
            Logo.Name = "Logo";
            Logo.Size = new Size(889, 256);
            Logo.TabIndex = 4;
            // 
            // btnEntrar
            // 
            btnEntrar.AutoEllipsis = true;
            btnEntrar.FlatStyle = FlatStyle.System;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(379, 542);
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
            Mensagem.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mensagem.ForeColor = SystemColors.Window;
            Mensagem.Location = new Point(157, 162);
            Mensagem.Name = "Mensagem";
            Mensagem.Size = new Size(408, 42);
            Mensagem.TabIndex = 1;
            Mensagem.Text = "Bem vindo de volta!";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 766);
            Controls.Add(Background);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Recursos Humanos";
            Background.ResumeLayout(false);
            Background.PerformLayout();
            Tela.ResumeLayout(false);
            Tela.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel Background;
        private Label lblWorkBridge;
        private Panel Tela;
        private TextBox txtUsuario;
        private Label lErro;
        private Label lSenha;
        private Label lUsuario;
        private TextBox txtSenha;
        private Label btesquecisenha;
        private Label label1;
        private Panel Logo;
        private Panel panel3;
        private Panel panel4;
        private Button btnEntrar;
        private Label Mensagem;
    }
}
