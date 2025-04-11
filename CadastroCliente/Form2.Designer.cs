namespace CadastroCliente
{
    partial class Form2
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
            tbnome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            mtbdata = new MaskedTextBox();
            Telefone = new Label();
            mtbtelefone = new MaskedTextBox();
            label4 = new Label();
            cbgenero = new ComboBox();
            label5 = new Label();
            tbtnomesocial = new TextBox();
            label6 = new Label();
            cbetnia = new ComboBox();
            label7 = new Label();
            cbestrangeiro = new CheckBox();
            label8 = new Label();
            rbpf = new RadioButton();
            rbpj = new RadioButton();
            tbemail = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            mtbcep = new MaskedTextBox();
            label15 = new Label();
            cbestado = new ComboBox();
            label14 = new Label();
            tbmunicio = new TextBox();
            label13 = new Label();
            tbbairro = new TextBox();
            label12 = new Label();
            tbcomplemento = new TextBox();
            label11 = new Label();
            tbnumero = new TextBox();
            label10 = new Label();
            tblogradouro = new TextBox();
            label9 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();            // 
            // tbnome
            // 
            tbnome.Location = new Point(115, 28);
            tbnome.Name = "tbnome";
            tbnome.Size = new Size(100, 23);
            tbnome.TabIndex = 0;
            tbnome.TextChanged += tbnome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 2;
            label2.Text = "Data Nascimento:";
            // 
            // mtbdata
            // 
            mtbdata.Location = new Point(115, 62);
            mtbdata.Mask = "00/00/0000";
            mtbdata.Name = "mtbdata";
            mtbdata.Size = new Size(100, 23);
            mtbdata.TabIndex = 3;
            mtbdata.ValidatingType = typeof(DateTime);
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(6, 108);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(54, 15);
            Telefone.TabIndex = 4;
            Telefone.Text = "Telefone:";
            // 
            // mtbtelefone
            // 
            mtbtelefone.Location = new Point(115, 100);
            mtbtelefone.Mask = "(99)00000-0000";
            mtbtelefone.Name = "mtbtelefone";
            mtbtelefone.Size = new Size(100, 23);
            mtbtelefone.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(533, 41);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 8;
            label4.Text = "Gênero:";
            // 
            // cbgenero
            // 
            cbgenero.FormattingEnabled = true;
            cbgenero.Items.AddRange(new object[] { "Feminino", "Masculino", "Outros" });
            cbgenero.Location = new Point(625, 33);
            cbgenero.Name = "cbgenero";
            cbgenero.Size = new Size(100, 23);
            cbgenero.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 36);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 10;
            label5.Text = "Nome Social:";
            // 
            // tbtnomesocial
            // 
            tbtnomesocial.Location = new Point(365, 33);
            tbtnomesocial.Name = "tbtnomesocial";
            tbtnomesocial.Size = new Size(100, 23);
            tbtnomesocial.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 71);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 12;
            label6.Text = "Etnia:";
            // 
            // cbetnia
            // 
            cbetnia.FormattingEnabled = true;
            cbetnia.Items.AddRange(new object[] { " BRANCO", " NEGRO", " INDÍGENA", " OUTROS" });
            cbetnia.Location = new Point(365, 68);
            cbetnia.Name = "cbetnia";
            cbetnia.Size = new Size(100, 23);
            cbetnia.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(533, 76);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 14;
            label7.Text = "Estrangeiro:";
            // 
            // cbestrangeiro
            // 
            cbestrangeiro.AutoSize = true;
            cbestrangeiro.Location = new Point(627, 76);
            cbestrangeiro.Name = "cbestrangeiro";
            cbestrangeiro.Size = new Size(15, 14);
            cbestrangeiro.TabIndex = 15;
            cbestrangeiro.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(533, 105);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 16;
            label8.Text = "Tipo:";
            // 
            // rbpf
            // 
            rbpf.AutoSize = true;
            rbpf.Location = new Point(628, 101);
            rbpf.Name = "rbpf";
            rbpf.Size = new Size(93, 19);
            rbpf.TabIndex = 17;
            rbpf.TabStop = true;
            rbpf.Text = "Pessoa Fisica";
            rbpf.UseVisualStyleBackColor = true;
            // 
            // rbpj
            // 
            rbpj.AutoSize = true;
            rbpj.Location = new Point(628, 126);
            rbpj.Name = "rbpj";
            rbpj.Size = new Size(104, 19);
            rbpj.TabIndex = 18;
            rbpj.TabStop = true;
            rbpj.Text = "Pessoa Jurídica";
            rbpj.UseVisualStyleBackColor = true;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(365, 105);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(100, 23);
            tbemail.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 108);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 19;
            label3.Text = "Email:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbemail);
            groupBox1.Controls.Add(tbnome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rbpj);
            groupBox1.Controls.Add(mtbdata);
            groupBox1.Controls.Add(rbpf);
            groupBox1.Controls.Add(Telefone);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(mtbtelefone);
            groupBox1.Controls.Add(cbestrangeiro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbgenero);
            groupBox1.Controls.Add(cbetnia);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbtnomesocial);
            groupBox1.Location = new Point(11, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 167);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "DADOS PESSOAIS";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mtbcep);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(cbestado);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(tbmunicio);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(tbbairro);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(tbcomplemento);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(tbnumero);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(tblogradouro);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(21, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(740, 133);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "ENDEREÇO";
            // 
            // mtbcep
            // 
            mtbcep.Location = new Point(95, 82);
            mtbcep.Mask = "00000-9999";
            mtbcep.Name = "mtbcep";
            mtbcep.Size = new Size(100, 23);
            mtbcep.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(7, 90);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 12;
            label15.Text = "CEP:";
            // 
            // cbestado
            // 
            cbestado.FormattingEnabled = true;
            cbestado.Items.AddRange(new object[] { "Acre - AC", "Alagoas - AL", "Amapá - AP", "Amazonas - AM", "Bahia - BA", "Ceará - CE", "Distrito Federal - DF", "Espírito Santo - ES", "Goiás - GO", "Maranhão - MA", "Mato Grosso - MT", "Mato Grosso do Sul - MS", "Minas Gerais - MG", "Pará - PA", "Paraíba - PB", "Paraná - PR", "Pernambuco - PE", "Piauí - PI", "Rio de Janeiro - RJ", "Rio Grande do Norte - RN", "Rio Grande do Sul - RS", "Rondônia - RO", "Roraima - RR", "Santa Catarina - SC", "São Paulo - SP", "Sergipe - SE", "Tocantins - TO" });
            cbestado.Location = new Point(493, 53);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(183, 23);
            cbestado.TabIndex = 11;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(442, 61);
            label14.Name = "label14";
            label14.Size = new Size(45, 15);
            label14.TabIndex = 10;
            label14.Text = "Estado:";
            // 
            // tbmunicio
            // 
            tbmunicio.Location = new Point(313, 53);
            tbmunicio.Name = "tbmunicio";
            tbmunicio.Size = new Size(100, 23);
            tbmunicio.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(233, 61);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 8;
            label13.Text = "Municipio:";
            // 
            // tbbairro
            // 
            tbbairro.Location = new Point(95, 53);
            tbbairro.Name = "tbbairro";
            tbbairro.Size = new Size(100, 23);
            tbbairro.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 61);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 6;
            label12.Text = "Bairro:";
            // 
            // tbcomplemento
            // 
            tbcomplemento.Location = new Point(457, 20);
            tbcomplemento.Name = "tbcomplemento";
            tbcomplemento.Size = new Size(100, 23);
            tbcomplemento.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(364, 22);
            label11.Name = "label11";
            label11.Size = new Size(87, 15);
            label11.TabIndex = 4;
            label11.Text = "Complemento:";
            // 
            // tbnumero
            // 
            tbnumero.Location = new Point(266, 20);
            tbnumero.Name = "tbnumero";
            tbnumero.Size = new Size(49, 23);
            tbnumero.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(233, 22);
            label10.Name = "label10";
            label10.Size = new Size(27, 15);
            label10.TabIndex = 2;
            label10.Text = "N° :";
            // 
            // tblogradouro
            // 
            tblogradouro.Location = new Point(95, 19);
            tblogradouro.Name = "tblogradouro";
            tblogradouro.Size = new Size(100, 23);
            tblogradouro.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 22);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 0;
            label9.Text = "Logradouro:";
            // 
            // button1
            // 
            button1.Location = new Point(321, 327);
            button1.Name = "button1";
            button1.Size = new Size(151, 39);
            button1.TabIndex = 23;
            button1.Text = "CADASTRAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(544, 315);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(411, 320);
            dataGridView1.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 665);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbnome;
        private Label label1;
        private Label label2;
        private MaskedTextBox mtbdata;
        private Label Telefone;
        private MaskedTextBox mtbtelefone;
        private Label label4;
        private ComboBox cbgenero;
        private Label label5;
        private TextBox tbtnomesocial;
        private Label label6;
        private ComboBox cbetnia;
        private Label label7;
        private CheckBox cbestrangeiro;
        private Label label8;
        private RadioButton rbpf;
        private RadioButton rbpj;
        private TextBox tbemail;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tbnumero;
        private Label label10;
        private TextBox tblogradouro;
        private Label label9;
        private Label label12;
        private TextBox tbcomplemento;
        private Label label11;
        private MaskedTextBox mtbcep;
        private Label label15;
        private ComboBox cbestado;
        private Label label14;
        private TextBox tbmunicio;
        private Label label13;
        private TextBox tbbairro;
        private Button button1;
        private DataGridView dataGridView1;
    }
}