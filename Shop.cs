using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
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
        public System.Windows.Forms.Timer DoubleTimer;

        public int AutoclickerEarnings = 1;
        public int CursorEarnings = 1;
        int Level_autoclicker = 1;
        int Level_cursor = 1;
        public int Level_Double = 1;



        public Shop()
        {
            InitializeComponent();
        }
        public Shop(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            timer = new System.Windows.Forms.Timer { Interval = 2000 };
            timer.Tick += UpdateAutoclicker;

            DoubleTimer = new System.Windows.Forms.Timer { Interval = 60000 };
            DoubleTimer.Tick += DoubleEarningsStop;


            UpdateShopCookieCount();
        }

        public void UpdateShopCookieCount()
        {
            cookie_count_shop.Text = $"Cookies: {mainForm.cookieCount}";
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void UpdateCookieCount()
        {
            cookie_count_shop.Text = $"Cookies: {mainForm.cookieCount}";
        }
        private void Autoclicker_Click(object sender, EventArgs e)
        {
            string[] parts = Preis_Autoklicker.Text.Split(' ');
            int currentPrice = 0;
            int.TryParse(parts[0], out currentPrice);


            if (mainForm.cookieCount >= currentPrice)
            {
                mainForm.cookieCount -= currentPrice;
                if (currentPrice > 3199)
                {
                    currentPrice *= 3;
                }
                if (currentPrice < 3199)
                {
                    currentPrice *= 2;
                }
                Preis_Autoklicker.Text = currentPrice.ToString() + " 🍪";

                UpdateShopCookieCount();

                mainForm.UpdateCookieCount();
                if (!timer.Enabled)
                {

                    timer.Start();
                }

                AutoclickerEarnings *= 2;
                Level_autoclicker++;
                Level_Autoclicker.Text = $"Level {Level_autoclicker}";
            }


        }
        private void UpdateAutoclicker(object sender, EventArgs e)
        {
            mainForm.cookieCount += AutoclickerEarnings;
            mainForm.UpdateCookieCount();

            UpdateShopCookieCount();
        }

        private void Cursor_Upgrade_Click(object sender, EventArgs e)
        {
            string[] parts = Preis_Cursor.Text.Split(' ');
            int currentPrice = 0;
            int.TryParse(parts[0], out currentPrice);

            if (mainForm.cookieCount >= currentPrice)
            {
                mainForm.cookieCount -= currentPrice;
                if (currentPrice > 3199)
                {
                    currentPrice *= 3;
                }
                if (currentPrice < 3199)
                {
                    currentPrice *= 2;
                }
                Preis_Cursor.Text = currentPrice.ToString() + " 🍪";

                UpdateShopCookieCount();
                mainForm.UpdateCookieCount();


                CursorEarnings *= 2;
                Level_cursor++;
                Level_Cursor.Text = $"Level {Level_cursor}";
            }
        }

        private void Shop_Sign_Click(object sender, EventArgs e)
        {

        }

        public void cookie_count_shop_Click(object sender, EventArgs e)
        {

        }

        private void Level_Autoclicker_Click(object sender, EventArgs e)
        {

        }

        private void Level_Cursor_Click(object sender, EventArgs e)
        {

        }

        public void Upgrade_2x_Click(object sender, EventArgs e)
        {
            string[] parts = Preis_2x.Text.Split(' ');
            int currentPrice = 0;
            int.TryParse(parts[0], out currentPrice);

            if (mainForm.cookieCount >= currentPrice)
            {
                mainForm.cookieCount -= currentPrice;
                if (currentPrice > 4000)
                {
                    currentPrice *= 2;
                }
                if (currentPrice < 4001)
                {
                    currentPrice += 1000;
                }
                Preis_2x.Text = currentPrice.ToString() + " 🍪";

                UpdateShopCookieCount();
                mainForm.UpdateCookieCount();

                Level_Double++;
                Level_2x.Text = $"Level {Level_Double}";

                StartDoubleTimer();
            }


        }
        private void StartDoubleTimer()
        {
            // Verdoppeln nur aktivieren, wenn es nicht bereits aktiv ist
            if (!DoubleTimer.Enabled)
            {
                AutoclickerEarnings *= 2;
                CursorEarnings *= 2;

                DoubleTimer.Start();
            }
        }
        private void DoubleEarningsStop(object sender, EventArgs e)
        {
            AutoclickerEarnings /= 2;
            CursorEarnings /= 2;

            DoubleTimer.Stop();

        }

        private void Level_2x_Click(object sender, EventArgs e)
        {

        }

        private void Preis_2x_Click(object sender, EventArgs e)
        {

        }
    }
}
