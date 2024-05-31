namespace COFFE_SHARP
{
    partial class UserControlLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox3 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            btnLogin = new Button();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnRegister = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Dock = DockStyle.Bottom;
            pictureBox3.Image = Properties.Resources.bottom;
            pictureBox3.Location = new Point(0, 879);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1920, 201);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Pro Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(167, 36);
            label2.Name = "label2";
            label2.Size = new Size(114, 38);
            label2.TabIndex = 8;
            label2.Text = "Sign In";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Sign_Up;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(usernameBox);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1344, 241);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 416);
            panel1.TabIndex = 9;
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(103, 233);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(267, 20);
            passwordBox.TabIndex = 2;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // usernameBox
            // 
            usernameBox.BorderStyle = BorderStyle.None;
            usernameBox.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.Location = new Point(103, 142);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(267, 20);
            usernameBox.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Chocolate;
            btnLogin.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Cornsilk;
            btnLogin.Location = new Point(37, 315);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(363, 60);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(46, 188);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 11;
            label5.Text = "Password";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(46, 96);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 10;
            label4.Text = "Username";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(357, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SF Pro Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 398);
            label1.Name = "label1";
            label1.Size = new Size(489, 64);
            label1.TabIndex = 5;
            label1.Text = "Aplikasi pencatatan dan penjualan produk\r\nKopi dan Kakao";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1424, 141);
            label3.Name = "label3";
            label3.Size = new Size(305, 84);
            label3.TabIndex = 9;
            label3.Text = "Selamat Datang di\r\nCoffe Sharp!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(476, 722);
            label6.Name = "label6";
            label6.Size = new Size(112, 23);
            label6.TabIndex = 10;
            label6.Text = "Develop by:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(434, 745);
            label7.Name = "label7";
            label7.Size = new Size(196, 46);
            label7.TabIndex = 11;
            label7.Text = "Fakultas Ilmu Komputer\r\nUniversitas Jember";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SaddleBrown;
            btnRegister.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ControlLightLight;
            btnRegister.Location = new Point(1381, 731);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(363, 60);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1488, 686);
            label8.Name = "label8";
            label8.Size = new Size(151, 19);
            label8.TabIndex = 13;
            label8.Text = "Belum memiliki akun?";
            // 
            // UserControlLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgUC1;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(label8);
            Controls.Add(btnRegister);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "UserControlLogin";
            Size = new Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Label label2;
        private Panel panel1;
        private Button btnLogin;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label6;
        private Label label7;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Button btnRegister;
        private Label label8;
    }
}
