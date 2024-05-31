namespace COFFE_SHARP.View
{
    partial class MetodePembayaran
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
            btnTunai.BackColor = Color.Wheat;
            btnTunai.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTunai.Image = Properties.Resources.tunai;
            btnTunai.ImageAlign = ContentAlignment.MiddleLeft;
            btnTunai.Location = new Point(241, 158);
            btnTunai.Name = "btnTunai";
            btnTunai.Size = new Size(361, 118);
            btnTunai.TabIndex = 0;
            btnTunai.Text = "Tunai";
            btnTunai.UseVisualStyleBackColor = false;
            // 
            // btnQRIS
            // 
            btnQRIS.BackColor = Color.Wheat;
            btnQRIS.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQRIS.Image = Properties.Resources.qris;
            btnQRIS.ImageAlign = ContentAlignment.MiddleLeft;
            btnQRIS.Location = new Point(241, 316);
            btnQRIS.Name = "btnQRIS";
            btnQRIS.Size = new Size(361, 118);
            btnQRIS.TabIndex = 1;
            btnQRIS.Text = "QRIS";
            btnQRIS.UseVisualStyleBackColor = false;
            btnQRIS.Click += btnBayar_Click;
            // 
            // MetodePembayaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 731);
            Controls.Add(btnQRIS);
            Controls.Add(btnTunai);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MetodePembayaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MetodePembayaran";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTunai;
        private Button btnQRIS;
    }
}