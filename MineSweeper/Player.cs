using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

// Dylan Burnham
// A class that represents a player and all of their profile info for the game. If a player decides not to input any values
// for their player info the game will automatically do it for them. 
// Also where I created non auto implemented properties and an overloaded constructor

namespace MineSweeper
{
    
    internal class Player
    {
        private string name;
        private string userName;
        private int age;

        // Default constructor used in the case when we wouldnt have user input
        public Player()
        {
            Name = "Meme Memerson";
            UserName = "MemeMan";
            Age = 0;
        }

        // Constructor to be used when all 3 values are provided by the user
        public Player(string name, string userName, int age)
        {
            Name = name;
            UserName = userName;
            Age = age;
        }

        // Name property, used for public access and to trim the name to avoid leading and trailing whitespace and replace the
        // word hate with meme, also if name text is empty replace it with None
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.Trim().Replace("hate", "meme");
                if (name == "")
                    name = "Meme Memerson";
            }
        }

        // UserName property, used for public access and trim the name to avoid leading and trailing whitespace and replace the
        // word hate with meme, also if the text is empty replace it with the word MemeMan
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value.Trim().Replace("hate", "meme");
                if (userName == "")
                    userName = "MemeMan";  
            }
        }

        // Age property, used for public access and to update the age parameter if the user chooses a value less than 0
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                    age = value;
                else
                    age = 0;
            }
        }
    }
}
