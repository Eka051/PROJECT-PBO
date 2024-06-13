using COFFE_SHARP.Models;
using COFFE_SHARP.View;
using System.Windows.Forms;

namespace COFFE_SHARP
{
    public partial class MainForm : Form
    {
        private ProdukContext produkContext;
        private LoginAdminContext loginAdminContext;
        private UCSplashScreen splashScreen;
        private UserControlLogin login;
        private UserControlRegister register;
        public UserControlDashboard dashboard;
        private UCPengelolaanStok pengelolaanStok;
        private UCPengelolaanProduk pengelolaanProduk;
        private UCTransaksi transaksi;
        private RekapPenjualan rekapPenjualan;
        private RiwayatTransaksi riwayatTransaksi;
        private TransaksiContext transaksiContext = new TransaksiContext();
        private System.Windows.Forms.Timer timer;
        public MainForm()
        {
            InitializeComponent();
            produkContext = new ProdukContext();
            loginAdminContext = new LoginAdminContext();
            splashScreen = new UCSplashScreen();
            login = new UserControlLogin(this, loginAdminContext);
            rekapPenjualan = new RekapPenjualan(this);
            register = new UserControlRegister(this);
            dashboard = new UserControlDashboard(this, produkContext, loginAdminContext);
            pengelolaanStok = new UCPengelolaanStok(this, produkContext);
            pengelolaanProduk = new UCPengelolaanProduk(this, produkContext);
            transaksi = new UCTransaksi(this, produkContext);
            riwayatTransaksi = new RiwayatTransaksi(this, transaksiContext, loginAdminContext);

            this.Controls.Add(splashScreen);
            this.Controls.Add(login);
            this.Controls.Add(register);
            this.Controls.Add(dashboard);
            this.Controls.Add(pengelolaanStok);
            this.Controls.Add(pengelolaanProduk);
            this.Controls.Add(transaksi);
            this.Controls.Add(rekapPenjualan);
            this.Controls.Add(riwayatTransaksi);

            HideAllUserControl();
            ShowSplashScreen();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            ShowLogin();
        }

        public void HideAllUserControl()
        {
            foreach (UserControl userControl in this.Controls)
            {
                userControl.Visible = false;
            }
        }

        public void ShowSplashScreen()
        {
            HideAllUserControl();
            splashScreen.Visible = true;
        }

        public void ShowLogin()
        {
            HideAllUserControl();
            login.Visible = true;
        }


        public void ShowRegister()
        {
            HideAllUserControl();
            register.Visible = true;
        }

        public void ShowDashboard()
        {
            HideAllUserControl();
            dashboard.Visible = true;
        }

        public void ShowRekapPenjualan()
        {
            HideAllUserControl();
            rekapPenjualan.Visible = true;
        }

        public void ShowKelolaStok()
        {
            HideAllUserControl();
            pengelolaanStok.Visible = true;
        }

        public void ShowKelolaProduk()
        {
            HideAllUserControl();
            pengelolaanProduk.Visible = true;
        }

        public void ShowTransaksi()
        {
            HideAllUserControl();
            transaksi.Visible = true;
        }

        public void ShowRiwayatTransaksi()
        {
            HideAllUserControl();
            riwayatTransaksi.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
