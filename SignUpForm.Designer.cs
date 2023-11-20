namespace BGListDesktop
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleIcon = new System.Windows.Forms.PictureBox();
            this.nameTxtbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmPassTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.confirmPassErrorLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(63, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(300, 50);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Board Games List";
            // 
            // titleIcon
            // 
            this.titleIcon.Image = ((System.Drawing.Image)(resources.GetObject("titleIcon.Image")));
            this.titleIcon.Location = new System.Drawing.Point(0, 0);
            this.titleIcon.Margin = new System.Windows.Forms.Padding(0);
            this.titleIcon.Name = "titleIcon";
            this.titleIcon.Size = new System.Drawing.Size(60, 70);
            this.titleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleIcon.TabIndex = 3;
            this.titleIcon.TabStop = false;
            // 
            // nameTxtbox
            // 
            this.nameTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTxtbox.Location = new System.Drawing.Point(150, 150);
            this.nameTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTxtbox.MaxLength = 50;
            this.nameTxtbox.Name = "nameTxtbox";
            this.nameTxtbox.Size = new System.Drawing.Size(240, 34);
            this.nameTxtbox.TabIndex = 7;
            this.nameTxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTxtbox_Validating);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(53, 150);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(82, 35);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Name";
            // 
            // emailTxtbox
            // 
            this.emailTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTxtbox.Location = new System.Drawing.Point(150, 225);
            this.emailTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTxtbox.MaxLength = 50;
            this.emailTxtbox.Name = "emailTxtbox";
            this.emailTxtbox.Size = new System.Drawing.Size(239, 34);
            this.emailTxtbox.TabIndex = 9;
            this.emailTxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTxtbox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "E-mail";
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxtbox.Location = new System.Drawing.Point(150, 300);
            this.passwordTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTxtbox.MaxLength = 50;
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.Size = new System.Drawing.Size(239, 34);
            this.passwordTxtbox.TabIndex = 11;
            this.passwordTxtbox.UseSystemPasswordChar = true;
            this.passwordTxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTxtbox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // confirmPassTxtbox
            // 
            this.confirmPassTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPassTxtbox.Location = new System.Drawing.Point(150, 375);
            this.confirmPassTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmPassTxtbox.MaxLength = 50;
            this.confirmPassTxtbox.Name = "confirmPassTxtbox";
            this.confirmPassTxtbox.Size = new System.Drawing.Size(239, 34);
            this.confirmPassTxtbox.TabIndex = 13;
            this.confirmPassTxtbox.UseSystemPasswordChar = true;
            this.confirmPassTxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.confirmPassTxtbox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirm";
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(150, 450);
            this.signupButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(150, 50);
            this.signupButton.TabIndex = 14;
            this.signupButton.Text = "Create";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLabel.Location = new System.Drawing.Point(150, 188);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.nameErrorLabel.TabIndex = 15;
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLabel.Location = new System.Drawing.Point(150, 263);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.emailErrorLabel.TabIndex = 16;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLabel.Location = new System.Drawing.Point(150, 338);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.passwordErrorLabel.TabIndex = 17;
            // 
            // confirmPassErrorLabel
            // 
            this.confirmPassErrorLabel.AutoSize = true;
            this.confirmPassErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPassErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.confirmPassErrorLabel.Location = new System.Drawing.Point(150, 413);
            this.confirmPassErrorLabel.Name = "confirmPassErrorLabel";
            this.confirmPassErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.confirmPassErrorLabel.TabIndex = 18;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::BGListDesktop.Properties.Resources.close1437;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Location = new System.Drawing.Point(405, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 33);
            this.closeButton.TabIndex = 19;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.confirmPassErrorLabel);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.emailErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.confirmPassTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxtbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label titleLabel;
        private PictureBox titleIcon;
        private Label emailLabel;
        private TextBox emailTxtbox;
        private Label label1;
        private TextBox passwordTxtbox;
        private Label label2;
        private TextBox confirmPassTxtbox;
        private Label label3;
        private Button signupButton;
        private Label nameErrorLabel;
        private Label emailErrorLabel;
        private Label passwordErrorLabel;
        private Label confirmPassErrorLabel;
        public TextBox nameTxtbox;
        private Button closeButton;
    }
}