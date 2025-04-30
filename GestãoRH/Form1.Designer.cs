namespace GestãoRH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            textNome = new TextBox();
            label1 = new Label();
            textBoxID = new TextBox();
            groupBox1 = new GroupBox();
            label14 = new Label();
            CBEstadoCivil = new ComboBox();
            label6 = new Label();
            CBGenero = new ComboBox();
            label5 = new Label();
            MBDataNascimento = new MaskedTextBox();
            label4 = new Label();
            MBRG = new MaskedTextBox();
            label3 = new Label();
            MBCpf = new MaskedTextBox();
            groupBox2 = new GroupBox();
            label10 = new Label();
            TXTComplemento = new TextBox();
            label9 = new Label();
            TXTNumero = new TextBox();
            label13 = new Label();
            CBEstado = new ComboBox();
            label11 = new Label();
            TXTCidade = new TextBox();
            label12 = new Label();
            TXTBairro = new TextBox();
            label8 = new Label();
            MBCEP = new MaskedTextBox();
            label7 = new Label();
            TXTLogradouro = new TextBox();
            groupBox3 = new GroupBox();
            label15 = new Label();
            CBParentesco = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            txtNome2 = new TextBox();
            CBGeneroDependente = new ComboBox();
            label19 = new Label();
            MBDataDependente = new MaskedTextBox();
            label20 = new Label();
            MBRgDependente = new MaskedTextBox();
            label21 = new Label();
            MBCPFDependente = new MaskedTextBox();
            groupBox4 = new GroupBox();
            MBSalario = new MaskedTextBox();
            label24 = new Label();
            label23 = new Label();
            MBDataAdimissao = new MaskedTextBox();
            label22 = new Label();
            TXTDepartamento = new TextBox();
            label18 = new Label();
            TXTCargo = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 26);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 11;
            label2.Text = "NOME COMPLETO:";
            // 
            // textNome
            // 
            textNome.Location = new Point(47, 44);
            textNome.Name = "textNome";
            textNome.Size = new Size(170, 23);
            textNome.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 26);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 9;
            label1.Text = "ID:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(11, 44);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(30, 23);
            textBoxID.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(CBEstadoCivil);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textNome);
            groupBox1.Controls.Add(CBGenero);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(MBDataNascimento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(MBRG);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(MBCpf);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 92);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "DADOS PESSOAIS";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(642, 26);
            label14.Name = "label14";
            label14.Size = new Size(82, 15);
            label14.TabIndex = 13;
            label14.Text = "ESTADO CIVIL:";
            // 
            // CBEstadoCivil
            // 
            CBEstadoCivil.FormattingEnabled = true;
            CBEstadoCivil.Items.AddRange(new object[] { "SOLTEIRO(a)", "CASADO(a)", "DIVORCIADO(a)", "VIUVO(a)" });
            CBEstadoCivil.Location = new Point(642, 42);
            CBEstadoCivil.Name = "CBEstadoCivil";
            CBEstadoCivil.Size = new Size(102, 23);
            CBEstadoCivil.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(534, 26);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 8;
            label6.Text = "GENERO:";
            // 
            // CBGenero
            // 
            CBGenero.FormattingEnabled = true;
            CBGenero.Items.AddRange(new object[] { "MASCULINO", "FEMININO", "OUTROS" });
            CBGenero.Location = new Point(534, 42);
            CBGenero.Name = "CBGenero";
            CBGenero.Size = new Size(102, 23);
            CBGenero.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 26);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 6;
            label5.Text = "DATA DE NASCIMENTO:";
            // 
            // MBDataNascimento
            // 
            MBDataNascimento.Location = new Point(398, 42);
            MBDataNascimento.Mask = "00/00/0000";
            MBDataNascimento.Name = "MBDataNascimento";
            MBDataNascimento.Size = new Size(130, 23);
            MBDataNascimento.TabIndex = 5;
            MBDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 24);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 4;
            label4.Text = "RG:";
            // 
            // MBRG
            // 
            MBRG.Location = new Point(321, 42);
            MBRG.Mask = "00.000.000-0";
            MBRG.Name = "MBRG";
            MBRG.Size = new Size(71, 23);
            MBRG.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 26);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // MBCpf
            // 
            MBCpf.Location = new Point(222, 42);
            MBCpf.Mask = "000.000.000-00";
            MBCpf.Name = "MBCpf";
            MBCpf.Size = new Size(93, 23);
            MBCpf.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(TXTComplemento);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(TXTNumero);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(CBEstado);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(TXTCidade);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(TXTBairro);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(MBCEP);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(TXTLogradouro);
            groupBox2.Location = new Point(12, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(766, 147);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "ENDEREÇO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(541, 25);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 39;
            label10.Text = "COMPLEMENTO:";
            // 
            // TXTComplemento
            // 
            TXTComplemento.Location = new Point(541, 43);
            TXTComplemento.Name = "TXTComplemento";
            TXTComplemento.Size = new Size(97, 23);
            TXTComplemento.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(464, 25);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 37;
            label9.Text = "NUMERO:";
            // 
            // TXTNumero
            // 
            TXTNumero.Location = new Point(464, 43);
            TXTNumero.Name = "TXTNumero";
            TXTNumero.Size = new Size(71, 23);
            TXTNumero.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(151, 83);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 35;
            label13.Text = "ESTADO:";
            // 
            // CBEstado
            // 
            CBEstado.FormattingEnabled = true;
            CBEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            CBEstado.Location = new Point(151, 101);
            CBEstado.Name = "CBEstado";
            CBEstado.Size = new Size(65, 23);
            CBEstado.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 83);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 33;
            label11.Text = "CIDADE:";
            // 
            // TXTCidade
            // 
            TXTCidade.Location = new Point(11, 101);
            TXTCidade.Name = "TXTCidade";
            TXTCidade.Size = new Size(134, 23);
            TXTCidade.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(644, 25);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 31;
            label12.Text = "BAIRRO:";
            // 
            // TXTBairro
            // 
            TXTBairro.Location = new Point(644, 43);
            TXTBairro.Name = "TXTBairro";
            TXTBairro.Size = new Size(117, 23);
            TXTBairro.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 27);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 29;
            label8.Text = "CEP:";
            // 
            // MBCEP
            // 
            MBCEP.Location = new Point(11, 43);
            MBCEP.Mask = "00000-000";
            MBCEP.Name = "MBCEP";
            MBCEP.Size = new Size(93, 23);
            MBCEP.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(113, 25);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 27;
            label7.Text = "LOGRADOURO:";
            // 
            // TXTLogradouro
            // 
            TXTLogradouro.Location = new Point(113, 43);
            TXTLogradouro.Name = "TXTLogradouro";
            TXTLogradouro.Size = new Size(345, 23);
            TXTLogradouro.TabIndex = 26;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(CBParentesco);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(txtNome2);
            groupBox3.Controls.Add(CBGeneroDependente);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(MBDataDependente);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(MBRgDependente);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(MBCPFDependente);
            groupBox3.Location = new Point(12, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(766, 92);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "DEPENDENTES";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(601, 19);
            label15.Name = "label15";
            label15.Size = new Size(81, 15);
            label15.TabIndex = 13;
            label15.Text = "PARENTESCO:";
            // 
            // CBParentesco
            // 
            CBParentesco.FormattingEnabled = true;
            CBParentesco.Items.AddRange(new object[] { "CÔNJUGE", "FILHO(A)" });
            CBParentesco.Location = new Point(601, 35);
            CBParentesco.Name = "CBParentesco";
            CBParentesco.Size = new Size(102, 23);
            CBParentesco.TabIndex = 12;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(493, 19);
            label16.Name = "label16";
            label16.Size = new Size(55, 15);
            label16.TabIndex = 8;
            label16.Text = "GENERO:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 19);
            label17.Name = "label17";
            label17.Size = new Size(109, 15);
            label17.TabIndex = 11;
            label17.Text = "NOME COMPLETO:";
            // 
            // txtNome2
            // 
            txtNome2.Location = new Point(6, 37);
            txtNome2.Name = "txtNome2";
            txtNome2.Size = new Size(170, 23);
            txtNome2.TabIndex = 10;
            // 
            // CBGeneroDependente
            // 
            CBGeneroDependente.FormattingEnabled = true;
            CBGeneroDependente.Items.AddRange(new object[] { "MASCULINO", "FEMININO", "OUTROS" });
            CBGeneroDependente.Location = new Point(493, 35);
            CBGeneroDependente.Name = "CBGeneroDependente";
            CBGeneroDependente.Size = new Size(102, 23);
            CBGeneroDependente.TabIndex = 7;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(355, 19);
            label19.Name = "label19";
            label19.Size = new Size(132, 15);
            label19.TabIndex = 6;
            label19.Text = "DATA DE NASCIMENTO:";
            // 
            // MBDataDependente
            // 
            MBDataDependente.Location = new Point(357, 35);
            MBDataDependente.Mask = "00/00/0000";
            MBDataDependente.Name = "MBDataDependente";
            MBDataDependente.Size = new Size(130, 23);
            MBDataDependente.TabIndex = 5;
            MBDataDependente.ValidatingType = typeof(DateTime);
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(280, 17);
            label20.Name = "label20";
            label20.Size = new Size(25, 15);
            label20.TabIndex = 4;
            label20.Text = "RG:";
            // 
            // MBRgDependente
            // 
            MBRgDependente.Location = new Point(280, 35);
            MBRgDependente.Mask = "00.000.000-0";
            MBRgDependente.Name = "MBRgDependente";
            MBRgDependente.Size = new Size(71, 23);
            MBRgDependente.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(182, 19);
            label21.Name = "label21";
            label21.Size = new Size(31, 15);
            label21.TabIndex = 2;
            label21.Text = "CPF:";
            // 
            // MBCPFDependente
            // 
            MBCPFDependente.Location = new Point(181, 35);
            MBCPFDependente.Mask = "000.000.000-00";
            MBCPFDependente.Name = "MBCPFDependente";
            MBCPFDependente.Size = new Size(93, 23);
            MBCPFDependente.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(MBSalario);
            groupBox4.Controls.Add(label24);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(MBDataAdimissao);
            groupBox4.Controls.Add(label22);
            groupBox4.Controls.Add(TXTDepartamento);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(TXTCargo);
            groupBox4.Location = new Point(12, 361);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(305, 112);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "FUNÇÃO";
            // 
            // MBSalario
            // 
            MBSalario.Location = new Point(134, 83);
            MBSalario.Mask = "$000000000000000000";
            MBSalario.Name = "MBSalario";
            MBSalario.Size = new Size(93, 23);
            MBSalario.TabIndex = 20;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(134, 67);
            label24.Name = "label24";
            label24.Size = new Size(57, 15);
            label24.TabIndex = 19;
            label24.Text = "SALARIO:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(4, 67);
            label23.Name = "label23";
            label23.RightToLeft = RightToLeft.No;
            label23.Size = new Size(117, 15);
            label23.TabIndex = 17;
            label23.Text = "DATA DE ADMISSÃO:";
            // 
            // MBDataAdimissao
            // 
            MBDataAdimissao.Location = new Point(4, 83);
            MBDataAdimissao.Mask = "00/00/0000";
            MBDataAdimissao.Name = "MBDataAdimissao";
            MBDataAdimissao.Size = new Size(117, 23);
            MBDataAdimissao.TabIndex = 16;
            MBDataAdimissao.ValidatingType = typeof(DateTime);
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(134, 19);
            label22.Name = "label22";
            label22.Size = new Size(97, 15);
            label22.TabIndex = 15;
            label22.Text = "DEPARTAMENTO:";
            // 
            // TXTDepartamento
            // 
            TXTDepartamento.Location = new Point(134, 37);
            TXTDepartamento.Name = "TXTDepartamento";
            TXTDepartamento.Size = new Size(120, 23);
            TXTDepartamento.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 19);
            label18.Name = "label18";
            label18.Size = new Size(50, 15);
            label18.TabIndex = 13;
            label18.Text = "CARGO:";
            // 
            // TXTCargo
            // 
            TXTCargo.Location = new Point(6, 37);
            TXTCargo.Name = "TXTCargo";
            TXTCargo.Size = new Size(120, 23);
            TXTCargo.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(33, 540);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 586);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(840, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(840, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(779, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 534);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(610, 415);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(168, 165);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(837, 657);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CADASTRO DE  COLABORADORES";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private TextBox textNome;
        private Label label1;
        private TextBox textBoxID;
        private GroupBox groupBox1;
        private Label label3;
        private MaskedTextBox MBCpf;
        private ComboBox CBGenero;
        private Label label5;
        private MaskedTextBox MBDataNascimento;
        private Label label4;
        private MaskedTextBox MBRG;
        private Label label6;
        private GroupBox groupBox2;
        private Label label10;
        private TextBox TXTComplemento;
        private Label label9;
        private TextBox TXTNumero;
        private Label label13;
        private ComboBox CBEstado;
        private Label label11;
        private TextBox TXTCidade;
        private Label label12;
        private TextBox TXTBairro;
        private Label label8;
        private MaskedTextBox MBCEP;
        private Label label7;
        private TextBox TXTLogradouro;
        private Label label14;
        private ComboBox CBEstadoCivil;
        private GroupBox groupBox3;
        private Label label16;
        private Label label17;
        private TextBox txtNome2;
        private ComboBox CBGeneroDependente;
        private Label label19;
        private MaskedTextBox MBDataDependente;
        private Label label20;
        private MaskedTextBox MBRgDependente;
        private Label label21;
        private MaskedTextBox MBCPFDependente;
        private Label label15;
        private ComboBox CBParentesco;
        private GroupBox groupBox4;
        private Label label18;
        private TextBox TXTCargo;
        private Label label24;
        private Label label23;
        private MaskedTextBox MBDataAdimissao;
        private Label label22;
        private TextBox TXTDepartamento;
        private MaskedTextBox MBSalario;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
