using BrowserCheck.Controller;
using BrowserCheck.Forms;
using System;
using System.Windows.Forms;

namespace BrowserCheck
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MainPage main = null;
        private void loginButton_Click(object sender, EventArgs e)
        {
            UserController userControl = new UserController();
            string message = userControl.checkUser(textBox1.Text, textBox2.Text);
            if (string.IsNullOrEmpty(message))
            {
                main = new MainPage();
                main.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                this.Hide();
            }
            else
            {
                Exception.ThrowExc.Instance.ErrorMessage(message);
            }
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
