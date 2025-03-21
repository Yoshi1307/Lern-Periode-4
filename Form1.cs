namespace Cookie_Clicker
{
    public partial class Form1 : Form
    {
        public int cookieCount = 0;
        public int Countdown = 60;
        private System.Windows.Forms.Timer CountdownTimer;
        private Shop ShopForm;


        public Form1()
        {
            InitializeComponent();

        }

        public void UpdateCookieCount()
        {
            cookies_count.Text = $"Cookies: {cookieCount}";
        }
        private void button_cookie_Click(object sender, EventArgs e)
        {
            if (ShopForm == null || ShopForm.IsDisposed)
            {
                ShopForm = new Shop(this);
            }

            ShopForm.Show();
            ShopForm.UpdateShopCookieCount();

            int cookiesToAdd = ShopForm.CursorEarnings;


            cookieCount += ShopForm.CursorEarnings;

            cookies_count.Text = $"Cookies: {cookieCount}";
            ShopForm.UpdateShopCookieCount();
        }

        private void button_shop_Click(object sender, EventArgs e)
        {
            Shop shopForm = new Shop(this);
            shopForm.Show();
            ShopForm.UpdateShopCookieCount();
        }

        private void cookies_count_Click(object sender, EventArgs e)
        {

        }

        private void StartDoubleTimer()
        {
            if (ShopForm.Level_Double > 1)  
            {
                if (CountdownTimer == null)
                {
                    CountdownTimer = new System.Windows.Forms.Timer() {Interval = 1000};
                    CountdownTimer.Tick += UpdateCountdown;
                }

                Countdown = 60; 
                CountdownTimer.Start();
            }
        }
        private void UpdateCountdown(object sender, EventArgs e)
        {
            if (Countdown > 0)
            {
                Countdown--;
                Double_Countdown.Text = $"2x Boost: {Countdown}Sec";
            }
            else
            {
                CountdownTimer.Stop();
            }
        }

        private void Double_Countdown_Click(object sender, EventArgs e)
        {

        }
    }

} 