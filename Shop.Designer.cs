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
            SuspendLayout();
            // 
            // Cursor_Upgrade
            // 
            Cursor_Upgrade.Location = new Point(100, 91);
            Cursor_Upgrade.Name = "Cursor_Upgrade";
            Cursor_Upgrade.Size = new Size(160, 34);
            Cursor_Upgrade.TabIndex = 1;
            Cursor_Upgrade.Text = "Cursor Upgrades";
            Cursor_Upgrade.UseVisualStyleBackColor = true;
            Cursor_Upgrade.Click += Cursor_Upgrade_Click;
            // 
            // Autoclicker
            // 
            Autoclicker.Location = new Point(546, 91);
            Autoclicker.Name = "Autoclicker";
            Autoclicker.Size = new Size(112, 34);
            Autoclicker.TabIndex = 2;
            Autoclicker.Text = "Autoclicker";
            Autoclicker.UseVisualStyleBackColor = true;
            Autoclicker.Click += Autoclicker_Click;
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.simple_background_textured_wood_texture_wallpaper_preview;
            ClientSize = new Size(800, 450);
            Controls.Add(Autoclicker);
            Controls.Add(Cursor_Upgrade);
            Name = "Shop";
            Text = "Shop";
            ResumeLayout(false);
        }

        #endregion
        private Button Cursor_Upgrade;
        private Button Autoclicker;
    }
}