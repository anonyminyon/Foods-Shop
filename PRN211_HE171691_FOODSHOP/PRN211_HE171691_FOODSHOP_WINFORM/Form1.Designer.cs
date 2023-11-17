namespace PRN211_HE171691_FOODSHOP_WINFORM
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
            panel1 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button2 = new Button();
            btnLogin = new Button();
            panel4 = new Panel();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OliveDrab;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 774);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(115, 314);
            label2.Name = "label2";
            label2.Size = new Size(235, 34);
            label2.TabIndex = 1;
            label2.Text = "Welcome to the";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 421);
            label4.Name = "label4";
            label4.Size = new Size(305, 34);
            label4.TabIndex = 1;
            label4.Text = "Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(190, 367);
            label3.Name = "label3";
            label3.Size = new Size(160, 34);
            label3.TabIndex = 1;
            label3.Text = "Food Shop";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 691);
            label1.Name = "label1";
            label1.Size = new Size(273, 34);
            label1.TabIndex = 1;
            label1.Text = "Develop by HieuHT";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = Properties.Resources.settings_gears_60473;
            pictureBox1.Location = new Point(115, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.ForeColor = Color.OliveDrab;
            panel2.Location = new Point(400, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(628, 774);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(228, 463);
            button2.Name = "button2";
            button2.Size = new Size(300, 50);
            button2.TabIndex = 3;
            button2.Text = "FORGOT PASSWORD ?";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.OliveDrab;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.OldLace;
            btnLogin.Location = new Point(38, 463);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 50);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(0, 344);
            panel4.Name = "panel4";
            panel4.Size = new Size(628, 57);
            panel4.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(547, 34);
            textBox1.TabIndex = 4;
            textBox1.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, -2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 266);
            panel3.Name = "panel3";
            panel3.Size = new Size(628, 57);
            panel3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(547, 34);
            textBox2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(7, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(69, 192);
            label5.Name = "label5";
            label5.Size = new Size(280, 34);
            label5.TabIndex = 1;
            label5.Text = "Login your account";
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.OliveDrab;
            btnClose.Location = new Point(579, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(53, 57);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 774);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        public PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnClose;
        private Label label4;
        private Panel panel4;
        private Panel panel3;
        private Label label5;
        public PictureBox pictureBox3;
        public PictureBox pictureBox2;
        private Button btnLogin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
    }
}