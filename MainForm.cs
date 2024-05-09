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
        System.Windows.Forms.Timer timer;
        public MainForm()
        {
            InitializeComponent();
            splashScreen = new UCSplashScreen();
            login = new UserControlLogin(this);
            dashboard = new UserControlDashboard(this);
            pengelolaanStok = new UCPengelolaanStok(this);
            pengelolaanProduk = new UCPengelolaanProduk(this);

            splashScreen = new UCSplashScreen(); //Tampilan splashscreen awal dibuka selama 3 detik

            this.Controls.Add(splashScreen);
            this.Controls.Add(login);
            this.Controls.Add(dashboard);
            this.Controls.Add(pengelolaanStok);
            this.Controls.Add(pengelolaanProduk);


            login.Visible = false;
            dashboard.Visible = false;
            splashScreen.Visible = true;
            pengelolaanStok.Visible = false;
            pengelolaanProduk.Visible = false;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public void HideAllUserControl()
        {
            
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            ShowLogin();
        }

        public void ShowSplashScreen()
        {
            splashScreen.Visible = true;
            login.Visible = false;
            dashboard.Visible = false;
            pengelolaanStok.Visible=false;
            pengelolaanProduk.Visible=false;
        }

        public void ShowLogin()
        {
            splashScreen.Visible = false;
            login.Visible = true;
            dashboard.Visible = false;
            pengelolaanStok.Visible = false;
            pengelolaanProduk.Visible = false;
        }

        public void ShowDashboard()
        {
            splashScreen.Visible = false;
            login.Visible = false;
            dashboard.Visible = true;
            pengelolaanStok.Visible = false;
            pengelolaanProduk.Visible = false;
        }

        public void ShowKelolaStok()
        {
            splashScreen.Visible = false;
            login.Visible = false;
            dashboard.Visible = false;
            pengelolaanStok.Visible = true;
            pengelolaanProduk.Visible = false;
        }

        public void ShowKelolaProduk()
        {
            splashScreen.Visible = false;
            login.Visible = false;
            dashboard.Visible = false;
            pengelolaanStok.Visible = false;
            pengelolaanProduk.Visible = true;
        }
    }
}
