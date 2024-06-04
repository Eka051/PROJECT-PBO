namespace COFFE_SHARP.View
{
    partial class QRIS
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
            pictQRIS = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictQRIS).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.qris1;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(pictQRIS);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 857);
            panel1.TabIndex = 0;
            // 
            // pictQRIS
            // 
            pictQRIS.BackgroundImageLayout = ImageLayout.Zoom;
            pictQRIS.Location = new Point(144, 257);
            pictQRIS.Name = "pictQRIS";
            pictQRIS.Size = new Size(457, 459);
            pictQRIS.SizeMode = PictureBoxSizeMode.Zoom;
            pictQRIS.TabIndex = 0;
            pictQRIS.TabStop = false;
            // 
            // QRIS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(732, 861);
            Controls.Add(panel1);
            Name = "QRIS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QRIS";
            Load += QRIS_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictQRIS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictQRIS;
    }
}