namespace COFFE_SHARP
{
    partial class EditProduk
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
            panel1 = new Panel();
            namaProduk = new TextBox();
            BtnUpload = new Button();
            gambarProduk = new PictureBox();
            panel2 = new Panel();
            hargaProduk = new TextBox();
            labelNama = new Label();
            BtnSimpan = new Button();
            label1 = new Label();
            label2 = new Label();
            kategoriProduk = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gambarProduk).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.textBox_bg1;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(namaProduk);
            panel1.Location = new Point(337, 311);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 59);
            panel1.TabIndex = 13;
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
            // BtnUpload
            // 
            BtnUpload.BackColor = Color.DarkOrange;
            BtnUpload.FlatStyle = FlatStyle.Popup;
            BtnUpload.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUpload.ForeColor = SystemColors.ControlLightLight;
            BtnUpload.Location = new Point(522, 234);
            BtnUpload.Name = "BtnUpload";
            BtnUpload.Size = new Size(150, 34);
            BtnUpload.TabIndex = 12;
            BtnUpload.Text = "Upload Gambar";
            BtnUpload.UseVisualStyleBackColor = false;
            BtnUpload.Click += BtnUpload_Click;
            // 
            // gambarProduk
            // 
            gambarProduk.BackColor = Color.Transparent;
            gambarProduk.BackgroundImage = Properties.Resources.iconImg;
            gambarProduk.BackgroundImageLayout = ImageLayout.Center;
            gambarProduk.BorderStyle = BorderStyle.FixedSingle;
            gambarProduk.Location = new Point(522, 68);
            gambarProduk.Name = "gambarProduk";
            gambarProduk.Size = new Size(150, 150);
            gambarProduk.SizeMode = PictureBoxSizeMode.Zoom;
            gambarProduk.TabIndex = 11;
            gambarProduk.TabStop = false;
            gambarProduk.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.textBox_bg1;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(hargaProduk);
            panel2.Location = new Point(337, 415);
            panel2.Name = "panel2";
            panel2.Size = new Size(511, 53);
            panel2.TabIndex = 15;
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
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNama.Location = new Point(345, 287);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(108, 19);
            labelNama.TabIndex = 14;
            labelNama.Text = "Nama Produk";
            // 
            // BtnSimpan
            // 
            BtnSimpan.BackColor = Color.DarkOrange;
            BtnSimpan.FlatStyle = FlatStyle.Popup;
            BtnSimpan.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSimpan.ForeColor = SystemColors.ControlLightLight;
            BtnSimpan.Location = new Point(535, 579);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(131, 36);
            BtnSimpan.TabIndex = 19;
            BtnSimpan.Text = "Selesai";
            BtnSimpan.UseVisualStyleBackColor = false;
            BtnSimpan.Click += BtnSimpan_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 393);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 16;
            label1.Text = "Harga Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(345, 489);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 20;
            label2.Text = "Kategori";
            // 
            // kategoriProduk
            // 
            kategoriProduk.DropDownStyle = ComboBoxStyle.DropDownList;
            kategoriProduk.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kategoriProduk.FormattingEnabled = true;
            kategoriProduk.Location = new Point(345, 519);
            kategoriProduk.Name = "kategoriProduk";
            kategoriProduk.Size = new Size(503, 27);
            kategoriProduk.TabIndex = 21;
            // 
            // EditProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 691);
            Controls.Add(kategoriProduk);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(BtnUpload);
            Controls.Add(gambarProduk);
            Controls.Add(panel2);
            Controls.Add(labelNama);
            Controls.Add(BtnSimpan);
            Controls.Add(label1);
            Name = "EditProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProduk";
            Load += EditProduk_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gambarProduk).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox namaProduk;
        private Button BtnUpload;
        private PictureBox gambarProduk;
        private Panel panel2;
        private TextBox hargaProduk;
        private Label labelNama;
        private Button BtnSimpan;
        private Label label1;
        private Label label2;
        private ComboBox kategoriProduk;
    }
}