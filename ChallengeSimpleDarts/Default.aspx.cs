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

        public class Game
        {
            private int player1Score { get; set; }
            private int player2Score { get; set; }
            public Random fatesWhim { get; set; }

            public Game()
            {
                this.player1Score = 0;
                this.player2Score = 0;
                this.fatesWhim = new Random();
            }

            public void PlayGame()
            {
                Dart luckyDart = new Dart(fatesWhim);
                while(player1Score < 300 && player2Score < 300)
                {
                    player1Score += Score.ScoreRound(luckyDart);
                    player2Score += Score.ScoreRound(luckyDart);
                }
            }

            public void PrintResult(Label outcome, Label play1, Label play2)
            {
                string winner = (player1Score > player2Score) ? "Player 1" :
                    (player2Score > player1Score) ? "Player 2" : "Tie Game";
                play1.Text = "Player 1: " + this.player1Score;
                play2.Text = "Player 2: " + this.player2Score;
                outcome.Text = string.Format("Winner: {0}", winner);
            }
        }

        public class Score 
        {
            public static int ScoreRound(Dart luckyDart)
            {
                int score = 0;
                for (int i = 0; i < 3; i++)
                {
                    luckyDart.Throw();
                    score += luckyDart.Hit * luckyDart.Multiplier;
                }
                return score;
            }
        }
    }
}