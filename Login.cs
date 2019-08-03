using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitsProject
{
    public partial class Login : Form
    {

        public static string username = "";
        public Login()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void BtnLogin1_Click(object sender, EventArgs e)
        {
            username = this.txtUserName.Text;
            string pass = this.txtPassword.Text;

            if (username == "Billadal" && pass == "123")
            {
                
                Admin admin = new Admin();
                admin.Show();
            }
        }
    }
}
