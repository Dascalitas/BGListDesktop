using BGListDesktop.DBClass;
using SQLiteDB.Models;

namespace BGListDesktop
{
    partial class MainPageForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleIcon = new System.Windows.Forms.PictureBox();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.boardGameList = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptimalPlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WishList = new System.Windows.Forms.Button();
            this.AddGameBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardGameList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::BGListDesktop.Properties.Resources.close1437;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Location = new System.Drawing.Point(404, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 33);
            this.closeButton.TabIndex = 12;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(63, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(300, 50);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Board Games List";
            // 
            // titleIcon
            // 
            this.titleIcon.Image = ((System.Drawing.Image)(resources.GetObject("titleIcon.Image")));
            this.titleIcon.Location = new System.Drawing.Point(-1, 0);
            this.titleIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleIcon.Name = "titleIcon";
            this.titleIcon.Size = new System.Drawing.Size(60, 70);
            this.titleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleIcon.TabIndex = 10;
            this.titleIcon.TabStop = false;
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greetingLabel.Location = new System.Drawing.Point(12, 74);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(114, 28);
            this.greetingLabel.TabIndex = 13;
            this.greetingLabel.Text = "Hello there!";
            // 
            // boardGameList
            // 
            this.boardGameList.AllowUserToAddRows = false;
            this.boardGameList.AllowUserToDeleteRows = false;
            this.boardGameList.AutoGenerateColumns = false;
            this.boardGameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boardGameList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.OptimalPlayers});
            this.boardGameList.DataSource = this.gamesBindingSource;
            this.boardGameList.Location = new System.Drawing.Point(12, 105);
            this.boardGameList.Name = "boardGameList";
            this.boardGameList.ReadOnly = true;
            this.boardGameList.RowHeadersWidth = 51;
            this.boardGameList.RowTemplate.Height = 29;
            this.boardGameList.Size = new System.Drawing.Size(425, 288);
            this.boardGameList.TabIndex = 14;
            this.boardGameList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.boardGameList_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // OptimalPlayers
            // 
            this.OptimalPlayers.DataPropertyName = "OptimalPlayers";
            this.OptimalPlayers.HeaderText = "OptimalPlayers";
            this.OptimalPlayers.MinimumWidth = 6;
            this.OptimalPlayers.Name = "OptimalPlayers";
            this.OptimalPlayers.ReadOnly = true;
            this.OptimalPlayers.Width = 125;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "Games";
            this.gamesBindingSource.DataSource = this.usersBindingSource;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.gameBindingSource;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataSource = typeof(SQLiteDB.Models.Game);
            // 
            // WishList
            // 
            this.WishList.Location = new System.Drawing.Point(343, 409);
            this.WishList.Name = "WishList";
            this.WishList.Size = new System.Drawing.Size(94, 29);
            this.WishList.TabIndex = 15;
            this.WishList.Text = "Wishlist";
            this.WishList.UseVisualStyleBackColor = true;
            // 
            // AddGameBtn
            // 
            this.AddGameBtn.Location = new System.Drawing.Point(12, 409);
            this.AddGameBtn.Name = "AddGameBtn";
            this.AddGameBtn.Size = new System.Drawing.Size(94, 29);
            this.AddGameBtn.TabIndex = 16;
            this.AddGameBtn.Text = "Add Game";
            this.AddGameBtn.UseVisualStyleBackColor = true;
            this.AddGameBtn.Click += new System.EventHandler(this.AddGameBtn_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.ControlBox = false;
            this.Controls.Add(this.AddGameBtn);
            this.Controls.Add(this.WishList);
            this.Controls.Add(this.boardGameList);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardGameList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button closeButton;
        private Label titleLabel;
        private PictureBox titleIcon;
        private Label greetingLabel;
        private DataGridView boardGameList;
        private DataGridViewTextBoxColumn maxPlayersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxTimeDataGridViewTextBoxColumn;
        private BindingSource gameBindingSource;
        private Button WishList;
        private Button AddGameBtn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn OptimalPlayers;
        private BindingSource gamesBindingSource;
        private BindingSource usersBindingSource;
    }
}