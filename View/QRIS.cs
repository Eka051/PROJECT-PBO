using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace COFFE_SHARP.View
{
    public partial class QRIS : UserControl
    {
        public QRIS()
        {
            InitializeComponent();
        }

        public void GenerateQRCode(string paymentUrl)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(paymentUrl, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);
                    pictQRIS.Image = qrCodeImage;
                }
            }
        }
    }
}
