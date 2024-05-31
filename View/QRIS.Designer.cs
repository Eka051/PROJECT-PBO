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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictQRIS = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictQRIS).BeginInit();
            SuspendLayout();
            // 
            // pictQRIS
            // 
            pictQRIS.Location = new Point(216, 121);
            pictQRIS.Name = "pictQRIS";
            pictQRIS.Size = new Size(450, 450);
            pictQRIS.TabIndex = 0;
            pictQRIS.TabStop = false;
            // 
            // QRIS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictQRIS);
            Name = "QRIS";
            Size = new Size(900, 770);
            ((System.ComponentModel.ISupportInitialize)pictQRIS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictQRIS;
    }
}
