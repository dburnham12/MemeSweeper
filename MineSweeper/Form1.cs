using MineSweeper.Properties;
using System.Text.Json;
using System.Windows.Forms;

// Dylan Burnham
// The main form class for my minesweeper game, handles many of the operations of the game including start, ending and restarting
// a game. Also handles serialization and deserialization of files. 
// Note we talked about the swapping of rows and cols and i was told that it was ok, just to add a comment in my solution
// cols = xPosition/xThreeByThree
// rows = yPosition/yThreeByThree
// There is a message box located in the player info section and if there is no player info loaded into the game

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        // EASY DIFFICULTY
        const int EASYBOARDSIZEX = 9;
        const int EASYBOARDSIZEY = 9;
        const int EASYNUMBEROFMINES = 10;

        // MEDIUM DIFFICULTY
        const int MEDIUMBOARDSIZEX = 16;
        const int MEDIUMBOARDSIZEY = 16;
        const int MEDIUMNUMBEROFMINES = 40;

        // HARD DIFFICULTY
        const int HARDBOARDSIZEX = 30;
        const int HARDBOARDSIZEY = 16;
        const int HARDNUMBEROFMINES = 99;

        // MAX AMOUNT OF TIME FOR A GAME
        const double MAXTIMEELAPSED = 999.0;

        // GAME BOARDS
        Board gameBoard;
        PictureBox[,] visualGameBoard;

        // TIMER INFO
        System.Windows.Forms.Timer timer;
        double timeElapsed = 0.0;

        Player currentPlayer;
        ScoreBoard scoreBoard;

        // GAMESTATE
        enum GameState { GameStart, Playing, GameOver }
        GameState gameState = GameState.GameStart;

        // DIFFICULTY LEVEL
        enum Difficulty { Easy, Medium, Hard }
        Difficulty difficulty = Difficulty.Easy;

        Form2 winLoseMessageBox;

        public Form1()
        {
            InitializeComponent();
            
            // Initialize the message box (second form) that displays a win or loss message
            winLoseMessageBox = new Form2();

            // Set up the timer and add the tick function to allow it to work properly
            timer = new System.Windows.Forms.Timer();
            timer.Tick += TickTimer;

            // Hide all menus/menu items that are not being used
            timerLbl.Hide();
            numFlagsLbl.Hide();
            instructionsPnl.Hide();
            playerInfoPnl.Hide();
            leaderboardSelectPnl.Hide();

            // Load the player info and set up the main menu
            LoadPlayer();
            ShowMenuPanel(mainMenuPnl);
        }

        private void SetUpGame(int boardSizeX, int boardSizeY, int numberOfMines)
        {
            // Hide the main menu
            mainMenuPnl.Hide();

            // Set up the game boards, both visuals and the background board
            gameBoard = new Board(boardSizeX, boardSizeY, numberOfMines);
            visualGameBoard = new PictureBox[boardSizeX, boardSizeY];

            this.MinimumSize = new Size(60 + boardSizeX * 25, 170 + boardSizeY * 25);
            this.MaximumSize = new Size(60 + boardSizeX * 25, 170 + boardSizeY * 25);
            
            // set the gamestate to playing 
            gameState = GameState.Playing;

            // Set up the timer and show it 
            timerLbl.Location = new Point(25, 25);
            timer.Start();
            timerLbl.Show();

            // Set up the flags label and show it
            numFlagsLbl.Text = "" + gameBoard.NumberOfFlags;
            numFlagsLbl.Location = new Point(25 * boardSizeX - (numFlagsLbl.Width / 2), 25);
            numFlagsLbl.Show();

            // Set up the visual portion of the game board
            for (int xPosition = 0; xPosition < boardSizeX; xPosition++)
            {
                for (int yPosition = 0; yPosition < boardSizeY; yPosition++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(20 + xPosition * 25, 100 + yPosition * 25);
                    pictureBox.Size = new Size(25, 25);
                    pictureBox.Name = "" + xPosition + "-" + yPosition;
                    pictureBox.BackColor = Color.White;
                    pictureBox.Image = MineSweeper.Properties.Resources.Unopened32;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.MouseDown += ClickBoardSquare;
                    visualGameBoard[xPosition, yPosition] = pictureBox;
                    this.Controls.Add(pictureBox);
                }
            }

            
        }

        // Function to clear a game board and hide the timer and flag labels
        void ClearGame()
        {
            // Remove all picture boxes from controls
            for (int xPosition = 0; xPosition < gameBoard.BoardSizeX; xPosition++)
            {
                for (int yPosition = 0; yPosition < gameBoard.BoardSizeY; yPosition++)
                {
                    this.Controls.Remove(visualGameBoard[xPosition, yPosition]);
                }
            }

            // hide the timer and number of flags labels
            timerLbl.Hide();
            numFlagsLbl.Hide();

            // set all other states to empty or 0
            gameBoard = null;
            visualGameBoard = null;
            timeElapsed = 0.0;
            timerLbl.Text = "0";
        }

        // Function used to allow the timer to execute properly
        private void TickTimer(object sender, EventArgs e)
        {
            if (gameState == GameState.Playing && timeElapsed < MAXTIMEELAPSED)
            {
                timeElapsed += timer.Interval / 1000.0;
                timerLbl.Text = "" + Math.Round(timeElapsed);
            }
            else
            {
                timer.Stop();
            }
        }

        // Function used when a user clicks on a specific board square
        private void ClickBoardSquare(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pictureBox && gameState == GameState.Playing)
            {
                // Coordinates for each point are stored as the name of the picture box, get the name and split into an array of strings
                string[] coordinates = pictureBox.Name.Split("-");
                int xPosition = Int32.Parse(coordinates[0]);
                int yPosition = Int32.Parse(coordinates[1]);
                if (e.Button == MouseButtons.Left) // If the left mouse button was clicked
                {
                    HandleLeftCLick(xPosition, yPosition, pictureBox);
                }
                if (e.Button == MouseButtons.Right) // If the right mouse button was clicked
                {
                    HandleRightClick(xPosition, yPosition, pictureBox);
                }
            }
        }

        // Function to handle left clicks
        private void HandleLeftCLick(int xPosition, int yPosition, PictureBox pictureBox)
        {
            if (!gameBoard.GetBoardSquareFlagged(xPosition, yPosition))
            {
                
                int value = gameBoard.GetBoardSquareValue(xPosition, yPosition);
                pictureBox.Image = GetSquareImage(value);// Update game board visuals based on value
                
                gameBoard.SetBoardSquarePressed(xPosition, yPosition);// Update the game board itself if a square is pressed
                SpreadClick(xPosition, yPosition);// If a 0 tile is pressed spread the click to adjacent tiles

                numFlagsLbl.Text = "" + gameBoard.NumberOfFlags; // Update number of flags in case of spreading
                if (value == Board.MINESQUARE) // If the user has clicked on a mine 
                {
                    gameState = GameState.GameOver;
                    winLoseMessageBox.SetUpForm(false, ScoreBoard.NOTONLEADERBOARD); // false indicating the game was lost with a position value of -1 
                    winLoseMessageBox.ShowDialog(); // Show the message box (second form) with a win or loss message
                    ClearGame();
                    if (Form2.SelectAction == Form2.RETRYGAME) // If the user selects retry
                    {
                        LoadGameByDifficulty();
                    }
                    else if(Form2.SelectAction == Form2.VEIWHIGHSCORES) // If the user selects to view high scores
                    {
                        LoadHighScores(); // In this case we can load the leaderboard scores here because we do not need to save them
                        UpdateHighScoresDisplay(ScoreBoard.NOTONLEADERBOARD);
                        ShowMenuPanel(highScoresPnl);
                    }
                    else // If the user wants to return to the main menu
                    {
                        ShowMenuPanel(mainMenuPnl);
                        gameState = GameState.GameStart;
                    }

                }
                else if (gameBoard.HasWon()) // If the user has not clicked on a mine check if the user has won the game
                {
                    int newHighScorePosition;

                    gameState = GameState.GameOver;
                    LoadHighScores(); // In this case we need to load the scores for the current leaderboard
                    newHighScorePosition = SaveHighScore(); // We then save the score based on the leaderboard that we are adding it to
                    UpdateHighScoresDisplay(newHighScorePosition);
                    winLoseMessageBox.SetUpForm(true, newHighScorePosition); // true indicating we have won and that we may have a high score position
                    winLoseMessageBox.ShowDialog(); // Show the message box (second form) with a win or loss message
                    ClearGame();
                    if (Form2.SelectAction == Form2.RETRYGAME) // If the user selected retry
                    {
                        LoadGameByDifficulty();
                    }
                    else if(Form2.SelectAction == Form2.VEIWHIGHSCORES) // If the user wants to view high scores
                    {
                        ShowMenuPanel(highScoresPnl);
                    }
                    else // If the user wants to return to the main menu
                    {
                        ShowMenuPanel(mainMenuPnl);
                        gameState = GameState.GameStart;
                    }
                }
            }
        }

        // Function to handle right clicks
        private void HandleRightClick(int xPosition, int yPosition, PictureBox pictureBox)
        {
            if (gameBoard.GetBoardSquareFlagged(xPosition, yPosition)) // If the board square has a flag
            {
                gameBoard.SetBoardSquareFlagged(xPosition, yPosition, false);
                pictureBox.Image = MineSweeper.Properties.Resources.Unopened32;
            }
            else if (!gameBoard.GetBoardSquarePressed(xPosition, yPosition)) // If the board square does not have a flag and is not pressed
            {
                gameBoard.SetBoardSquareFlagged(xPosition, yPosition, true);
                // Check if the square was actually flagged or not, if so update visuals
                if (gameBoard.GetBoardSquareFlagged(xPosition, yPosition))
                    pictureBox.Image = MineSweeper.Properties.Resources.Flag;
            }
            numFlagsLbl.Text = "" + gameBoard.NumberOfFlags; // also update the number of flags label

        }

        // Function used for click spreading when the user clicks on a tile with no connecting mines
        private void SpreadClick(int xPosition, int yPosition)
        {
            if (gameBoard.GetBoardSquareValue(xPosition, yPosition) == 0)
            {
                for (int xThreeByThree = xPosition - 1; xThreeByThree <= xPosition + 1; xThreeByThree++)
                {
                    for (int yThreeByThree = yPosition - 1; yThreeByThree <= yPosition + 1; yThreeByThree++)
                    {
                        if (xThreeByThree >= 0 && xThreeByThree < gameBoard.BoardSizeX && yThreeByThree >= 0 && yThreeByThree < gameBoard.BoardSizeY)
                        {
                            if (!gameBoard.GetBoardSquarePressed(xThreeByThree, yThreeByThree)) // check if the board square is pressed
                            {
                                // Update game board visuals
                                visualGameBoard[xThreeByThree, yThreeByThree].Image = GetSquareImage(gameBoard.GetBoardSquareValue(xThreeByThree, yThreeByThree));
                                gameBoard.SetBoardSquarePressed(xThreeByThree, yThreeByThree);
                                // Remove flags if the spreading occurs on squares that have them 
                                if (gameBoard.GetBoardSquareFlagged(xThreeByThree, yThreeByThree))
                                    gameBoard.SetBoardSquareFlagged(xThreeByThree, yThreeByThree, false);
                                SpreadClick(xThreeByThree, yThreeByThree); // recall the function if an adjascent square is also a 0
                            }
                        }
                    }
                }
            }
        }

        // Function used to get the image for the square on the board 
        static private Image GetSquareImage(int value)
        {
            Image returnImage;
            switch (value)
            {
                case -1:
                    returnImage = MineSweeper.Properties.Resources.Mine32;
                    break;
                case 0:
                    returnImage = MineSweeper.Properties.Resources.Blank32;
                    break;
                case 1:
                    returnImage = MineSweeper.Properties.Resources.Number1_32;
                    break;
                case 2:
                    returnImage = MineSweeper.Properties.Resources.Number2_32;
                    break;
                case 3:
                    returnImage = MineSweeper.Properties.Resources.Number3_32;
                    break;
                case 4:
                    returnImage = MineSweeper.Properties.Resources.Number4_32;
                    break;
                case 5:
                    returnImage = MineSweeper.Properties.Resources.Number5_32;
                    break;
                case 6:
                    returnImage = MineSweeper.Properties.Resources.Number6_32;
                    break;
                case 7:
                    returnImage = MineSweeper.Properties.Resources.Number7_32;
                    break;
                case 8:
                    returnImage = MineSweeper.Properties.Resources.Number8_32;
                    break;
                default:
                    returnImage = MineSweeper.Properties.Resources.Unopened32;
                    break;
            }
            return returnImage;
        }

        // Function to load a game based off of the current difficulty level chosen 
        private void LoadGameByDifficulty()
        {
            if (difficulty == Difficulty.Easy)
            {
                SetUpGame(EASYBOARDSIZEX, EASYBOARDSIZEY, EASYNUMBEROFMINES);
            }
            else if (difficulty == Difficulty.Medium)
            {
                SetUpGame(MEDIUMBOARDSIZEX, MEDIUMBOARDSIZEY, MEDIUMNUMBEROFMINES);
            }
            else
            {
                SetUpGame(HARDBOARDSIZEX, HARDBOARDSIZEY, HARDNUMBEROFMINES);
            }
        }

        // Function used to load a game from the main menu, mainly exists to avoid duplicate code
        private void LoadGameModeFromMainMenu(Difficulty difficulty)
        {
            if (CheckPlayerFile()) // make sure the player has loaded their profile info before starting the game
            {
                this.difficulty = difficulty;
                LoadGameByDifficulty();
            }
        }

        // Helper function to display a panel of the game
        private void ShowMenuPanel(Panel panel)
        {
            this.MinimumSize = new Size(60 + panel.Width, 100 + panel.Height);
            this.MaximumSize = new Size(60 + panel.Width, 100 + panel.Height);

            panel.Location = new Point(20, 20);

            panel.Show();
        }



        // ----- EVENT HANDLERS (BUTTONS) -----
        // Event handler to check if the player file has been initialized, if so load an easy game
        private void easyModeBtn_Click(object sender, EventArgs e)
        {
            LoadGameModeFromMainMenu(Difficulty.Easy);
        }

        // Event handler to check if the player file has been initialized, if so load a medium game
        private void mediumModeBtn_Click(object sender, EventArgs e)
        {
            LoadGameModeFromMainMenu(Difficulty.Medium);
        }


        // Event handler to check if the player file has been initialized, if so load a hard game
        private void hardModeBtn_Click(object sender, EventArgs e)
        {
            LoadGameModeFromMainMenu(Difficulty.Hard);
        }

        // Event handler to hide the main menu and show the instructions menu
        private void instructionsBtn_Click(object sender, EventArgs e)
        {
            mainMenuPnl.Hide();
            ShowMenuPanel(instructionsPnl);
        }

        // Event handler to hide the instructions and show the main menu
        private void instructionsBackBtn_Click(object sender, EventArgs e)
        {
            instructionsPnl.Hide();
            ShowMenuPanel(mainMenuPnl);
        }

        // Event handler to hide the main menu and show the player info menu panel
        private void profileBtn_Click(object sender, EventArgs e)
        {
            mainMenuPnl.Hide();
            ShowMenuPanel(playerInfoPnl);
        }

        // Event handler used to save the players info and show the main menu panel
        private void infoSaveBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogueResult = MessageBox.Show("Are you sure this info is correct?", "Are you sure?", MessageBoxButtons.YesNo);
            if(dialogueResult == DialogResult.Yes)
            {
                playerInfoPnl.Hide();
                SavePlayer();
                ShowMenuPanel(mainMenuPnl);
            }
            
        }

        // Event handler to close the leaderboard menu and open the main menu
        private void leaderboardMainBtn_Click(object sender, EventArgs e)
        {
            highScoresPnl.Hide();
            if (gameState == GameState.GameOver) // if exiting from the game itself
            {
                ShowMenuPanel(mainMenuPnl);
                gameState = GameState.GameStart;
            } else // if we are showing the leaderboard from the main menu
            {
                ShowMenuPanel(leaderboardSelectPnl);
            }
        }
        
        // Event handler to close the leaderboard select panel and go back to the main menu
        private void leaderboardSelectMainMenuBtn_Click(object sender, EventArgs e)
        {
            leaderboardSelectPnl.Hide();
            ShowMenuPanel(mainMenuPnl);
        }

        // Event handler to close the main menu and load the leaderboard selection screen
        private void leaderboardMainMenuBtn_Click(object sender, EventArgs e)
        {
            mainMenuPnl.Hide();
            ShowMenuPanel(leaderboardSelectPnl);
        }

        // Event handler to load the easy leaderboard
        private void leaderboardSelectEasy_Click(object sender, EventArgs e)
        {
            difficulty = Difficulty.Easy;
            ShowLeaderboardFromMain();
        }

        // Event handler to load the medium leaderboard
        private void leaderboardSelectMedium_Click(object sender, EventArgs e)
        {
            difficulty = Difficulty.Medium;
            ShowLeaderboardFromMain();
        }

        // Event handler to load the hard leaderboard
        private void leaderboardSelectHard_Click(object sender, EventArgs e)
        {
            difficulty = Difficulty.Hard;
            ShowLeaderboardFromMain();
        }

        // ----- SCORE RELATED FUNCTIONS -----
        // Function to display the high score from main menu
        private void ShowLeaderboardFromMain()
        {
            leaderboardSelectPnl.Hide();
            LoadHighScores();
            UpdateHighScoresDisplay(ScoreBoard.MAINMENULEADERBOARD);
            ShowMenuPanel(highScoresPnl);
        }

        // Function to get the difficuly level text based on the current difficulty level
        private string GetDifficultyText()
        {
            string diffcultyText = "";
            if (difficulty == Difficulty.Easy)
                diffcultyText = "easy";
            else if (difficulty == Difficulty.Medium)
                diffcultyText = "medium";
            else
                diffcultyText = "hard";
            return diffcultyText;
        }

        // Function to load the high scores for the game based on difficulty level, if the file doesnt exist initialize a
        // new scoreboard instead
        private void LoadHighScores()
        {
            string filePrefix = GetDifficultyText();
            if (File.Exists(filePrefix + "highscores.txt"))
            {
                string json = File.ReadAllText(filePrefix + "highscores.txt");
                scoreBoard = JsonSerializer.Deserialize<ScoreBoard>(json);
            }
            else
            {
                scoreBoard = new ScoreBoard();
            }
        }

        // Function to add a new high score and save the file based on difficulty level
        private int SaveHighScore()
        {
            string filePrefix = GetDifficultyText();
            int newHighScorePosition = scoreBoard.AddHighScore(currentPlayer.UserName, (int)Math.Round(timeElapsed));
            string json = JsonSerializer.Serialize(scoreBoard);
            File.WriteAllText(filePrefix + "highscores.txt", json);
            return newHighScorePosition;
        }

        // Function to update the display for high scores, if newHighScorePosition > -1 will display a meme 
        // notifying the user that they have achieved a new high score
        private void UpdateHighScoresDisplay(int newHighScorePosition)
        {
            highScoreDifficultyLbl.Text = "(" + GetDifficultyText() + ")";
            scoreBoardNamesLbl.Text = "";
            scoreboardTimesLbl.Text = "";
            if (scoreBoard.Length == 0)
            {
                scoreBoardNamesLbl.Text = "No high scores yet";
            }
            else
            {
                for (int index = 0; index < scoreBoard.Length; index++)
                {
                    scoreBoardNamesLbl.Text += "" + scoreBoard.Names[index] + "\n";
                    scoreboardTimesLbl.Text += "" + scoreBoard.Scores[index] + "\n";
                }
            }

            // Display an image based on wether or not the player has made it onto the leaderboard
            if(newHighScorePosition == ScoreBoard.MAINMENULEADERBOARD) // accessing from main menu
                newHighScorePbx.Image = MineSweeper.Properties.Resources.MainMenuLeaderboardMeme;
            else if (newHighScorePosition == ScoreBoard.NOTONLEADERBOARD) // accessing when the player doesnt have a high score or has lost
                newHighScorePbx.Image = MineSweeper.Properties.Resources.NotNewHighScoreMeme;
            else // accessing if the player has a new high score
                newHighScorePbx.Image = MineSweeper.Properties.Resources.NewHighScoreMeme;
        }

        // ----- PLAYER RELATED FUNCTIONS -----
        // Function used to ensure that a player file exists and display a relavent message box if it doesn't
        private bool CheckPlayerFile()
        {
            bool playerFileExists = false;
            if (File.Exists("player.txt"))
                playerFileExists = true;
            else
                MessageBox.Show("Please update profile to start the game");
            return playerFileExists;
        }

        // Function used to update the current players input fields based on the current player info
        private void UpdatePlayerInfoFields()
        {
            infoNameMsk.Text = currentPlayer.Name;
            infoUsernameMsk.Text = currentPlayer.UserName;
            infoAgeNud.Value = currentPlayer.Age;
        }

        // Function used to check if the player file exists, if so load the player
        private void LoadPlayer()
        {
            if (File.Exists("player.txt"))
            {
                string json = File.ReadAllText("player.txt");
                currentPlayer = JsonSerializer.Deserialize<Player>(json);
                UpdatePlayerInfoFields();
            }

        }

        // Function used to save the current players info based on input fields
        private void SavePlayer()
        {
            currentPlayer = new Player(infoNameMsk.Text, infoUsernameMsk.Text, (int)infoAgeNud.Value);
            UpdatePlayerInfoFields();
            string json = JsonSerializer.Serialize(currentPlayer);
            File.WriteAllText("player.txt", json);
        }
    }
}