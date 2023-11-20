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
        Guid userGuid = Guid.Empty;
        private BGRepository BGRepository = new BGRepository();
        private IEnumerable<Game> games;
        public MainPageForm(Guid userGuid)
        {
            InitializeComponent();
            this.userGuid = userGuid;
            games = BGRepository.getUserGames(userGuid);
            boardGameList.DataSource = games;
            boardGameList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            // create new Panel, and put inside it the grid / label, in dependence of list.
        }

        private void AddGameBtn_Click(object sender, EventArgs e)
        {
            SearchGameForm searchGameForm = new SearchGameForm();
            //this.Hide();
            searchGameForm.Show(this);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boardGameList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
