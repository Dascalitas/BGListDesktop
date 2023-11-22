namespace BGListDesktop
{
    partial class AddGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGameForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleIcon = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.MinPlayersLabel = new System.Windows.Forms.Label();
            this.maxPlayers = new System.Windows.Forms.Label();
            this.optimalPlayersLabel = new System.Windows.Forms.Label();
            this.minTimeLabel = new System.Windows.Forms.Label();
            this.maxTimeLabel = new System.Windows.Forms.Label();
            this.genresLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.minPlayersDropdown = new System.Windows.Forms.ComboBox();
            this.maxPlayersDropdown = new System.Windows.Forms.ComboBox();
            this.optimalPlayersDropdown = new System.Windows.Forms.ComboBox();
            this.minTimeDropdown = new System.Windows.Forms.ComboBox();
            this.maxTimeDropdown = new System.Windows.Forms.ComboBox();
            this.genresDropdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::BGListDesktop.Properties.Resources.close1437;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Location = new System.Drawing.Point(415, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 33);
            this.closeButton.TabIndex = 18;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(65, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(300, 50);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Board Games List";
            // 
            // titleIcon
            // 
            this.titleIcon.Image = ((System.Drawing.Image)(resources.GetObject("titleIcon.Image")));
            this.titleIcon.Location = new System.Drawing.Point(0, 0);
            this.titleIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleIcon.Name = "titleIcon";
            this.titleIcon.Size = new System.Drawing.Size(60, 70);
            this.titleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleIcon.TabIndex = 16;
            this.titleIcon.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(10, 100);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(170, 30);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(10, 150);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(170, 30);
            this.descriptionLabel.TabIndex = 20;
            this.descriptionLabel.Text = "Description:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MinPlayersLabel
            // 
            this.MinPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinPlayersLabel.Location = new System.Drawing.Point(10, 300);
            this.MinPlayersLabel.Name = "MinPlayersLabel";
            this.MinPlayersLabel.Size = new System.Drawing.Size(170, 30);
            this.MinPlayersLabel.TabIndex = 21;
            this.MinPlayersLabel.Text = "Min players:";
            this.MinPlayersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxPlayers
            // 
            this.maxPlayers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxPlayers.Location = new System.Drawing.Point(10, 350);
            this.maxPlayers.Name = "maxPlayers";
            this.maxPlayers.Size = new System.Drawing.Size(170, 30);
            this.maxPlayers.TabIndex = 22;
            this.maxPlayers.Text = "Max players:";
            this.maxPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // optimalPlayersLabel
            // 
            this.optimalPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optimalPlayersLabel.Location = new System.Drawing.Point(10, 400);
            this.optimalPlayersLabel.Name = "optimalPlayersLabel";
            this.optimalPlayersLabel.Size = new System.Drawing.Size(170, 30);
            this.optimalPlayersLabel.TabIndex = 23;
            this.optimalPlayersLabel.Text = "Optimal players:";
            this.optimalPlayersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minTimeLabel
            // 
            this.minTimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minTimeLabel.Location = new System.Drawing.Point(10, 450);
            this.minTimeLabel.Name = "minTimeLabel";
            this.minTimeLabel.Size = new System.Drawing.Size(170, 30);
            this.minTimeLabel.TabIndex = 24;
            this.minTimeLabel.Text = "Min time:";
            this.minTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxTimeLabel
            // 
            this.maxTimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxTimeLabel.Location = new System.Drawing.Point(60, 500);
            this.maxTimeLabel.Name = "maxTimeLabel";
            this.maxTimeLabel.Size = new System.Drawing.Size(120, 30);
            this.maxTimeLabel.TabIndex = 25;
            this.maxTimeLabel.Text = "Max time:";
            this.maxTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genresLabel
            // 
            this.genresLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genresLabel.Location = new System.Drawing.Point(10, 550);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(170, 30);
            this.genresLabel.TabIndex = 26;
            this.genresLabel.Text = "Genres:";
            this.genresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameInput.Location = new System.Drawing.Point(196, 100);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(240, 30);
            this.nameInput.TabIndex = 27;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(196, 150);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(240, 130);
            this.descriptionInput.TabIndex = 28;
            // 
            // minPlayersDropdown
            // 
            this.minPlayersDropdown.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minPlayersDropdown.FormattingEnabled = true;
            this.minPlayersDropdown.Location = new System.Drawing.Point(196, 300);
            this.minPlayersDropdown.Name = "minPlayersDropdown";
            this.minPlayersDropdown.Size = new System.Drawing.Size(240, 31);
            this.minPlayersDropdown.TabIndex = 29;
            // 
            // maxPlayersDropdown
            // 
            this.maxPlayersDropdown.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxPlayersDropdown.FormattingEnabled = true;
            this.maxPlayersDropdown.Location = new System.Drawing.Point(196, 350);
            this.maxPlayersDropdown.Name = "maxPlayersDropdown";
            this.maxPlayersDropdown.Size = new System.Drawing.Size(240, 31);
            this.maxPlayersDropdown.TabIndex = 30;
            // 
            // optimalPlayersDropdown
            // 
            this.optimalPlayersDropdown.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optimalPlayersDropdown.FormattingEnabled = true;
            this.optimalPlayersDropdown.Location = new System.Drawing.Point(196, 400);
            this.optimalPlayersDropdown.Name = "optimalPlayersDropdown";
            this.optimalPlayersDropdown.Size = new System.Drawing.Size(240, 31);
            this.optimalPlayersDropdown.TabIndex = 31;
            // 
            // minTimeDropdown
            // 
            this.minTimeDropdown.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minTimeDropdown.FormattingEnabled = true;
            this.minTimeDropdown.Location = new System.Drawing.Point(196, 450);
            this.minTimeDropdown.Name = "minTimeDropdown";
            this.minTimeDropdown.Size = new System.Drawing.Size(240, 31);
            this.minTimeDropdown.TabIndex = 32;
            // 
            // maxTimeDropdown
            // 
            this.maxTimeDropdown.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxTimeDropdown.FormattingEnabled = true;
            this.maxTimeDropdown.Location = new System.Drawing.Point(196, 500);
            this.maxTimeDropdown.Name = "maxTimeDropdown";
            this.maxTimeDropdown.Size = new System.Drawing.Size(240, 31);
            this.maxTimeDropdown.TabIndex = 33;
            // 
            // genresDropdown
            // 
            this.genresDropdown.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genresDropdown.FormattingEnabled = true;
            this.genresDropdown.Location = new System.Drawing.Point(196, 550);
            this.genresDropdown.Name = "genresDropdown";
            this.genresDropdown.Size = new System.Drawing.Size(240, 31);
            this.genresDropdown.TabIndex = 35;
            // 
            // AddGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(460, 690);
            this.ControlBox = false;
            this.Controls.Add(this.genresDropdown);
            this.Controls.Add(this.maxTimeDropdown);
            this.Controls.Add(this.minTimeDropdown);
            this.Controls.Add(this.optimalPlayersDropdown);
            this.Controls.Add(this.maxPlayersDropdown);
            this.Controls.Add(this.minPlayersDropdown);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.genresLabel);
            this.Controls.Add(this.maxTimeLabel);
            this.Controls.Add(this.minTimeLabel);
            this.Controls.Add(this.optimalPlayersLabel);
            this.Controls.Add(this.maxPlayers);
            this.Controls.Add(this.MinPlayersLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGameForm";
            this.Text = "AddGameForm";
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button closeButton;
        private Label titleLabel;
        private PictureBox titleIcon;
        private Label nameLabel;
        private Label descriptionLabel;
        private Label MinPlayersLabel;
        private Label maxPlayers;
        private Label optimalPlayersLabel;
        private Label minTimeLabel;
        private Label maxTimeLabel;
        private Label genresLabel;
        private TextBox nameInput;
        private TextBox descriptionInput;
        private ComboBox minPlayersDropdown;
        private ComboBox maxPlayersDropdown;
        private ComboBox optimalPlayersDropdown;
        private ComboBox minTimeDropdown;
        private ComboBox maxTimeDropdown;
        private ComboBox genresDropdown;
    }
}