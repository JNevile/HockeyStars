
using System.Numerics;
using static HockeyStars.HomePage;
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
            InitializeComponent();
            players = PlayerData.GetPlayers(); // Make sure PlayerData is defined
            lbPlayers.DataSource = players.ToList();
            lbPlayers.DisplayMember = "Name";
            lbPlayers.SelectedIndexChanged += lbPlayers_SelectedIndexChanged;
        }

        private void lbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPlayers.SelectedItem is Player selectedPlayer)
            {
                var tradingCard = new TradingCard(selectedPlayer);
                tradingCard.Show(); // Open the trading card display
            }
        }
    }

    public static class PlayerData
    {
        public static List<Player> GetPlayers()
        {
            return new List<Player>
            {
                new Player { Name = "Bobby McMann", Team = "Toronto Maple Leafs", Jersey = "74", Birthday = "June 15 1996", Position = "Center", Games = "87", Goals = "21", ImageName = "BobbyMcmann.jpg" },
                new Player { Name = "Cale Makar", Team = "Colorado Avalanche", Jersey = "8", Birthday = "October 30 1998", Position = "Defence", Games = "340", Goals = "94", ImageName = "ColeMakar.jpg" },
                new Player { Name = "Cole Koepke", Team = "Boston Bruins", Jersey = "45", Birthday = "May 17 1998 ", Position = "Left wing", Games = "50", Goals = "5" , ImageName = "ColeKoepke.jpg" },
                new Player { Name = "Connor McDavid", Team = "Edmonton Oilers", Jersey = "41", Birthday = "January 13 1997", Position = "Center", Games = "665", Goals = "347", ImageName = "ConnorMcdavid.jpg" },
                new Player { Name = "Danton Heinen", Team = "Vancouver Canucks", Jersey = "20", Birthday = "July 5 1995", Position = "Left wing", Games = "510", Goals = "90", ImageName = "DantonHeinen.jpg" },
                new Player { Name = "Justin Kirkland", Team = "Calgary Flames", Jersey = "58", Birthday = "August 2 1996", Position = "Center", Games = "30", Goals = "2", ImageName = "JustinKirland.jpg" },
                new Player { Name = "Michael Pezzetta", Team = "Montreal Canadiens", Jersey = "55", Birthday = "March 13 1998", Position = "Left wing", Games = "178", Goals = "15", ImageName = "MichaelPezzetta.jpg"  },
                new Player { Name = "Morgan Geekie", Team = "Boston Bruins", Jersey = "39", Birthday = "July 20, 1998", Position = "Center", Games = "276", Goals = "41", ImageName = "MorganGeekie.jpg" }, 
                new Player { Name = "Nolan Allan", Team = "Chicago Blackhawks", Jersey = "42", Birthday = "April 28, 2003", Position = "Defence", Games = "17", Goals = "0", ImageName = "NolanAllan.jpg"  },
                new Player { Name = "Sidney Crosby", Team = "Pittsburgh Penguins", Jersey = "87", Birthday = "August 7, 1987", Position = "Center", Games = "1298", Goals = "600", ImageName = "SidneyCrosby.jpg" },
            };
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string Jersey { get; set; }
        public string Birthday { get; set; }
        public string Position { get; set; }
        public string Games { get; set; }
        public string Goals { get; set; }
        public string ImageName { get; set; } 
    }
}

















                