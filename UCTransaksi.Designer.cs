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
            lblNamaProduk = new Label();
            pictureBox1 = new PictureBox();
            dspProduk = new Panel();
            addProdukTrs = new Button();
            lblHrgProduk = new Label();
            btnRiwayatTrs = new Button();
            panel1 = new Panel();
            flowLayoutCart = new FlowLayoutPanel();
            totalHargaTrs = new Label();
            label3 = new Label();
            btnLanjutTransaksi = new Button();
            label2 = new Label();
            flowLayoutPanelProduk = new FlowLayoutPanel();
            topPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            dspProduk.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanelProduk.SuspendLayout();
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
            // dspProduk
            // 
            dspProduk.BackgroundImage = Properties.Resources.dspProduk;
            dspProduk.BackgroundImageLayout = ImageLayout.Zoom;
            dspProduk.Controls.Add(addProdukTrs);
            dspProduk.Controls.Add(lblHrgProduk);
            dspProduk.Controls.Add(lblNamaProduk);
            dspProduk.Controls.Add(pictureBox1);
            dspProduk.Location = new Point(3, 3);
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
            panel1.Controls.Add(flowLayoutCart);
            panel1.Controls.Add(totalHargaTrs);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnLanjutTransaksi);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1447, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 832);
            panel1.TabIndex = 22;
            // 
            // flowLayoutCart
            // 
            flowLayoutCart.Anchor = AnchorStyles.Top;
            flowLayoutCart.AutoScroll = true;
            flowLayoutCart.BackColor = SystemColors.ControlLightLight;
            flowLayoutCart.Location = new Point(13, 71);
            flowLayoutCart.Name = "flowLayoutCart";
            flowLayoutCart.Size = new Size(414, 602);
            flowLayoutCart.TabIndex = 24;
            // 
            // totalHargaTrs
            // 
            totalHargaTrs.AutoSize = true;
            totalHargaTrs.BackColor = Color.Transparent;
            totalHargaTrs.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalHargaTrs.Location = new Point(245, 685);
            totalHargaTrs.Name = "totalHargaTrs";
            totalHargaTrs.Size = new Size(69, 29);
            totalHargaTrs.TabIndex = 22;
            totalHargaTrs.Text = "Rp. 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("SF Pro Display", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 685);
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
            btnLanjutTransaksi.Location = new Point(13, 731);
            btnLanjutTransaksi.Name = "btnLanjutTransaksi";
            btnLanjutTransaksi.Size = new Size(414, 60);
            btnLanjutTransaksi.TabIndex = 20;
            btnLanjutTransaksi.Text = "Lanjutkan Transaksi";
            btnLanjutTransaksi.UseVisualStyleBackColor = false;
            btnLanjutTransaksi.Click += btnLanjutTransaksi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Pro Display", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 24);
            label2.Name = "label2";
            label2.Size = new Size(292, 44);
            label2.TabIndex = 19;
            label2.Text = "Daftar Transaksi\r\n";
            // 
            // flowLayoutPanelProduk
            // 
            flowLayoutPanelProduk.AutoScroll = true;
            flowLayoutPanelProduk.Controls.Add(dspProduk);
            flowLayoutPanelProduk.Location = new Point(385, 197);
            flowLayoutPanelProduk.Name = "flowLayoutPanelProduk";
            flowLayoutPanelProduk.Size = new Size(1056, 797);
            flowLayoutPanelProduk.TabIndex = 23;
            // 
            // UCTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(flowLayoutPanelProduk);
            Controls.Add(panel1);
            Controls.Add(btnRiwayatTrs);
            Controls.Add(topPanel);
            Controls.Add(leftPanel);
            Name = "UCTransaksi";
            Size = new Size(1920, 1080);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            dspProduk.ResumeLayout(false);
            dspProduk.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanelProduk.ResumeLayout(false);
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
        private Label lblNamaProduk;
        private PictureBox pictureBox1;
        private Panel dspProduk;
        private Button btnRiwayatTrs;
        private Panel panel1;
        private Label label2;
        private Button btnLanjutTransaksi;
        private Label totalHargaTrs;
        private Label label3;
        private Label lblHrgProduk;
        private Button addProdukTrs;
        private FlowLayoutPanel flowLayoutPanelProduk;
        private FlowLayoutPanel flowLayoutCart;
    }
}
