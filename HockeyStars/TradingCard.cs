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
            InitializeComponent();
            player = selectedPlayer;
            DisplayPlayerDetails();
        }

        private void DisplayPlayerDetails()
        {
            lblName.Text = $"{player.Name}";
            lblTeam.Text = $"{player.Team}";
            lblJersey.Text = $"{player.Jersey}";
            lblBirthday.Text = $"{player.Birthday}";
            lblPosition.Text = $"{player.Position}";
            lblGames.Text = $"{player.Games}";
            lblGoals.Text = $"{player.Goals}";
            try
            {
                // Construct the path for the image file
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, player.ImageName);
                pbPlayer.Image = Image.FromFile(imagePath);  // Use pbPlayer to load the image
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image: {ex.Message}");
            }
        }
    }
}
