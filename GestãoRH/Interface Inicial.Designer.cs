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
            ButtonNovo = new Button();
            dataGridView1 = new DataGridView();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            button4 = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            buttonAtualizar = new Button();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ButtonNovo
            // 
            ButtonNovo.BackColor = Color.Transparent;
            ButtonNovo.BackgroundImage = (Image)resources.GetObject("ButtonNovo.BackgroundImage");
            ButtonNovo.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonNovo.Cursor = Cursors.Hand;
            ButtonNovo.FlatStyle = FlatStyle.Flat;
            ButtonNovo.ForeColor = Color.Transparent;
            ButtonNovo.Location = new Point(5, 22);
            ButtonNovo.Name = "ButtonNovo";
            ButtonNovo.Size = new Size(90, 42);
            ButtonNovo.TabIndex = 0;
            ButtonNovo.UseMnemonic = false;
            ButtonNovo.UseVisualStyleBackColor = false;
            ButtonNovo.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Menu;
            dataGridView1.Location = new Point(203, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(685, 370);
            dataGridView1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(887, -23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 614);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(283, 23);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(463, 125);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(groupBox1);
            panel2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 598);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 568);
            label4.Name = "label4";
            label4.Size = new Size(37, 16);
            label4.TabIndex = 3;
            label4.Text = "Home";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(22, 513);
            button4.Name = "button4";
            button4.Size = new Size(66, 52);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ButtonNovo);
            groupBox1.Controls.Add(buttonAtualizar);
            groupBox1.Location = new Point(6, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 174);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Açoes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 67);
            label2.Name = "label2";
            label2.Size = new Size(37, 13);
            label2.TabIndex = 6;
            label2.Text = "Editar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 67);
            label1.Name = "label1";
            label1.Size = new Size(99, 13);
            label1.TabIndex = 6;
            label1.Text = "Novo Funcionario";
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.BackColor = Color.Transparent;
            buttonAtualizar.BackgroundImage = (Image)resources.GetObject("buttonAtualizar.BackgroundImage");
            buttonAtualizar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAtualizar.Cursor = Cursors.Hand;
            buttonAtualizar.FlatStyle = FlatStyle.Flat;
            buttonAtualizar.ForeColor = Color.Transparent;
            buttonAtualizar.Location = new Point(101, 20);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(62, 36);
            buttonAtualizar.TabIndex = 0;
            buttonAtualizar.UseVisualStyleBackColor = false;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(203, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(685, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Interface_Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(966, 603);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(pictureBox4);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Interface_Inicial";
            Text = "Interface_Inicial";
            Load += Interface_Inicial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonNovo;
        private DataGridView dataGridView1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Label label4;
        private Button button4;
        private Button buttonAtualizar;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Label label1;
    }
}