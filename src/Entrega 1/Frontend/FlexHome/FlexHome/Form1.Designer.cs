namespace FlexHome
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(289, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 151);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MidnightBlue;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(244, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(449, 34);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MidnightBlue;
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(244, 311);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(449, 34);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(244, 193);
            label1.Name = "label1";
            label1.Size = new Size(114, 37);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(244, 271);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 4;
            label2.Text = "Senha:";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Segoe UI", 20F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(387, 363);
            button1.Name = "button1";
            button1.Size = new Size(165, 51);
            button1.TabIndex = 5;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(922, 531);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
