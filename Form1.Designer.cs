namespace CoffeSharp
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            BtnDashboard = new Button();
            Dashboard_text = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1506, 126);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 126);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(297, 689);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnDashboard);
            panel2.Location = new Point(10, 3);
            panel2.Margin = new Padding(10, 3, 3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 103);
            panel2.TabIndex = 3;
            // 
            // BtnDashboard
            // 
            BtnDashboard.AutoSize = true;
            BtnDashboard.BackColor = Color.FromArgb(255, 128, 0);
            BtnDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDashboard.Cursor = Cursors.Hand;
            BtnDashboard.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDashboard.Image = Properties.Resources.akar_icons_dashboard1;
            BtnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDashboard.Location = new Point(13, 19);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Padding = new Padding(20, 0, 0, 0);
            BtnDashboard.Size = new Size(230, 66);
            BtnDashboard.TabIndex = 0;
            BtnDashboard.Text = "        Dashboard";
            BtnDashboard.UseVisualStyleBackColor = false;
            BtnDashboard.Click += BtnDashboard_Click;
            // 
            // Dashboard_text
            // 
            Dashboard_text.AutoSize = true;
            Dashboard_text.Font = new Font("SF Pro Display", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard_text.Location = new Point(408, 144);
            Dashboard_text.Name = "Dashboard_text";
            Dashboard_text.Size = new Size(239, 51);
            Dashboard_text.TabIndex = 2;
            Dashboard_text.Text = "Dashboard";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1506, 815);
            Controls.Add(Dashboard_text);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label Dashboard_text;
        private Button BtnDashboard;
        private Panel panel2;
    }
}
