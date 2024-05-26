namespace COFFE_SHARP
{
    partial class UCPengelolaanProduk
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
            lblHrgProduk = new Label();
            lblNamaProduk = new Label();
            PBProduk = new PictureBox();
            dspProduk = new Panel();
            button6 = new Button();
            button5 = new Button();
            btnLogout = new Button();
            btnTransaksi = new Button();
            button2 = new Button();
            btnPengelolaanStok = new Button();
            btnDashboard = new Button();
            leftPanel = new Panel();
            logoPanel = new Panel();
            topPanel = new Panel();
            lblDashboard = new Label();
            btnTambahProduk = new Button();
            flowLayoutPanelProduk = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)PBProduk).BeginInit();
            dspProduk.SuspendLayout();
            leftPanel.SuspendLayout();
            topPanel.SuspendLayout();
            flowLayoutPanelProduk.SuspendLayout();
            SuspendLayout();
            // 
            // lblHrgProduk
            // 
            lblHrgProduk.AutoSize = true;
            lblHrgProduk.BackColor = Color.Transparent;
            lblHrgProduk.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHrgProduk.ForeColor = Color.DarkOrange;
            lblHrgProduk.Location = new Point(40, 191);
            lblHrgProduk.Name = "lblHrgProduk";
            lblHrgProduk.Size = new Size(106, 23);
            lblHrgProduk.TabIndex = 2;
            lblHrgProduk.Text = "Rp. 55.000";
            lblHrgProduk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.BackColor = Color.Transparent;
            lblNamaProduk.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProduk.Location = new Point(7, 167);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(179, 23);
            lblNamaProduk.TabIndex = 1;
            lblNamaProduk.Text = "Cokelat Strawberry";
            // 
            // PBProduk
            // 
            PBProduk.BackColor = Color.Transparent;
            PBProduk.Image = Properties.Resources.coffe_beans;
            PBProduk.Location = new Point(32, 25);
            PBProduk.Name = "PBProduk";
            PBProduk.Size = new Size(128, 128);
            PBProduk.SizeMode = PictureBoxSizeMode.Zoom;
            PBProduk.TabIndex = 0;
            PBProduk.TabStop = false;
            // 
            // dspProduk
            // 
            dspProduk.BackgroundImage = Properties.Resources.dspProduk;
            dspProduk.BackgroundImageLayout = ImageLayout.Zoom;
            dspProduk.Controls.Add(button6);
            dspProduk.Controls.Add(button5);
            dspProduk.Controls.Add(lblHrgProduk);
            dspProduk.Controls.Add(lblNamaProduk);
            dspProduk.Controls.Add(PBProduk);
            dspProduk.Location = new Point(3, 3);
            dspProduk.Name = "dspProduk";
            dspProduk.Size = new Size(190, 286);
            dspProduk.TabIndex = 14;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.DeleteButton;
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(127, 223);
            button6.Name = "button6";
            button6.Size = new Size(33, 36);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Image = Properties.Resources.editIcon;
            button5.ImageAlign = ContentAlignment.BottomLeft;
            button5.Location = new Point(32, 223);
            button5.Name = "button5";
            button5.Size = new Size(89, 36);
            button5.TabIndex = 3;
            button5.Text = "       Edit";
            button5.UseVisualStyleBackColor = true;
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
            btnLogout.Location = new Point(3, 262);
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
            btnTransaksi.BackColor = Color.Transparent;
            btnTransaksi.BackgroundImageLayout = ImageLayout.Zoom;
            btnTransaksi.Cursor = Cursors.Hand;
            btnTransaksi.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaksi.ForeColor = Color.Black;
            btnTransaksi.Image = Properties.Resources.transaksiBlack;
            btnTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaksi.Location = new Point(3, 198);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Padding = new Padding(20, 0, 0, 0);
            btnTransaksi.Size = new Size(258, 58);
            btnTransaksi.TabIndex = 5;
            btnTransaksi.Text = "             Transaksi";
            btnTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            btnTransaksi.UseVisualStyleBackColor = false;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.SaddleBrown;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.kelolaProdukWhite;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 134);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(258, 58);
            button2.TabIndex = 4;
            button2.Text = "             Pengelolaan Produk";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
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
            btnPengelolaanStok.Location = new Point(3, 70);
            btnPengelolaanStok.Name = "btnPengelolaanStok";
            btnPengelolaanStok.Padding = new Padding(20, 0, 0, 0);
            btnPengelolaanStok.Size = new Size(258, 58);
            btnPengelolaanStok.TabIndex = 3;
            btnPengelolaanStok.Text = "             Pengelolaan Stok";
            btnPengelolaanStok.TextAlign = ContentAlignment.MiddleLeft;
            btnPengelolaanStok.UseVisualStyleBackColor = false;
            btnPengelolaanStok.Click += btnPengelolaanStok_Click;
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
            btnDashboard.Location = new Point(3, 6);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(20, 0, 0, 0);
            btnDashboard.Size = new Size(258, 58);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "             Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(btnLogout);
            leftPanel.Controls.Add(btnTransaksi);
            leftPanel.Controls.Add(button2);
            leftPanel.Controls.Add(btnPengelolaanStok);
            leftPanel.Controls.Add(btnDashboard);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 110);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(264, 970);
            leftPanel.TabIndex = 9;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.Transparent;
            logoPanel.BackgroundImage = Properties.Resources.adminLogo;
            logoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            logoPanel.Location = new Point(-2, -2);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(266, 112);
            logoPanel.TabIndex = 2;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(logoPanel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1920, 110);
            topPanel.TabIndex = 8;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("SF Pro Display", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(396, 137);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(415, 51);
            lblDashboard.TabIndex = 10;
            lblDashboard.Text = "Pengelolaan Produk";
            // 
            // btnTambahProduk
            // 
            btnTambahProduk.AutoSize = true;
            btnTambahProduk.BackColor = Color.SaddleBrown;
            btnTambahProduk.BackgroundImageLayout = ImageLayout.Zoom;
            btnTambahProduk.Cursor = Cursors.Hand;
            btnTambahProduk.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTambahProduk.ForeColor = Color.White;
            btnTambahProduk.Image = Properties.Resources.addBtn;
            btnTambahProduk.ImageAlign = ContentAlignment.MiddleLeft;
            btnTambahProduk.Location = new Point(1579, 137);
            btnTambahProduk.Name = "btnTambahProduk";
            btnTambahProduk.Padding = new Padding(20, 0, 0, 0);
            btnTambahProduk.Size = new Size(233, 58);
            btnTambahProduk.TabIndex = 16;
            btnTambahProduk.Text = "             Tambah Produk";
            btnTambahProduk.TextAlign = ContentAlignment.MiddleLeft;
            btnTambahProduk.UseVisualStyleBackColor = false;
            btnTambahProduk.Click += btnTambahProduk_Click;
            // 
            // flowLayoutPanelProduk
            // 
            flowLayoutPanelProduk.Anchor = AnchorStyles.Top;
            flowLayoutPanelProduk.AutoScroll = true;
            flowLayoutPanelProduk.Controls.Add(dspProduk);
            flowLayoutPanelProduk.Location = new Point(396, 202);
            flowLayoutPanelProduk.Name = "flowLayoutPanelProduk";
            flowLayoutPanelProduk.Size = new Size(1459, 790);
            flowLayoutPanelProduk.TabIndex = 17;
            // 
            // UCPengelolaanProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelProduk);
            Controls.Add(btnTambahProduk);
            Controls.Add(lblDashboard);
            Controls.Add(leftPanel);
            Controls.Add(topPanel);
            Name = "UCPengelolaanProduk";
            Size = new Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)PBProduk).EndInit();
            dspProduk.ResumeLayout(false);
            dspProduk.PerformLayout();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            topPanel.ResumeLayout(false);
            flowLayoutPanelProduk.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHrgProduk;
        private Label lblNamaProduk;
        private PictureBox PBProduk;
        private Panel dspProduk;
        private Button btnLogout;
        private Button btnTransaksi;
        private Button button2;
        private Button btnPengelolaanStok;
        private Button btnDashboard;
        private Panel leftPanel;
        private Panel logoPanel;
        private Panel topPanel;
        private Label lblDashboard;
        private Button button6;
        private Button button5;
        private Button btnTambahProduk;
        private FlowLayoutPanel flowLayoutPanelProduk;
    }
}
