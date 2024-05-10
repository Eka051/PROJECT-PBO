using Microsoft.VisualBasic.Logging;

namespace COFFE_SHARP
{
    public partial class MainForm : Form
    {
        UCSplashScreen splashScreen;
        UserControlLogin login;
        UserControlDashboard dashboard;
        UCPengelolaanStok pengelolaanStok;
        UCPengelolaanProduk pengelolaanProduk;
        UCTransaksi transaksi;
        System.Windows.Forms.Timer timer;
        public MainForm()
        {
            InitializeComponent();
            splashScreen = new UCSplashScreen();
            login = new UserControlLogin(this);
            dashboard = new UserControlDashboard(this);
            pengelolaanStok = new UCPengelolaanStok(this);
            pengelolaanProduk = new UCPengelolaanProduk(this);
            transaksi = new UCTransaksi(this);

            this.Controls.Add(splashScreen);
            this.Controls.Add(login);
            this.Controls.Add(dashboard);
            this.Controls.Add(pengelolaanStok);
            this.Controls.Add(pengelolaanProduk);
            this.Controls.Add(transaksi);

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

        public void ShowDashboard()
        {
            HideAllUserControl();
            dashboard.Visible = true;
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
    }
}
