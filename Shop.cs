using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie_Clicker
{
    public partial class Shop : Form
    {

        private Form1 mainForm;
        private System.Windows.Forms.Timer timer;



        public Shop()
        {
            InitializeComponent();
        }
        public Shop(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            timer = new System.Windows.Forms.Timer { Interval = 2000 };
            timer.Tick += TimerElapsed;

            UpdateShopCookieCount(); 
        }

        public void UpdateShopCookieCount()
        {
            cookies_count.Text = $"Cookies: {mainForm.cookieCount}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void UpdateCookieCount()
        {
            cookies_count.Text = $"Cookies: {mainForm.cookieCount}";
        }
        private void Autoclicker_Click(object sender, EventArgs e)
        {
            string[] parts = Preis_Autoklicker.Text.Split(' ');
            int currentPrice = 0;
            int.TryParse(parts[0], out currentPrice);


            if (mainForm.cookieCount >= currentPrice) 
            {
                mainForm.cookieCount -= currentPrice;
                currentPrice *= 2;
                Preis_Autoklicker.Text = currentPrice.ToString() + " 🍪";
                
                UpdateShopCookieCount();

                mainForm.UpdateCookieCount();
                if (!timer.Enabled)
                {

                    timer.Start();
                }
            }
        }
        private void TimerElapsed(object sender, EventArgs e)
        {
            mainForm.cookieCount++;
            mainForm.UpdateCookieCount();

            UpdateShopCookieCount();
        }

        private void Cursor_Upgrade_Click(object sender, EventArgs e)
        {

        }

        private void Shop_Sign_Click(object sender, EventArgs e)
        {

        }

        private void cookies_count_Click(object sender, EventArgs e)
        {
            cookies_count.Text = $"Cookies: {mainForm.cookieCount}";
        }
    }
}
