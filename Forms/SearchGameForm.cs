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
    public partial class SearchGameForm : Form
    {
        readonly BGRepository bGRepository = new();
        private List<Game> games = new();
        readonly DataGridView gamesGrid = new();
        readonly Guid userGuid;
        
        public SearchGameForm(Guid guid)
        {
            InitializeComponent();
            userGuid = guid;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (bGRepository.searchForGames(searchInput.Text, out games))
            {
                //open list of games
                this.Size = new Size(450, 470);

                //the grid
                gamesGrid.Dock = DockStyle.Fill;
                gamesGrid.AutoGenerateColumns = true;
                gamesGrid.DataSource = games;
                gamesGrid.Size = new Size(320, 200);
                gamesGrid.Location = new Point(65, 200);
                gamesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // add button
                Button addButton = new()
                {
                    Size = new Size(150, 50),
                    Location = new Point(175, 410),
                    Name = "Add"
                };
                addButton.Click += new(this.AddGame_Click);
            } 
            else
            {
                //open add game module
                var result = MessageBox.Show("Игра не найдена в списке. Хотите её добавить?", "Добавить игру", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (result == DialogResult.Yes) 
                 { 
                    // add new Form   
                    // TODO create new module for inserting new game
                 }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGame_Click(object sender, EventArgs e)
        {
            // verification any game is selected, and can be added
            if (gamesGrid.SelectedRows.Count > 0)
            {
                // cast rows to Games, and insert to user
                bGRepository.findGamesAndAdd(userGuid, GetSelectedGames());
            }
            else
            {
                MessageBox.Show("Игра не выбрана. Пожалуйта выберете перед этим игру.", "Игра не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<string> GetSelectedGames()
        {
            List<string>? games = null;

            foreach (DataGridViewRow row in gamesGrid.SelectedRows)
            {
                games.Add(item: row.Cells[0].Value.ToString());
            }

            //object value = from row in gamesGrid.SelectedRows.AsQueryable() select row.Cells[0].Value.ToString();
;
            return games;
        }
    }
}
