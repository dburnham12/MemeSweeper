using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Dylan Burnham
// A form to act as a message box but with a picture for a meme when the player has completed a game , also used to display
// a leaderboard position if the user has made it to the leaderboards.

namespace MineSweeper
{
    
    public partial class Form2 : Form
    {
        public const int RETRYGAME = 0; // Used when retrying 
        public const int VEIWHIGHSCORES = 1; // Used to view high scores from this menu
        public const int RETURNTOMAINMENU = 2; // Used to return to the main menu


        public static int SelectAction { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        // Function to set up the initial state of the form based off a boolean determining if the player has won or lost
        public void SetUpForm(bool hasWon, int leaderboardPosition)
        {
            Random randomGenerator = new Random();
            int randomValue = randomGenerator.Next(0, 3);

            if (hasWon) // If the player has won update message and choose a new meme based off of a random value 
            {
                winLoseMessageLbl.Text = "You win!";
                switch (randomValue)
                {
                    case 0:
                        winLosePbx.Image = MineSweeper.Properties.Resources.YouWinOneMeme;
                        break;
                    case 1:
                        winLosePbx.Image = MineSweeper.Properties.Resources.YouWinTwoMeme;
                        break;
                    case 2:
                        winLosePbx.Image = MineSweeper.Properties.Resources.YouWinThreeMeme;
                        break;
                }
            }
            else // If the player has lost update message and choose a new meme based off of a random value 
            {
                winLoseMessageLbl.Text = "You lose!";
                switch (randomValue)
                {
                    case 0:
                        winLosePbx.Image = MineSweeper.Properties.Resources.YouLoseOneMeme;
                        break;
                    case 1:
                        winLosePbx.Image = MineSweeper.Properties.Resources.YouLoseTwoMeme;
                        break;
                    case 2:
                        winLosePbx.Image = MineSweeper.Properties.Resources.YouLoseThreeMeme;
                        break;
                }
            }

            if (leaderboardPosition == ScoreBoard.NOTONLEADERBOARD)
                leaderboardPositionLbl.Text = "You did not make the leaderboard";
            else
                leaderboardPositionLbl.Text = "You made the leaderboard pos #" + (leaderboardPosition + 1);
        }

        // Event handler to retry the game
        private void retryBtn_Click(object sender, EventArgs e)
        {
            SelectAction = RETRYGAME;
            this.Close();
        }

        // Event handler to close the form and not retry the game (view high scores)
        private void viewHighScoresBtn_Click(object sender, EventArgs e)
        {
            SelectAction = VEIWHIGHSCORES;
            this.Close();
        }

        private void popupMainMenuBtn_Click(object sender, EventArgs e)
        {
            SelectAction = RETURNTOMAINMENU;
            this.Close();
        }
    }
}
