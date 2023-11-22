using BGListDesktop.DBClass;
using SQLiteDB.Models;
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
    public partial class MainPageForm : Form
    {
        readonly Guid userGuid = Guid.Empty;
        private readonly BGRepository BGRepository = new();
        private readonly IEnumerable<Game>? games = null;
        public MainPageForm(Guid userGuid)
        {
            InitializeComponent();
            this.userGuid = userGuid;
            games = BGRepository.getUserGames(userGuid);
            if (games == null || !games.Any())
            {
                noGamesLabel = new Label();
                this.noGamesLabel.AutoSize = true;
                this.noGamesLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
                this.noGamesLabel.Location = new Point(12, 105);
                this.noGamesLabel.Name = "noGamesLabel";
                this.noGamesLabel.Size = new Size(425, 288);
                this.noGamesLabel.TabIndex = 13;
                this.noGamesLabel.Text = "У вас пока нету игр!";
                //this.noGamesLabel.
                this.Controls.Add(this.noGamesLabel);
            }
            else
            {
                this.boardGameList = new ();
                ((ISupportInitialize)(this.titleIcon)).BeginInit();
                GenerateGrid();
            }

            // create new Panel, and put inside it the grid / label, in dependence of list.
        }

        private void AddGameBtn_Click(object sender, EventArgs e)
        {
            SearchGameForm searchGameForm = new(userGuid);
            //this.Hide();
            searchGameForm.Show(this);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateGrid()
        {

            // 
            // boardGameList
            // 
            this.boardGameList.AllowUserToAddRows = false;
            this.boardGameList.AllowUserToDeleteRows = false;
            this.boardGameList.AutoGenerateColumns = false;
            this.boardGameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.boardGameList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            //this.nameDataGridViewTextBoxColumn,
            //this.OptimalPlayers});
            //this.boardGameList.DataSource = this.gamesBindingSource;
            this.boardGameList.Location = new Point(12, 105);
            this.boardGameList.Name = "boardGameList";
            this.boardGameList.ReadOnly = true;
            this.boardGameList.RowHeadersWidth = 50;
            this.boardGameList.RowTemplate.Height = 29;
            this.boardGameList.Size = new Size(425, 288);
            this.boardGameList.TabIndex = 14;
            this.boardGameList.DataSource = games;
            boardGameList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }
    }
}
