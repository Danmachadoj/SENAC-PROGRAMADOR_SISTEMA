namespace GestaoRH
{
    partial class Interface_Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface_Inicial));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox4 = new PictureBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            button4 = new Button();
            label1 = new Label();
            ButtonNovo = new Button();
            buttonAtualizar = new Button();
            panel2 = new Panel();
            Logo = new Panel();
            Background = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            Background.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(189, 163);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(758, 216);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Menu;
            dataGridView1.Location = new Point(162, 276);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(733, 324);
            dataGridView1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ButtonNovo);
            groupBox1.Controls.Add(buttonAtualizar);
            groupBox1.Location = new Point(5, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(111, 564);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Açoes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 545);
            label4.Name = "label4";
            label4.Size = new Size(37, 16);
            label4.TabIndex = 3;
            label4.Text = "Home";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 155);
            label2.Name = "label2";
            label2.Size = new Size(37, 13);
            label2.TabIndex = 6;
            label2.Text = "Editar";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(16, 476);
            button4.Name = "button4";
            button4.Size = new Size(75, 66);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 66);
            label1.Name = "label1";
            label1.Size = new Size(99, 13);
            label1.TabIndex = 6;
            label1.Text = "Novo Funcionario";
            // 
            // ButtonNovo
            // 
            ButtonNovo.BackColor = Color.Transparent;
            ButtonNovo.BackgroundImage = (Image)resources.GetObject("ButtonNovo.BackgroundImage");
            ButtonNovo.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonNovo.Cursor = Cursors.Hand;
            ButtonNovo.FlatStyle = FlatStyle.Flat;
            ButtonNovo.ForeColor = Color.Transparent;
            ButtonNovo.Location = new Point(16, 7);
            ButtonNovo.Name = "ButtonNovo";
            ButtonNovo.Size = new Size(75, 56);
            ButtonNovo.TabIndex = 0;
            ButtonNovo.UseMnemonic = false;
            ButtonNovo.UseVisualStyleBackColor = false;
            ButtonNovo.Click += ButtonNovo_Click;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.BackColor = Color.Transparent;
            buttonAtualizar.BackgroundImage = (Image)resources.GetObject("buttonAtualizar.BackgroundImage");
            buttonAtualizar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAtualizar.Cursor = Cursors.Hand;
            buttonAtualizar.FlatStyle = FlatStyle.Flat;
            buttonAtualizar.ForeColor = Color.Transparent;
            buttonAtualizar.Location = new Point(16, 96);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(75, 56);
            buttonAtualizar.TabIndex = 0;
            buttonAtualizar.UseVisualStyleBackColor = false;
            buttonAtualizar.Click += buttonAtualizar_Click_1;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Logo);
            panel2.Controls.Add(groupBox1);
            panel2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(39, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 588);
            panel2.TabIndex = 9;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.Location = new Point(122, 1);
            Logo.Margin = new Padding(3, 4, 3, 4);
            Logo.Name = "Logo";
            Logo.Size = new Size(733, 256);
            Logo.TabIndex = 5;
            // 
            // Background
            // 
            Background.BackColor = Color.Transparent;
            Background.BackgroundImage = (Image)resources.GetObject("Background.BackgroundImage");
            Background.Controls.Add(pictureBox4);
            Background.Location = new Point(-52, -109);
            Background.Margin = new Padding(3, 4, 3, 4);
            Background.Name = "Background";
            Background.Size = new Size(1052, 821);
            Background.TabIndex = 11;
            // 
            // Interface_Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(966, 603);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(Background);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Interface_Inicial";
            Text = "Interface_Inicial";
            Load += Interface_Inicial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            Background.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button ButtonNovo;
        private Button buttonAtualizar;
        private Panel panel2;
        private Label label4;
        private Button button4;
        private Panel Background;
        private Panel Logo;
    }
}