namespace COFFE_SHARP.View
{
    partial class RiwayatTransaksi
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
            logoPanel = new Panel();
            buttonKembali = new Button();
            leftPanel = new Panel();
            lblDashboard = new Label();
            dataGridView1 = new DataGridView();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(264, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1656, 110);
            topPanel.TabIndex = 39;
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
            // buttonKembali
            // 
            buttonKembali.AutoSize = true;
            buttonKembali.BackColor = Color.SaddleBrown;
            buttonKembali.BackgroundImage = Properties.Resources.LeftArrow;
            buttonKembali.BackgroundImageLayout = ImageLayout.Zoom;
            buttonKembali.Cursor = Cursors.Hand;
            buttonKembali.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKembali.ForeColor = Color.White;
            buttonKembali.ImageAlign = ContentAlignment.MiddleLeft;
            buttonKembali.Location = new Point(293, 133);
            buttonKembali.Name = "buttonKembali";
            buttonKembali.Padding = new Padding(20, 0, 0, 0);
            buttonKembali.Size = new Size(72, 68);
            buttonKembali.TabIndex = 38;
            buttonKembali.UseVisualStyleBackColor = false;
            buttonKembali.Click += buttonKembali_Click;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.GhostWhite;
            leftPanel.Controls.Add(logoPanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(264, 1080);
            leftPanel.TabIndex = 40;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("SF Pro Display", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(417, 142);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(376, 51);
            lblDashboard.TabIndex = 41;
            lblDashboard.Text = "Riwayat Transaksi";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(427, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1342, 677);
            dataGridView1.TabIndex = 42;
            // 
            // RiwayatTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(topPanel);
            Controls.Add(buttonKembali);
            Controls.Add(leftPanel);
            Controls.Add(lblDashboard);
            Name = "RiwayatTransaksi";
            Size = new Size(1920, 1080);
            Load += RiwayatTransaksi_Load;
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topPanel;
        private Panel logoPanel;
        private Button buttonKembali;
        private Panel leftPanel;
        private Label lblDashboard;
        private DataGridView dataGridView1;
    }
}
