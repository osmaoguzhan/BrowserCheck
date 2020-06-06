using System;
using System.Windows.Forms;
using BrowserCheck.Controller;

namespace BrowserCheck.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void saveUser_Click(object sender, EventArgs e)
        {
            UserController control = new UserController();
            Login login = new Login();
            string message = control.saveUser(nameText.Text,surnameText.Text,emailText.Text,passwordText.Text);
            if (string.IsNullOrEmpty(message))
            {
                Exception.ThrowExc.Instance.SuccessMessage(Const.Constants.USER_SUCCESSFULLY_ADDED);
                this.Close();
                Application.OpenForms[0].Show();
            }
            else
            {
                Exception.ThrowExc.Instance.ErrorMessage(message);
            }
        }

        private void CancelProcess_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
    }
}
