namespace esfera
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            lbxR = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 27);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite o raio da esfera";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(51, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 59);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(145, 58);
            button2.Name = "button2";
            button2.Size = new Size(112, 22);
            button2.TabIndex = 9;
            button2.Text = "Circunferência";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(145, 84);
            button3.Name = "button3";
            button3.Size = new Size(112, 22);
            button3.TabIndex = 10;
            button3.Text = "Perímetro";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(145, 108);
            button4.Name = "button4";
            button4.Size = new Size(112, 22);
            button4.TabIndex = 11;
            button4.Text = "Diâmetro";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(145, 131);
            button5.Name = "button5";
            button5.Size = new Size(112, 22);
            button5.TabIndex = 12;
            button5.Text = "Área";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // lbxR
            // 
            lbxR.AutoSize = true;
            lbxR.Location = new Point(237, 165);
            lbxR.Name = "lbxR";
            lbxR.Size = new Size(59, 15);
            lbxR.TabIndex = 13;
            lbxR.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 511);
            Controls.Add(lbxR);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = ",";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label lbxR;
    }
}
