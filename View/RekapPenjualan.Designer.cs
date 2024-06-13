namespace COFFE_SHARP.View
{
    partial class RekapPenjualan
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
            lblDashboard = new Label();
            leftPanel = new Panel();
            logoPanel = new Panel();
            topPanel = new Panel();
            panel3 = new Panel();
            labelPeriode = new Label();
            label3 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            custom = new CheckBox();
            hariIni = new CheckBox();
            MingguIni = new CheckBox();
            BulanIni = new CheckBox();
            panel2 = new Panel();
            labelMingguIni = new Label();
            label2 = new Label();
            panel1 = new Panel();
            labelHariIni = new Label();
            label1 = new Label();
            panel4 = new Panel();
            labelBulanIni = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            buttonKembali = new Button();
            panel5 = new Panel();
            topPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("SF Pro Display", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(417, 142);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(349, 51);
            lblDashboard.TabIndex = 22;
            lblDashboard.Text = "Rekap Penjualan";
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.GhostWhite;
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 110);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(264, 953);
            leftPanel.TabIndex = 21;
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
            topPanel.Size = new Size(2210, 110);
            topPanel.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Frame_2bg_color;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(labelPeriode);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(417, 391);
            panel3.Name = "panel3";
            panel3.Size = new Size(472, 297);
            panel3.TabIndex = 28;
            // 
            // labelPeriode
            // 
            labelPeriode.AutoSize = true;
            labelPeriode.BackColor = Color.Transparent;
            labelPeriode.Font = new Font("SF Pro Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPeriode.ForeColor = SystemColors.ControlLightLight;
            labelPeriode.Location = new Point(29, 132);
            labelPeriode.Name = "labelPeriode";
            labelPeriode.Size = new Size(90, 38);
            labelPeriode.TabIndex = 1;
            labelPeriode.Text = "Rp. 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("SF Pro Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(29, 63);
            label3.Name = "label3";
            label3.Size = new Size(227, 38);
            label3.TabIndex = 0;
            label3.Text = "Rekap Periode";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 13);
            label6.Name = "label6";
            label6.Size = new Size(227, 25);
            label6.TabIndex = 29;
            label6.Text = "Pilih Periode Transaksi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(33, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 25);
            dateTimePicker1.TabIndex = 30;
            // 
            // custom
            // 
            custom.AutoSize = true;
            custom.BackColor = Color.Transparent;
            custom.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            custom.Location = new Point(36, 87);
            custom.Name = "custom";
            custom.Size = new Size(98, 27);
            custom.TabIndex = 32;
            custom.Text = "Custom";
            custom.UseVisualStyleBackColor = false;
            custom.CheckedChanged += custom_CheckedChanged;
            // 
            // hariIni
            // 
            hariIni.AutoSize = true;
            hariIni.BackColor = Color.Transparent;
            hariIni.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hariIni.Location = new Point(36, 120);
            hariIni.Name = "hariIni";
            hariIni.Size = new Size(90, 27);
            hariIni.TabIndex = 33;
            hariIni.Text = "Hari Ini";
            hariIni.UseVisualStyleBackColor = false;
            hariIni.CheckedChanged += hariIni_CheckedChanged;
            // 
            // MingguIni
            // 
            MingguIni.AutoSize = true;
            MingguIni.BackColor = Color.Transparent;
            MingguIni.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MingguIni.Location = new Point(211, 87);
            MingguIni.Name = "MingguIni";
            MingguIni.Size = new Size(119, 27);
            MingguIni.TabIndex = 34;
            MingguIni.Text = "Minggu Ini";
            MingguIni.UseVisualStyleBackColor = false;
            MingguIni.CheckedChanged += MingguIni_CheckedChanged;
            // 
            // BulanIni
            // 
            BulanIni.AutoSize = true;
            BulanIni.BackColor = Color.Transparent;
            BulanIni.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BulanIni.Location = new Point(211, 120);
            BulanIni.Name = "BulanIni";
            BulanIni.Size = new Size(103, 27);
            BulanIni.TabIndex = 35;
            BulanIni.Text = "Bulan Ini";
            BulanIni.UseVisualStyleBackColor = false;
            BulanIni.CheckedChanged += BulanIni_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Frame_4bg_color;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(labelMingguIni);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(907, 391);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 297);
            panel2.TabIndex = 36;
            // 
            // labelMingguIni
            // 
            labelMingguIni.AutoSize = true;
            labelMingguIni.BackColor = Color.Transparent;
            labelMingguIni.Font = new Font("SF Pro Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMingguIni.ForeColor = SystemColors.ControlLightLight;
            labelMingguIni.Location = new Point(29, 132);
            labelMingguIni.Name = "labelMingguIni";
            labelMingguIni.Size = new Size(90, 38);
            labelMingguIni.TabIndex = 1;
            labelMingguIni.Text = "Rp. 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Pro Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(29, 63);
            label2.Name = "label2";
            label2.Size = new Size(265, 38);
            label2.TabIndex = 0;
            label2.Text = "Rekap Minggu Ini";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Frame_3bg_color;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(labelHariIni);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(417, 694);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 297);
            panel1.TabIndex = 29;
            // 
            // labelHariIni
            // 
            labelHariIni.AutoSize = true;
            labelHariIni.BackColor = Color.Transparent;
            labelHariIni.Font = new Font("SF Pro Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHariIni.ForeColor = SystemColors.ControlLightLight;
            labelHariIni.Location = new Point(29, 132);
            labelHariIni.Name = "labelHariIni";
            labelHariIni.Size = new Size(90, 38);
            labelHariIni.TabIndex = 1;
            labelHariIni.Text = "Rp. 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SF Pro Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(29, 63);
            label1.Name = "label1";
            label1.Size = new Size(216, 38);
            label1.TabIndex = 0;
            label1.Text = "Rekap Hari Ini";
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Frame_5bg_color;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Controls.Add(labelBulanIni);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(907, 694);
            panel4.Name = "panel4";
            panel4.Size = new Size(472, 297);
            panel4.TabIndex = 37;
            // 
            // labelBulanIni
            // 
            labelBulanIni.AutoSize = true;
            labelBulanIni.BackColor = Color.Transparent;
            labelBulanIni.Font = new Font("SF Pro Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBulanIni.ForeColor = SystemColors.ControlLightLight;
            labelBulanIni.Location = new Point(29, 132);
            labelBulanIni.Name = "labelBulanIni";
            labelBulanIni.Size = new Size(90, 38);
            labelBulanIni.TabIndex = 1;
            labelBulanIni.Text = "Rp. 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("SF Pro Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(29, 63);
            label4.Name = "label4";
            label4.Size = new Size(237, 38);
            label4.TabIndex = 0;
            label4.Text = "Rekap Bulan Ini";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(369, 50);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(286, 25);
            dateTimePicker2.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(337, 50);
            label5.Name = "label5";
            label5.Size = new Size(17, 19);
            label5.TabIndex = 39;
            label5.Text = "–";
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
            buttonKembali.TabIndex = 3;
            buttonKembali.UseVisualStyleBackColor = false;
            buttonKembali.Click += buttonKembali_Click;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.pickRekap;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(dateTimePicker1);
            panel5.Controls.Add(custom);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(hariIni);
            panel5.Controls.Add(dateTimePicker2);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(MingguIni);
            panel5.Controls.Add(BulanIni);
            panel5.Location = new Point(417, 218);
            panel5.Name = "panel5";
            panel5.Size = new Size(962, 167);
            panel5.TabIndex = 37;
            // 
            // RekapPenjualan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(buttonKembali);
            Controls.Add(lblDashboard);
            Controls.Add(leftPanel);
            Controls.Add(topPanel);
            Name = "RekapPenjualan";
            Size = new Size(2210, 1063);
            Load += RekapPenjualan_Load;
            topPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDashboard;
        private Panel leftPanel;
        private Panel logoPanel;
        private Panel topPanel;
        private Panel panel3;
        private Label label3;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private CheckBox custom;
        private CheckBox hariIni;
        private CheckBox MingguIni;
        private CheckBox BulanIni;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Panel panel4;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private Label labelPeriode;
        private Label labelMingguIni;
        private Label labelHariIni;
        private Label labelBulanIni;
        private Button buttonKembali;
        private Panel panel5;
    }
}
