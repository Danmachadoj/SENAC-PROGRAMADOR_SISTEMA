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
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            Textboxentrar = new Button();
            Label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            LabelResultado = new Label();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(175, 61);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(183, 23);
            textBoxUsuario.TabIndex = 0;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(174, 98);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(184, 23);
            textBoxSenha.TabIndex = 1;
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
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(130, 69);
            Label1.Name = "Label1";
            Label1.Size = new Size(42, 15);
            Label1.TabIndex = 6;
            Label1.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 101);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 7;
            label2.Text = "Senha :";
            label2.Click += label2_Click;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(210, 9);
            label5.Name = "label5";
            label5.Size = new Size(92, 37);
            label5.TabIndex = 10;
            label5.Text = "LOGIN";
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(244, 128);
            button2.Name = "button2";
            button2.Size = new Size(104, 22);
            button2.TabIndex = 11;
            button2.Text = "Esqueci senha";
            button2.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(479, 275);
            Controls.Add(LabelResultado);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(Textboxentrar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            ForeColor = SystemColors.MenuHighlight;
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Button Textboxentrar;
        private Label Label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Label LabelResultado;
    }
}
