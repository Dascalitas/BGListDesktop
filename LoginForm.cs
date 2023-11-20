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

        private BGRepository repository = new BGRepository();
        public SignUp signUp;

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = emailTxtbox.Text;
            string password = passwordTxtbox.Text;
            Guid userGuid;
            bool succes = repository.tryLogin(login, password, out userGuid);

            if (succes) 
            {
                MainPageForm mainPageForm= new MainPageForm(userGuid);
                this.Hide();
                mainPageForm.Show(this);
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            signUp = new SignUp();
            this.Hide();
            signUp.Show(this);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void emailTxtbox_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidEmailAddress(emailTxtbox.Text, out string errorMsg))
                loginButton.Enabled = true;
            else loginButton.Enabled = false;

            emailErrorLabel.Text = errorMsg;
        }

        private void passwordTxtbox_Validating(object sender, CancelEventArgs e)
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

        public bool IsValidEmailAddress(string emailAddress, out string errorMessage)
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
