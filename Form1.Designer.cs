﻿namespace Cookie_Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button_cookie = new Button();
            button_shop = new Button();
            cookies_count = new Label();
            SuspendLayout();
            // 
            // button_cookie
            // 
            button_cookie.Location = new Point(396, 136);
            button_cookie.Name = "button_cookie";
            button_cookie.Size = new Size(211, 202);
            button_cookie.TabIndex = 0;
            button_cookie.Text = "Cookie";
            button_cookie.UseVisualStyleBackColor = true;
            button_cookie.Click += button_cookie_Click;
            // 
            // button_shop
            // 
            button_shop.Location = new Point(113, 106);
            button_shop.Name = "button_shop";
            button_shop.Size = new Size(112, 262);
            button_shop.TabIndex = 1;
            button_shop.Text = "Shop";
            button_shop.UseVisualStyleBackColor = true;
            button_shop.Click += button_shop_Click;
            // 
            // cookies_count
            // 
            cookies_count.AutoSize = true;
            cookies_count.Font = new Font("ROG Fonts", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cookies_count.Location = new Point(396, 46);
            cookies_count.Name = "cookies_count";
            cookies_count.Size = new Size(194, 34);
            cookies_count.TabIndex = 2;
            cookies_count.Text = "Cookies: ";
            cookies_count.Click += cookies_count_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(cookies_count);
            Controls.Add(button_shop);
            Controls.Add(button_cookie);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cookie;
        private Button button_shop;
        private Label cookies_count;
    }
}
