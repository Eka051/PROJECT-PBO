namespace COFFE_SHARP.View
{
    partial class Struk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Struk));
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            buttonPrint = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            labelTanggal = new Label();
            labelAdmin = new Label();
            labelLineHeader = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            labelTotalHrg = new Label();
            label6 = new Label();
            panelStruk = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelStruk.SuspendLayout();
            SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // buttonPrint
            // 
            buttonPrint.BackgroundImage = Properties.Resources.iconPrint1;
            buttonPrint.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPrint.Location = new Point(629, 12);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(73, 75);
            buttonPrint.TabIndex = 2;
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(274, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 134);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 162);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 1;
            label1.Text = "Date         :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 188);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 2;
            label2.Text = "Cashier   :";
            // 
            // labelTanggal
            // 
            labelTanggal.AutoSize = true;
            labelTanggal.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTanggal.Location = new Point(101, 162);
            labelTanggal.Name = "labelTanggal";
            labelTanggal.Size = new Size(107, 19);
            labelTanggal.TabIndex = 3;
            labelTanggal.Text = "DD/MM/YYYY";
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAdmin.Location = new Point(102, 188);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(136, 19);
            labelAdmin.TabIndex = 4;
            labelAdmin.Text = "Admin Coffe Sharp";
            // 
            // labelLineHeader
            // 
            labelLineHeader.AutoSize = true;
            labelLineHeader.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLineHeader.Location = new Point(23, 216);
            labelLineHeader.Name = "labelLineHeader";
            labelLineHeader.Size = new Size(679, 19);
            labelLineHeader.TabIndex = 5;
            labelLineHeader.Text = "===================================================================";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 258);
            label3.Name = "label3";
            label3.Size = new Size(679, 19);
            label3.TabIndex = 6;
            label3.Text = "===================================================================";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(260, 235);
            label4.Name = "label4";
            label4.Size = new Size(188, 23);
            label4.TabIndex = 7;
            label4.Text = "DAFTAR TRANSAKSI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 560);
            label5.Name = "label5";
            label5.Size = new Size(679, 19);
            label5.TabIndex = 8;
            label5.Text = "===================================================================";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(251, 706);
            label7.Name = "label7";
            label7.Size = new Size(239, 46);
            label7.TabIndex = 11;
            label7.Text = "Terima Kasih Telah Belanja\r\ndi Coffe Sharp!";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(98, 277);
            label8.Name = "label8";
            label8.Size = new Size(42, 19);
            label8.TabIndex = 12;
            label8.Text = "Item";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(292, 277);
            label9.Name = "label9";
            label9.Size = new Size(54, 19);
            label9.TabIndex = 13;
            label9.Text = "Harga";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(454, 277);
            label10.Name = "label10";
            label10.Size = new Size(36, 19);
            label10.TabIndex = 14;
            label10.Text = "Qty";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(585, 277);
            label11.Name = "label11";
            label11.Size = new Size(45, 19);
            label11.TabIndex = 15;
            label11.Text = "Total";
            // 
            // labelTotalHrg
            // 
            labelTotalHrg.AutoSize = true;
            labelTotalHrg.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalHrg.Location = new Point(554, 581);
            labelTotalHrg.Name = "labelTotalHrg";
            labelTotalHrg.Size = new Size(106, 23);
            labelTotalHrg.TabIndex = 17;
            labelTotalHrg.Text = "Rp. 00.000\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(387, 581);
            label6.Name = "label6";
            label6.Size = new Size(108, 23);
            label6.TabIndex = 18;
            label6.Text = "Total Harga";
            // 
            // panelStruk
            // 
            panelStruk.BackColor = SystemColors.ControlLightLight;
            panelStruk.Controls.Add(label6);
            panelStruk.Controls.Add(labelTotalHrg);
            panelStruk.Controls.Add(label11);
            panelStruk.Controls.Add(label10);
            panelStruk.Controls.Add(label9);
            panelStruk.Controls.Add(label8);
            panelStruk.Controls.Add(label7);
            panelStruk.Controls.Add(label5);
            panelStruk.Controls.Add(label4);
            panelStruk.Controls.Add(label3);
            panelStruk.Controls.Add(labelLineHeader);
            panelStruk.Controls.Add(labelAdmin);
            panelStruk.Controls.Add(labelTanggal);
            panelStruk.Controls.Add(label2);
            panelStruk.Controls.Add(label1);
            panelStruk.Controls.Add(pictureBox1);
            panelStruk.Location = new Point(0, 91);
            panelStruk.Name = "panelStruk";
            panelStruk.Size = new Size(733, 770);
            panelStruk.TabIndex = 1;
            // 
            // Struk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 861);
            Controls.Add(buttonPrint);
            Controls.Add(panelStruk);
            Name = "Struk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Struk";
            Load += Struk_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelStruk.ResumeLayout(false);
            panelStruk.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button buttonPrint;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label labelTanggal;
        private Label labelAdmin;
        private Label labelLineHeader;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label labelTotalHrg;
        private Label label6;
        private Panel panelStruk;
    }
}