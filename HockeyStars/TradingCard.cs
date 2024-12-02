using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HockeyStars.HomePage;
using System.Windows.Forms;

namespace HockeyStars
{
    public partial class TradingCard : Form
    {
        private Player player;

        public TradingCard(Player selectedPlayer)
        {
            //When the user double clicks on any player's name in the list on the Home Page,
            //select that player to display on the Trading Card
            InitializeComponent();
            player = selectedPlayer;
            DisplayPlayerDetails();
        }

        private void DisplayPlayerDetails()
        {
            //Display the information for the selected player's stats on the Trading Card 
                lblName.Text = $"{player.Name}";
                lblTeam.Text = $"{player.Team}";
                lblJersey.Text = $"{player.Jersey}";
                lblBirthday.Text = $"{player.Birthday}";
                lblPosition.Text = $"{player.Position}";
                lblGames.Text = $"{player.Games}";
                lblGoals.Text = $"{player.Goals}";
                pbPlayer.Image = Image.FromFile(player.ImageName);
        }
    }
}
