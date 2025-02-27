namespace Login
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
            SuspendLayout();
            // 
            // BoxAcesso
            // 
            BoxAcesso.Location = new Point(175, 61);
            BoxAcesso.Name = "BoxAcesso";
            BoxAcesso.Size = new Size(183, 23);
            BoxAcesso.TabIndex = 0;
            BoxAcesso.TextChanged += textBoxUsuario_TextChanged;
            // 
            // BoxSenha
            // 
            BoxSenha.Location = new Point(174, 98);
            BoxSenha.Name = "BoxSenha";
            BoxSenha.Size = new Size(184, 23);
            BoxSenha.TabIndex = 1;
            // 
            // Textboxentrar
            // 
            Textboxentrar.Location = new Point(175, 128);
            Textboxentrar.Name = "Textboxentrar";
            Textboxentrar.Size = new Size(63, 22);
            Textboxentrar.TabIndex = 5;
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
            labelSenha.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 190);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 8;
            label3.Click += label3_Click;
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
            labelLogin.Click += label5_Click;
            // 
            // BRecupera
            // 
            BRecupera.Location = new Point(244, 128);
            BRecupera.Name = "BRecupera";
            BRecupera.Size = new Size(104, 22);
            BRecupera.TabIndex = 11;
            BRecupera.Text = "Esqueci senha";
            BRecupera.UseVisualStyleBackColor = true;
            // 
            // LabelResultado
            // 
            LabelResultado.AutoSize = true;
            LabelResultado.Location = new Point(148, 158);
            LabelResultado.Name = "LabelResultado";
            LabelResultado.Size = new Size(10, 15);
            LabelResultado.TabIndex = 12;
            LabelResultado.Text = "l";
            LabelResultado.Click += label1_Click_1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(489, 243);
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
    }
}
