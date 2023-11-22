using BGListDesktop.DBClass;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGListDesktop
{
    public partial class LoginForm : Form
    {
        public LoginForm() => InitializeComponent();

        private readonly BGRepository repository = new();
        public SignUp signUp;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = emailTxtbox.Text;
            string password = passwordTxtbox.Text;
            bool succes = repository.tryLogin(login, password, out Guid userGuid);

            if (succes) 
            {
                MainPageForm mainPageForm= new(userGuid);
                this.Hide();
                mainPageForm.Show(this);
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            signUp = new SignUp();
            this.Hide();
            signUp.Show(this);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EmailTxtbox_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidEmailAddress(emailTxtbox.Text, out string errorMsg))
                loginButton.Enabled = true;
            else loginButton.Enabled = false;

            emailErrorLabel.Text = errorMsg;
        }

        private void PasswordTxtbox_Validating(object sender, CancelEventArgs e)
        {
            if (passwordTxtbox.Text.Length < 3)
            {
                passwordErrorLabel.Text = "Your Password is too short. Please enter a new one";
                loginButton.Enabled = false;
            } 
            else 
            {
                loginButton.Enabled = true;
            }
        }

        public static bool IsValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (emailAddress.Trim().Length == 0)
            {
                errorMessage = "email address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.IndexOf("@") > 0)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "email address must be valid email address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }
    }
}
