namespace COFFE_SHARP.View
{
    partial class Pembayaran
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
            btnTunai = new Button();
            btnQRIS = new Button();
            SuspendLayout();
            // 
            // btnTunai
            // 
            btnTunai.BackColor = Color.SandyBrown;
            btnTunai.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTunai.Image = Properties.Resources.tunai;
            btnTunai.ImageAlign = ContentAlignment.MiddleLeft;
            btnTunai.Location = new Point(140, 245);
            btnTunai.Name = "btnTunai";
            btnTunai.Size = new Size(430, 131);
            btnTunai.TabIndex = 0;
            btnTunai.Text = "TUNAI";
            btnTunai.UseVisualStyleBackColor = false;
            btnTunai.Click += btnTunai_Click;
            // 
            // btnQRIS
            // 
            btnQRIS.BackColor = Color.SandyBrown;
            btnQRIS.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQRIS.Image = Properties.Resources.qris;
            btnQRIS.ImageAlign = ContentAlignment.MiddleLeft;
            btnQRIS.Location = new Point(140, 413);
            btnQRIS.Name = "btnQRIS";
            btnQRIS.Size = new Size(430, 131);
            btnQRIS.TabIndex = 1;
            btnQRIS.Text = "QRIS";
            btnQRIS.UseVisualStyleBackColor = false;
            btnQRIS.Click += btnQRIS_Click;
            // 
            // Pembayaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 861);
            Controls.Add(btnQRIS);
            Controls.Add(btnTunai);
            Name = "Pembayaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pembayaran";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTunai;
        private Button btnQRIS;
    }
}