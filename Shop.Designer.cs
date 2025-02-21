namespace Cookie_Clicker
{
    partial class Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cursor_Upgrade = new Button();
            Autoclicker = new Button();
            button1 = new Button();
            Shop_Sign = new Label();
            Level_Cursor = new Label();
            Level_Autoclicker = new Label();
            Level_2x = new Label();
            cookies_count = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // Cursor_Upgrade
            // 
            Cursor_Upgrade.Font = new Font("Rockwell", 11F);
            Cursor_Upgrade.Location = new Point(31, 186);
            Cursor_Upgrade.Name = "Cursor_Upgrade";
            Cursor_Upgrade.Size = new Size(197, 45);
            Cursor_Upgrade.TabIndex = 1;
            Cursor_Upgrade.Text = "Cursor Upgrades";
            Cursor_Upgrade.UseVisualStyleBackColor = true;
            Cursor_Upgrade.Click += Cursor_Upgrade_Click;
            // 
            // Autoclicker
            // 
            Autoclicker.Font = new Font("Rockwell", 11F);
            Autoclicker.Location = new Point(31, 237);
            Autoclicker.Name = "Autoclicker";
            Autoclicker.Size = new Size(246, 45);
            Autoclicker.TabIndex = 2;
            Autoclicker.Text = "Autoclicker Upgrades";
            Autoclicker.UseVisualStyleBackColor = true;
            Autoclicker.Click += Autoclicker_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 11F);
            button1.Location = new Point(31, 288);
            button1.Name = "button1";
            button1.Size = new Size(216, 45);
            button1.TabIndex = 3;
            button1.Text = "2x Cookies 60.Sec";
            button1.UseVisualStyleBackColor = true;
            // 
            // Shop_Sign
            // 
            Shop_Sign.AutoSize = true;
            Shop_Sign.Font = new Font("Rockwell", 25F, FontStyle.Bold);
            Shop_Sign.Location = new Point(182, 36);
            Shop_Sign.Name = "Shop_Sign";
            Shop_Sign.Size = new Size(168, 61);
            Shop_Sign.TabIndex = 4;
            Shop_Sign.Text = "SHOP";
            Shop_Sign.Click += Shop_Sign_Click;
            // 
            // Level_Cursor
            // 
            Level_Cursor.AutoSize = true;
            Level_Cursor.Font = new Font("Rockwell", 13F);
            Level_Cursor.Location = new Point(335, 192);
            Level_Cursor.Name = "Level_Cursor";
            Level_Cursor.Size = new Size(79, 30);
            Level_Cursor.TabIndex = 5;
            Level_Cursor.Text = "Level";
            // 
            // Level_Autoclicker
            // 
            Level_Autoclicker.AutoSize = true;
            Level_Autoclicker.Font = new Font("Rockwell", 13F);
            Level_Autoclicker.Location = new Point(335, 243);
            Level_Autoclicker.Name = "Level_Autoclicker";
            Level_Autoclicker.Size = new Size(79, 30);
            Level_Autoclicker.TabIndex = 6;
            Level_Autoclicker.Text = "Level";
            // 
            // Level_2x
            // 
            Level_2x.AutoSize = true;
            Level_2x.Font = new Font("Rockwell", 13F);
            Level_2x.Location = new Point(335, 294);
            Level_2x.Name = "Level_2x";
            Level_2x.Size = new Size(79, 30);
            Level_2x.TabIndex = 7;
            Level_2x.Text = "Level";
            // 
            // cookies_count
            // 
            cookies_count.AutoSize = true;
            cookies_count.Font = new Font("Rockwell", 16F, FontStyle.Bold);
            cookies_count.Location = new Point(156, 380);
            cookies_count.Name = "cookies_count";
            cookies_count.Size = new Size(163, 39);
            cookies_count.TabIndex = 8;
            cookies_count.Text = "Cookies: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 13F);
            label4.Location = new Point(438, 294);
            label4.Name = "label4";
            label4.Size = new Size(71, 30);
            label4.TabIndex = 11;
            label4.Text = "50🍪";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 13F);
            label5.Location = new Point(438, 243);
            label5.Name = "label5";
            label5.Size = new Size(71, 30);
            label5.TabIndex = 10;
            label5.Text = "50🍪";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 13F);
            label6.Location = new Point(438, 192);
            label6.Name = "label6";
            label6.Size = new Size(71, 30);
            label6.TabIndex = 9;
            label6.Text = "50🍪";
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.simple_background_textured_wood_texture_wallpaper_preview;
            ClientSize = new Size(544, 450);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(cookies_count);
            Controls.Add(Level_2x);
            Controls.Add(Level_Autoclicker);
            Controls.Add(Level_Cursor);
            Controls.Add(Shop_Sign);
            Controls.Add(button1);
            Controls.Add(Autoclicker);
            Controls.Add(Cursor_Upgrade);
            Name = "Shop";
            Text = "Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Cursor_Upgrade;
        private Button Autoclicker;
        private Button button1;
        private Label Shop_Sign;
        private Label Level_Cursor;
        private Label Level_Autoclicker;
        private Label Level_2x;
        private Label cookies_count;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}