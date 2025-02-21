namespace Cookie_Clicker
{
    public partial class Form1 : Form
    {
         public int cookieCount = 0;

        
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
            cookieCount++;
            cookies_count.Text = $"Cookies: {cookieCount}";
        }

        private void button_shop_Click(object sender, EventArgs e)
        {
            Shop shopForm = new Shop(this);
            shopForm.Show();
        }

        private void cookies_count_Click(object sender, EventArgs e)
        {
            
        }

    }
}