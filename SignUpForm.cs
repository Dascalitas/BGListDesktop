using BGListDesktop.DBClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BGListDesktop
{
    public partial class SignUp : Form
    {
        public SignUp() => InitializeComponent();

        private BGRepository repository = new BGRepository();
        readonly Regex nameRegex = new Regex(@"[A-Z][a-z]+(/s[A-Z][a-z]+)*");

        private void signupButton_Click(object sender, EventArgs e)
        {
            string name = nameTxtbox.Text;
            string email = emailTxtbox.Text;
            string password = passwordTxtbox.Text;
            string errorMessage;

            if (!nameRegex.IsMatch(name)) 
                ShowErrorMessage("your Name have wrong format");

            else if (!IsValidEmailAddress(email, out errorMessage)) 
                ShowErrorMessage(errorMessage);

            else if (password.Length < 3) 
                ShowErrorMessage("Password is too short");
                
            else if (passwordTxtbox.Text != confirmPassTxtbox.Text) 
                ShowErrorMessage("The passwords are not same");

            else
            {
                bool success = repository.TrySignUp(name, email, password, out var exception);
                if (success) 
                {
                    RedirectToLoginForm();
                }
                else 
                {
                    ShowErrorMessage("This email is used already\n" + exception.Message); 
                }
                
            } 
        }

        private void nameTxtbox_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage;
            if (nameTxtbox.Text.Length == 0)
            {
                errorMessage = "This field is mandatory";
            } 
            else if (nameRegex.Match(nameTxtbox.Text).Success) 
            {
                errorMessage = "";
            }
            else
            {
                errorMessage = "Please enter your true name. No numbers or symbols are allowed.";
            }
            nameErrorLabel.Text = errorMessage;
            nameErrorLabel.Update();
        }

        private void emailTxtbox_Validating(object sender, CancelEventArgs e)
        {
            IsValidEmailAddress(emailTxtbox.Text, out string errorMsg);           

            emailErrorLabel.Text = errorMsg;
        }

        private void passwordTxtbox_Validating(object sender, CancelEventArgs e)
        {
            if(passwordTxtbox.Text.Length < 3)
            {
                passwordErrorLabel.Text = "Your Password is too short. Please enter a new one";
            }
        }

        private void confirmPassTxtbox_Validating(object sender, CancelEventArgs e)
        {
            if (passwordTxtbox.Text != confirmPassTxtbox.Text)
            {
                confirmPassErrorLabel.Text = "Password and Confirm Password fields should be same";
            }
        }

        public void closeButton_Click(object sender, EventArgs e)
        {
            RedirectToLoginForm();
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

        public void ShowErrorMessage(String message) => MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public void RedirectToLoginForm()
        {
            Owner?.Show();
            
            this.Close();
        }
    }
}
