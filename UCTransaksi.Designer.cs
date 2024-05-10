namespace COFFE_SHARP
{
    partial class UCTransaksi
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
            topPanel = new Panel();
            lblDashboard = new Label();
            logoPanel = new Panel();
            btnDashboard = new Button();
            btnPengelolaanProduk = new Button();
            leftPanel = new Panel();
            btnLogout = new Button();
            btnTransaksi = new Button();
            btnPengelolaanStok = new Button();
            labelTotalProduk = new Label();
            addTotal = new Button();
            subsTotal = new Button();
            lblNamaProduk = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            labelHrgProduk = new Label();
            pictureBox2 = new PictureBox();
            dspProduk = new Panel();
            addProdukTrs = new Button();
            lblHrgProduk = new Label();
            btnRiwayatTrs = new Button();
            panel1 = new Panel();
            totalTransaksi = new Label();
            label3 = new Label();
            btnLanjutTransaksi = new Button();
            label2 = new Label();
            panel2 = new Panel();
            HargaProduk = new Label();
            NamaProduk = new Label();
            pictureBox3 = new PictureBox();
            topPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            dspProduk.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(lblDashboard);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(264, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1656, 110);
            topPanel.TabIndex = 16;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("SF Pro Display", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(132, 27);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(210, 51);
            lblDashboard.TabIndex = 18;
            lblDashboard.Text = "Transaksi\r\n";
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.Transparent;
            logoPanel.BackgroundImage = Properties.Resources.adminLogo;
            logoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            logoPanel.Location = new Point(1, -1);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(266, 112);
            logoPanel.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSize = true;
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Image = Properties.Resources.dashboardBlack;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 119);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(20, 0, 0, 0);
            btnDashboard.Size = new Size(258, 58);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "             Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnPengelolaanProduk
            // 
            btnPengelolaanProduk.AutoSize = true;
            btnPengelolaanProduk.BackColor = Color.Transparent;
            btnPengelolaanProduk.BackgroundImageLayout = ImageLayout.Zoom;
            btnPengelolaanProduk.Cursor = Cursors.Hand;
            btnPengelolaanProduk.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPengelolaanProduk.ForeColor = Color.Black;
            btnPengelolaanProduk.Image = Properties.Resources.kelolaProdukBlack;
            btnPengelolaanProduk.ImageAlign = ContentAlignment.MiddleLeft;
            btnPengelolaanProduk.Location = new Point(3, 247);
            btnPengelolaanProduk.Name = "btnPengelolaanProduk";
            btnPengelolaanProduk.Padding = new Padding(20, 0, 0, 0);
            btnPengelolaanProduk.Size = new Size(258, 58);
            btnPengelolaanProduk.TabIndex = 7;
            btnPengelolaanProduk.Text = "             Pengelolaan Produk";
            btnPengelolaanProduk.TextAlign = ContentAlignment.MiddleLeft;
            btnPengelolaanProduk.UseVisualStyleBackColor = false;
            btnPengelolaanProduk.Click += btnPengelolaanProduk_Click;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(logoPanel);
            leftPanel.Controls.Add(btnDashboard);
            leftPanel.Controls.Add(btnPengelolaanProduk);
            leftPanel.Controls.Add(btnLogout);
            leftPanel.Controls.Add(btnTransaksi);
            leftPanel.Controls.Add(btnPengelolaanStok);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(264, 1080);
            leftPanel.TabIndex = 17;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            btnLogout.BackColor = Color.Red;
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.logoutBtn;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(3, 375);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(258, 58);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "             Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.AutoSize = true;
            btnTransaksi.BackColor = Color.SaddleBrown;
            btnTransaksi.BackgroundImageLayout = ImageLayout.Zoom;
            btnTransaksi.Cursor = Cursors.Hand;
            btnTransaksi.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaksi.ForeColor = Color.White;
            btnTransaksi.Image = Properties.Resources.transaksiWhite;
            btnTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaksi.Location = new Point(3, 311);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Padding = new Padding(20, 0, 0, 0);
            btnTransaksi.Size = new Size(258, 58);
            btnTransaksi.TabIndex = 5;
            btnTransaksi.Text = "             Transaksi";
            btnTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            btnTransaksi.UseVisualStyleBackColor = false;
            // 
            // btnPengelolaanStok
            // 
            btnPengelolaanStok.AutoSize = true;
            btnPengelolaanStok.BackColor = Color.Transparent;
            btnPengelolaanStok.BackgroundImageLayout = ImageLayout.Zoom;
            btnPengelolaanStok.Cursor = Cursors.Hand;
            btnPengelolaanStok.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPengelolaanStok.ForeColor = Color.Black;
            btnPengelolaanStok.Image = Properties.Resources.kelolaStokBlack;
            btnPengelolaanStok.ImageAlign = ContentAlignment.MiddleLeft;
            btnPengelolaanStok.Location = new Point(3, 183);
            btnPengelolaanStok.Name = "btnPengelolaanStok";
            btnPengelolaanStok.Padding = new Padding(20, 0, 0, 0);
            btnPengelolaanStok.Size = new Size(258, 58);
            btnPengelolaanStok.TabIndex = 3;
            btnPengelolaanStok.Text = "             Pengelolaan Stok";
            btnPengelolaanStok.TextAlign = ContentAlignment.MiddleLeft;
            btnPengelolaanStok.UseVisualStyleBackColor = false;
            btnPengelolaanStok.Click += btnPengelolaanStok_Click;
            // 
            // labelTotalProduk
            // 
            labelTotalProduk.AutoSize = true;
            labelTotalProduk.BackColor = Color.Transparent;
            labelTotalProduk.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalProduk.Location = new Point(278, 68);
            labelTotalProduk.Name = "labelTotalProduk";
            labelTotalProduk.Size = new Size(29, 29);
            labelTotalProduk.TabIndex = 4;
            labelTotalProduk.Text = "0";
            // 
            // addTotal
            // 
            addTotal.BackgroundImage = Properties.Resources.plusIcon;
            addTotal.BackgroundImageLayout = ImageLayout.Center;
            addTotal.Location = new Point(324, 68);
            addTotal.Name = "addTotal";
            addTotal.Size = new Size(31, 29);
            addTotal.TabIndex = 3;
            addTotal.UseVisualStyleBackColor = true;
            // 
            // subsTotal
            // 
            subsTotal.BackgroundImage = Properties.Resources.minusIcon;
            subsTotal.BackgroundImageLayout = ImageLayout.Center;
            subsTotal.Location = new Point(227, 68);
            subsTotal.Name = "subsTotal";
            subsTotal.Size = new Size(31, 29);
            subsTotal.TabIndex = 2;
            subsTotal.UseVisualStyleBackColor = true;
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.BackColor = Color.Transparent;
            lblNamaProduk.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProduk.Location = new Point(32, 169);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(125, 23);
            lblNamaProduk.TabIndex = 1;
            lblNamaProduk.Text = "Kopi Robusta";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.coffe_beans;
            pictureBox1.Location = new Point(32, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(36, 169);
            label8.Name = "label8";
            label8.Size = new Size(119, 23);
            label8.TabIndex = 1;
            label8.Text = "Kopi Arabica";
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.dspProduk;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(labelHrgProduk);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(628, 225);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 286);
            panel4.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.addTransaction;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(75, 227);
            button1.Name = "button1";
            button1.Size = new Size(39, 36);
            button1.TabIndex = 28;
            button1.UseVisualStyleBackColor = true;
            // 
            // labelHrgProduk
            // 
            labelHrgProduk.AutoSize = true;
            labelHrgProduk.BackColor = Color.Transparent;
            labelHrgProduk.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHrgProduk.ForeColor = Color.DarkOrange;
            labelHrgProduk.Location = new Point(45, 192);
            labelHrgProduk.Name = "labelHrgProduk";
            labelHrgProduk.Size = new Size(105, 23);
            labelHrgProduk.TabIndex = 23;
            labelHrgProduk.Text = "Rp. 75.000";
            labelHrgProduk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.coffe_beans;
            pictureBox2.Location = new Point(32, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // dspProduk
            // 
            dspProduk.BackgroundImage = Properties.Resources.dspProduk;
            dspProduk.BackgroundImageLayout = ImageLayout.Zoom;
            dspProduk.Controls.Add(addProdukTrs);
            dspProduk.Controls.Add(lblHrgProduk);
            dspProduk.Controls.Add(lblNamaProduk);
            dspProduk.Controls.Add(pictureBox1);
            dspProduk.Location = new Point(396, 225);
            dspProduk.Name = "dspProduk";
            dspProduk.Size = new Size(190, 286);
            dspProduk.TabIndex = 19;
            // 
            // addProdukTrs
            // 
            addProdukTrs.BackgroundImage = Properties.Resources.addTransaction;
            addProdukTrs.BackgroundImageLayout = ImageLayout.Center;
            addProdukTrs.Location = new Point(73, 227);
            addProdukTrs.Name = "addProdukTrs";
            addProdukTrs.Size = new Size(39, 36);
            addProdukTrs.TabIndex = 27;
            addProdukTrs.UseVisualStyleBackColor = true;
            // 
            // lblHrgProduk
            // 
            lblHrgProduk.AutoSize = true;
            lblHrgProduk.BackColor = Color.Transparent;
            lblHrgProduk.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHrgProduk.ForeColor = Color.DarkOrange;
            lblHrgProduk.Location = new Point(41, 192);
            lblHrgProduk.Name = "lblHrgProduk";
            lblHrgProduk.Size = new Size(106, 23);
            lblHrgProduk.TabIndex = 24;
            lblHrgProduk.Text = "Rp. 55.000";
            lblHrgProduk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRiwayatTrs
            // 
            btnRiwayatTrs.AutoSize = true;
            btnRiwayatTrs.BackColor = Color.White;
            btnRiwayatTrs.BackgroundImageLayout = ImageLayout.Zoom;
            btnRiwayatTrs.Cursor = Cursors.Hand;
            btnRiwayatTrs.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRiwayatTrs.ForeColor = Color.Black;
            btnRiwayatTrs.Image = Properties.Resources.historyIconBlck;
            btnRiwayatTrs.ImageAlign = ContentAlignment.MiddleLeft;
            btnRiwayatTrs.Location = new Point(396, 128);
            btnRiwayatTrs.Name = "btnRiwayatTrs";
            btnRiwayatTrs.Padding = new Padding(20, 0, 0, 0);
            btnRiwayatTrs.Size = new Size(236, 58);
            btnRiwayatTrs.TabIndex = 21;
            btnRiwayatTrs.Text = "         Riwayat Transaksi";
            btnRiwayatTrs.TextAlign = ContentAlignment.MiddleLeft;
            btnRiwayatTrs.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.trsPanel;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(totalTransaksi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnLanjutTransaksi);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1452, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 809);
            panel1.TabIndex = 22;
            // 
            // totalTransaksi
            // 
            totalTransaksi.AutoSize = true;
            totalTransaksi.BackColor = Color.Transparent;
            totalTransaksi.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalTransaksi.Location = new Point(245, 674);
            totalTransaksi.Name = "totalTransaksi";
            totalTransaksi.Size = new Size(69, 29);
            totalTransaksi.TabIndex = 22;
            totalTransaksi.Text = "Rp. 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("SF Pro Display", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 674);
            label3.Name = "label3";
            label3.Size = new Size(61, 29);
            label3.TabIndex = 21;
            label3.Text = "Total";
            // 
            // btnLanjutTransaksi
            // 
            btnLanjutTransaksi.BackColor = Color.SaddleBrown;
            btnLanjutTransaksi.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLanjutTransaksi.ForeColor = Color.White;
            btnLanjutTransaksi.Location = new Point(28, 720);
            btnLanjutTransaksi.Name = "btnLanjutTransaksi";
            btnLanjutTransaksi.Size = new Size(370, 58);
            btnLanjutTransaksi.TabIndex = 20;
            btnLanjutTransaksi.Text = "Lanjutkan Transaksi";
            btnLanjutTransaksi.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Pro Display", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 35);
            label2.Name = "label2";
            label2.Size = new Size(292, 44);
            label2.TabIndex = 19;
            label2.Text = "Daftar Transaksi\r\n";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(HargaProduk);
            panel2.Controls.Add(NamaProduk);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(labelTotalProduk);
            panel2.Controls.Add(addTotal);
            panel2.Controls.Add(subsTotal);
            panel2.Location = new Point(28, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 106);
            panel2.TabIndex = 23;
            // 
            // HargaProduk
            // 
            HargaProduk.AutoSize = true;
            HargaProduk.BackColor = Color.Transparent;
            HargaProduk.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HargaProduk.ForeColor = Color.DarkOrange;
            HargaProduk.Location = new Point(102, 51);
            HargaProduk.Name = "HargaProduk";
            HargaProduk.Size = new Size(106, 23);
            HargaProduk.TabIndex = 26;
            HargaProduk.Text = "Rp. 55.000";
            HargaProduk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NamaProduk
            // 
            NamaProduk.AutoSize = true;
            NamaProduk.BackColor = Color.Transparent;
            NamaProduk.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NamaProduk.Location = new Point(102, 13);
            NamaProduk.Name = "NamaProduk";
            NamaProduk.Size = new Size(125, 23);
            NamaProduk.TabIndex = 25;
            NamaProduk.Text = "Kopi Robusta";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.coffe_beans;
            pictureBox3.Location = new Point(15, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(81, 83);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // UCTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnRiwayatTrs);
            Controls.Add(topPanel);
            Controls.Add(leftPanel);
            Controls.Add(panel4);
            Controls.Add(dspProduk);
            Name = "UCTransaksi";
            Size = new Size(1920, 1080);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            dspProduk.ResumeLayout(false);
            dspProduk.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topPanel;
        private Panel logoPanel;
        private Button btnDashboard;
        private Button btnPengelolaanProduk;
        private Panel leftPanel;
        private Button btnLogout;
        private Button btnTransaksi;
        private Button btnPengelolaanStok;
        private Label lblDashboard;
        private Label labelTotalProduk;
        private Button addTotal;
        private Button subsTotal;
        private Label lblNamaProduk;
        private PictureBox pictureBox1;
        private Label label8;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Panel dspProduk;
        private Button btnRiwayatTrs;
        private Panel panel1;
        private Label label2;
        private Button btnLanjutTransaksi;
        private Label totalTransaksi;
        private Label label3;
        private Label labelHrgProduk;
        private Label lblHrgProduk;
        private Panel panel2;
        private Button button1;
        private Button addProdukTrs;
        private Label HargaProduk;
        private Label NamaProduk;
        private PictureBox pictureBox3;
    }
}
