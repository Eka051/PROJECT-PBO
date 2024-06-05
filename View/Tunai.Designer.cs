namespace COFFE_SHARP.View
{
    partial class Tunai
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
            labelKembalian = new Label();
            label4 = new Label();
            buttonLanjutkan = new Button();
            label3 = new Label();
            textBoxNominal = new TextBox();
            labelTotalHarga = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // labelKembalian
            // 
            labelKembalian.AutoSize = true;
            labelKembalian.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKembalian.Location = new Point(209, 443);
            labelKembalian.Name = "labelKembalian";
            labelKembalian.Size = new Size(121, 25);
            labelKembalian.TabIndex = 16;
            labelKembalian.Text = "Rp. 00.000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 443);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 15;
            label4.Text = "Kembali       :";
            // 
            // buttonLanjutkan
            // 
            buttonLanjutkan.BackColor = Color.SaddleBrown;
            buttonLanjutkan.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLanjutkan.ForeColor = SystemColors.ControlLightLight;
            buttonLanjutkan.Location = new Point(217, 530);
            buttonLanjutkan.Name = "buttonLanjutkan";
            buttonLanjutkan.Size = new Size(304, 62);
            buttonLanjutkan.TabIndex = 14;
            buttonLanjutkan.Text = "Lanjutkan";
            buttonLanjutkan.UseVisualStyleBackColor = false;
            buttonLanjutkan.Click += buttonLanjutkan_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 350);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 13;
            label3.Text = "Nominal       :";
            // 
            // textBoxNominal
            // 
            textBoxNominal.BorderStyle = BorderStyle.FixedSingle;
            textBoxNominal.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNominal.Location = new Point(250, 344);
            textBoxNominal.Name = "textBoxNominal";
            textBoxNominal.Size = new Size(268, 36);
            textBoxNominal.TabIndex = 12;
            textBoxNominal.TextChanged += textBoxNominal_TextChanged_1;
            // 
            // labelTotalHarga
            // 
            labelTotalHarga.AutoSize = true;
            labelTotalHarga.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalHarga.Location = new Point(204, 266);
            labelTotalHarga.Name = "labelTotalHarga";
            labelTotalHarga.Size = new Size(139, 29);
            labelTotalHarga.TabIndex = 11;
            labelTotalHarga.Text = "Rp. 00.000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 269);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 10;
            label2.Text = "Total Harga :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 98);
            label1.Name = "label1";
            label1.Size = new Size(311, 42);
            label1.TabIndex = 9;
            label1.Text = "Pembayaran Tunai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(203, 349);
            label5.Name = "label5";
            label5.Size = new Size(53, 29);
            label5.TabIndex = 17;
            label5.Text = "Rp. ";
            // 
            // Tunai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 861);
            Controls.Add(labelKembalian);
            Controls.Add(label4);
            Controls.Add(buttonLanjutkan);
            Controls.Add(label3);
            Controls.Add(textBoxNominal);
            Controls.Add(labelTotalHarga);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "Tunai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tunai";
            Load += Tunai_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelKembalian;
        private Label label4;
        private Button buttonLanjutkan;
        private Label label3;
        private TextBox textBoxNominal;
        private Label labelTotalHarga;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}