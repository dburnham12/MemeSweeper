using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dylan Burnham
// Class used to represent a scoreboard for a specific difficulty setting. It als contains constants which control where the 
// user is accessing the menu from. Scores have a max limit of 10 scores and are sorted when adding the score to the leaderboard

namespace MineSweeper
{
    
    internal class ScoreBoard
    {
        private const int SCORESSIZE = 10;
        public const int NOTONLEADERBOARD = -1; // used for updating and displaying a scoreboard when the user did make the leaderboard
        public const int MAINMENULEADERBOARD = -2; // used to display the scoreboard from the main menu

        public int Length { get; set; }
        public int[] Scores { get; set; }
        public string[] Names { get; set; }

        // Default cunstructor for a new scoreboard
        public ScoreBoard()
        {
            Names = new string[SCORESSIZE];
            Scores = new int[SCORESSIZE];
            Length = 0;
        }

        // Function used to add a new high score to the scoreboard 
        public int AddHighScore(string name, int score)
        {
            int newHighScorePosition = NOTONLEADERBOARD;
            if(Length < SCORESSIZE) // if the leaderboard is not full, insert at a position and increment length
            {
                int position = 0;
                for (; position < Length; position++)
                {
                    if (Scores[position] > score)
                        break;
                }
                for(int index = Length; index > position; index--)
                {
                    Names[index] = Names[index - 1];
                    Scores[index] = Scores[index - 1];
                }
                newHighScorePosition = position;
                Scores[position] = score;
                Names[position] = name;
                Length++;
            } 
            else // If the leaderboard is full, insert at a position and dont increment length
            {
                int position = 0;
                for (; position < SCORESSIZE; position++)
                {
                    if (Scores[position] > score)        
                        break;
                }
                if(position < SCORESSIZE)
                {
                    for (int index = SCORESSIZE - 1; index > position; index--)
                    {
                        Names[index] = Names[index - 1];
                        Scores[index] = Scores[index - 1];
                    }
                    newHighScorePosition = position;
                    Scores[position] = score;
                    Names[position] = name;
                }
            }
            return newHighScorePosition;
        }
    }
}
