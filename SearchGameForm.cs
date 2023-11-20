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
        BGRepository bGRepository = new();
        private List<Game> games;
        DataGridView gamesGrid = new DataGridView();
        Guid userGuid;
        
        public SearchGameForm(Guid guid)
        {
            InitializeComponent();
            userGuid = guid;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (bGRepository.searchForGames(searchInput.Text, out games))
            {
                //open list of games
                this.Size = new System.Drawing.Size(450, 470);

                //the grid
                
                gamesGrid.Dock = DockStyle.Fill;
                gamesGrid.AutoGenerateColumns = true;
                gamesGrid.DataSource = games;
                gamesGrid.Size = new System.Drawing.Size(320, 200);
                gamesGrid.Location = new System.Drawing.Point(65, 200);
                gamesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
                // add button
                Button addButton = new Button();
                addButton.Size = new System.Drawing.Size(150, 50);
                addButton.Location = new System.Drawing.Point(175, 410);
                addButton.Name = "Add";
                addButton.Click += new System.EventHandler(this.addGame_Click);
            } 
            else
            {
                //open add game module
                // TO DO
                // MessageBox to appear =>i 
                var result = MessageBox.Show("Игра не найдена в списке. Хотите её добавить?", "Добавить игру", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (result == DialogResult.Yes) 
                 { 
                    // add new Form   
                    // create new module for inserting new game
                 }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addGame_Click(object sender, EventArgs e)
        {
            // verification any game is selected, and can be added
            if (gamesGrid.SelectedRows.Count > 0)
            {
                // cast rows to Games, and insert to user
                bGRepository.findGamesAndAdd(userGuid, getSelectedGames());
            }
            else
            {
                MessageBox.Show("Игра не выбрана. Пожалуйта выберете перед этим игру.", "Игра не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<string> getSelectedGames()
        {
            List<string> games = null; ;

            foreach (DataGridViewRow row in gamesGrid.SelectedRows)
            {
                games.Add(item: row.Cells[0].Value.ToString());
            }
            return games;
        }
    }
}
