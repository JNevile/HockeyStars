using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HockeyStars
{
    public partial class HomePage : Form
    {
        private List<Player> players;

        public HomePage()
        {
            //Open the home page when the app starts, displaying the list of hockey players
            InitializeComponent();
            players = PlayerData.GetPlayers();
            lbPlayers.DataSource = players.ToList();
            lbPlayers.DisplayMember = "Name";
            lbPlayers.SelectedIndexChanged += lbPlayers_SelectedIndexChanged;
        }

        private void lbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Open the trading card displaying the selected hockey player 
            if (lbPlayers.SelectedItem is Player selectedPlayer)
            {
                var tradingCard = new TradingCard(selectedPlayer);
                tradingCard.Show(); 
            }
        }
    }

    public static class PlayerData
    {
        public static List<Player> GetPlayers()
        {
            //List of all the hockey player's stats that can be displayed on the Trading Card when a player gets selected
            return new List<Player>
            {
                new Player { Name = "Bobby McMann", Team = "Toronto Maple Leafs", Jersey = "74", Birthday = "June 15 1996", Position = "Center", Games = "87", Goals = "21", ImageName = Image.FromFile("Resources/BobbyMcmann.jpg") },
                new Player { Name = "Cale Makar", Team = "Colorado Avalanche", Jersey = "8", Birthday = "October 30 1998", Position = "Defence", Games = "340", Goals = "94", ImageName = Image.FromFile("Resources/CaleMakar.jpg") },
                new Player { Name = "Cole Koepke", Team = "Boston Bruins", Jersey = "45", Birthday = "May 17 1998 ", Position = "Left wing", Games = "50", Goals = "5" , ImageName = Image.FromFile("Resources/ColeKoepke.jpg") },
                new Player { Name = "Connor McDavid", Team = "Edmonton Oilers", Jersey = "41", Birthday = "January 13 1997", Position = "Center", Games = "665", Goals = "347", ImageName = Image.FromFile("Resources/ConnorMcdavid.jpg") },
                new Player { Name = "Danton Heinen", Team = "Vancouver Canucks", Jersey = "20", Birthday = "July 5 1995", Position = "Left wing", Games = "510", Goals = "90", ImageName = Image.FromFile("Resources/DantonHeinen.jpg") },
                new Player { Name = "Justin Kirkland", Team = "Calgary Flames", Jersey = "58", Birthday = "August 2 1996", Position = "Center", Games = "30", Goals = "2", ImageName = Image.FromFile("Resources/JustinKirkland.jpg") },
                new Player { Name = "Michael Pezzetta", Team = "Montreal Canadiens", Jersey = "55", Birthday = "March 13 1998", Position = "Left wing", Games = "178", Goals = "15", ImageName = Image.FromFile("Resources/MichaelPezzetta.jpg") },
                new Player { Name = "Morgan Geekie", Team = "Boston Bruins", Jersey = "39", Birthday = "July 20, 1998", Position = "Center", Games = "276", Goals = "41", ImageName = Image.FromFile("Resources/MorganGeekie.jpg") },
                new Player { Name = "Nolan Allan", Team = "Chicago Blackhawks", Jersey = "42", Birthday = "April 28, 2003", Position = "Defence", Games = "17", Goals = "0", ImageName = Image.FromFile("Resources/NolanAllan.jpg") },
                new Player { Name = "Sidney Crosby", Team = "Pittsburgh Penguins", Jersey = "87", Birthday = "August 7, 1987", Position = "Center", Games = "1298", Goals = "600", ImageName = Image.FromFile("Resources/SidneyCrosby.jpg") }
            };
        }
    }

    public class Player
    {
        //The Player class defines properties that represent various player stats
        //to display on the Trading Cards when the player is selected
        public string Name { get; set; }
        public string Team { get; set; }
        public string Jersey { get; set; }
        public string Birthday { get; set; }
        public string Position { get; set; }
        public string Games { get; set; }
        public string Goals { get; set; }
        public Image ImageName { get; set; }
    }
}

















                
