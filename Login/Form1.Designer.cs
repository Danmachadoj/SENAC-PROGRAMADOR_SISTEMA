﻿namespace Login
{
    partial class FormLogin
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
            BoxAcesso = new TextBox();
            BoxSenha = new TextBox();
            Textboxentrar = new Button();
            LabelEmail = new Label();
            labelSenha = new Label();
            label3 = new Label();
            label4 = new Label();
            labelLogin = new Label();
            BRecupera = new Button();
            LabelResultado = new Label();
            BoxCriar = new Button();
            label1 = new Label();
            textBoxNome = new TextBox();
            textBoxCriarS = new TextBox();
            textBoxCSenha = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            labelNovoUsuario = new Label();
            labelConfir = new Label();
            SuspendLayout();
            // 
            // BoxAcesso
            // 
            BoxAcesso.Location = new Point(175, 61);
            BoxAcesso.Name = "BoxAcesso";
            BoxAcesso.Size = new Size(183, 23);
            BoxAcesso.TabIndex = 1;
            // 
            // BoxSenha
            // 
            BoxSenha.Location = new Point(174, 98);
            BoxSenha.Name = "BoxSenha";
            BoxSenha.Size = new Size(184, 23);
            BoxSenha.TabIndex = 2;
            // 
            // Textboxentrar
            // 
            Textboxentrar.Location = new Point(175, 128);
            Textboxentrar.Name = "Textboxentrar";
            Textboxentrar.Size = new Size(63, 22);
            Textboxentrar.TabIndex = 3;
            Textboxentrar.Text = "Entrar";
            Textboxentrar.UseVisualStyleBackColor = true;
            Textboxentrar.Click += button1_Click;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(130, 69);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(42, 15);
            LabelEmail.TabIndex = 6;
            LabelEmail.Text = "Email :";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(128, 101);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(45, 15);
            labelSenha.TabIndex = 7;
            labelSenha.Text = "Senha :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 190);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 190);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(210, 9);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(92, 37);
            labelLogin.TabIndex = 10;
            labelLogin.Text = "LOGIN";
            // 
            // BRecupera
            // 
            BRecupera.Location = new Point(244, 128);
            BRecupera.Name = "BRecupera";
            BRecupera.Size = new Size(104, 22);
            BRecupera.TabIndex = 4;
            BRecupera.Text = "Esqueci senha";
            BRecupera.UseVisualStyleBackColor = true;
            // 
            // LabelResultado
            // 
            LabelResultado.AutoSize = true;
            LabelResultado.Location = new Point(148, 158);
            LabelResultado.Name = "LabelResultado";
            LabelResultado.Size = new Size(0, 15);
            LabelResultado.TabIndex = 12;
            // 
            // BoxCriar
            // 
            BoxCriar.Location = new Point(653, 167);
            BoxCriar.Name = "BoxCriar";
            BoxCriar.Size = new Size(75, 23);
            BoxCriar.TabIndex = 14;
            BoxCriar.Text = "CriarConta";
            BoxCriar.UseVisualStyleBackColor = true;
            BoxCriar.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(597, 12);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 15;
            label1.Text = "CADASTRO";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(597, 61);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(183, 23);
            textBoxNome.TabIndex = 16;
            // 
            // textBoxCriarS
            // 
            textBoxCriarS.Location = new Point(597, 90);
            textBoxCriarS.Name = "textBoxCriarS";
            textBoxCriarS.Size = new Size(183, 23);
            textBoxCriarS.TabIndex = 17;
            // 
            // textBoxCSenha
            // 
            textBoxCSenha.Location = new Point(597, 119);
            textBoxCSenha.Name = "textBoxCSenha";
            textBoxCSenha.Size = new Size(183, 23);
            textBoxCSenha.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 64);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 19;
            label2.Text = "Nome completo :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(519, 93);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 20;
            label5.Text = "Criar senha :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(491, 122);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 21;
            label6.Text = "Confirmar senha :";
            // 
            // labelNovoUsuario
            // 
            labelNovoUsuario.AutoSize = true;
            labelNovoUsuario.Location = new Point(592, 147);
            labelNovoUsuario.Name = "labelNovoUsuario";
            labelNovoUsuario.Size = new Size(0, 15);
            labelNovoUsuario.TabIndex = 22;
            // 
            // labelConfir
            // 
            labelConfir.AutoSize = true;
            labelConfir.Location = new Point(789, 93);
            labelConfir.Name = "labelConfir";
            labelConfir.Size = new Size(0, 15);
            labelConfir.TabIndex = 23;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(998, 477);
            Controls.Add(labelConfir);
            Controls.Add(labelNovoUsuario);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBoxCSenha);
            Controls.Add(textBoxCriarS);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            Controls.Add(BoxCriar);
            Controls.Add(LabelResultado);
            Controls.Add(BRecupera);
            Controls.Add(labelLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelSenha);
            Controls.Add(LabelEmail);
            Controls.Add(Textboxentrar);
            Controls.Add(BoxSenha);
            Controls.Add(BoxAcesso);
            ForeColor = SystemColors.MenuHighlight;
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BoxAcesso;
        private TextBox BoxSenha;
        private Button Textboxentrar;
        private Label LabelEmail;
        private Label labelSenha;
        private Label label3;
        private Label label4;
        private Label labelLogin;
        private Button BRecupera;
        private Label LabelResultado;
        private Button BoxCriar;
        private Label label1;
        private TextBox textBoxNome;
        private TextBox textBoxCriarS;
        private TextBox textBoxCSenha;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label labelNovoUsuario;
        private Label labelConfir;
    }
}
