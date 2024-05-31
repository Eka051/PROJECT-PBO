namespace COFFE_SHARP
{
    partial class TambahProduk
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahProduk));
            gambarProduk = new PictureBox();
            BtnUpload = new Button();
            panel1 = new Panel();
            namaProduk = new TextBox();
            labelNama = new Label();
            panel2 = new Panel();
            hargaProduk = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnSimpan = new Button();
            kategoriProduk = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gambarProduk).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // gambarProduk
            // 
            gambarProduk.BackColor = Color.Transparent;
            gambarProduk.BackgroundImage = Properties.Resources.iconImg;
            gambarProduk.BackgroundImageLayout = ImageLayout.Center;
            gambarProduk.BorderStyle = BorderStyle.FixedSingle;
            gambarProduk.Location = new Point(508, 12);
            gambarProduk.Name = "gambarProduk";
            gambarProduk.Size = new Size(150, 150);
            gambarProduk.SizeMode = PictureBoxSizeMode.Zoom;
            gambarProduk.TabIndex = 0;
            gambarProduk.TabStop = false;
            gambarProduk.UseWaitCursor = true;
            // 
            // BtnUpload
            // 
            BtnUpload.BackColor = Color.DarkOrange;
            BtnUpload.FlatStyle = FlatStyle.Popup;
            BtnUpload.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUpload.ForeColor = SystemColors.ControlLightLight;
            BtnUpload.Location = new Point(508, 178);
            BtnUpload.Name = "BtnUpload";
            BtnUpload.Size = new Size(150, 34);
            BtnUpload.TabIndex = 1;
            BtnUpload.Text = "Upload Gambar";
            BtnUpload.UseVisualStyleBackColor = false;
            BtnUpload.Click += BtnUpload_Click_1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.textBox_bg1;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(namaProduk);
            panel1.Location = new Point(323, 255);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 59);
            panel1.TabIndex = 2;
            // 
            // namaProduk
            // 
            namaProduk.BackColor = Color.LightGray;
            namaProduk.BorderStyle = BorderStyle.None;
            namaProduk.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namaProduk.Location = new Point(38, 17);
            namaProduk.Name = "namaProduk";
            namaProduk.Size = new Size(438, 23);
            namaProduk.TabIndex = 3;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNama.Location = new Point(331, 231);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(108, 19);
            labelNama.TabIndex = 4;
            labelNama.Text = "Nama Produk";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.textBox_bg1;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(hargaProduk);
            panel2.Location = new Point(323, 359);
            panel2.Name = "panel2";
            panel2.Size = new Size(511, 53);
            panel2.TabIndex = 5;
            // 
            // hargaProduk
            // 
            hargaProduk.BackColor = Color.LightGray;
            hargaProduk.BorderStyle = BorderStyle.None;
            hargaProduk.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hargaProduk.Location = new Point(38, 18);
            hargaProduk.Name = "hargaProduk";
            hargaProduk.Size = new Size(438, 23);
            hargaProduk.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 337);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 7;
            label1.Text = "Harga Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(331, 432);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 8;
            label2.Text = "Kategori";
            // 
            // BtnSimpan
            // 
            BtnSimpan.BackColor = Color.DarkOrange;
            BtnSimpan.FlatStyle = FlatStyle.Popup;
            BtnSimpan.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSimpan.ForeColor = SystemColors.ControlLightLight;
            BtnSimpan.Location = new Point(521, 530);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(131, 36);
            BtnSimpan.TabIndex = 10;
            BtnSimpan.Text = "Selesai";
            BtnSimpan.UseVisualStyleBackColor = false;
            BtnSimpan.Click += BtnSimpan_Click_1;
            // 
            // kategoriProduk
            // 
            kategoriProduk.BackColor = SystemColors.ScrollBar;
            kategoriProduk.DropDownStyle = ComboBoxStyle.DropDownList;
            kategoriProduk.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kategoriProduk.FormattingEnabled = true;
            kategoriProduk.Location = new Point(331, 466);
            kategoriProduk.Name = "kategoriProduk";
            kategoriProduk.Size = new Size(503, 27);
            kategoriProduk.TabIndex = 12;
            // 
            // TambahProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 691);
            Controls.Add(kategoriProduk);
            Controls.Add(BtnSimpan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(labelNama);
            Controls.Add(panel1);
            Controls.Add(BtnUpload);
            Controls.Add(gambarProduk);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TambahProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tambah Produk";
            Load += TambahProduk_Load;
            ((System.ComponentModel.ISupportInitialize)gambarProduk).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox gambarProduk;
        private Button BtnUpload;
        private Panel panel1;
        private TextBox namaProduk;
        private Label labelNama;
        private Panel panel2;
        private TextBox hargaProduk;
        private Label label1;
        private Label label2;
        private Button BtnSimpan;
        private ComboBox kategoriProduk;
    }
}