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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            labelTotalHarga = new Label();
            textBoxNominal = new TextBox();
            label3 = new Label();
            buttonLanjutkan = new Button();
            label4 = new Label();
            labelKembalian = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 64);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 0;
            label1.Text = "Pembayaran Tunai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 183);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 1;
            label2.Text = "Total Harga :";
            // 
            // labelTotalHarga
            // 
            labelTotalHarga.AutoSize = true;
            labelTotalHarga.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalHarga.Location = new Point(191, 180);
            labelTotalHarga.Name = "labelTotalHarga";
            labelTotalHarga.Size = new Size(139, 29);
            labelTotalHarga.TabIndex = 2;
            labelTotalHarga.Text = "Rp. 00.000";
            // 
            // textBoxNominal
            // 
            textBoxNominal.BorderStyle = BorderStyle.FixedSingle;
            textBoxNominal.Font = new Font("SF Pro Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNominal.Location = new Point(191, 287);
            textBoxNominal.Name = "textBoxNominal";
            textBoxNominal.Size = new Size(304, 40);
            textBoxNominal.TabIndex = 3;
            textBoxNominal.TextChanged += textBoxNominal_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 294);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 4;
            label3.Text = "Nominal";
            // 
            // buttonLanjutkan
            // 
            buttonLanjutkan.BackColor = Color.SaddleBrown;
            buttonLanjutkan.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLanjutkan.ForeColor = SystemColors.ControlLightLight;
            buttonLanjutkan.Location = new Point(191, 474);
            buttonLanjutkan.Name = "buttonLanjutkan";
            buttonLanjutkan.Size = new Size(304, 62);
            buttonLanjutkan.TabIndex = 5;
            buttonLanjutkan.Text = "Lanjutkan";
            buttonLanjutkan.UseVisualStyleBackColor = false;
            buttonLanjutkan.Click += buttonLanjutkan_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 387);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 6;
            label4.Text = "Kembali";
            // 
            // labelKembalian
            // 
            labelKembalian.AutoSize = true;
            labelKembalian.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKembalian.Location = new Point(191, 387);
            labelKembalian.Name = "labelKembalian";
            labelKembalian.Size = new Size(121, 25);
            labelKembalian.TabIndex = 7;
            labelKembalian.Text = "Rp. 00.000";
            // 
            // Tunai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelKembalian);
            Controls.Add(label4);
            Controls.Add(buttonLanjutkan);
            Controls.Add(label3);
            Controls.Add(textBoxNominal);
            Controls.Add(labelTotalHarga);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tunai";
            Size = new Size(746, 900);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelTotalHarga;
        private TextBox textBoxNominal;
        private Label label3;
        private Button buttonLanjutkan;
        private Label label4;
        private Label labelKembalian;
    }
}
