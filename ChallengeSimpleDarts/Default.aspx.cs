using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Darts;

namespace ChallengeSimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            Dart luckyDart = new Dart(random);

            
        }

        protected void playButton_Click(object sender, EventArgs e)
        {
            Game gentlemansGame = new Game();
            gentlemansGame.PlayGame();
            gentlemansGame.PrintResult(winLabel, player1Label, player2Label);
        }
    }
}