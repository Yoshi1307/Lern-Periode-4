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

        public Shop()
        {
            InitializeComponent();
        }
        public Shop(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Autoclicker_Click(object sender, EventArgs e)
        {
            mainForm.cookieCount++;
            mainForm.UpdateCookieCount();

        }

        private void Cursor_Upgrade_Click(object sender, EventArgs e)
        {

        }

        private void Shop_Sign_Click(object sender, EventArgs e)
        {

        }
    }
}
