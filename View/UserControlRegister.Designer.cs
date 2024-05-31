namespace COFFE_SHARP
{
    partial class UserControlRegister
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
            registerKey = new TextBox();
            namaAdmin = new TextBox();
            label9 = new Label();
            namalbl = new Label();
            confirmPass = new TextBox();
            label8 = new Label();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            btnRegister = new Button();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSignIn = new Button();
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
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Pro Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(160, 20);
            label2.Name = "label2";
            label2.Size = new Size(130, 38);
            label2.TabIndex = 8;
            label2.Text = "Sign Up";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.RegisterBG;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(registerKey);
            panel1.Controls.Add(namaAdmin);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(namalbl);
            panel1.Controls.Add(confirmPass);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(usernameBox);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1344, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 620);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // registerKey
            // 
            registerKey.BorderStyle = BorderStyle.None;
            registerKey.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerKey.Location = new Point(103, 462);
            registerKey.Name = "registerKey";
            registerKey.Size = new Size(267, 20);
            registerKey.TabIndex = 4;
            // 
            // namaAdmin
            // 
            namaAdmin.BorderStyle = BorderStyle.None;
            namaAdmin.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namaAdmin.Location = new Point(103, 115);
            namaAdmin.Name = "namaAdmin";
            namaAdmin.Size = new Size(267, 20);
            namaAdmin.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(51, 420);
            label9.Name = "label9";
            label9.Size = new Size(112, 19);
            label9.TabIndex = 17;
            label9.Text = "Kode Registrasi";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // namalbl
            // 
            namalbl.AutoSize = true;
            namalbl.BackColor = Color.Transparent;
            namalbl.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namalbl.ForeColor = Color.White;
            namalbl.Location = new Point(51, 72);
            namalbl.Name = "namalbl";
            namalbl.Size = new Size(49, 19);
            namalbl.TabIndex = 16;
            namalbl.Text = "Nama";
            namalbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confirmPass
            // 
            confirmPass.BorderStyle = BorderStyle.None;
            confirmPass.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPass.Location = new Point(103, 375);
            confirmPass.Name = "confirmPass";
            confirmPass.Size = new Size(267, 20);
            confirmPass.TabIndex = 3;
            confirmPass.TextChanged += confirmPass_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(46, 331);
            label8.Name = "label8";
            label8.Size = new Size(145, 19);
            label8.TabIndex = 15;
            label8.Text = "Konfirmasi Password";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(103, 289);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(267, 20);
            passwordBox.TabIndex = 2;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // usernameBox
            // 
            usernameBox.BorderStyle = BorderStyle.None;
            usernameBox.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.Location = new Point(103, 201);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(267, 20);
            usernameBox.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Chocolate;
            btnRegister.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Cornsilk;
            btnRegister.Location = new Point(44, 530);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(350, 60);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(51, 245);
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
            label4.Location = new Point(46, 157);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 10;
            label4.Text = "Username";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(434, 675);
            label7.Name = "label7";
            label7.Size = new Size(196, 46);
            label7.TabIndex = 18;
            label7.Text = "Fakultas Ilmu Komputer\r\nUniversitas Jember";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(476, 652);
            label6.Name = "label6";
            label6.Size = new Size(112, 23);
            label6.TabIndex = 17;
            label6.Text = "Develop by:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1370, 85);
            label3.Name = "label3";
            label3.Size = new Size(397, 42);
            label3.TabIndex = 16;
            label3.Text = "Buat Akun Untuk Masuk";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SF Pro Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 328);
            label1.Name = "label1";
            label1.Size = new Size(489, 64);
            label1.TabIndex = 13;
            label1.Text = "Aplikasi pencatatan dan penjualan produk\r\nKopi dan Kakao";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(357, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.SaddleBrown;
            btnSignIn.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.Cornsilk;
            btnSignIn.Location = new Point(1388, 813);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(350, 60);
            btnSignIn.TabIndex = 24;
            btnSignIn.Text = "Login";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // UserControlRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgUC1;
            Controls.Add(btnSignIn);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "UserControlRegister";
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
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Button btnRegister;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox confirmPass;
        private Label label8;
        private TextBox registerKey;
        private TextBox namaAdmin;
        private Label label9;
        private Label namalbl;
        private Button btnSignIn;
    }
}
