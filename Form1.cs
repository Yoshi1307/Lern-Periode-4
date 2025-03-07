namespace Cookie_Clicker
{
    public partial class Form1 : Form
    {
        public int cookieCount = 0;
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

    }
}